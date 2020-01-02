using System;
using System.ComponentModel.DataAnnotations;

namespace CandidaturaEmais.Models
{
    public class Hora
    {
        [Key]
        public int HoraId { get; set; }

        [Display(Name = "Data de Inicio")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy H:mm:ss zzz}")]
        public DateTime HoraInicio { get; set; }

        [Display(Name = "Data de Fim")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy H:mm:ss zzz}")]
        public DateTime HoraFim { get; set; }

        // fk
        [Display(Name = "Docente")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        public int UtilizadorId { get; set; }

        // prop. navegação
        public Utilizador Utilizador { get; set; }
    }
}
