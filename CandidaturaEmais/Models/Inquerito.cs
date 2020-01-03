using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaEmais.Models
{
    public class Inquerito
    {
        public int InqueritoId { get; set; }

        public DateTime Data { get; set; }

        public string AnoLetivo { get; set; }

        //public IFormFile PDF { get; set; }
        public string Url { get; set; }

        public Inquerito()
        {
            this.Data = DateTime.UtcNow;
        }
    }
}
