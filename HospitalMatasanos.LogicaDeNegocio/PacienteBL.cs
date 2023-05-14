using HospitalMatasanos.AccesoADatos;
using HospitalMatasanos.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMatasanos.LogicaDeNegocio
{
    public class PacienteBL
    {
        public static int Guardar(Paciente pPaciente)
        {
            return PacienteDAL.Guardar(pPaciente);
        }
        public static int Modificar(Paciente pPaciente)
        {
            return PacienteDAL.Modificar(pPaciente);
        }
        public static int Eliminar(Paciente pPaciente)
        {
            return PacienteDAL.Eliminar(pPaciente);
        }
    }
}
