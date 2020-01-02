using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CandidaturaEmais.Models
{
    /// <summary>
    /// Esta classe representa a estrutura de dados de uma empresa.
    /// A empresa é identificada pelo seu nome, o nome do seu representante,
    /// contato telefónico e endereço de email.
    /// </summary>
    public class Empresa
    {
        /// <value>ID</value>
        [Key]
        public int EmpresaId { get; set; }

        /// <value>Nome da empresa</value>
        [Display(Name = "Nome da Empresa")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        [StringLength(255, MinimumLength = 4, ErrorMessage = "{0} não pode ser superior a {1} digitos ou inferior a {2}!")]
        public string Nome { get; set; }

        /// <value>Pessoa que representa a empresa ou que contactou com o IPS/Docente</value>
        [Display(Name = "Representante")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        [StringLength(255, MinimumLength = 4, ErrorMessage = "{0} não pode ser superior a {1} digitos ou inferior a {2}!")]
        public string Representante { get; set; }

        /// <value>Contato telefónico</value>
        [Display(Name = "Número de Contato")]
        [StringLength(9, ErrorMessage = "{0} inválido! Necessita de ter {1} digitos!")]
        public string Contacto { get; set; }

        /// <value>Endereço de email</value>
        [Display(Name = "Email")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        [EmailAddress(ErrorMessage = "{0} inválido!")]
        public string email { get; set; }

        /// <value>Propriedade navegacional (one-to-many) - Tutores</value>
        public List<Tutor> Tutores { get; set; }
    }
}
