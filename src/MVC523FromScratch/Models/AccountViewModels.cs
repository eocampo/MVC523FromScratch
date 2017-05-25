using System;

namespace MVC523FromScratch.Models
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }
    }

    public class Administrador : Usuario
    {
        public string MasterKey { get; set; }
    }    
}