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
    public class BenodigdheidService
    {
        private IRepository<Benodigdheid> _benodigdheidRepository;
        private IMapper _mapper;
        private BenodigdheidRepo _benodigdheidRepo;

        public BenodigdheidService(IRepository<Benodigdheid> benodigdheidRepository, IMapper mapper, BenodigdheidRepo benodigdheidRepo)
        {
            _benodigdheidRepository = benodigdheidRepository;
            _mapper = mapper;
            _benodigdheidRepo = benodigdheidRepo;
        }

        public List<BenodigdheidViewModel> GetAll()
        {
            return _mapper.Map<List<BenodigdheidViewModel>>(_benodigdheidRepository.GetAll().ToList());
        }

        public BenodigdheidViewModel GetById(int id)
        {
            return _mapper.Map<BenodigdheidViewModel>(_benodigdheidRepository.GetById(id));
        }

        public void Add(BenodigdheidViewModel benodigdheid)
        {
            Benodigdheid result = _mapper.Map<Benodigdheid>(benodigdheid);
            _benodigdheidRepository.Add(result);
            benodigdheid.Id = result.BenodigdheidId;
        }

        public void Update(BenodigdheidViewModel benodigdheid)
        {
            _benodigdheidRepository.Update(_mapper.Map<Benodigdheid>(benodigdheid));
        }

        public void Delete(int id)
        {
            _benodigdheidRepository.Delete(id);
        }
    }

}
