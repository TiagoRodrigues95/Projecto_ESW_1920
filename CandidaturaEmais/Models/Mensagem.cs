using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaEmais.Models
{
    public class Mensagem
    {
        [Key]
        public int MensagemId { get; set; }

        public int UtilizadorId { get; set; }
        public int utilizador2Id { get; set; }

        public Utilizador UtilizadorIniciante { get; set; }
        public Utilizador UtilizadorDestinatario { get; set; }
    }
}
