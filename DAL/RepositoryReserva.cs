using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RepositoryReserva : BaseReposotory<Reserva>
    {

        private string fileName = "Huesped.txt";

        public RepositoryReserva(string fileName) : base(fileName)
        {
        }

        public string SaveReserva(Reserva reserva)
        {
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine(reserva.ToString());
            }
            return "Datos guardados correctamente";
        }

        public List<Reserva> GetAllUserData()
        {
            var list = new List<Reserva>();
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    list.Add(Map(line));
                }
            }
            return list;
        }
        private Reserva Map(string line)
        {
            var parts = line.Split(';');
            return new Reserva
            {
                Nombre = parts[0],
                Identificacion = (parts[1]),
                DatosContacto = parts[2],
            };
        }
        public override List<Reservad> LoadData()
        {
            throw new NotImplementedException();
        }
    }
}
