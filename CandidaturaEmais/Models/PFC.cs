using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaEmais.Models
{
    public class PFC
    {
        /// <value>Primary Key - ID</value>
        public int PFCId { get; set; }

        /// <value>Data de publicação</value>
        public DateTime Timestamp  { get; set; }

        /// <value>Ficheiro do Projeto fim de curso pré-visualização</value>
        public string PropostaUrl { get; set; }

        //FK - 

        /// <value>ForeignKey - ID Utilizador Docente do PFC</value>
        [ForeignKey("DocenteFkpfc")]
        [Display(Name = "Docente")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        public string DocenteId { get; set; }

        /// <value>ForeignKey - ID Utilizador Aluno do PFC</value>
        [ForeignKey("AlunoFkpfc")]
        [Display(Name = "Aluno")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        public string AlunoId{ get; set; }

        //Prop Navegacional

        ///<value>Propriedade de Navegação - modelo de Utilizador atribuída ao PFC</value>
        public Utilizador Docente { get; set; }

        ///<value>Propriedade de Navegação - modelo de Utilizador atribuída ao PFC</value>
        public Utilizador Aluno { get; set; }

        public PFC()
        {
            this.Timestamp = DateTime.UtcNow;
        }
    }
}
