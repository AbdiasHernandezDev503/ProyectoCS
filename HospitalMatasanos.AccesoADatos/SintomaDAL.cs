using HospitalMatasanos.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMatasanos.AccesoADatos
{
    public class SintomaDAL
    {
        public static int Guardar(Sintoma pSintoma)
        {
            string consulta = "INSERT INTO SINTOMA(Condicion_Medica) VALUES (@Condicion_Medica)";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Condicion_Medica", pSintoma.CondicionMedica);

            return ComunDB.EjecutarComando(comando);
        }

        public static int Modificar(Sintoma pSintoma)
        {
            string consulta = "UPDATE SINTOMA SET Condicion_Medica=@Condicion_Medica WHERE ID_Sintoma=@ID_Sintoma";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@ID_Sintoma", pSintoma.IdSintoma);
            comando.Parameters.AddWithValue("@Condicion_Medica",pSintoma.CondicionMedica);


            return ComunDB.EjecutarComando(comando);
        }

        public static int Eliminar(Sintoma pSintoma)
        {
            string consulta = "DELETE FROM SINTOMA WHERE ID_Sintoma=@ID_Sintoma";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@ID_Sintoma", pSintoma.IdSintoma);
            return ComunDB.EjecutarComando(comando);
        }
    }
}
