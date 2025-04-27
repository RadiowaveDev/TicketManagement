using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketManagement.Modelos.Enum;

namespace TicketManagement.Modelos
{
    public class Ticket
    {
        private static int _nextId = 1;
        public int Id { get; private set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TicketStatus Status {get;set;}
        public Priority priority { get; set;}
        public TicketCategory Category { get; set;}
        public string ReportedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public Developer AssignedTo { get; set; }

        public List<Comment> comments { get; set; }

        public Ticket()
        {
            Id = _nextId++;
        }
    }
}
