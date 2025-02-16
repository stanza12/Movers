using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace SR_Movers_coursework.Classes.AccessClasses
{
    class ALogin : MasterDB
    {
        public bool checkpassword(int staffID, string password)
        {
            bool correct = false;
            string query = "SELECT PasswordHash FROM Login WHERE StaffID = @StaffID";

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
                            string dbPassword = result.ToString().Trim();  
                            string inputPassword = password.Trim();       

                     
                            if (dbPassword == inputPassword)
                            {
                                correct = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return correct;
        }




        public Models.MCurrentStaff GetStaffDetails(int staffID)
        {
           Models.MCurrentStaff staff = null;

            string query = "SELECT StaffID, Forename, Surname, Email, TelephoneNo FROM Staff WHERE StaffID = @StaffID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StaffID", staffID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                staff = new Models.MCurrentStaff
                                {
                                    StaffID = reader.GetInt32(reader.GetOrdinal("StaffID")),
                                    Forename = reader.GetString(reader.GetOrdinal("Forename")),
                                    Surname = reader.GetString(reader.GetOrdinal("Surname")),
                                    Email = reader.GetString(reader.GetOrdinal("Email")),
                                    TelephoneNumber = reader.GetString(reader.GetOrdinal("TelephoneNo"))
                                    //
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while fetching staff details: " + ex.Message);
            }

            return staff;
        }

    }
}