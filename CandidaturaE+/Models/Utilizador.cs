using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaE_.Models
{
    public class Utilizador : IdentityUser
    {

        public int UtilizadorId { get; set; }

        [PersonalData, Required(ErrorMessage = "O {0} é obrigatório")]
        public string CodigoIPS { get; set; }

        [PersonalData, Required(ErrorMessage = "O {0} é obrigatório")]
        public string Nome { get; set; }

        public int Telefone { get; set; }
    }
}
