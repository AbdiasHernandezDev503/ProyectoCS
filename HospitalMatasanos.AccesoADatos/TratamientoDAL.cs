using HospitalMatasanos.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMatasanos.AccesoADatos
{
    public class TratamientoDAL
    {
        public static int Guardar(Tratamiento pTratamiento)
        {
            string consulta = "INSERT INTO TRATAMIENTO(Tratamiento,Dosis,Duracion_Semanas,Fecha_Inicio,Fecha_Fin,ID_EfectSecund_Tto,ID_PerHosp_Tto) VALUES (@Tratamiento,@Dosis,@Duracion_Semanas,@Fecha_Inicio,@Fecha_Fin,@ID_EfectSecund_Tto,@ID_PerHosp_Tto)";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Tratamiento", pTratamiento.NombreTratamiento);
            comando.Parameters.AddWithValue("@Dosis", pTratamiento.Dosis);
            comando.Parameters.AddWithValue("@Duracion_Semanas", pTratamiento.DuracionSemanas);
            comando.Parameters.AddWithValue("@Fecha_Inicio", pTratamiento.FechaInicio);
            comando.Parameters.AddWithValue("@Fecha_Fin", pTratamiento.FechaFin);
            comando.Parameters.AddWithValue("@ID_EfectSecund_Tto", pTratamiento.IdEffectSecnundTto);
            comando.Parameters.AddWithValue("@ID_PerHosp_Tto", pTratamiento.IdPerHospTto);

            return ComunDB.EjecutarComando(comando);
        }

        public static int Modificar(Tratamiento pTratamiento)
        {
            string consulta = "UPDATE TRATAMIENTO SET Tratamiento=@Tratamiento,Dosis=@Dosis,Duracion_Semanas=@Duracion_Semanas,Fecha_Inicio=@Fecha_Inicio,Fecha_Fin=@Fecha_Fin,ID_EfectSecund_Tto=@ID_EfectSecund_Tto,ID_PerHosp_Tto=@ID_PerHosp_Tto WHERE ID_Tratamiento=@ID_Tratamiento";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@ID_Tratamiento", pTratamiento.IdTratamiento);
            comando.Parameters.AddWithValue("@Tratamiento", pTratamiento.NombreTratamiento);
            comando.Parameters.AddWithValue("@Dosis", pTratamiento.Dosis);
            comando.Parameters.AddWithValue("@Duracion_Semanas", pTratamiento.DuracionSemanas);
            comando.Parameters.AddWithValue("@Fecha_Inicio", pTratamiento.FechaInicio);
            comando.Parameters.AddWithValue("@Fecha_Fin", pTratamiento.FechaFin);
            comando.Parameters.AddWithValue("@ID_EfectSecund_Tto", pTratamiento.IdEffectSecnundTto);
            comando.Parameters.AddWithValue("@ID_PerHosp_Tto", pTratamiento.IdPerHospTto);
            
            return ComunDB.EjecutarComando(comando);
        }

        public static int Eliminar(Tratamiento pTratamiento)
        {
            string consulta = "DELETE FROM TRATAMIENTO WHERE ID_Tratamiento=@ID_Tratamiento";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@ID_Tratamiento", pTratamiento.IdTratamiento);
            return ComunDB.EjecutarComando(comando);
        }
    }
}
