using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketManagement.Modelos;
using TicketManagement.Modelos.Enum;

namespace TicketManagement.Servicios
{
    public class DeveloperServicio : IDeveloperServicio
    {
        public void AgregarDesarrollador(SistemaTickets sistema)
        {
            Console.WriteLine("\nAgregar un nuevo desarrollador: ");

            Console.WriteLine("Nombre del desarrollador: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("DNI del desarrollador");
            string DNI = Console.ReadLine();

            Console.WriteLine("Direccion del desarrollador: ");
            string direccion = Console.ReadLine();

            Console.WriteLine("Edad del desarrollador: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Genero: (0)Masculino, (1)Femenino");
            Genero genero = (Genero)Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("¿Es senior developer?: true or false");
            bool seniority = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Rol: (0) Developer,(1)QAEngineer,(2)SupportAgent,(3)ProductManager,(4)TeamLead,(5)Admin");
            Role role = (Role)Convert.ToInt32((Console.ReadLine()));

            List<Ticket> tickets = TicketsAsignados(sistema);

            var dev = new Developer()
            {
                Nombre = nombre,
                Direccion = direccion,
                DNI = DNI,
                genero = genero,
                Edad = edad,
                role = role,
                Seniority = seniority,
                Tickets = tickets
            };
            sistema.AgregarDeveloper(dev);
            Console.WriteLine($"Developer agregado con el ID: {dev.Id}");
        }

        public void ListarDesarrolladores(SistemaTickets sistema)
        {
            var developers = sistema.ListarDevelopers();

            // Validar si no hay productos
            if (developers.Count == 0)
            {
                Console.WriteLine("No hay ningun Empleado");
                return;
            }

            Console.WriteLine("Lista de Developers: ");
            Console.WriteLine("ID\tNombre\t\tDNI\t\tGenero\t\tEdad\tRol\t\tSeniority\tTickets");
            Console.WriteLine("----------------------------------------------------------------------");
            foreach (var dev in developers)
            {
                string ticketsCount = dev.Tickets?.Count.ToString() ?? "0";
                Console.WriteLine($"{dev.Id}\t{dev.Nombre}\t{dev.DNI}\t{dev.genero}\t{dev.Edad}\t{dev.role}\t{dev.Seniority}\t\t{ticketsCount}");
            }
        }

        public void BuscarDeveloperPorId(SistemaTickets sistema)
        {
            Console.WriteLine("\nMostrar Developers por Id: ");
            Console.WriteLine("Ingresa el Id del Developer: ");

            int id = int.Parse(Console.ReadLine());

            var dev = sistema.ObtenerDeveloperPorId(id);
            Console.WriteLine("ID\tNombre\t\tRol");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"{dev.Id}\t{dev.Nombre}\t{dev.role}");
        }

        public void ActualizarDeveloperSeniority(SistemaTickets sistema)
        {
            Console.WriteLine("Ingresa el Id del Developer: ");
            int id = int.Parse(Console.ReadLine());

            if (id <= 0)
            {
                throw new ArgumentException("Solo se almacenan valores de Id mayores a 0");
            }
            else
            {
                var dev = sistema.ObtenerDeveloperPorId(id);
                Console.WriteLine($"¿El developer {dev.Nombre} ha conseguido Seniority?");
                bool Senior = Convert.ToBoolean(Console.ReadLine());
                dev.Seniority= Senior;
            }
        }

        public void EliminarDeveloper(SistemaTickets sistema)
        {
            Console.WriteLine("Ingresa el Id del Developer: ");
            int id = int.Parse(Console.ReadLine());

            if (id <= 0)
            {
                throw new ArgumentException("Solo se almacenan valores de Id mayores a 0");
            }
            else
            {
                Developer dev = sistema.ObtenerDeveloperPorId(id);
                Console.WriteLine($"¿Desea eliminar el registro del developer {dev.Nombre}-{dev.role}? (S)/(N)");
                char opcion = Convert.ToChar(Console.ReadLine());
                if (opcion.Equals('S'))
                {
                    sistema.EliminarDeveloper(dev);
                    Console.WriteLine("Registro de developer borrado");
                }
            }
        }

        public List<Ticket> TicketsAsignados(SistemaTickets sistema)
        {
            List<Ticket> ticketAsignados = new List<Ticket>();
            Console.WriteLine("Ingrese el Id del developer: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Developer dev = sistema.ObtenerDeveloperPorId(id);

            List<Ticket> listaTotal = sistema.ListarTickets();
            foreach (Ticket t in listaTotal)
            {
                if(t.AssignedTo == dev)
                {
                    ticketAsignados.Add(t);
                }
            }
            return ticketAsignados;
        }
    }
}
