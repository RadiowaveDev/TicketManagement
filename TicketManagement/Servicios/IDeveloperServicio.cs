using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketManagement.Modelos;

namespace TicketManagement.Servicios
{
    public interface IDeveloperServicio
    {
        void AgregarDesarrollador(SistemaTickets sistema);
        void ListarDesarrolladores(SistemaTickets sistema);
        void BuscarDeveloperPorId(SistemaTickets sistema);
        void ActualizarDeveloperSeniority(SistemaTickets sistema);
        void EliminarDeveloper(SistemaTickets sistema);
        List<Ticket> TicketsAsignados(SistemaTickets sistema);
    }
}
