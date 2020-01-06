using System;
using System.ComponentModel.DataAnnotations;


namespace CandidaturaEmais.Models
{
    public class MarcacaoDuvidas
    {
        /// <value>Primary Key - ID</value>
        [Key]
        public int MarcacaoDuvidasId { get; set; }


        //FK
        /// <value>ForeignKey - ID hora que foi marcada para a Marcação de dúvidas</value>
        public int HoraId { get; set; }

        /// <value>ForeignKey - ID aluno que efetuo a marcação</value>
        [Display(Name = "Aluno")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        public string AlunoId { get; set; }

        ///<value>Propriedade de Navegação - modelo de Hora atribuída à MarcacaoDuvidas</value>
        public Hora Hora { get; set; }

        ///<value>Propriedade de Navegação - modelo de Utilizador atribuída à MarcacaoDuvidas</value>
        public Utilizador Aluno { get; set; }
    }
}
