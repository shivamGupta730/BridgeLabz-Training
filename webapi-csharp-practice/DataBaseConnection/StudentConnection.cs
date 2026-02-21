using System;
using Microsoft.Data.SqlClient;

namespace DataBaseConnection
{
    public class StudentConnection
    {
        static void Main(string[] args)
        {
            string connectionString =
                "Server=localhost\\SQLEXPRESS;Database=CollegeDB;Trusted_Connection=True;TrustServerCertificate=True;";

            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM dbo.students";

            using SqlCommand command = new SqlCommand(query, connection);
            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(
                    reader["Id"] + " " +
                    reader["Name"] + " " +
                    reader["Mobile"]
                );
            }
        }
    }
}
