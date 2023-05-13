using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMatasanos.EntidadesDeNegocio
{
    public class Paciente
    {
        public int IdPaciente { get; set; }
        public int NoSeguro { get; set; }
        public string NombresPaciente { get; set; }
        public string ApellidosPaciente { get; set; }
        public int TelefonoPaciente { get; set; }
        public string IdDepartamentoPaciente { get; set; }
        public string IdGeneroPaciente { get; set; }
    }
}
