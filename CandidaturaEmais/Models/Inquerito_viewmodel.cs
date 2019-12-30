using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaEmais.Models
{
    public class Inquerito_viewmodel
    {
        public DateTime Data { get; set; }

        public string AnoLetivo { get; set; }

        public IFormFile Url { get; set; }

        public Inquerito_viewmodel()
        {
            this.Data = DateTime.UtcNow;
        }
    }
}
