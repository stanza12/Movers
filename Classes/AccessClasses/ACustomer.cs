using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR_Movers_coursework.Classes.AccessClasses
{
    class ACustomer: MasterDB
    {
        public static int AddCustomer(SR_Movers_coursework.Classes.MCustomer Customer)
        {
            using( SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = string.Format("INSERT INTO Customer (Forename, Surname, Email, TelephoneNumber, BillingAddress) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                                 Customer.Forename,
                                 Customer.Surname,
                                 Customer.Email,
                                 Customer.TelephoneNo,
                                 Customer.BillingAddress);

                SqlCommand insertcommand = new SqlCommand(sqlQuery, connection);
                int rowsaffected = insertcommand.ExecuteNonQuery();

                connection.Close();
                return rowsaffected;
            }


            }


        public void DeleteCustomer(int Customer)
        {
            string deletecustomer = "DELETE FROM Customer WHERE CustomerID = @CustomerID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand deleteCommand = new SqlCommand(deletecustomer, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@CustomerID", Customer);
                    deleteCommand.ExecuteNonQuery();
                }
            }
        }
        public void UpdateCustomer(int ID, string Forename, string Surname, string Email, string TeleNo, string BillingAdd)
        {
            string query = @"
            UPDATE Customer
            SET 
            Forename = @Forename,
            Surname = @Surname,
            Email = @Email,
            TelephoneNumber = @TelephoneNumber,
            BillingAddress = @BillingAddress
            WHERE CustomerID = @CustomerID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

       
                command.Parameters.AddWithValue("@CustomerID", ID);
                command.Parameters.AddWithValue("@Forename", Forename);
                command.Parameters.AddWithValue("@Surname", Surname);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@TelephoneNumber", TeleNo);
                command.Parameters.AddWithValue("@BillingAddress", BillingAdd);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

              
            }
        }












    }
}
