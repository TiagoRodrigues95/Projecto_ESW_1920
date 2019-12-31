using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaEmais.Models
{
    public class MarcacaoDuvidas
    {
        public int MDId { get; set; }

        //FK
        public int HoraId { get; set; }

        [Display(Name = "Aluno")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        public int AlunoId { get; set; }

        //Prop Navegacional
        public Utilizador Aluno { get; set; }
    }
}
