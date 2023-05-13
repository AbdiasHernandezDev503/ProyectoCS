using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMatasanos.EntidadesDeNegocio
{
    public class Diagnostico
    {
        public int IdDiagnostico { get; set; }  
        public int IdConsultaDg { get; set; }
        public string Resultado { get; set; }
        public int IdTratamientoDg { get; set; }
    }
}
