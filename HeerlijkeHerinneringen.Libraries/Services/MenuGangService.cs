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
    public class MenuGangService
    {
        private IRepository<MenuGang> _menugangrepository;
        private IMapper _mapper;
        public MenuGangService(IRepository<MenuGang> menugangrepository, IMapper mapper)
        {
            _menugangrepository = menugangrepository;
            _mapper = mapper;
        }

        public List<MenuGangViewModel> GetAll()
        {
            return _mapper.Map<List<MenuGangViewModel>>(_menugangrepository.GetAll().ToList());
        }

        public MenuGangViewModel GetById(int id)
        {
            return _mapper.Map<MenuGangViewModel>(_menugangrepository.GetById(id));
        }

        public void Add(MenuGangViewModel menugang)
        {
            MenuGang result = _mapper.Map<MenuGang>(menugang);
            _menugangrepository.Add(result);
            menugang.Id = result.MenuGangId;
        }

        public void Update(MenuGangViewModel menuGang)
        {
            _menugangrepository.Update(_mapper.Map<MenuGang>(menuGang));
        }

        public void Delete(int id)
        {
            _menugangrepository.Delete(id);
        }
    }
}

