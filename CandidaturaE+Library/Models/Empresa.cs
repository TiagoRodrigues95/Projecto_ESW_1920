using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaE_Library.Models
{
    public class Empresa
    {
        // Chave primária
        public int EmpresaId { get; set; }

        [Required(ErrorMessage = "A {0} é obrigatória")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A {0} é obrigatória")]
        public string Representante { get; set; }

        [Required(ErrorMessage = "A {0} é obrigatória")]
        public string Contacto { get; set; }

        // Propriedade Navegacional
        public List<Tutor> Tutores { get; set; }
    }
}
