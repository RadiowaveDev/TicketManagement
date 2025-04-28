using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketManagement.Modelos;
using TicketManagement.Modelos.Enum;

namespace TicketManagement.Servicios
{
    public class TicketServicio : ITicketServicio
    {
        public void AgregarTicket(SistemaTickets sistema)
        {
            Console.WriteLine("\nAgregar un nuevo Ticket: ");

            Console.WriteLine("Titulo del Ticket: ");
            string titulo = Console.ReadLine();

            Console.WriteLine("Descripcion del Ticket: ");
            string descripcion = Console.ReadLine();

            Console.WriteLine("Status : (0)Open, (1)InProgress, (2)OnHold, (3)Resolved, (4)Closed, (5)Reopened");
            TicketStatus status = (TicketStatus)Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prioridad: (0)Low, (1)Medium, (2)High, (3)Critical");
            Priority priority = (Priority)Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Categoria: (0)SoporteTecnico, (1)Facturacion, (2)GestionDeCuenta, (3)PeticionDeFuncionalidad, (4)ReporteDeErrores, (5)Otros");
            TicketCategory category = (TicketCategory)Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Usuario que genera el reporte");
            string reportedBy = Console.ReadLine();

            DateTime createdDate = DateTime.Now.AddDays(-7);
            DateTime updateDate = DateTime.Now.AddDays(-3);
            Developer dev = AsignarTicket(sistema);

            var ticket = new Ticket
            {
                Title = titulo,
                Description = descripcion,
                Status = status,
                priority = priority,
                Category = category,
                ReportedBy = reportedBy,
                CreatedDate = createdDate,
                LastUpdated = updateDate,
                AssignedTo = dev
            };

            sistema.AgregarTicket(ticket);
            Console.WriteLine($"Ticket creado con el ID: {ticket.Id}");
        }

        public void ListarTickets(SistemaTickets sistema)
        {
            var tickets = sistema.ListarTickets();

            // Validar si no hay productos
            if (tickets.Count == 0)
            {
                Console.WriteLine("No hay ningun Ticket");
                return;
            }

            Console.WriteLine("Lista de Tickets: ");
            Console.WriteLine("ID\tTitulo\t\t\t\tDescripcion\t\t\t\tStatus\tPrioridad\tCategoria\tReportadoPor\tFechaReporte\tDeveloperAsignado");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            foreach (var t in tickets)
            {
                Console.WriteLine($"{t.Id}\t{t.Title}\t\t{t.Description}\t{t.Status}\t{t.priority}\t{t.Category}\t{t.ReportedBy}\t{t.CreatedDate}\t{t.AssignedTo?.Nombre ?? "No asignado"}");
            }
        }

        public void BuscarTicketPorId(SistemaTickets sistema)
        {
            Console.WriteLine("\nMostrar Ticket por Id: ");
            Console.WriteLine("Ingresa el Id del Ticket: ");

            int id = int.Parse(Console.ReadLine());
            if (id <= 0)
            {
                throw new ArgumentException("Solo se almacenan valores de Id mayores a 0");
            }
            else
            {
                Ticket t = sistema.ObtenerTicketPorId(id);
                Console.WriteLine("ID\tTitulo\t\tDeveloperAsignado");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine($"{t.Id}\t{t.Title}\t");
            }
        }

        public void ActualizarTicketStatus(SistemaTickets sistema)
        {
            Console.WriteLine("Ingresa el Id del Ticket: ");
            int id = int.Parse(Console.ReadLine());

            if (id <= 0)
            {
                throw new ArgumentException("Solo se almacenan valores de Id mayores a 0");
            }
            else
            {
                Ticket ticket = sistema.ObtenerTicketPorId(id);
                Console.WriteLine("¿Cuál es el nuevo Estado del Ticket? (1)Abierto,(2)EnProgreso,(3)EnEspera,(4)Resuelto,(5)Cerrado,(6)ReAbierto");
                TicketStatus status = (TicketStatus)Convert.ToInt32(Console.ReadLine());
                ticket.Status = status;
                Console.WriteLine("Estado del ticket actualizado");
            }
        }

        public void EliminarTicket(SistemaTickets sistema)
        {
            Console.WriteLine("Ingresa el Id del Ticket: ");
            int id = int.Parse(Console.ReadLine());

            if (id <= 0)
            {
                throw new ArgumentException("Solo se almacenan valores de Id mayores a 0");
            }
            else
            {
                Ticket ticket = sistema.ObtenerTicketPorId(id);
                Console.WriteLine($"¿Desea eliminar el registro del ticket {ticket.Title}? (S)/(N)");
                char opcion = Convert.ToChar(Console.ReadLine());
                if (opcion.Equals('S'))
                {
                    sistema.EliminarTicket(ticket);
                    Console.WriteLine("Registro de ticket borrado");
                }
            }
        }

        public Developer AsignarTicket(SistemaTickets sistema)
        {
            Console.WriteLine("Ingresa el Id del developer asignado: ");
            int id = int.Parse(Console.ReadLine());

            if (id <= 0)
            {
                throw new ArgumentException("Solo se almacenan valores de Id mayores a 0");
            }
            else
            {
                var dev = sistema.ObtenerDeveloperPorId(id);
                return dev;
            }
        }

       
    }
}
