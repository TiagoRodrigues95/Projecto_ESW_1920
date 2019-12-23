using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaE_Library.Models
{
    public class Ata
    {
        public int AtaId { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        //FK
        [ForeignKey("MarcacaoReuniao")]
        public MarcacaoReuniao MarcacaoAta { get; set; }

        [ForeignKey("Docente")]
        public int DocenteId { get; set; }

        [ForeignKey("Aluno")]
        public int AlunoId { get; set; }

        //Prop Navegacional
        public Docente Docente { get; set; }

        public Aluno Aluno { get; set; }
    }
}
