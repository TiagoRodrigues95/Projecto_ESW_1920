using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaEmais.Models
{
    public class MarcacaoDuvidas
    {
<<<<<<< Updated upstream
        public int MDId { get; set; }
=======
        [Key]
        public int MD_Id { get; set; }
>>>>>>> Stashed changes

        //FK
        public int HoraId { get; set; }

        [Display(Name = "Aluno")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        public int AlunoId { get; set; }

        //Prop Navegacional
<<<<<<< Updated upstream
=======
        public Hora Hora { get; set; }

>>>>>>> Stashed changes
        public Utilizador Aluno { get; set; }
    }
}
