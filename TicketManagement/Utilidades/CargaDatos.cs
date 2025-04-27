using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketManagement.Modelos;
using TicketManagement.Modelos.Enum;

namespace TicketManagement.Utilidades
{
    public class CargaDatos
    {
        public static void CargarDatosIniciales(SistemaTickets sistema) 
        {   
            //Agregar Desarrollador
            var dev1 = new Developer
            {
                Nombre = "Angel Gonzales",
                genero = Genero.MASCULINO,
                Direccion = "Av SistemaSolar 123",
                DNI = "78964523",
                Edad = 30,
                role=Role.Developer,
                Seniority=false,
                Tickets=new List<Ticket>()
            };

            var dev2 = new Developer
            {
                Nombre = "Diego Zapata",
                genero = Genero.MASCULINO,
                Direccion = "Av GloboTerraqueo 123",
                DNI = "35293847",
                Edad = 32,
                role = Role.QAEngineer,
                Seniority = false,
                Tickets = new List<Ticket>()
            };

            sistema.AgregarDeveloper(dev1);
            sistema.AgregarDeveloper(dev2);

            //Agregar Comentarios
            var comment1 = new Comment
            {
                Author = "Luis Suarez",
                Text = "Error de visualizacion de interfaz grafica",
                CreatedDate = DateTime.Now.AddDays(-2)
            };
            var comment2 = new Comment
            {
                Author = "Eder Valencia",
                Text = "Tiempo de carga muy prolongado",
                CreatedDate = DateTime.Now.AddDays(-7)
            };

            sistema.AgregarComment(comment1);
            sistema.AgregarComment(comment2);

            //Agregar tickets
            var ticket1 = new Ticket
            {
                Title="Malfuncion de interfaz",
                Description="La interfaz de pago no se visualiza",
                Status=TicketStatus.Open,
                priority=Priority.High,
                Category=TicketCategory.ReporteDeErrores,
                ReportedBy="Luis Suarez",
                CreatedDate = DateTime.Now.AddDays(-3),
                comments=new List<Comment>()
            };

            var ticket2 = new Ticket
            {
                Title = "Error de capa 8",
                Description = "Usuario no entiende instrucciones de pago",
                Status = TicketStatus.Open,
                priority = Priority.High,
                Category = TicketCategory.ReporteDeErrores,
                ReportedBy = "Eder Valencia",
                CreatedDate = DateTime.Now.AddDays(-3),
            };

            sistema.AgregarTicket(ticket1);
            sistema.AgregarTicket(ticket2);
        }
    }
}
