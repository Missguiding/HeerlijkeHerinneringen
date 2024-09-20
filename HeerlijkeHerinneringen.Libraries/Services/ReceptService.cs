using AutoMapper;
using HeerlijkeHerinneringen.Data.Models;
using HeerlijkeHerinneringen.Libraries.Interfaces;
using HeerlijkeHerinneringen.Libraries.Repositories;
using HeerlijkeHerinneringen.Libraries.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeerlijkeHerinneringen.Libraries.Services
{
    public class ReceptService
    {
        private IRepository<Recept> _receptRepository;
        private IMapper _mapper;
        private ReceptRepository _receptRepo;

        public ReceptService(IRepository<Recept> receptRepository, IMapper mapper, ReceptRepository receptRepo)
        {
            _receptRepository = receptRepository;
            _mapper = mapper;
            _receptRepo = receptRepo;
        }

        public List<ReceptViewModel> GetAll()
        {
            return _mapper.Map<List<ReceptViewModel>>(_receptRepository.GetAll().ToList());
        }

        //// Methode om alle recepten op te halen
        //public IEnumerable<Recept> GetAllRecepts()
        //{
        //    // Haalt recepten op via de repository
        //    return _receptRepo.GetAllRecepies().ToList();
        //}
        public ReceptViewModel GetById(int id)
        {
            //return _receptRepo.GetAllRecepies()
            //                     .Include(r => r.Afbeeldingen) // Zorgt ervoor dat afbeeldingen worden opgehaald
            //                     .FirstOrDefault(r => r.ReceptId == id);
            return _mapper.Map<ReceptViewModel>(_receptRepository.GetById(id));
        }

        public void Add(ReceptViewModel recept)
        {
            Recept result = _mapper.Map<Recept>(recept);
            _receptRepository.Add(result);
            recept.Id = result.ReceptId;
        }

        public bool ReceptExistsByName(string name)
        {
            return _receptRepo.GetByName(name) != null;
        }

        public void Update(ReceptViewModel recept)
        {
            _receptRepository.Update(_mapper.Map<Recept>(recept));
        }

        public void Delete(int id)
        {
            _receptRepository.Delete(id);
        }
    }
}
