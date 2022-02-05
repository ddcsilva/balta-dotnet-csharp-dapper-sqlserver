using System;
using Microsoft.Data.SqlClient;

namespace BaltaDataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            // Servidor do Banco de Dados + Porta + Banco de Dados + Usuário + Senha
            const string connectionString = "Server=localhost,1433;Database=balta;User ID=sa;Password=1q2w3e4r@#$";

            var connection = new SqlConnection();
            connection.Open();
            // INSERT
            // UPDATE
            connection.Close();
            connection.Dispose();

            using (var connectionUsing = new SqlConnection())
            {
                Console.WriteLine("Conectado");
            }
        }
    }
}
