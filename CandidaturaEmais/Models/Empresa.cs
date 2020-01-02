using System.ComponentModel.DataAnnotations;

namespace CandidaturaEmais.Models
{
    public class Empresa
    {
        [Key]
        public int EmpresaId { get; set; }

        [Display(Name = "Nome da Empresa")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        [StringLength(255, MinimumLength = 4, ErrorMessage = "{0} não pode ser superior a {1} digitos ou inferior a {2}!")]
        public string Nome { get; set; }

        [Display(Name = "Representante")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        [StringLength(255, MinimumLength = 4, ErrorMessage = "{0} não pode ser superior a {1} digitos ou inferior a {2}!")]
        public string Representante { get; set; }

        [Display(Name = "Número de Contato")]
        [Phone(ErrorMessage = "{0} inválido! Necessita de ter 9 digitos!")]
        public string Contacto { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        [EmailAddress(ErrorMessage = "{0} inválido!")]
        public string email { get; set; }
    }
}
