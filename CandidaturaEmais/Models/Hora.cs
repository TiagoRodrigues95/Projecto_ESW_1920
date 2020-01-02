using System;
using System.ComponentModel.DataAnnotations;

namespace CandidaturaEmais.Models
{
    public class Hora
    {
        [Key]
        public int HoraId { get; set; }

        [Required]
        public DateTime HoraInicio { get; set; }

        [Required]
        public DateTime HoraFim { get; set; }

        // fk
        [Required]
        public int UtilizadorId { get; set; }

        // prop. navegação
        public Utilizador Docente { get; set; }
    }
}
