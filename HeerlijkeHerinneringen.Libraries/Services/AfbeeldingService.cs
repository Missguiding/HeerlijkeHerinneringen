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
    public class AfbeeldingService
    {
        private IRepository<Afbeelding> _afbeeldingRepository;
        private IMapper _mapper;

        public AfbeeldingService(IRepository<Afbeelding> afbeeldingRepository, IMapper mapper)
        {
            _afbeeldingRepository = afbeeldingRepository;
            _mapper = mapper;
        }

        public List<AfbeeldingViewModel> GetAll()
        {
            return _mapper.Map<List<AfbeeldingViewModel>>(_afbeeldingRepository.GetAll().ToList());
        }

        public AfbeeldingViewModel GetById(int id)
        {
            return _mapper.Map<AfbeeldingViewModel>(_afbeeldingRepository.GetById(id));
        }

        public void Add(AfbeeldingViewModel afbeelding)
        {
            Afbeelding result = _mapper.Map<Afbeelding>(afbeelding);
            _afbeeldingRepository.Add(result);
            afbeelding.AfbeeldingId = result.AfbeeldingId;
        }

        public void Update(AfbeeldingViewModel afbeelding)
        {
            _afbeeldingRepository.Update(_mapper.Map<Afbeelding>(afbeelding));
        }

        public void Delete(int id)
        {
            _afbeeldingRepository.Delete(id);
        }
    }
}

