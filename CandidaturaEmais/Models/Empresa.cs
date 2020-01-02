using System.ComponentModel.DataAnnotations;

namespace CandidaturaEmais.Models
{
    public class Empresa
    {
        [Key]
        public int EmpresaId { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Representante { get; set; }

        [Phone]
        public string Contacto { get; set; }

        [Required]
        public string email { get; set; }
    }
}
