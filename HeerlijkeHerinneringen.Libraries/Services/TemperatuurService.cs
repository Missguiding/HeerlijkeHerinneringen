using AutoMapper;
using HeerlijkeHerinneringen.Data.Models;
using HeerlijkeHerinneringen.Libraries.Interfaces;
using HeerlijkeHerinneringen.Libraries.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeerlijkeHerinneringen.Libraries.Services
{
    public class TemperatuurService
    {
        private IRepository<Temperatuur> _temperatuurrepository;
        private IMapper _mapper;
        public TemperatuurService(IRepository<Temperatuur> temperatuurRepository, IMapper mapper)
        {
            _temperatuurrepository = temperatuurRepository;
            _mapper = mapper;
        }
        public List<TemperatuurViewModel> GetAll()
        {
            return _mapper.Map<List<TemperatuurViewModel>>(_temperatuurrepository.GetAll().ToList());
        }

        public TemperatuurViewModel GetById(int id)
        {
            return _mapper.Map<TemperatuurViewModel>(_temperatuurrepository.GetById(id));
        }

        public void Add(TemperatuurViewModel graad)
        {
            Temperatuur result = _mapper.Map<Temperatuur>(graad);
            _temperatuurrepository.Add(result);
            graad.TemperatuurId = result.TemperatuurId;
        }

        public void Update(TemperatuurViewModel graad)
        {
            _temperatuurrepository.Update(_mapper.Map<Temperatuur>(graad));
        }

        public void Delete(int id)
        {
            _temperatuurrepository.Delete(id);
        }
    }
}
