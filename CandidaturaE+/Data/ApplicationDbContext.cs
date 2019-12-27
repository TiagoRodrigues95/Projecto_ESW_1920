using System;
using System.Collections.Generic;
using System.Text;
using CandidaturaE_.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CandidaturaE_.Data
{
    public class ApplicationDbContext : IdentityDbContext<Utilizador>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CandidaturaE_.Models.Ata> Ata { get; set; }
        public DbSet<CandidaturaE_.Models.MarcacaoDuvidas> MarcacaoDuvidas { get; set; }
        public DbSet<CandidaturaE_.Models.Inquerito_Resposta> Inquerito_Resposta { get; set; }
        public DbSet<CandidaturaE_.Models.Inquerito> Inquerito { get; set; }
        //public DbSet<CandidaturaE_.Models.Utilizador> Utilizador { get; set; }
    }
}
