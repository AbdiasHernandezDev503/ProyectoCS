using HospitalMatasanos.AccesoADatos;
using HospitalMatasanos.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMatasanos.LogicaDeNegocio
{
    public class TipoLicenciaBL
    {
        public static int Guardar(TipoLicencia pTipoLicencia)
        {
            return TipoLicenciaDAL.Guardar(pTipoLicencia);
        }
        public static int Modificar(TipoLicencia pTipoLicencia)
        {
            return TipoLicenciaDAL.Modificar(pTipoLicencia);
        }
        public static int Eliminar(TipoLicencia pTipoLicencia)
        {
            return TipoLicenciaDAL.Eliminar(pTipoLicencia);
        }
    }
}
