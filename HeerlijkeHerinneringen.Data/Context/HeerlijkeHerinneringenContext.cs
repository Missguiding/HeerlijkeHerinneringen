using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeerlijkeHerinneringen.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HeerlijkeHerinneringen.Data.Context
{
    public class HeerlijkeHerinneringenContext : DbContext
    {
        public HeerlijkeHerinneringenContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Afbeelding> Afbeeldings { get; set; }
        public DbSet<Benodigdheid> Benodigdheids { get; set; }
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<MenuGang> MenuGangs { get; set; }
        public DbSet<Recept> Recepts { get; set; }
        public DbSet<ReceptBenodigdheid> ReceptBenodigdheids { get; set; }
        public DbSet<ReceptIngredient> ReceptIngredients { get; set; }
        public DbSet<ReceptStap> ReceptStaps { get; set; }
        public DbSet<Temperatuur> Temperatuurs { get; set; }
        public DbSet<TypeGerecht> TypeGerechts { get; set; }
        



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReceptIngredient>()
                .HasKey(ri => new { ri.ReceptId, ri.IngredientId });

            modelBuilder.Entity<ReceptIngredient>()
                .HasOne(ri => ri.Recept)
                .WithMany(r => r.ReceptIngredients)
                .HasForeignKey(ri => ri.ReceptId);

            modelBuilder.Entity<ReceptIngredient>()
                .HasOne(ri => ri.Ingredient)
                .WithMany(i => i.ReceptIngredients)
                .HasForeignKey(ri => ri.IngredientId);

            modelBuilder.Entity<ReceptBenodigdheid>()
               .HasKey(ri => new { ri.ReceptId, ri.BenodigdheidId });

            modelBuilder.Entity<ReceptBenodigdheid>()
                .HasOne(ri => ri.Recept)
                .WithMany(r => r.ReceptBenodigdheids)
                .HasForeignKey(ri => ri.ReceptId);

            modelBuilder.Entity<ReceptBenodigdheid>()
                .HasOne(ri => ri.Benodigdheid)
                .WithMany(i => i.ReceptBenodigdheids)
                .HasForeignKey(ri => ri.BenodigdheidId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
