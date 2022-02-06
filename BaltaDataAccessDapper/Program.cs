using System;
using Microsoft.Data.SqlClient;
using Dapper;

namespace BaltaDataAccessDapper
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = "Server=localhost,1433;Database=balta;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True";

            using (var connection = new SqlConnection(connectionString))
            {

            }
        }
    }
}
