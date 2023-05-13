using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMatasanos.EntidadesDeNegocio
{
    public class PersonalHospital
    {
        public int IdPersonalHospital { get; set; }
        public int NoLicencia { get; set; } 
        public string IdTLicenciaPH { get; set; }   
        public int IdEspecialidadPH { get; set; }
        public string NombresPH { get; set; }   
        public string ApellidosPH { get; set; } 
        public int TelefonoPH { get; set; } 
        public string DireccionCorreo { get; set; } 

    }
}
