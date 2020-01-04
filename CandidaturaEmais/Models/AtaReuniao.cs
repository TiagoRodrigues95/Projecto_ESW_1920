using System;
using System.ComponentModel.DataAnnotations;

namespace CandidaturaEmais.Models
{
    public class AtaReuniao
    {
        [Key]
        public int AtaId { get; set; }

        [Display(Name = "Data-Hora")]
        [Required(ErrorMessage = "{0} é obrigatório!")]

        public DateTime Timestamp { get; set; }

        [Display(Name="Título")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "{0} não pode ser superior a {1} digitos ou inferior a {2}!")]
        public string Titulo { get; set; }

        [Display(Name="Descrição")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        public string Descricao { get; set; }
    }
}
