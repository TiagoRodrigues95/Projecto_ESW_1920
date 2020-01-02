using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CandidaturaEmais.Models
{
    /// <summary>
    /// Esta classe representa a estrutura de uma hora utilizada para 
    /// definir a disponibilidade de um utilizador docente para realizar 
    /// marcações (e.g. marcar reuniões, marcar dúvidas).
    /// A hora é constituída por hora de inicio e hora de fim, e por norma
    /// tem como intervalo de 1h entre a hora de inicio e a hora de fim.
    /// </summary>
    public class Hora
    {
        /// <value>ID</value>
        [Key]
        public int HoraId { get; set; }

        /// <value>Hora que indica a disponibilidade de marcação</value>
        [Display(Name = "Data de Inicio")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy H:mm:ss}")]
        public DateTime HoraInicio { get; set; }

        /// <value>Hora que termina a disponibilidade de marcação</value>
        [Display(Name = "Data de Fim")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy H:mm:ss}")]
        public DateTime HoraFim { get; set; }

        /// <value>ForeignKey - ID Utilizador a que pertence a hora</value>
        [ForeignKey("UtilizadorFk")]
        [Display(Name = "Docente")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        public string UtilizadorId { get; set; }

        /// <value>Propriedade de Nvaegação - modelo do Utilizador a que pertence a hora</value>
        public Utilizador Utilizador { get; set; }
    }
}
