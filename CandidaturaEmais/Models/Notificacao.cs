using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaEmais.Models
{
    /// <summary>
    /// Esta class representa a estrutura de uma notificação.
    /// A notificação é construída por endereço de email destinatário,
    /// assunto, mensagem e as horas a que foi criada.
    /// </summary>
    public class Notificacao
    {
        [Key]
        public int NotificacaoId { get; set; }

        [Display(Name = "Email Destino")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        [EmailAddress(ErrorMessage = "Endereço de email inválido")]
        public string Para { get; set; }

        [Display(Name = "Assunto")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "")]
        public string Assunto { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Mensagem")]
        public string Mensagem { get; set; }

        [Display(Name = "Data de Envio")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy H:mm:ss zzz}")]
        public DateTime Timestamp { get; set; }
        
    }
}
