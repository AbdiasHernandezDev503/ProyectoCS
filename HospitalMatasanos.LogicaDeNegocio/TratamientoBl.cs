using HospitalMatasanos.AccesoADatos;
using HospitalMatasanos.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMatasanos.LogicaDeNegocio
{
    public class TratamientoBl
    {
        public static int Guardar(Tratamiento pTratamiento)
        {
            return TratamientoDAL.Guardar(pTratamiento);
        }
        public static int Modificar(Tratamiento pTratamiento)
        {
            return TratamientoDAL.Modificar(pTratamiento);
        }
        public static int Eliminar(Tratamiento pTratamiento)
        {
            return TratamientoDAL.Eliminar(pTratamiento);
        }
    }
}
