using HospitalMatasanos.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMatasanos.AccesoADatos
{
    public class PacienteDAL
    {
        public static int Guardar(Paciente pPaciente)
        {
            string consulta = "INSERT INTO PACIENTE(No_Seguro,Nombres_paciente,Apellidos_paciente,Telefono_paciente,ID_Departamento_paciente,ID_Genero_paciente) VALUES (@No_Seguro,@Nombres_paciente,@Apellidos_paciente,@Telefono_paciente,@ID_Departamento_paciente,@ID_Genero_paciente)";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@No_Seguro", pPaciente.NoSeguro);
            comando.Parameters.AddWithValue("@Nombres_paciente", pPaciente.NombresPaciente);
            comando.Parameters.AddWithValue("@Apellidos_paciente", pPaciente.ApellidosPaciente);
            comando.Parameters.AddWithValue("@Telefono_paciente", pPaciente.TelefonoPaciente);
            comando.Parameters.AddWithValue("@ID_Genero_paciente", pPaciente.IdGeneroPaciente);
            comando.Parameters.AddWithValue("@ID_Departamento_paciente", pPaciente.IdDepartamentoPaciente);

            return ComunDB.EjecutarComando(comando);
        }

        public static int Modificar(Paciente pPaciente)
        {
            string consulta = "UPDATE PACIENTE SET NoSeguro=@No_Seguro,Nombres_paciente=@Nombres_paciente,Apellidos_paciente=@Apellidos_paciente,Telefono_paciente=@Telefono_paciente WHERE ID_Paciente=@ID_Paciente";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@ID_Paciente", pPaciente.IdPaciente);
            comando.Parameters.AddWithValue("@No_Seguro", pPaciente.NoSeguro);
            comando.Parameters.AddWithValue("@Nombres_paciente", pPaciente.NombresPaciente);
            comando.Parameters.AddWithValue("@Apellidos_paciente", pPaciente.ApellidosPaciente);
            comando.Parameters.AddWithValue("@Telefono_paciente", pPaciente.TelefonoPaciente);

            return ComunDB.EjecutarComando(comando);
        }

        public static int Eliminar(Paciente pPaciente)
        {
            string consulta = "DELETE FROM PACIENTE WHERE ID_Paciente=@ID_Paciente";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@ID_Paciente", pPaciente.IdPaciente);
            return ComunDB.EjecutarComando(comando);
        }
    }
}
