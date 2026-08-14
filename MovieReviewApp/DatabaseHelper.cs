using System.Data.SqlClient;

namespace MovieReviewApp
{
    internal class DatabaseHelper
    {
        private string connectionString =
            @"Server=.\SQLEXPRESS;Database=MovieReviewDB;Trusted_Connection=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}