using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaE_.Models
{
    public class Empresa
    {
        public int EmpresaId { get; set; }

        public string Nome { get; set; }

        public string Representante { get; set; }

        public string Contacto { get; set; }

        //Lista
        public List<Tutor> Tutores { get; set; }
    }
}
