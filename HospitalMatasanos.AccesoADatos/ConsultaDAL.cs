using HospitalMatasanos.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMatasanos.AccesoADatos
{
    public class ConsultaDAL
    {
        public static int Guardar(Consulta pConsulta)
        {
            string consulta = "INSERT INTO CONSULTA(NomID_Consulta,ID_Sintoma_Cns, ID_PersonalHospital_Cns, ID_Paciente_Cns) VALUES (@ID_Consulta,@ID_Sintoma_Cns,@ID_PersonalHospital_Cns,@ID_Paciente_Cns)";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@ID_Consulta", pConsulta.IdConsulta);
            comando.Parameters.AddWithValue("@ID_Sintoma_Cns", pConsulta.IdSintoma);
            comando.Parameters.AddWithValue("@ID_PersonalHospital_Cns", pConsulta.IdPersonalHospitalCns);
            comando.Parameters.AddWithValue("@ID_Paciente_Cns", pConsulta.IdPacienteCns);

            return ComunDB.EjecutarComando(comando);
        }

        public static int Modificar(Consulta pConsulta)
        {
            string consulta = "UPDATE CONSULTA SET ID_Sintoma_Cns=@ID_Sintoma_Cns,ID_PersonalHospital_Cns=@ID_PersonalHospital_Cns,ID_Paciente_Cns=@ID_Paciente_Cns WHERE ID_Consulta=@ID_Consulta";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText= consulta;
            comando.Parameters.AddWithValue("@ID_Consulta", pConsulta.IdConsulta);
            comando.Parameters.AddWithValue("@ID_Sintoma_Cns", pConsulta.IdSintoma);
            comando.Parameters.AddWithValue("@ID_PersonalHospital_Cns", pConsulta.IdPersonalHospitalCns);
            comando.Parameters.AddWithValue("@ID_Paciente_Cns", pConsulta.IdPacienteCns);

            return ComunDB.EjecutarComando(comando);
        }

        public static int Eliminar(Consulta pConsulta)
        {
            string consulta = "DELETE FROM CONSULTA WHERE ID_Consulta=@ID_Consulta";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@ID_Consulta", pConsulta.IdConsulta);
            return ComunDB.EjecutarComando(comando);
        }
    }
}
