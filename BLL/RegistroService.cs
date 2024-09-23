using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class RegistroService
    {
        private RepositoryHuesped _repositoryHuesped;

        public RegistroService()
        {
            _repositoryHuesped = new RepositoryHuesped("Huesped.txt");
        }

        public string SaveHuesped(string identificacion, string nombre, string datosContacto)
        {
           
            Huesped huesped = new Huesped
            {
                Identificacion = identificacion,
                Nombre = nombre,
                DatosContacto = datosContacto
            };

            return _repositoryHuesped.SaveHuesped(huesped);
        }

    }
}
