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
        public void agregarTicket(SistemaTickets sistema)
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
                AssignedTo = new Developer() { Nombre = "Hector Lavoe" }
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
            Console.WriteLine("ID\tTitulo\t\t\t\tDescripcion\t\t\t\tStatus\tPrioridad\tCategoria\tReportadoPor\tFechaReporte");
            Console.WriteLine("-------------------------------------");
            foreach (var ticket in tickets)
            {
                Console.WriteLine($"{ticket.Id}\t{ticket.Title}\t\t{ticket.Description}\t{ticket.Status}\t{ticket.priority}\t{ticket.Category}\t{ticket.ReportedBy}\t{ticket.CreatedDate}");
            }
        }
    }
}
