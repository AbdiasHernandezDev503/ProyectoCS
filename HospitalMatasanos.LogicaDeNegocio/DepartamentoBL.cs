using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalMatasanos;
using HospitalMatasanos.EntidadesDeNegocio;
using HospitalMatasanos.AccesoADatos;

namespace HospitalMatasanos.LogicaDeNegocio
{
    public class DepartamentoBL
    {
        public static int Guardar(Departamento pDepartamento)
        {
            return DepartamentoDAL.Guardar(pDepartamento);
        }
        public static int Modificar(Departamento pDepartamento)
        {
            return DepartamentoDAL.Modificar(pDepartamento);
        }
        public static int Eliminar(Departamento pDepartamento)
        {
            return DepartamentoDAL.Eliminar(pDepartamento);
        }
        public static List<Departamento> ObtenerTodos()
        {
            return DepartamentoDAL.ObtenerTodos();
        }
        public static Departamento BuscarPorId(int pId)
        {
            return DepartamentoDAL.BuscarPorId(pId);
        }
        public static List<Departamento> ObtnerHabilitados()
        {
            return DepartamentoDAL.ObtenerHabilitados();
        }
        public static List<Departamento> Buscar(Departamento pDepartamento)
        {
            return DepartamentoDAL.Buscar(pDepartamento);
        }
    }
}
