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
    public class ReceptStapService
    {
        private IRepository<ReceptStap> _receptStaprepository;
        private IMapper _mapper;
        public ReceptStapService(IRepository<ReceptStap> receptStaprepository, IMapper mapper)
        {
            _receptStaprepository = receptStaprepository;
            _mapper = mapper;
        }

        public List<ReceptStapViewModel> GetAll()
        {
            return _mapper.Map<List<ReceptStapViewModel>>(_receptStaprepository.GetAll().ToList());
        }

        public ReceptStapViewModel GetById(int id)
        {
            return _mapper.Map<ReceptStapViewModel>(_receptStaprepository.GetById(id));
        }

        public void Add(ReceptStapViewModel receptStap)
        {
            ReceptStap result = _mapper.Map<ReceptStap>(receptStap);
            _receptStaprepository.Add(result);
            receptStap.Id = result.ReceptStapId;
        }

        public void Update(ReceptStapViewModel receptStap)
        {
            _receptStaprepository.Update(_mapper.Map<ReceptStap>(receptStap));
        }

        public void Delete(int id)
        {
            _receptStaprepository.Delete(id);
        }
    }
}
