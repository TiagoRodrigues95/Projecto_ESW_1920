using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaEmais.Models
{
    public class Empresa
    {
        [Key]
        public int EmpresaId { get; set; }

        [Display(Name="Nome da Empresa")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(255, MinimumLength = 4, ErrorMessage = "{0} não pode ser superior a {1} digitos ou inferior a {2}")]
        public string Nome { get; set; }

        [Display(Name ="Representatnte")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(255, MinimumLength = 4, ErrorMessage = "{0} não pode ser superior a {1} digitos ou inferior a {2}")]
        public string Representante { get; set; }

        [Display(Name ="Número de Contato")]
        [Phone]
        public string Contacto { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "{0} is required")]
        [EmailAddress]
        public string email { get; set; }

    }
}
