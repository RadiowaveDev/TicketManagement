using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagement.Servicios
{
    public interface ITicketServicio
    {
        void agregarTicket(SistemaTickets sistema);
        void ListarTickets(SistemaTickets sistema);
    }
}
