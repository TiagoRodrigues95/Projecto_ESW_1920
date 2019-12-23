using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaE_.Models
{
    public class Tutor
    {
        public int TutorId { get; set; }

        public string Nome { get; set; }

        public string Contacto { get; set; }
        
        //FK
        public int Empresa_Id { get; set; }

        //Prop Navegacional
        public Empresa Empresa { get; set; }
    }
}
