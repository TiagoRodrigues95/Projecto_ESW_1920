using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaEmais.Models
{
    public class Inquerito_Resposta
    {
        public int Id { get; set; }

        public DateTime Data { get; set; }

        public string AnoLetivo { get; set; }

        public string Url { get; set; }

        //FK
        public int InqueritoId { get; set; }

        public int UtilizadorId { get; set; }

        //Prop Navegacional
        public Inquerito Inquerito { get; set; }

        public Utilizador Utilizador { get; set; }
    }
}
