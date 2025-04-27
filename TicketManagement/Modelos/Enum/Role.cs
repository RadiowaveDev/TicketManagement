using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagement.Modelos.Enum
{
    public enum Role
    {
        Developer,          // Desarrollador que trabaja en la resolución del ticket
        QAEngineer,         // Ingeniero de calidad que valida las correcciones
        SupportAgent,       // Agente de soporte que atiende directamente al cliente
        ProductManager,     // Responsable de priorizar y analizar los tickets
        TeamLead,           // Líder técnico o de equipo, supervisa el flujo de trabajo
        Admin               // Rol con permisos administrativos completos
    }
}
