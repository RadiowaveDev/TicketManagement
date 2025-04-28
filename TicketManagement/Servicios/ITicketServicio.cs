using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketManagement.Modelos;

namespace TicketManagement.Servicios
{
    public interface ITicketServicio
    {
        void AgregarTicket(SistemaTickets sistema);
        void ListarTickets(SistemaTickets sistema);
        void BuscarTicketPorId(SistemaTickets sistema);
        void ActualizarTicketStatus(SistemaTickets sistema);
        void EliminarTicket(SistemaTickets sistema);
        Developer AsignarTicket(SistemaTickets sistema);
    }
}
