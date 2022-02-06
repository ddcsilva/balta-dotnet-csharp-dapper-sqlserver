﻿using System;
using Microsoft.Data.SqlClient;
using Dapper;
using BaltaDataAccessDapper.Models;

namespace BaltaDataAccessDapper
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = "Server=localhost,1433;Database=balta;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True";

            using (var connection = new SqlConnection(connectionString))
            {
                var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [Category]");

                foreach (var category in categories)
                {
                    Console.WriteLine($"{category.Id} - {category.Title}");
                }
            }
        }
    }
}