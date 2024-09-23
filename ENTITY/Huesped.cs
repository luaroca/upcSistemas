using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ENTITY
{
    public class Huesped
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string DatosContacto { get; set; }


        public override string ToString()
        {
            return $"{Identificacion};{Nombre};{DatosContacto} ";
        }



    }
}
