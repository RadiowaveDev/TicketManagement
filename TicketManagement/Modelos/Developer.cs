using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using TicketManagement.Modelos.Enum;

namespace TicketManagement.Modelos
{
    public class Developer : Persona 
    {
        private static int _nextId = 1;
        public int Id { get; set; }
        public Role role { get; set; }
        public bool Seniority   { get; set; }
        public List<Ticket> Tickets { get; set; }

        public Developer() 
        {
            Id = _nextId++;
        }
    }
}
