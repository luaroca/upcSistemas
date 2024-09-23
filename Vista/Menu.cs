using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL;
using ENTITY;


namespace Vista
{
    public class Menu
    {
        private RegistroService registroService;

        public Menu()
        {
            registroService = new RegistroService();
        }

        public void MostrarMenu()
        {
            int opcion;
            do
            {
                Console.WriteLine("Sistema de Gestión de Reservas en el Hotel 'Estancia Feliz'");
                Console.WriteLine("1. Registrar Nuevo Huésped");
                Console.WriteLine("2. Registrar Nueva Reserva");
                Console.WriteLine("3. Calcular Costo Total de Estancia");
                Console.WriteLine("4. Verificar Disponibilidad de Habitación");
                Console.WriteLine("5. Visualizar Reservas");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        RegistrarHuesped();
                        break;
                    case 2:
                        
                        Console.WriteLine("");
                        break;
                    case 3:
                        
                        Console.WriteLine("");
                        break;
                    case 4:
                        
                        Console.WriteLine("");
                        break;
                    case 5:
                        
                        Console.WriteLine("");
                        break;
                    case 6:
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            } while (opcion != 6);
        }

       

        private void RegistrarReserva()
        {
            Console.Write("Ingrese el ID de la reserva: ");
            string idReserva = Console.ReadLine();
            Console.Write("Ingrese la identificación del huésped: ");
            string identificacionHuesped = Console.ReadLine();
            Console.Write("Ingrese el ID de la habitación: ");
            int idHabitacion = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la fecha de entrada (yyyy-mm-dd): ");
            DateTime fechaEntrada = DateTime.Parse(Console.ReadLine());
            Console.Write("Ingrese la fecha de salida (yyyy-mm-dd): ");
            DateTime fechaSalida = DateTime.Parse(Console.ReadLine());

            Reserva reserva = new Reserva(idReserva, identificacionHuesped, idHabitacion, fechaEntrada, fechaSalida);
            
        }


    }
}
