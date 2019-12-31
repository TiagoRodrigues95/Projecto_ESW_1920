using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaEmais.Models
{
    public class PFC
    {
        public int PFCId { get; set; }

        public DateTime Timestamp  { get; set; }

        public string PropostaUrl { get; set; }

        //FK - 

        [Display(Name = "Docente")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        public int DocenteId { get; set; }

        [Display(Name = "Aluno")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        public int AlunoId{ get; set; }
        //Prop Navegacional
        public Utilizador Aluno { get; set; }
        public Utilizador Docente { get; set; }
    }
}
