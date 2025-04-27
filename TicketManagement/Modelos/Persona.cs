using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketManagement.Modelos.Enum;

namespace TicketManagement.Modelos
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public Genero genero { get; set; }
        public string DNI { get; set; }
        public string Direccion { get; set; }
        public int Edad { get; set; }
    }
}
