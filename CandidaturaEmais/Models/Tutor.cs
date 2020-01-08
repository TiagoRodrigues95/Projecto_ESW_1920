using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaEmais.Models
{
    public class Tutor
    {
        public int TutorId { get; set; }

        public string Nome { get; set; }

        public string Contacto { get; set; }
        
        //FK
        public int EmpresaId { get; set; }

        //Prop Navegacional
        public Empresa Empresa { get; set; }
    }
}
