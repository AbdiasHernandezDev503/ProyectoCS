using HospitalMatasanos.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMatasanos.AccesoADatos
{
    public class EfectoSecundarioDAL
    {
        public static int Guardar(EfectoSecundario pEfecto)
        {
            string consulta = "INSERT INTO EFECTO_SECUNDARIO(Efecto_Secundario) VALUES (@Efecto_ecundario)";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Efecto_Secundario", pEfecto.NombreEfectoSecundario);
            
            return ComunDB.EjecutarComando(comando);
        }

        public static int Modificar(EfectoSecundario pEfecto)
        {
            string consulta = "UPDATE EFECTO_SECUNDARIO SET Efecto_Secundario=@Efecto_Secundario WHERE ID_Efecto_Secundario=@ID_Efecto_Secundario";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@ID_Efecto_Secundario", pEfecto.IdEfectoSecundario);
            comando.Parameters.AddWithValue("@Efecto_Secundario", pEfecto.NombreEfectoSecundario);
            

            return ComunDB.EjecutarComando(comando);
        }

        public static int Eliminar(EfectoSecundario pEfecto)
        {
            string consulta = "DELETE FROM EFECTO_SECUNDARIO WHERE ID_Efecto_Secundario=@ID_Efecto_Secundario";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@ID_Efecto_Secundario", pEfecto.IdEfectoSecundario);
            return ComunDB.EjecutarComando(comando);
        }
    }
}
