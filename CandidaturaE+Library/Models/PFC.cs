using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaE_Library.Models
{
    public class PFC
    {
        public int PFCId { get; set; }

        public DateTime Timestamp  { get; set; }

        public string PropostaUrl { get; set; }

        //FK
        [ForeignKey("Docente")]
        public int DocenteId { get; set; }

        [ForeignKey("Aluno")]
        public int AlunoId{ get; set; }

        //Prop Navegacional
        public Aluno Aluno { get; set; }
        public Docente Docente { get; set; }
    }
}
