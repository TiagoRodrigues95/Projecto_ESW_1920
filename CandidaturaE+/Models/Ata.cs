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
        public int MR_Id { get; set; }

        public int UtilizadorId { get; set; }

        //Prop Navegacional
        public MarcacaoReuniao MarcacaoReuniao { get; set; }

        public Utilizador Utilizador { get; set; }
    }
}
