using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaEmais.Models
{
    public class Tutor
    {
        [Key]
        public int TutorId { get; set; }

        [Display(Name = "Nome da Empresa")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        [StringLength(255, MinimumLength = 4, ErrorMessage = "{0} não pode ser superior a {1} digitos ou inferior a {2}!")]
        public string Nome { get; set; }

        [Display(Name = "Número de Contato")]
        [Phone(ErrorMessage = "{0} inválido! Necessita de ter 9 digitos!")]
        public string Contacto { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        [EmailAddress(ErrorMessage = "{0} inválido!")]
        public string email { get; set; }

        //FK
        [Display(Name = "Empresa")]
        [Required(ErrorMessage = "{0} é obrigatório")]
        public int Empresa_Id { get; set; }

        //Prop Navegacional
        public Empresa Empresa { get; set; }
    }
}
