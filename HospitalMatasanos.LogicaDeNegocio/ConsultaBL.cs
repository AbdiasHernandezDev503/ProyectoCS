using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using HospitalMatasanos.AccesoADatos;
using HospitalMatasanos.EntidadesDeNegocio;

namespace HospitalMatasanos.LogicaDeNegocio
{
    public class ConsultaBL
    {
        public static int Guardar(Consulta pConsulta)
        {
            return ConsultaDAL.Guardar(pConsulta);
        }
        
        public static int Modificar (Consulta pConsulta)
        {
            return ConsultaDAL.Modificar(pConsulta);
        }

        public static int Eliminar (Consulta pConsulta)
        {
            return ConsultaDAL.Eliminar(pConsulta);
        }
    }
}
