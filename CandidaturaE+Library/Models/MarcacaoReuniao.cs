using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaE_Library.Models
{
    public class MarcacaoReuniao
    {
        public int MRId { get; set; }

        //FK
        public int HoraId { get; set; }

        [ForeignKey("Aluno")]
        public int AlunoId { get; set; }
        //Prop Navegacional
        public Aluno Aluno { get; set; }
    }
}
