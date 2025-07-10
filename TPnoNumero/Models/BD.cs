using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using Dapper;

namespace TPnoNumero.Models;

public static class BD{
    private static string _connectionString = @"Server=localhost;DataBase=TPnoNum;Integrated Security=True;TrustServerCertificate=True;";

public static Integrante searchIntegrante(string nombreUser, string password)
{
    Integrante integrante = null;
    using(SqlConnection connection = new SqlConnection(_connectionString))
    {
        string query = "SELECT * FROM Integrante WHERE nombreUser = @nombreUser AND password = @password";
        integrante = connection.QueryFirstOrDefault<Integrante>(query, new { nombreUser = nombreUser, password = password });
    }
    return integrante;
}
    public static void addIntegrante (Integrante integrante)
    {
     string query = "INSERT INTO Integrante (nombreUser, password, nombre, apellido, DNI, direccion, barrio) " + "VALUES (@nombreUser, @password, @nombre, @apellido, @DNI, @direccion, @barrio)";
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Execute(query, new
            {
                nombreUser = integrante.nombreUser,
                password = integrante.password,
                nombre = integrante.nombre,
                DNI = integrante.DNI,
                apellido = integrante.apellido,
                direccion = integrante.direccion,
                barrio = integrante.barrio
            });
        }
    }
}
