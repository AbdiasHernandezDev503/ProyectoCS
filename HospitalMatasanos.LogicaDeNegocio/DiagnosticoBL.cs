using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HospitalMatasanos.AccesoADatos;
using HospitalMatasanos.EntidadesDeNegocio;

namespace HospitalMatasanos.LogicaDeNegocio
{
    public class DiagnosticoBL
    {
        public static int Guardar(Diagnostico pDiagnostico)
        {
            return DiagnosticoDAL.Guardar(pDiagnostico);
        }
        public static int Modificar (Diagnostico pDiagnostico)
        {
            return DiagnosticoDAL.Modificar(pDiagnostico);
        }
        public static int Eliminar (Diagnostico pDiagnostico)
        {
            return DiagnosticoDAL.Eliminar(pDiagnostico);
        }
    }
}
