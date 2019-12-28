using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaEmais.Models
{
    public class PFC
    {
        public int PFCId { get; set; }

        public DateTime Timestamp  { get; set; }

        public string PropostaUrl { get; set; }

        //FK - 
        public int DocenteId { get; set; }

        public int AlunoId{ get; set; }
        //Prop Navegacional
        public Aluno Aluno { get; set; }
        public Docente Docente { get; set; }
    }
}
