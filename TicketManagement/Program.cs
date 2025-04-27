using TicketManagement.Utilidades;

namespace TicketManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======== Ticket Management System =======\n");
            SistemaTickets sistema = new SistemaTickets();
            CargaDatos.CargarDatosIniciales(sistema);
            MenuUI.CargarMenuPrincipal(sistema);
        }
    }
}
