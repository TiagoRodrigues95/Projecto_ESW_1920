using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaE_Library.Models
{
    public class Tutor
    {
        public int TutorId { get; set; }

        public string Nome { get; set; }

        public string Contacto { get; set; }

        //FK
        [ForeignKey("Empresa")]
        public int Empresa_Id { get; set; }

        //Prop Navegacional
        public Empresa Empresa { get; set; }
    }
}
