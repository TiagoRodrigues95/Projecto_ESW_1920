using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaEmais.Models
{
    /// <summary>
    /// Esta classe representa a estrutura de dados de uma empresa.
    /// A empresa é identificada pelo seu nome, o nome do seu representante,
    /// contato telefónico e endereço de email.
    /// </summary>
    public class Empresa
    {
        [Key]
        public int EmpresaId { get; set; }

        [Display(Name="Nome da Empresa")]
        [Required(ErrorMessage = "{0} é obrigatório")]
        [StringLength(255, MinimumLength = 4, ErrorMessage = "{0} não pode ser superior a {1} digitos ou inferior a {2}")]
        public string Nome { get; set; }

        [Display(Name ="Representante")]
        [Required(ErrorMessage = "{0} é obrigatório")]
        [StringLength(255, MinimumLength = 4, ErrorMessage = "{0} não pode ser superior a {1} digitos ou inferior a {2}")]
        public string Representante { get; set; }

        [Display(Name ="Número de Contato")]
        [Phone]
        public string Contacto { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "{0} é obrigatório")]
        [EmailAddress]
        public string email { get; set; }

    }
}
