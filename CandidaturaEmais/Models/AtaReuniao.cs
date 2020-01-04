using System;

namespace CandidaturaEmais.Models
{
    public class AtaReuniao
    {
        public int AtaId { get; set; }

        public DateTime Timestamp { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }
    }
}
