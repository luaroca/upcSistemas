using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Habitacion
    {

        public int IdHabitacion { get; set; }
        public string Categoria { get; set; }
      

        public Habitacion(int idHabitacion, string categoria)
        {
            IdHabitacion = idHabitacion;
            Categoria = categoria;
           
        }




    }
}
