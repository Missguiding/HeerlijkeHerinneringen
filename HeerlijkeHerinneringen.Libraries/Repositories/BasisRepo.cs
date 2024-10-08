﻿using HeerlijkeHerinneringen.Data.Context;
using HeerlijkeHerinneringen.Data.Models;
using HeerlijkeHerinneringen.Libraries.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace HeerlijkeHerinneringen.Libraries.Repositories
{
    public class BasisRepo<T> : IRepository<T> where T : class
    {
        protected HeerlijkeHerinneringenContext _dbContext;

        public BasisRepo(HeerlijkeHerinneringenContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<T> GetAll()
        {
            //De methode controleert eerst of het generieke type T overeenkomt met het type Recept.
            if (typeof(T) == typeof(Recept))
                //Als T van het type Recept is,
                //wordt een query opgebouwd die alle relevante gerelateerde gegevens
                //(Chef, TypeGerecht, MenuGang, Temperatuur, ReceptIngredients, ReceptStaps, ReceptBenodigdheids)
                //laadt met behulp van Include en ThenInclude.
            {
                return _dbContext.Set<T>()
                          .Include(r => ((Recept)(object)r).Chef)
                          .Include(r => ((Recept)(object)r).TypeGerecht)
                          .Include(r => ((Recept)(object)r).MenuGang)
                          .Include(r => ((Recept)(object)r).Temperatuur)
                          .Include(r => ((Recept)(object)r).ReceptIngredients)
                              .ThenInclude(rb => rb.Ingredient)
                          .Include(r => ((Recept)(object)r).ReceptStaps)
                          .Include(r => ((Recept)(object)r).ReceptBenodigdheids)
                              .ThenInclude(rb => rb.Benodigdheid)
                          .ToList();
            }
            //Als T niet van het type Recept is, wordt een algemene query uitgevoerd.
            //Het resultaat wordt ook omgezet naar een lijst en geretourneerd.
            return _dbContext.Set<T>().ToList();            
        }

        public T GetById(int id)
        {
            return _dbContext.Find<T>(id); // Vind een entity v/h type T met het geven ID in de context.
        }

        public void Add(T entity)
        {
            _dbContext.Add(entity); // Voeg entity toe aan de Context.           
            _dbContext.SaveChanges(); // Sla de veranderingen op in de database.
        }

        public void Update(T entity)
        {
            

            _dbContext.Update(entity); // Update de entity in de context.
            _dbContext.SaveChanges(); //  Sla wijzigingen op in de database.
        }

        public void Delete(int id)
        {
            T item = GetById(id); // Ontvang entity door het gegeven ID.
            _dbContext.Remove(item); // Verwijder entity uit DbSet in de context.
            _dbContext.SaveChanges(); // Sla wijzigingen op in de database.
        }
    }
}
