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
            string consulta = "INSERT INTO DEPARTAMENTO(ID_Departamento, Departamento) VALUES (@ID_Departamento,@Departamento)";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@ID_Departamento", pDepartamento.IdDepartamento);
            comando.Parameters.AddWithValue("@Departamento", pDepartamento.NombreDepartamento);

            return ComunDB.EjecutarComando(comando);
        }

        public static int Modificar(Departamento pDepartamento)
        {
            string consulta = "UPDATE DEPARTAMENTO SET Departamento=@Departamento WHERE ID_Departamento=@ID_Departmento";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
           // comando.Parameters.AddWithValue("@ID_Departamento", pConsulta.IdConsulta);
            comando.Parameters.AddWithValue("@Departamento", pDepartamento.IdDepartamento);
            
            return ComunDB.EjecutarComando(comando);
        }

        public static int Eliminar(Departamento pDepartamento)
        {
            string consulta = "DELETE FROM DEPARTAMENTO WHERE ID_Departamento=@ID_Departamento";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@ID_Departamento", pDepartamento.IdDepartamento);
            return ComunDB.EjecutarComando(comando);
        }
    }
}
