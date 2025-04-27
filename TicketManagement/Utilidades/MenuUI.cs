using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketManagement.Servicios;

namespace TicketManagement.Utilidades
{
    public class MenuUI
    {
        public static void CargarMenuPrincipal(SistemaTickets sistema)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("--- Menu Principal: ---");
                Console.WriteLine("1. Gestion de Tickets");
                Console.WriteLine("2. Gestion de Desarrolladores");
                Console.WriteLine("3. Gestion de Comentarios");
                Console.WriteLine("0. Salir");
                Console.WriteLine("Seleccione una opción");

                try
                {
                    int opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            GestionTickets(sistema);
                            break;
                        case 2:
                            GestionDesarrolladores(sistema);
                            break;
                        case 3:
                            GestionComentarios(sistema);
                            break;
                        case 0:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Opcion invalida.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static void GestionTickets(SistemaTickets sistema)
        {
            bool comeback = false;
            while (!comeback)
            {
                Console.WriteLine("\n--- Gestion de Tickets: ");
                Console.WriteLine("Seleccione una opcion: ");
                Console.WriteLine("1. Agregar nuevo ticket");
                Console.WriteLine("2. Listar los tickets registrados");
                Console.WriteLine("3. Buscar ticket por ticketID");
                Console.WriteLine("0. Volver atras");

                ITicketServicio servicio1 = new TicketServicio();
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        servicio1.agregarTicket(sistema);
                        break;
                    case "2":
                        servicio1.ListarTickets(sistema);
                        break;
                    case "0":
                        comeback= true;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }
        }


        public static void GestionDesarrolladores(SistemaTickets sistema)
        {
            bool comeback = false;
            while (!comeback)
            {
                Console.WriteLine("\n--- Gestion de Developers: ");
                Console.WriteLine("Seleccione una opcion: ");
                Console.WriteLine("1. Agregar nuevo developer");
                Console.WriteLine("2. Listar los developers registrados");
                Console.WriteLine("3. Buscar desarrollador por developerID");
                Console.WriteLine("0. Volver atras");

                IDeveloperServicio servicio2 = new DeveloperServicio();
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        servicio2.AgregarDesarrollador(sistema);
                        break;
                    case "2":
                        servicio2.ListarDesarrolladores(sistema);
                        break;
                    case "0":
                        comeback = true;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }
        }

        public static void GestionComentarios(SistemaTickets sistema)
        {
            bool comeback = false;
            while (!comeback)
            {
                Console.WriteLine("\n--- Gestion de Comentarios: ");
                Console.WriteLine("Seleccione una opcion: ");
                Console.WriteLine("1. Agregar nuevo comentario");
                Console.WriteLine("2. Listar los comentarios registrados");
                Console.WriteLine("3. Buscar comentario por comentarioID");
                Console.WriteLine("0. Volver atras");

                
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        //servicio.agregarTicket(sistema);
                        break;
                    case "2":
                        //servicio.ListarTickets(sistema);
                        break;
                    case "0":
                        comeback = true;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }
        }
        
    }
}
