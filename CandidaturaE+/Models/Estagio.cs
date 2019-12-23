using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaE_.Models
{
    public class Estagio
    {
        public int EstagioId { get; set; }

        public DateTime Timestamp { get; set; }

        public string PropostaUrl { get; set; }

        public string ProtocoloUrl { get; set; }

        //FK
        public int EmpresaId { get; set; }

        //Prop Navegacional
        public Empresa Empresa{ get; set; }
    }
}
