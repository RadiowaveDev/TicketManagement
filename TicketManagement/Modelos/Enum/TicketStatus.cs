using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagement.Modelos.Enum
{
    public enum TicketStatus
    {
        Open,           // El ticket ha sido creado pero aún no se ha atendido
        InProgress,     // Un agente está trabajando en el ticket
        OnHold,         // El ticket está pausado temporalmente
        Resolved,       // El problema ha sido resuelto, pendiente de cierre
        Closed,         // El ticket ha sido cerrado definitivamente
        Reopened
    }
}
