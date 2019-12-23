using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaE_.Models
{
    public class MarcacaoDuvidas
    {
        public int MRId { get; set; }

        //FK
        public int HoraId { get; set; }

        public int AlunoId { get; set; }

        //Prop Navegacional
        public Aluno Aluno { get; set; }
    }
}
