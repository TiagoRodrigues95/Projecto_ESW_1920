using System.ComponentModel.DataAnnotations;

namespace CandidaturaEmais.Models
{
    public class Tutor
    {
        [Key]
        public int TutorId { get; set; }

        [Required]
         public string Nome { get; set; }

        public string Contacto { get; set; }

        [Required]
        public string Email { get; set; }

        // fk
        [Required]
        public int Empresa_Id { get; set; }

        // prop Navegacional
        public Empresa Empresa { get; set; }
    }
}
