using System;
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

        public DbSet<Notificacao> Notificacao { get; set; }

        public DbSet<Hora> Hora { get; set; }

        public DbSet<Empresa> Empresa { get; set; }

        public DbSet<Tutor> Tutor { get; set; }

        public DbSet<CandidaturaEmais.Models.AtaReuniao> AtaReuniao { get; set; }

    }
}
