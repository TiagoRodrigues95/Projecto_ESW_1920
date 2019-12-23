using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaE_Library.Models
{
    public class Estagio
    {
        public int EstagioId { get; set; }

        public DateTime Timestamp { get; set; }

        public string PropostaUrl { get; set; }

        public string ProtocoloUrl { get; set; }

        //FK
        [ForeignKey("Empresa")]
        public int EmpresaId { get; set; }

        //Prop Navegacional
        public Empresa Empresa{ get; set; }

    }
}
