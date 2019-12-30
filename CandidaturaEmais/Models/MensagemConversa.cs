using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaEmais.Models
{
    public class MensagemConversa
    {
        [Key]
        public int MensagemId { get; set; }

        [Display(Name="Mensagem")]
        public int Mensagem { get; set; }

        // pk
        [Display(Name="De")]
        public int UtilizadorId { get; set; }
        [Display(Name="Para")]
        public int utilizador2Id { get; set; }

        public Utilizador UtilizadorIniciante { get; set; }
        public Utilizador UtilizadorDestinatario { get; set; }
    }
}
