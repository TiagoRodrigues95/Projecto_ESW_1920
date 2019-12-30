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
        public DbSet<CandidaturaEmais.Models.Notificacao> Notificacao { get; set; }
        public DbSet<CandidaturaEmais.Models.Empresa> Empresa { get; set; }
        public DbSet<CandidaturaEmais.Models.Inquerito> Inquerito { get; set; }
        public DbSet<CandidaturaEmais.Models.Inquerito_Resposta> Inquerito_Resposta { get; set; }
        public DbSet<CandidaturaEmais.Models.Hora> Hora { get; set; }

        public DbSet<CandidaturaEmais.Models.MarcacaoReuniao> MarcacaoReuniao { get; set; }

        public DbSet<CandidaturaEmais.Models.MensagemConversa> MensagemConversa { get; set; }

    }
}
