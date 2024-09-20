using HeerlijkeHerinneringen.Data.Context;
using HeerlijkeHerinneringen.Data.Models;
using HeerlijkeHerinneringen.Libraries.Interfaces;
using HeerlijkeHerinneringen.Libraries.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeerlijkeHerinneringen.Libraries.Repositories
{
    public class ReceptRepository : BasisRepo<Recept>
    {
       
        public ReceptRepository(HeerlijkeHerinneringenContext db) : base(db)
        {
        }

        public IQueryable<Recept> GetAllRecepies()
        {
            return _dbContext.Recepts; // Dit retourneert een queryable die je kunt uitbreiden met Include()
        }
        public Recept GetByName(string name)
        {
            return _dbContext.Recepts.Where(r => r.Titel == name).FirstOrDefault();
        }
    }
}
