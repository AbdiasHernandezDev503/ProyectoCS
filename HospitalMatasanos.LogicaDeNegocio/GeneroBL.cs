using HospitalMatasanos.AccesoADatos;
using HospitalMatasanos.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMatasanos.LogicaDeNegocio
{
    public class GeneroBL
    {
        public static int Guardar(Genero pGenero)
        {
            return GeneroDAL.Guardar(pGenero);
        }

        public static int Modificar(Genero pGenero)
        {
            return GeneroDAL.Modificar(pGenero);
        }

        public static int Eliminar(Genero pGenero)
        {
            return GeneroDAL.Eliminar(pGenero);
        }
    }
}
