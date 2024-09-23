using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class BaseReposotory<T>
    {

        protected string _fileName;
        public BaseReposotory(string fileName)
        {
            _fileName = fileName;
        }

        public string SaveData(T entidad)
        {
            try
            {
                StreamWriter writer = new StreamWriter(_fileName, true);
                writer.WriteLine(entidad.ToString());
                writer.Close();
                return "Datos guardados";
            }
            catch (Exception ex)
            {
                return "error al guardar Datos  \n" + ex.Message;
            }

        }
        public abstract List<T> LoadData();



    }
}
