using HospitalMatasanos.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMatasanos.AccesoADatos
{
    public class DepartamentoDAL
    {
        public static int Guardar(Departamento pDepartamento)
        {
            string consulta = "INSERT INTO Departamento(nombre) VALUES (@nombre)";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Nombre", pDepartamento.nombre);
            return ComunDB.EjecutarComando(comando);
        }

        public static int Modificar(Departamento pDepartamento)
        {
            string consulta = "UPDATE Departamento SET nombre=@nombre WHERE Id=@Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pDepartamento.Id);
            comando.Parameters.AddWithValue("@nombre", pDepartamento.nombre);
            return ComunDB.EjecutarComando(comando);
        }


        public static int Eliminar(Departamento pDepartamento)
        {
            string consulta = "DELETE FROM Departamento WHERE Id=@Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pDepartamento.Id);
            return ComunDB.EjecutarComando(comando);
        }

        public static List<Departamento> ObtenerTodos()
        {
            string consulta = "SELECT TOP 500 d.Id, d.nombre FROM Departamento d";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            List<Departamento> ListaDepartamentos = new List<Departamento>();
            while (reader.Read())
            {
                Departamento departamento = new Departamento();
                departamento.Id = reader.GetInt32(0);
                departamento.nombre = reader.GetString(1);
                ListaDepartamentos.Add(departamento);
            }
            return ListaDepartamentos; ;
        }

        public static Departamento BuscarPorId(int pId)
        {
            string consulta = "SELECT d.Id, d.Nombre FROM Departamento d WHERE Id= @Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pId);
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            Departamento departamento = new Departamento();
            while (reader.Read())
            {

                departamento.Id = reader.GetInt32(0);
                departamento.nombre = reader.GetString(1);
            }
            return departamento;
        }

        public static List<Departamento> ObtenerHabilitados()
        {
            string consulta = "SELECT TOP 500 d.Id, d.Nombre FROM Departamento d ";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            List<Departamento> ListaDepartamentos = new List<Departamento>();
            while (reader.Read())
            {
                Departamento departamento = new Departamento();
                departamento.Id = reader.GetByte(0);
                departamento.nombre = reader.GetString(1);
                ListaDepartamentos.Add(departamento);
            }
            return ListaDepartamentos; ;
        }

        public static List<Departamento> Buscar(Departamento pDepartamento)
        {
            string consulta = "SELECT TOP 500 d.Id, d.Nombre FROM Departamento d";
            string whereSql = " ";
            byte contadorDeCampos = 0;
            SqlCommand comando = ComunDB.ObtenerComando();
            if (pDepartamento.nombre != null && pDepartamento.nombre.Trim().Length > 0)
            {
                if (contadorDeCampos > 0)
                {
                    whereSql += " AND ";
                }
                contadorDeCampos++;
                whereSql += " Nombre LIKE @nombre ";
                comando.Parameters.AddWithValue("@nombre", '%' + pDepartamento.nombre + '%');
            }
            if (whereSql.Trim().Length > 0)
            {
                whereSql = " WHERE " + whereSql;
            }
            comando.CommandText = consulta + whereSql;
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            List<Departamento> ListaDepartamentos = new List<Departamento>();

            while (reader.Read())
            {
                Departamento departamento = new Departamento();
                departamento.Id = reader.GetInt32(0);
                departamento.nombre = reader.GetString(1);
                ListaDepartamentos.Add(departamento);
            }
            comando.Connection.Dispose();
            return ListaDepartamentos;
        }
    }
}
