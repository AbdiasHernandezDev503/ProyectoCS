using HospitalMatasanos.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMatasanos.AccesoADatos
{
    public class EspecialidadDAL
    {
        public static int Guardar(Especialidad pEspecialidad)
        {
            string consulta = "INSERT INTO ESPECIALIDAD(Especialidad) VALUES (@Especialidad)";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Especialidad", pEspecialidad.NombreEspecialidad);

            return ComunDB.EjecutarComando(comando);
        }

        public static int Modificar(Especialidad pEspecialidad)
        {
            string consulta = "UPDATE ESPECIALIDAD SET Especialidad=@Especialidad WHERE ID_Especialidad=@ID_Especialidad";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@ID_Especialidad", pEspecialidad.IdEspecialidad);
            comando.Parameters.AddWithValue("@Especialidad", pEspecialidad.NombreEspecialidad);


            return ComunDB.EjecutarComando(comando);
        }

        public static int Eliminar(Especialidad pEspecialidad)
        {
            string consulta = "DELETE FROM ESPECIALIDAD WHERE ID_Especialidad=@ID_Especialidad";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@ID_Especialidad", pEspecialidad.IdEspecialidad);
            return ComunDB.EjecutarComando(comando);
        }
    }
}
