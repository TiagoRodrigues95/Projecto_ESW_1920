using System;
using System.ComponentModel.DataAnnotations;

namespace CandidaturaEmais.Models
{
    /// <summary>
    /// Esta classe representa uma ata de reunião.
    /// A ata de reunião é constituída por título, descrição, data e hora.
    /// </summary>
    public class AtaReuniao
    {
        /// <value>Primary Key - ID</value>
        [Key]
        public int AtaId { get; set; }

        /// <value>Primary Key - ID</value>
        [Display(Name = "Data-Hora")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        [DataType(DataType.DateTime)]
        public DateTime Timestamp { get; set; }

        /// <value>Título da ata</value>
        [Display(Name="Título")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "{0} não pode ser superior a {1} digitos ou inferior a {2}!")]
        public string Titulo { get; set; }

        /// <value>Local onde se escreve toda a ocrrência durante reunião</value>
        [Display(Name="Descrição")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        public string Descricao { get; set; }
    }
}
