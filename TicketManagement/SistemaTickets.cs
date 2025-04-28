using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketManagement.Modelos;

namespace TicketManagement
{
    public class SistemaTickets
    {
        private List<Ticket> _tickets = new List<Ticket>();
        private List<Comment> _comments = new List<Comment>();
        private List<Developer> _developer = new List<Developer>();

        public void AgregarTicket(Ticket ticket)
        {
            _tickets.Add(ticket);
        }
        public List<Ticket> ListarTickets()
        {
            return _tickets.ToList();
        }
        public Ticket ObtenerTicketPorId(int id)
        {
            return _tickets.FirstOrDefault(t => t.Id == id);
        }
        public void EliminarTicket(Ticket ticket)
        {
            _tickets.Remove(ticket);
        }

        public void AgregarDeveloper(Developer developer)
        {
            _developer.Add(developer);
        }
        public List<Developer> ListarDevelopers()
        {
            return _developer.ToList();
        }
        public Developer ObtenerDeveloperPorId(int id)
        {
            return _developer.FirstOrDefault(d => d.Id == id);
        }
        public void EliminarDeveloper(Developer developer)
        {
            _developer.Remove(developer);
        }

        public void AgregarComment(Comment comment) 
        { 
            _comments.Add(comment);
        }
        public List<Comment> ListarComentarios()
        {
            return _comments.ToList();
        }
    }
}
