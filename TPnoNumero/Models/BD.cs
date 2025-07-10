using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using Dapper;

namespace TPnoNumero.Models;

public static class BD(){
    private static string _connectionString = @"Server=localhost;DataBase=TPnoNum;Integrated Security=True;TrustServerCertificate=True;";

public static Integrante BuscarIntegrante(string nombreUser, string password, string name, string surname, int DNI, string direccion, string barrio)
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
     string query = "INSERT INTO Integrante (nombreUser, password, name, apellido, DNI, direccion, barrio) " + "VALUES (@nombreUser, @password, @name, @apellido, @DNI, @direccion, @barrio)";
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
}
