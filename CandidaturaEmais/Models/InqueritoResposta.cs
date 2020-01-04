using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaEmais.Models
{
    /// <summary>
    /// Esta classe representa um InquéritoResposta.
    /// O Inquérito resposta é constituída por incluir data, ano letivo, url, . 
    /// </summary>
    public class InqueritoResposta
    {
        /// <value>Primary Key - ID</value>
        public int InqueritoRespostaId { get; set; }

        /// <value>Data de publicação</value>
        public DateTime Data { get; set; }

        /// <value>Ano letivo do inquérito</value>
        public string AnoLetivo { get; set; }

        /// <value>Ficheiro do Inquérito Resposta pré-visualização</value>
        public string Url { get; set; }

        //FK

        /// <value>ForeignKey - ID inquérito do inquérito com perguntas</value>
        public int InqueritoId { get; set; }

        /// <value>ForeignKey - ID Utilizador de quem respondeu ao inquérito</value>
        public string AlunoId { get; set; }

        //Prop Navegacional

        ///<value>Propriedade de Navegação - modelo de Inquérito atribuída ao Inquérito Respostas</value>
        public Inquerito Inquerito { get; set; }

        ///<value>Propriedade de Navegação - modelo de Utilizador atribuída ao Inquérito Respostas</value>
        public Utilizador Aluno { get; set; }

        public InqueritoResposta()
        {
            this.Data = DateTime.UtcNow;
        }
    }
}
