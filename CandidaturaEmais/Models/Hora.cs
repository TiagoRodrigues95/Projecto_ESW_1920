using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaEmais.Models
{
    public class Hora
    {
        // pk
        [Key]
        public int HoraId { get; set; }

        public DateTime HoraInicio { get; set; }
        public DateTime HoraFim { get; set; }

        // fk
        public int DocenteId { get; set; }
        
        // prop. navegação
        public Utilizador Docente { get; set; }
    }
}
