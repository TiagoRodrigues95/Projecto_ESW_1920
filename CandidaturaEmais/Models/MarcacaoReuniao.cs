using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaEmais.Models
{
    /// <summary>
    /// Esta classe representa uma marcação de reunião.
    /// A marcação de uma reunião é constituída por incluir hora, 
    /// docente e aluno. Como a hora já possui ligação ao docente,
    /// não é necessário fazer uma ligação a esta classe.
    /// </summary>
    public class MarcacaoReuniao
    {
        [Key]
        public int MarcacaoReuniaoId { get; set; }

        //FK
        [Display(Name = "Hora")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        public int HoraId { get; set; }

        [Display(Name = "Aluno")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        public int AlunoId { get; set; }

        //Prop Navegacional
        public Hora Hora { get; set; }
        public Utilizador Aluno { get; set; }
    }
}
