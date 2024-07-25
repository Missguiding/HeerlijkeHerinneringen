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
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<MenuGang> MenuGangs { get; set; }
        public DbSet<Recept> Recepts { get; set; }        
        public DbSet<Temperatuur> Temperatuurs { get; set; }
        public DbSet<TypeGerecht> TypeGerechts { get; set; }
    }
}
