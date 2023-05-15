using HospitalMatasanos.AccesoADatos;
using HospitalMatasanos.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMatasanos.LogicaDeNegocio
{
    public class SintomaBL
    {
        public static int Guardar(Sintoma pSintoma)
        {
            return SintomaDAL.Guardar(pSintoma);
        }
        public static int Modificar(Sintoma pSintoma)
        {
            return SintomaDAL.Modificar(pSintoma);
        }
        public static int Eliminar(Sintoma pSintoma)
        {
            return SintomaDAL.Eliminar(pSintoma);
        }

        public static Sintoma BuscarPorId(Int32 pId)
        {
            return SintomaDAL.BuscarPorId(pId);
        }

        public static List<Sintoma> ObtenerTodos()
        {
            return SintomaDAL.ObtenerTodos();
        }

        public static List<Sintoma> Buscar(Sintoma pSintoma)
        {
            return SintomaDAL.Buscar(pSintoma);
        }
    }
}
