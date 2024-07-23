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
        public DbSet<Ingrediënt> Ingrediënts { get; set; }
        public DbSet<MenuGang> MenuGangs { get; set; }
        public DbSet<Recept> Recepts { get; set; }
        public DbSet<ReceptIngrediënt> ReceptIngrediënts { get; set; }
        public DbSet<Temperatuur> Temperatuurs { get; set; }
        public DbSet<TypeGerecht> TypeGerechts { get; set; }

    }
}
