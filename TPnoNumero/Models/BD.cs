using Microsoft.Data.SqlClient;
using Dapper;

namespace TPnoNumero.Models;

private static string _connectionString = @"Server=localhost;DataBase=TPnoNum;Integrated Security=True;TrustServerCertificate=True;";
public bool LogInModel (string name, string answer){
 return name == nombreUser && answer == password;
}