using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaEmais.Models
{
    public class Utilizador : IdentityUser
    {

        public int UtilizadorId { get; set; }

        [PersonalData, Required(ErrorMessage = "O {0} é obrigatório")]
        public string CodigoIPS { get; set; }

        [PersonalData, Required(ErrorMessage = "O {0} é obrigatório")]
        public string Nome { get; set; }

        public int Telefone { get; set; }

        // refecencia ao modelo Mensagem

        [InverseProperty("UtilizadorIniciante")]
        public ICollection<Mensagem> UtilizadorIniciante { get; set; }

        [InverseProperty("UtilizadorDestinatario")]
        public ICollection<Mensagem> UtilizadorDestinatario { get; set; }
    }
}
