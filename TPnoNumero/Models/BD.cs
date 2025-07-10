using Microsoft.Data.SqlClient;
using Dapper;

namespace TPnoNumero.Models;

private static string _connectionString = @"Server=localhost;DataBase=TPnoNum;Integrated Security=True;TrustServerCertificate=True;";


public static Integrante BuscarIntegrante(string email, string contraseña)
{
    Integrante integrante = null;
    using(SqlConnection connection = new SqlConnection(_connectionString))
    {
        string query = "SELECT * FROM Integrantes WHERE nombreUser = @nombreUser AND password = @password";
        integrante = connection.QueryFirstOrDefault<Integrante>(query, new { nombreUser = nombreUser, password = password });
    }
    return integrante;
}
    public static void addIntegrante (Integrante integrante)
    {
     string query = "INSERT INTO Integrantes (nombreUser, password, name, apellido, DNI, direccion, barrio) " + "VALUES (@nombreUser, @password, @name, @apellido, @DNI, @direccion, @barrio)";
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Execute(query, new
            {
                nombreUser = integrante.nombreUser,
                password = integrante.password,
                name = integrante.name,
                DNI = integrante.DNI,
                apellido = integrante.apellido,
                direccion = integrante.direccion,
                barrio = integrante.barrio
            });
        }
    }
