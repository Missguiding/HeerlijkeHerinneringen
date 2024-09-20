using AutoMapper;
using HeerlijkeHerinneringen.Data.Models;
using HeerlijkeHerinneringen.Libraries.Interfaces;
using HeerlijkeHerinneringen.Libraries.Repositories;
using HeerlijkeHerinneringen.Libraries.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeerlijkeHerinneringen.Libraries.Services
{
    public class ChefService
    {
        private IRepository<Chef> _chefRepository;
        private IMapper _mapper;
        private ChefRepository _chefRepo;

        public ChefService(IRepository<Chef> chefRepository, IMapper mapper, ChefRepository chefRepo)
        {
            _chefRepository = chefRepository;
            _mapper = mapper;
            _chefRepo = chefRepo;
        }

        public List<ChefViewModel> GetAll()
        {
            return _mapper.Map<List<ChefViewModel>>(_chefRepository.GetAll().ToList());
        }

        public ChefViewModel GetById(int id)
        {
            return _mapper.Map<ChefViewModel>(_chefRepository.GetById(id));
        }

        public void Add(ChefViewModel chef)
        {
            Chef result = _mapper.Map<Chef>(chef);
            _chefRepository.Add(result);
            chef.Id = result.ChefId;
        }       

        public void Update(ChefViewModel chef)
        {
            _chefRepository.Update(_mapper.Map<Chef>(chef));
        }

        public void Delete(int id)
        {
            _chefRepository.Delete(id);
        }
    }
}
