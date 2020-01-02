using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaEmais.Models
{
    public class Utilizador : IdentityUser
    {

        [PersonalData, Required(ErrorMessage = "O {0} é obrigatório")]
        public string CodigoIPS { get; set; }

        [PersonalData, Required(ErrorMessage = "O {0} é obrigatório")]
        public string Nome { get; set; }

        public int Telefone { get; set; }

        // propriedade navegacional hora
        public List<Hora> Horas { get; set; }

    }
}
