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
    }
}
