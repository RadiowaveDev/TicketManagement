using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagement.Servicios
{
    public interface IComentarioServicio
    {
        void AgregarComentario(SistemaTickets sistema);
        void ListarComentarios(SistemaTickets sistema);
    }
}
