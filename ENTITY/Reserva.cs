using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Reserva
    {
        public string IdReserva { get; set; }
        public string IdentificacionHuesped { get; set; }
        public int IdHabitacion { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }

        public Reserva(string idReserva, string identificacionHuesped, int idHabitacion, DateTime fechaEntrada, DateTime fechaSalida)
        {
            IdReserva = idReserva;
            IdentificacionHuesped = identificacionHuesped;
            IdHabitacion = idHabitacion;
            FechaEntrada = fechaEntrada;
            FechaSalida = fechaSalida;
        }



    }
}
