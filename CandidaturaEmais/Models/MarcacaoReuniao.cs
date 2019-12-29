﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaEmais.Models
{
    public class MarcacaoReuniao
    {
        [Key]
        public int MarcacaoReuniaoId { get; set; }

        //FK
        public int HoraId { get; set; }

        public int AlunoId { get; set; }
        //Prop Navegacional
        public Utilizador Aluno { get; set; }
    }
}
