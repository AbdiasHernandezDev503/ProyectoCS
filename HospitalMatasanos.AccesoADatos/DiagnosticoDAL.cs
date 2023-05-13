using HospitalMatasanos.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMatasanos.AccesoADatos
{
    public class DiagnosticoDAL
    {
        public static int Guardar(Diagnostico pDiagnostico)
        {
            string consulta = "INSERT INTO DIAGNOSTICO(ID_Consulta_Dg, Resultado, ID_Tratamiento_DG) VALUES (@ID_Consulta_Dg,@Resultado,@ID_Tratamiento_Dg)";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@ID_Consulta_Dg", pDiagnostico.IdConsultaDg);
            comando.Parameters.AddWithValue("@Resultado", pDiagnostico.Resultado);
            comando.Parameters.AddWithValue("@ID_Tratamiento_Dg", pDiagnostico.IdTratamientoDg);

            return ComunDB.EjecutarComando(comando);
        }

        public static int Modificar(Diagnostico pDiagnostico)
        {
            string consulta = "UPDATE DIAGNOSTICO SET ID_Consulta_Dd=@ID_Consulta_Dg,Resultado=@Resultado,ID_Tratamiento_Dg=@ID_Tratamiento_Dg WHERE ID_Diagnostico=@ID_DIAGNOSTICO";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@ID_Diagnostico", pDiagnostico.IdDiagnostico);
            comando.Parameters.AddWithValue("@ID_Consulta_Dg", pDiagnostico.IdConsultaDg);
            comando.Parameters.AddWithValue("@Resultado", pDiagnostico.Resultado);
            comando.Parameters.AddWithValue("@ID_Tratamiento_Dg", pDiagnostico.IdTratamientoDg);

            return ComunDB.EjecutarComando(comando);
        }

        public static int Eliminar(Diagnostico pDiagnostico)
        {
            string consulta = "DELETE FROM DIAGNOSTICO WHERE ID_Diagnostico=@ID_Diagnostico";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@ID_Diagnostico", pDiagnostico.IdDiagnostico);
            return ComunDB.EjecutarComando(comando);
        }
    }
}
