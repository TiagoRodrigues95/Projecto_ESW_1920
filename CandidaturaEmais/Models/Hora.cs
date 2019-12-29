using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaEmais.Models
{
    /// <summary>
    /// Esta classe representa a estrutura de uma hora utilizada para 
    /// marcações (e.g. marcar reuniões).
    /// A hora é constituída por hora de inicio e hora de fim, e por norma
    /// tem como intervalo de 1h entre a hora de inicio e a hora de fim.
    /// </summary>
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
