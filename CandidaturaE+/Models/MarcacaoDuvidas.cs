﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaE_.Models
{
    public class MarcacaoDuvidas
    {
        [Key]
        public int MRId { get; set; }

        //FK
        public int HoraId { get; set; }

        public int UtilizadorId { get; set; }

        //Prop Navegacional
        public Utilizador Utilizador { get; set; }
    }
}
