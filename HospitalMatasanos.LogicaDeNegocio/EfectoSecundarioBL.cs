using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HospitalMatasanos.AccesoADatos;
using HospitalMatasanos.EntidadesDeNegocio;

namespace HospitalMatasanos.LogicaDeNegocio
{
    public class EfectoSecundarioBL
    {
        public static int Guardar (EfectoSecundario pEfecto)
        {
            return EfectoSecundarioDAL.Guardar(pEfecto);
        }
        public static int Modificar (EfectoSecundario pEfecto)
        {
            return EfectoSecundarioDAL.Modificar(pEfecto);
        }
        public static int Eliminar (EfectoSecundario pEfecto)
        {
            return EfectoSecundarioDAL.Eliminar(pEfecto);
        }
    }
}
