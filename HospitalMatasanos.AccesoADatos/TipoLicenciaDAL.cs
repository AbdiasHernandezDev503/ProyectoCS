using HospitalMatasanos.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMatasanos.AccesoADatos
{
    public class TipoLicenciaDAL
    {
        public static int Guardar(TipoLicencia pTipoLicencia)
        {
            string consulta = "INSERT INTO TIPO_LICENCIA(ID_TLicencia,Tipo_Licencia) VALUES (@ID_TLicencia,@Tipo_Licencia)";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@ID_TLicencia", pTipoLicencia.IdTLicencia);
            comando.Parameters.AddWithValue("@Tipo_Licencia", pTipoLicencia.TipoDeLicencia);

            return ComunDB.EjecutarComando(comando);
        }

        public static int Modificar(TipoLicencia pTipoLicecncia)
        {
            string consulta = "UPDATE TIPO_LICENCIA SET Tipo_Licencia=@Tipo_Licencia WHERE ID_TLicencia=@ID_TLicencia";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@ID_TLicencia", pTipoLicecncia.IdTLicencia);
            comando.Parameters.AddWithValue("@Tipo_Licencia", pTipoLicecncia.TipoDeLicencia);


            return ComunDB.EjecutarComando(comando);
        }

        public static int Eliminar(TipoLicencia pTipoLicencia)
        {
            string consulta = "DELETE FROM TIPO_LICENCIA WHERE ID_TLicencia=@ID_TLicencia";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@ID_TLicencia", pTipoLicencia.IdTLicencia);
            return ComunDB.EjecutarComando(comando);
        }
    }
}
