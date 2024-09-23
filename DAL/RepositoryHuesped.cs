using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RepositoryHuesped : BaseReposotory<Huesped>
    {

        private string fileName = "Huesped.txt";
        public RepositoryHuesped(string fileName) : base(fileName)
        {
        }

        public string SaveHuesped(Huesped huesped)
        {
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine(huesped.ToString());
            }
            return "Datos guardados correctamente";
        }

        public List<Huesped> GetAllUserData()
        {
            var list = new List<Huesped>();
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
        private Huesped Map(string line)
        {
            var parts = line.Split(';');
            return new Huesped
            {
                Nombre = parts[0],
                Identificacion = (parts[1]),
                DatosContacto = parts[2],
            };
        }
        public override List<Huesped> LoadData()
        {
            throw new NotImplementedException();
        }
    }
}
