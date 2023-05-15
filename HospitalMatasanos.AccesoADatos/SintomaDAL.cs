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
            string consulta = "UPDATE SINTOMA SET Condicion_Medica=@Condicion_Medica WHERE Id=@Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pSintoma.IdSintoma);
            comando.Parameters.AddWithValue("@Condicion_Medica",pSintoma.CondicionMedica);

            return ComunDB.EjecutarComando(comando);
        }

        public static int Eliminar(Sintoma pSintoma)
        {
            string consulta = "DELETE FROM SINTOMA WHERE Id=@Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pSintoma.IdSintoma);
            return ComunDB.EjecutarComando(comando);
        }

        public static Sintoma BuscarPorId(Int32 pId)
        {
            string consulta = "SELECT s.Id, s.Condicion_Medica FROM SINTOMA s WHERE Id= @Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pId);
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            Sintoma sintoma = new Sintoma();
            while (reader.Read())
            {
                sintoma.IdSintoma = reader.GetInt32(0);
                sintoma.CondicionMedica = reader.GetString(1);
            }
            return sintoma;
        }

        public static List<Sintoma> ObtenerTodos()
        {
            string consulta = "SELECT TOP 500 s.Id, s.Condicion_Medica FROM SINTOMA s";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            List<Sintoma> listaSintomas = new List<Sintoma>();
            while (reader.Read())
            {
                Sintoma sintoma = new Sintoma();
                sintoma.IdSintoma = reader.GetInt32(0);
                sintoma.CondicionMedica = reader.GetString(1);
                listaSintomas.Add(sintoma);
            }
            return listaSintomas; ;
        }

        public static List<Sintoma> Buscar(Sintoma pSintoma)
        {
            string consulta = "SELECT TOP 500 s.Id, s.Condicion_Medica FROM SINTOMA s";
            string whereSql = " ";
            byte contadorDeCampos = 0;
            SqlCommand comando = ComunDB.ObtenerComando();
            if (pSintoma.CondicionMedica != null && pSintoma.CondicionMedica.Trim().Length > 0)
            {
                if (contadorDeCampos > 0)
                {
                    whereSql += " AND ";
                }
                contadorDeCampos++;
                whereSql += " Condicion_Medica LIKE @Condicion_Medica ";
                comando.Parameters.AddWithValue("@Condicion_Medica", '%' + pSintoma.CondicionMedica + '%');
            }
            if (whereSql.Trim().Length > 0)
            {
                whereSql = " WHERE " + whereSql;
            }
            comando.CommandText = consulta + whereSql;
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            List<Sintoma> listaSintomas = new List<Sintoma>();

            while (reader.Read())
            {
                Sintoma sintoma = new Sintoma();
                sintoma.IdSintoma = reader.GetInt32(0);
                sintoma.CondicionMedica = reader.GetString(1);
                listaSintomas.Add(sintoma);
            }
            comando.Connection.Dispose();
            return listaSintomas;
        }
    }
}
