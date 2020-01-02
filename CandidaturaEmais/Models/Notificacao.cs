using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaEmais.Models
{
    public class Notificacao
    {
        // pk
        public int NotificacaoId { get; set; }
        public string Para { get; set; }
        public string Assunto { get; set; }
        public string Mensagem { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
