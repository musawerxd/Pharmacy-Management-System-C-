using System;
using System.Data;
using System.Data.SqlClient;

public static class DatabaseHelper
{




    private static readonly string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=PharmacyDB;Integrated Security=True;TrustServerCertificate=True";







    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }









    // Existing method for SELECT queries
    public static DataTable GetData(string query)
    {
        DataTable dt = new DataTable();
        using (SqlConnection conn = GetConnection())
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    sda.Fill(dt);
                }
            }
        }
        return dt;
    }








    // NEW Method for INSERT, UPDATE, DELETE queries
    public static void ExecuteQuery(string query)
    {
        using (SqlConnection conn = GetConnection())
        {
            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Rethrow error to be caught by the UI catch block
                throw new Exception("SQL Execution Failed: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}