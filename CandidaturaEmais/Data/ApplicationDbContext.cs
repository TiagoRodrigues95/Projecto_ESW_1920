﻿using System;
using System.Collections.Generic;
using System.Text;
using CandidaturaEmais.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CandidaturaEmais.Data
{
    public class ApplicationDbContext : IdentityDbContext<Utilizador>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CandidaturaEmais.Models.Inquerito> Inquerito { get; set; }
        public DbSet<CandidaturaEmais.Models.InqueritoResposta> InqueritoResposta { get; set; }
        public DbSet<CandidaturaEmais.Models.PFC> PFC { get; set; }
    }
}
