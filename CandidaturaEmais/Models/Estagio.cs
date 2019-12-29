using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaEmais.Models
{
    public class Estagio
    {
        [Key]
        public int EstagioId { get; set; }

        //FK
        public int Empresa_Id { get; set; }

        [Display(Name = "Proposta")]
        [Required(ErrorMessage = "{0} é obrigatório")]
        [StringLength(255, MinimumLength = 4, ErrorMessage = "{0} não pode ser superior a {1} digitos ou inferior a {2}")]
        public string PropostaUrl { get; set; }

        [Display(Name = "Protocolo de Empresa")]
        [Required(ErrorMessage = "{0} é obrigatório")]
        [StringLength(255, MinimumLength = 4, ErrorMessage = "{0} não pode ser superior a {1} digitos ou inferior a {2}")]
        public string ProtocoloUrl { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy H:mm:ss zzz}")]
        public DateTime Timestamp { get; set; }

        //Prop Navegacional
        public Empresa Empresa{ get; set; }
    }
}
