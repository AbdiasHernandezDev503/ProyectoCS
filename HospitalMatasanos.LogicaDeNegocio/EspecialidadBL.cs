using HospitalMatasanos.AccesoADatos;
using HospitalMatasanos.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMatasanos.LogicaDeNegocio
{
    public class EspecialidadBL
    {
        public static int Guardar(Especialidad pEspecialidad)
        {
            return EspecialidadDAL.Guardar(pEspecialidad);
        }
        public static int Modificar(Especialidad pEspecialidad)
        {
            return EspecialidadDAL.Modificar(pEspecialidad);
        }
        public static int Eliminar(Especialidad pEspecialidad)
        {
            return EspecialidadDAL.Eliminar(pEspecialidad);
        }
        public static List<Especialidad> ObtenerTodos()
        {
            return EspecialidadDAL.ObtenerTodos();
        }
        public static Especialidad BuscarPorId(int pId)
        {
            return EspecialidadDAL.BuscarPorId(pId);
        }
        public static List<Especialidad> ObtnerHabilitados()
        {
            return EspecialidadDAL.ObtenerHabilitados();
        }
        public static List<Especialidad> Buscar(Especialidad pEspecialidad)
        {
            return EspecialidadDAL.Buscar(pEspecialidad);
        }
    }
}
