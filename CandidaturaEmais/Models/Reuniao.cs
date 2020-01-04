using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaEmais.Models
{
    /// <summary>
    /// Esta classe representa uma reunião.
    /// A reunião é constituída por incluir hora, ata, utilizador que marcou 
    /// reunião e utilizador participante. Por norma a ata é adicionada só
    /// quando passar da hora da reunião.
    /// </summary>
    public class Reuniao
    {
        /// <value>Primary Key - ID</value>
        [Key]
        public int MarcaReuniaoId { get; set; }

        /// <value>ForeignKey - ID Hora atribuída à reunião</value>
        [ForeignKey("HoraFk")]
        [Display(Name = "Hora")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        public int HoraId { get; set; }

        [ForeignKey("AtaFk")]
        [Display(Name = "Ata")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        public int AtaId { get; set; }

        /// <value>ForeignKey - ID Utilizador de quem marcou a reunião</value>
        [ForeignKey("UtilizadorFk")]
        [Display(Name = "Participante")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        public string UtilizadorIdParticipante { get; set; }

        /// <value>ForeignKey - ID Utilizador de quem marcou a reunião</value>
        [ForeignKey("Utilizador2Fk")]
        [Display(Name = "Convocado")]
        [Required(ErrorMessage = "{0} é obrigatório!")]
        public string UtilizadorIdConvocado { get; set; }

        ///<value>Propriedade de Navegação - modelo da Ata atribuída à reunão</value>
        public AtaReuniao Ata { get; set; }

        /// <value>Propriedade de Navegação - modelo da Hora atribuída à reunião</value>
        public Hora Hora { get; set; }

        /// <value>Propriedade de Navegação - modelo do Utilizador de quem marcou a reunião</value>
        public Utilizador UtilizadorParticipante { get; set; }

        /// <value>Propriedade de Navegação - modelo do Utilizador de quem marcou a reunião</value>
        public Utilizador UtilizadorConvocado { get; set; }
    }
}
