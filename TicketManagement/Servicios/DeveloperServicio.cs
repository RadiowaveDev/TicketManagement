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

            Console.WriteLine("Genero del desarrollador: ");
            Genero genero = (Genero)Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("¿Es senior developer?");
            bool seniority = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Rol del desarrollador: ");
            Role role = (Role)Convert.ToInt32((Console.ReadLine()));

            var dev = new Developer()
            {
                Nombre = nombre,
                Direccion = direccion,
                genero = genero,
                Edad = edad,
                role = role,
                Seniority = seniority,
                Tickets = new List<Ticket>()
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
            Console.WriteLine("ID\tNombre\t\tDNI\t\tGenero\t\tEdad\tRole\tSeniority\t\tTickets");
            Console.WriteLine("-------------------------------------");
            foreach (var developer in developers)
            {
                Console.WriteLine($"{developer.Id}\t{developer.Nombre}\t{developer.DNI}\t{developer.genero}\t{developer.Edad}\t{developer.role}\t{developer.Seniority}\t{developer.Tickets}");
            }
        }

        public void BuscarDeveloperPorId(SistemaTickets sistema)
        {

        }
    }
}
