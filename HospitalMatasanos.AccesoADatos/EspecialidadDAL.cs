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
            string consulta = "INSERT INTO ESPECIALIDAD(Nombre) VALUES (@Nombre)";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Nombre", pEspecialidad.Nombre);

            return ComunDB.EjecutarComando(comando);
        }

        public static int Modificar(Especialidad pEspecialidad)
        {
            string consulta = "UPDATE ESPECIALIDAD SET Nombre=@Nombre WHERE Id = @Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pEspecialidad.Id);
            comando.Parameters.AddWithValue("@Nombre", pEspecialidad.Nombre);


            return ComunDB.EjecutarComando(comando);
        }

        public static int Eliminar(Especialidad pEspecialidad)
        {
            string consulta = "DELETE FROM ESPECIALIDAD WHERE Id=@Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pEspecialidad.Id);
            return ComunDB.EjecutarComando(comando);
        }
        public static List<Especialidad> ObtenerTodos()
        {
            string consulta = "SELECT TOP 500 e.Id, e.Nombre FROM Especialidad e";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            List<Especialidad> ListaEspecialidades = new List<Especialidad>();
            while (reader.Read())
            {
                Especialidad especialidad = new Especialidad();
                especialidad.Id = reader.GetInt32(0);
                especialidad.Nombre = reader.GetString(1);
                ListaEspecialidades.Add(especialidad);
            }
            return ListaEspecialidades; 
        }
        public static Especialidad BuscarPorId(int pId)
        {
            string consulta = "SELECT e.Id, e.Nombre FROM Especialidad e WHERE Id= @Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pId);
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            Especialidad especialidad = new Especialidad();
            while (reader.Read())
            {

                especialidad.Id = reader.GetInt32(0);
                especialidad.Nombre = reader.GetString(1);
            }
            return especialidad;
        }

        public static List<Especialidad> ObtenerHabilitados()
        {
            string consulta = "SELECT TOP 500 e.Id, e.Nombre FROM Especialidad e ";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            List<Especialidad> ListaEspecialidades = new List<Especialidad>();
            while (reader.Read())
            {
                Especialidad especialidad = new Especialidad();
                especialidad.Id = reader.GetByte(0);
                especialidad.Nombre = reader.GetString(1);
                ListaEspecialidades.Add(especialidad);
            }
            return ListaEspecialidades; ;
        }

        public static List<Especialidad> Buscar(Especialidad pEspecialidad)
        {
            string consulta = "SELECT TOP 500 e.Id, e.Nombre FROM Especialidad e";
            string whereSql = " ";
            byte contadorDeCampos = 0;
            SqlCommand comando = ComunDB.ObtenerComando();
            if (pEspecialidad.Nombre != null && pEspecialidad.Nombre.Trim().Length > 0)
            {
                if (contadorDeCampos > 0)
                {
                    whereSql += " AND ";
                }
                contadorDeCampos++;
                whereSql += " Nombre LIKE @nombre ";
                comando.Parameters.AddWithValue("@Nombre", '%' + pEspecialidad.Nombre + '%');
            }
            if (whereSql.Trim().Length > 0)
            {
                whereSql = " WHERE " + whereSql;
            }
            comando.CommandText = consulta + whereSql;
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            List<Especialidad> ListaEspecialidades = new List<Especialidad>();

            while (reader.Read())
            {
                Especialidad especialidad = new Especialidad();
                especialidad.Id = reader.GetInt32(0);
                pEspecialidad.Nombre = reader.GetString(1);
                ListaEspecialidades.Add(especialidad);
            }
            comando.Connection.Dispose();
            return ListaEspecialidades;
        }
    }
}
