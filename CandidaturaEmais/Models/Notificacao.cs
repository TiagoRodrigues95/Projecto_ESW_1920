using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaEmais.Models
{
    public class Notificacao
    {
        [Key]
        public int NotificacaoId { get; set; }

        [Required]
        public string Para { get; set; }

        [Required]
        public string Assunto { get; set; }
        
        [Required]
        public string Mensagem { get; set; }
        
        public DateTime Timestamp { get; set; }
    }
}
