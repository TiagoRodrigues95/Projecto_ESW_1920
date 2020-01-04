using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaEmais.Models
{
    /// <summary>
    /// Esta classe representa um Inquérito.
    /// O Inquérito é constituída por incluir data, ano letivo e url. 
    /// </summary>
    public class Inquerito
    {
        /// <value>Primary Key - ID</value>
        public int InqueritoId { get; set; }

        /// <value>Data de publicação</value>
        public DateTime Data { get; set; }

        /// <value>Ano letivo do inquérito</value>
        public string AnoLetivo { get; set; }

        /// <value>Ficheiro do Inquérito pré-visualização</value>
        public string Url { get; set; }

        public Inquerito()
        {
            this.Data = DateTime.UtcNow;
        }
    }
}
