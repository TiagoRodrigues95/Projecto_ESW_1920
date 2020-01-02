﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CandidaturaEmais.Models
{
    /// <summary>
    /// Esta class representa a estrutura de uma notificação.
    /// A notificação é construída por endereço de email destinatário,
    /// assunto, mensagem e as horas a que foi criada.
    /// </summary>
    public class Notificacao
    {
        /// <value>Primary Key - ID</value>
        [Key]
        public int NotificacaoId { get; set; }

        /// <value>Endereço de email destino (para que endereço de email enviar a notificação)</value>
        [Display(Name = "Email Destino")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        [EmailAddress(ErrorMessage = "{0} inválido!")]
        public string Para { get; set; }

        /// <value>Assunto da notificação</value>
        [Display(Name = "Assunto")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "{0} não pode ser superior a {1} digitos ou inferior a {2}!")]
        public string Assunto { get; set; }

        /// <value>Mensagem</value>
        [Display(Name = "Mensagem")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "{0} não pode ser superior a {1} digitos ou inferior a {2}!")]
        public string Mensagem { get; set; }

        /// <value>Data de criação da notificação</value>
        [Display(Name = "Data de Envio")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy H:mm:ss zzz}")]
        public DateTime Timestamp { get; set; }
    }
}
