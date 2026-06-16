using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using TP03_ALFIE_FAINSCHTEIN.Models;

namespace TP03JS.Models
{
    public class BD
    {
        private string connectionString = @"Server=localhost; Database=Ahorcado; Integrated Security=True;TrustServerCertificate=True;";
        public List<string> devolverPalabras()
        {
            List<string> palabras = new List<string>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT palabra FROM Palabra";
                palabras = connection.Query<string>(query).ToList();
            }
            return palabras;
        }
        public void agregar(string palabra)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Palabra (palabra) VALUES (@pPalabra)";
                connection.Execute(query, new { pPalabra = palabra });
            }
        }
    }
}