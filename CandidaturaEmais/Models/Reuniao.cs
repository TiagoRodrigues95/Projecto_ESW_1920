using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaEmais.Models
{
    public class Reuniao
    {
        [Key]
        public int MarcaReuniaoId { get; set; }

        public int HoraId { get; set; }


        public int AtaId { get; set; }

        public string UtilizadorIdParticipante { get; set; }

        public string UtilizadorIdConvocado { get; set; }

        public Hora Hora { get; set; }

        public Utilizador UtilizadorParticipante { get; set; }

        public Utilizador UtilizadorConvocado { get; set; }
    }
}
