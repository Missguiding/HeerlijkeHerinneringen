using HeerlijkeHerinneringen.Data.Context;
using HeerlijkeHerinneringen.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeerlijkeHerinneringen.Libraries.Repositories
{
    public class ChefRepository : BasisRepo<Chef>
    {

        public ChefRepository(HeerlijkeHerinneringenContext db) : base(db)
        {
        }

        public Chef GetByName(string name)
        {
            return _dbContext.Chefs.Where(r => r.ChefFamilieNaam == name).FirstOrDefault();
        }
    }
}
