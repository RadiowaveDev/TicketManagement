using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagement.Servicios
{
    public interface IDeveloperServicio
    {
        void AgregarDesarrollador(SistemaTickets sistema);
        void ListarDesarrolladores(SistemaTickets sistema);
        void BuscarDeveloperPorId(SistemaTickets sistema);
    }
}
