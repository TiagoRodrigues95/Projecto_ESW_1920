using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaE_Library.Models
{
    public class Utilizador : IdentityUser
    {

        public int UtilizadorId { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório")]
        [StringLength(9, ErrorMessage = "The {0} must be at least {2} and at max {1} digits long.", MinimumLength = 4)]
        [Display(Name = "Número IPS")]//Placeholder
        public string CodigoIPS { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório")]
        public string Nome { get; set; }

        public int Telefone { get; set; }
    }
}
