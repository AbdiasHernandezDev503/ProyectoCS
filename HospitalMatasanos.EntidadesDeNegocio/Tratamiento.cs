using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMatasanos.EntidadesDeNegocio
{
    public class Tratamiento
    {
        public int IdTratamiento { get; set; }  
        public string NombreTratamiento { get; set; }
        public string Dosis { get; set; }
        public int DuracionSemanas { get; set; }    
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public int IdEffectSecnundTto { get; set; } 
        public int IdPerHospTto { get; set; }
    }
}
