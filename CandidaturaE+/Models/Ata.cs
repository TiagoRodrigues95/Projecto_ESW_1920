using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaE_.Models
{
    public class Ata
    {
        public int AtaId { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        //FK
        public MarcacaoReuniao MarcacaoAta { get; set; }
        public Docente DocenteId { get; set; }
        public Aluno AlunoId { get; set; }
    }
}
