﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaEmais.Models
{
    public class MarcacaoDuvidas
    {
        public int MRId { get; set; }

        //FK
        public int HoraId { get; set; }

        public int UtilizadorId { get; set; }

        //Prop Navegacional
        public Aluno Aluno { get; set; }
    }
}
