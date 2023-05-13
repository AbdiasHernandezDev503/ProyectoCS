using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMatasanos.EntidadesDeNegocio
{
    public class Consulta
    {
        public int IdConsulta { get; set; } 
        public int IdSintoma {  get; set; }
        public int IdPersonalHospitalCns { get; set; }
        public int IdPacienteCns { get; set; }

    }
}
