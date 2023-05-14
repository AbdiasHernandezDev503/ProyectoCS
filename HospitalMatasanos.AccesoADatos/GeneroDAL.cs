using HospitalMatasanos.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMatasanos.AccesoADatos
{
    public class GeneroDAL
    {
        public static int Guardar(Genero pGenro)
        {
            string consulta = "INSERT INTO GENERO(ID_Genero, Genero) VALUES (@ID_Genero, @Genero)";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@ID_Genero", pGenro.IdGenero);
            comando.Parameters.AddWithValue("@Genero", pGenro.NombreGenero);

            return ComunDB.EjecutarComando(comando);
        }

        public static int Modificar(Genero pGenero)
        {
            string consulta = "UPDATE GENERO SET Genro=@Genero WHERE ID_Genero=@ID_Genero";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@ID_Genero", pGenero.IdGenero);
            comando.Parameters.AddWithValue("@Genero", pGenero.NombreGenero);


            return ComunDB.EjecutarComando(comando);
        }

        public static int Eliminar(Genero pGenero)
        {
            string consulta = "DELETE FROM GENERO WHERE ID_Genero=@Id_Genero";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@ID_Genero", pGenero.IdGenero);
            return ComunDB.EjecutarComando(comando);
        }
    }
}
