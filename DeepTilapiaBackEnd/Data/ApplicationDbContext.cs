using System;
using System.Collections.Generic;
using System.Text;
using DeepTilapiaBackEnd.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DeepTilapiaBackEnd.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SuplidorPeces> SuplidorAlevines { get; set; }
        public DbSet<GrupoTilapia> Grupos { get; set; }
        public DbSet<Jaula> Jaulas { get; set; }
        public DbSet<JaulaGrupo> JaulaGrupos { get; set; }
        public DbSet<JaulaGrupoAgua> JaulasGrupoAguas { get; set; }
        public DbSet<JaulaGrupoAlimento> JaulasGrupoAlimentos { get; set; }
        public DbSet<JaulaGrupoMuertes> JaulasGrupoMuertes { get; set; }
        public DbSet<JaulaGrupoPeso> JaulasGrupoPeso { get; set; }
        public DbSet<Alimento> Alimentos { get; set; }
        public DbSet<AlimentoSuplidor> AlimentosSuplidores { get; set; }
        public DbSet<SuplidorAlimento> SuplidorAlimentos { get; set; }
    }
}
