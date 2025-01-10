using HeerlijkeHerinneringen.Data.Context;
using HeerlijkeHerinneringen.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeerlijkeHerinneringen.Libraries.Repositories
{
    public class BenodigdheidRepo:BasisRepo<Benodigdheid>
    {
        public BenodigdheidRepo(HeerlijkeHerinneringenContext db) : base(db)
        {
        }

        public Benodigdheid GetByName(string name)
        {
            return _dbContext.Benodigdheids.Where(r => r.BenodigdheidNaam == name).FirstOrDefault();
        }
    }
}
