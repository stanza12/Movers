using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace SR_Movers_coursework.Classes.AccessClasses
{
    class AStaff : MasterDB
    {


          public Models.MStaff LoadStaffDetails(int staffID)
    {
            Models.MStaff staff = new Models.MStaff();

        try
        {
            // Retrieve basic staff information
            string staffQuery = @"
                SELECT StaffID, Forename, Surname, Email, TelephoneNumber, Status
                FROM Staff
                WHERE StaffID = @StaffID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(staffQuery, connection))
                {
                    command.Parameters.AddWithValue("@StaffID", staffID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            staff.StaffID = reader.GetInt32(reader.GetOrdinal("StaffID"));
                            staff.Forename = reader.GetString(reader.GetOrdinal("Forename"));
                            staff.Surname = reader.GetString(reader.GetOrdinal("Surname"));
                            staff.Email = reader.GetString(reader.GetOrdinal("Email"));
                            staff.TelephoneNumber = reader.IsDBNull(reader.GetOrdinal("TelephoneNumber"))
                                ? null
                                : reader.GetString(reader.GetOrdinal("TelephoneNumber"));
                            staff.Status = reader.GetString(reader.GetOrdinal("Status"));
                        }
                    }
                }


                    staff.Roles = GetAllRoleIDsForStaff(staffID.ToString())
                    .Select(roleID => getrole(staffID.ToString(), roleID))
                    .ToList();

                    // Retrieve contracted hours
                    try
                {
                        staff.Hours = returncontract(staffID.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(string.Format("No contract found for StaffID '{staffID}': {ex.Message}"));
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading staff details: {ex.Message}");
        }

        return staff;
    }








        public int AddStaff(Models.MStaff staff, string password, string primaryRole, string secondaryRole = null)
        {
            int staffID;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();


                string insertStaffQuery = @"INSERT INTO Staff (Forename, Surname, Email, TelephoneNumber, RoleID, Status)
                                    OUTPUT INSERTED.StaffID
                                    VALUES (@Forename, @Surname, @Email, @TelephoneNumber, @RoleID, @Status)";

                using (SqlCommand insertCommand = new SqlCommand(insertStaffQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@Forename", staff.Forename);
                    insertCommand.Parameters.AddWithValue("@Surname", staff.Surname);
                    insertCommand.Parameters.AddWithValue("@Email", staff.Email);
                    insertCommand.Parameters.AddWithValue("@TelephoneNumber", staff.TelephoneNumber);
                    insertCommand.Parameters.AddWithValue("@RoleID", staff.RoleID);
                    insertCommand.Parameters.AddWithValue("@Status", staff.Status);

                    staffID = (int)insertCommand.ExecuteScalar();
                }
                string hoursadd = @"INSERT INTO Login (StaffID, PasswordHash) VALUES (@StaffID, @PasswordHash)";

                using (SqlCommand insertLoginCommand = new SqlCommand(hoursadd, connection))
                {
                    insertLoginCommand.Parameters.AddWithValue("@StaffID", staffID);
                    insertLoginCommand.Parameters.AddWithValue("@PasswordHash", password);

                    insertLoginCommand.ExecuteNonQuery();



                }
                int primaryRoleID = GetRoleID(primaryRole);
                Addrole(staffID, primaryRoleID, connection);


                if (!string.IsNullOrEmpty(secondaryRole))
                {
                    int secondaryRoleID = GetRoleID(secondaryRole);
                    Addrole(staffID, secondaryRoleID, connection);
                }
            }
            return staffID;
        }

        public void UpdateStaff(int staffID, Models.MStaff staff, string password, string primaryRole, string secondaryRole = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                
                string updateStaffQuery = @"
            UPDATE Staff
            SET Forename = @Forename,
                Surname = @Surname,
                Email = @Email,
                TelephoneNumber = @TelephoneNumber,
                RoleID = @RoleID,
                Status = @Status
            WHERE StaffID = @StaffID";

                using (SqlCommand updateCommand = new SqlCommand(updateStaffQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@StaffID", staffID);
                    updateCommand.Parameters.AddWithValue("@Forename", staff.Forename);
                    updateCommand.Parameters.AddWithValue("@Surname", staff.Surname);
                    updateCommand.Parameters.AddWithValue("@Email", staff.Email);
                    updateCommand.Parameters.AddWithValue("@TelephoneNumber", staff.TelephoneNumber);
                    updateCommand.Parameters.AddWithValue("@RoleID", staff.RoleID);
                    updateCommand.Parameters.AddWithValue("@Status", staff.Status);

                    updateCommand.ExecuteNonQuery();
                }

              
           string updatePasswordQuery = @"
            UPDATE Login
            SET PasswordHash = @PasswordHash
            WHERE StaffID = @StaffID";

                using (SqlCommand updatePasswordCommand = new SqlCommand(updatePasswordQuery, connection))
                {
                    updatePasswordCommand.Parameters.AddWithValue("@StaffID", staffID);
                    updatePasswordCommand.Parameters.AddWithValue("@PasswordHash", password);

                    updatePasswordCommand.ExecuteNonQuery();
                }

               
                int primaryRoleID = GetRoleID(primaryRole);
                UpdateRoles(staffID, primaryRoleID, secondaryRole, connection);
            }
        }


        private void UpdateRoles(int staffID, int primaryRoleID, string secondaryRole, SqlConnection connection)
        {
      
            string delete = "DELETE FROM StaffRoles WHERE StaffID = @StaffID";
            using (SqlCommand deleteCommand = new SqlCommand(delete, connection))
            {
                deleteCommand.Parameters.AddWithValue("@StaffID", staffID);
                deleteCommand.ExecuteNonQuery();
            }

         
            string add = "INSERT INTO StaffRoles (StaffID, RoleID) VALUES (@StaffID, @RoleID)";
            using (SqlCommand addPrimaryRoleCommand = new SqlCommand(add, connection))
            {
                addPrimaryRoleCommand.Parameters.AddWithValue("@StaffID", staffID);
                addPrimaryRoleCommand.Parameters.AddWithValue("@RoleID", primaryRoleID);
                addPrimaryRoleCommand.ExecuteNonQuery();
            }

     
            if (!string.IsNullOrEmpty(secondaryRole))
            {
                int secondaryRoleID = GetRoleID(secondaryRole);
                using (SqlCommand addSecondaryRoleCommand = new SqlCommand(add, connection))
                {
                    addSecondaryRoleCommand.Parameters.AddWithValue("@StaffID", staffID);
                    addSecondaryRoleCommand.Parameters.AddWithValue("@RoleID", secondaryRoleID);
                    addSecondaryRoleCommand.ExecuteNonQuery();
                }
            }
        }

        public void DeleteStaff(int staff)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string deleteRoles = "DELETE FROM StaffRoles WHERE StaffID = @StaffID";
                string deleteLogin = "DELETE FROM Login WHERE StaffID = @StaffID";
                string deleteStaff = "DELETE FROM Staff WHERE StaffID = @StaffID";

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using( SqlCommand deletetrolecommand = new SqlCommand(deleteRoles, connection, transaction))
                        {
                            deletetrolecommand.Parameters.AddWithValue("@StaffID", staff);
                            deletetrolecommand.ExecuteNonQuery();
                        }
                        using (SqlCommand deletelogincommand = new SqlCommand(deleteLogin,connection,transaction))
                        {
                            deletelogincommand.Parameters.AddWithValue("StaffID", staff);
                            deletelogincommand.ExecuteNonQuery();
                        }
                        using (SqlCommand deletestaffcommand = new SqlCommand (deleteStaff,connection,transaction))
                        {
                            deletestaffcommand.Parameters.AddWithValue("StaffID", staff);
                            deletestaffcommand.ExecuteNonQuery();
                        }
                        transaction.Commit();

                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }








        public void addhours(int staffID, string[] workingHours, SqlConnection connection)
        {
            foreach (string hour in workingHours)
            {
                string query = "INSERT INTO StaffContract (StaffID, Hours) VALUES (@StaffID, @Hours)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StaffID", staffID);
                    command.Parameters.AddWithValue("@Hour", hour);
                    command.ExecuteNonQuery();
                }
            }


        }





        public void Hours(int staffID, string[] hourswork)
        {
            string hoursString = string.Join("", hourswork);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertContractQuery = @"INSERT INTO StaffContract (StaffID, Hours) 
                                       VALUES (@StaffID, @Hours)";

                using (SqlCommand insertCommand = new SqlCommand(insertContractQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@Hours", hoursString);
                    insertCommand.Parameters.AddWithValue("@StaffID", staffID);

                    int rowsAffected = insertCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Hours successfully inserted into the contract.");
                    }
                    else
                    {
                        Console.WriteLine("Failed to insert the contract.");
                    }
                }
            }
        }





        public string getrole(string staffID, string roleID)
        {

            string query = @"
        SELECT rt.RoleName 
        FROM StaffRoles sr
        JOIN RoleTable rt ON sr.RoleID = rt.RoleID
        WHERE sr.StaffID = @StaffID AND sr.RoleID = @RoleID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StaffID", staffID);
                        cmd.Parameters.AddWithValue("@RoleID", roleID);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            return result.ToString();
                        }
                        else
                        {
                            throw new Exception(string.Format("Role with RoleID '{0}' not found for StaffID '{1}'.", roleID, staffID));
                        }
                    }
                }
            }
        }






        public int GetRoleID(string roleName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                {

                    string getRoleIdQuery = "SELECT RoleID FROM RoleTable WHERE RoleName = @RoleName";
                    using (SqlCommand cmd = new SqlCommand(getRoleIdQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@RoleName", roleName);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            return (int)result;
                        }
                        else
                        {
                            throw new Exception(string.Format("Role '{0}' not found in RoleTable.", roleName));
                        }
                    }
                }
            }
        }






        private void Addrole(int staffID, int roleID, SqlConnection conn)
        {
            string insertStaffRoleQuery = @"INSERT INTO StaffRoles (StaffID, RoleID) VALUES (@StaffID, @RoleID)";
            using (SqlCommand cmd = new SqlCommand(insertStaffRoleQuery, conn))
            {
                cmd.Parameters.AddWithValue("@StaffID", staffID);
                cmd.Parameters.AddWithValue("@RoleID", roleID);
                cmd.ExecuteNonQuery();
            }
        }







        public List<string> sortstaff()
        {
            List<string> columns = new List<string>();
            string query = "SELECT TOP 0 * FROM Staff";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SchemaOnly))
                    {
                        DataTable schemaTable = reader.GetSchemaTable();

                        foreach (DataRow row in schemaTable.Rows)
                        {
                            columns.Add(row["ColumnName"].ToString());
                        }
                    }
                }
            }
            return columns;
        }









        public List<string> GetAllRoleIDsForStaff(string staffID)
        {
            List<string> roleIDs = new List<string>();

            string query = @"
        SELECT RoleID 
        FROM StaffRoles 
        WHERE StaffID = @StaffID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@StaffID", staffID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            string roleID = reader["RoleID"].ToString();
                            roleIDs.Add(roleID);
                        }
                    }
                }
            }

            return roleIDs;
        }




        public DataTable searchstaff(string selectedColumn, string searchText)
        {
            DataTable resultsTable = new DataTable();
            string searchQuery = "SELECT * FROM Staff WHERE [" + selectedColumn + "] LIKE @SearchText";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(searchQuery, connection))
                {
                    command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(resultsTable);
                    }
                }
            }

            return resultsTable;
        }


        public string getpass(string staffID)
        {
            string password = string.Empty;
            string query = "Select PasswordHash FROM Login WHERE StaffID = @StaffID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StaffID", staffID);
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            password = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return password;
        }



        public string returncontract(string staffID)
        {
            string Contractedhours = null;
            string query = @"SELECT Hours
            FROM ContractStaff
            WHERE StaffID = @StaffID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@StaffID", staffID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Contractedhours = reader["Hours"].ToString();
                        }

                    }
                }


            }
            if (Contractedhours == null)
            {
                throw new Exception(string.Format("No contract found for StaffID '{0}'.", staffID));
            }

            return Contractedhours;

        }

        public void addpassword(int staffID, string password)
        {
            string query = "INSERT INTO Login (StaffID, PasswordHash) VALUES (@StaffID, @PasswordHash)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {

                    cmd.Parameters.AddWithValue("@StaffID", staffID);
                    cmd.Parameters.AddWithValue("@PasswordHash", password);

                    try
                    {
                        int rowsaffected = cmd.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        throw new Exception(string.Format("An error occurred: " + ex.Message));

                    }


                }
            }

        }

    }
}







