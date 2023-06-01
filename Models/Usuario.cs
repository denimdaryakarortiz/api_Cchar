using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api_app_2.Models
{
    public class Usuario
    {
        internal string nombres;
        internal string telefono;
        internal string correo;
        internal string ciudad;
        internal string idu;

        public int IdU { get; set; }
        public string Nombres { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Ciudad { get; set; }
        public DateTime FechaIngreso { get; set; }

         }
    }

