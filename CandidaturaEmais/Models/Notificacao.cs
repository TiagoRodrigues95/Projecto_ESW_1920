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

        [Display(Name = "Email Destino")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        [EmailAddress(ErrorMessage = "{0} inválido!")]
        public string Para { get; set; }

        [Display(Name = "Assunto")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "{0} não pode ser superior a {1} digitos ou inferior a {2}!")]
        public string Assunto { get; set; }

        [Display(Name = "Mensagem")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "{0} não pode ser superior a {1} digitos ou inferior a {2}!")]
        public string Mensagem { get; set; }

        [Display(Name = "Data de Envio")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy H:mm:ss zzz}")]
        public DateTime Timestamp { get; set; }
    }
}
