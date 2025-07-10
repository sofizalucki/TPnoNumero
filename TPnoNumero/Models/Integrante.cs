namespace TPnoNumero.Models;
using Newtonsoft.Json;
public class Integrante
{
    [JsonProperty]
     public int IdIntegrante {get; private set;}
     [JsonProperty]
     public string nombreUser { get; private set; }
     [JsonProperty]
     public string password { get; private set; }
     [JsonProperty]
     public string nombre { get; private set; }
     [JsonProperty]
     public string apellido { get; private set; }
     [JsonProperty]
     public int DNI { get; private set; }
     [JsonProperty]
     public string direccion {get; private set;}
     [JsonProperty]
     public string barrio {get; private set;}
    public Integrante(string nombreUser, string password, string nombre, string apellido, int DNI, string direccion, string barrio){
        this.nombreUser = nombreUser;
        this.password = password;
        this.nombre = nombre;
        this.apellido = apellido;
        this.DNI = DNI;
        this.direccion = direccion;
        this.barrio = barrio;
    }
}
