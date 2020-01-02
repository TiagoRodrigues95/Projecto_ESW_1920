using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CandidaturaEmais.Models
{
    /// <summary>
    /// Esta classe representa a estrutura de dados de um tutor.
    /// O tutor é identificado pelo seu nome, contato telefónico, 
    /// endereço de email e empresa a que pertence.
    /// </summary>
    public class Tutor
    {
        /// <value>Primary Key - ID</value>
        [Key]
        public int TutorId { get; set; }

        /// <value>Nome</value>
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        [StringLength(255, MinimumLength = 4, ErrorMessage = "{0} não pode ser superior a {1} digitos ou inferior a {2}!")]

        public string Nome { get; set; }

        /// <value>Contato telefónico</value>
        [Display(Name = "Número de Contato")]
        [StringLength(9, ErrorMessage = "{0} inválido! Necessita de ter {1} digitos!")]
        public string Contacto { get; set; }

        /// <value>Endereço de email</value>
        [Display(Name = "Email")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        [EmailAddress(ErrorMessage = "{0} inválido!")]
        public string Email { get; set; }

        /// <value>Foreign Key - Empresa onde trabalha</value>
        [ForeignKey("EmpresaFk")]
        [Display(Name = "Empresa")]
        [Required(ErrorMessage = "{0} é obrigatório")]
        public int EmpresaId { get; set; }

        // prop Navegacional
        public Empresa Empresa { get; set; }
    }
}
