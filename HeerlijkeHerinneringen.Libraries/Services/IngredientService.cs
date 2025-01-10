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
    public class IngredientService
    {
        private IRepository<Ingredient> _ingredientrepository;
        private IMapper _mapper;
        public IngredientService(IRepository<Ingredient> ingredientRepository, IMapper mapper)
        {
            _ingredientrepository = ingredientRepository;
            _mapper = mapper;
        }

        public List<IngredientViewModel> GetAll()
        {
            return _mapper.Map<List<IngredientViewModel>>(_ingredientrepository.GetAll().ToList());
        }

        public IngredientViewModel GetById(int id)
        {
            return _mapper.Map<IngredientViewModel>(_ingredientrepository.GetById(id));
        }

        public void Add(IngredientViewModel ingredient)
        {
            Ingredient result = _mapper.Map<Ingredient>(ingredient);
            _ingredientrepository.Add(result);
            ingredient.Id = result.IngredientId;
        }

        public void Update(IngredientViewModel ingredient)
        {
            _ingredientrepository.Update(_mapper.Map<Ingredient>(ingredient));
        }

        public void Delete(int id)
        {
            _ingredientrepository.Delete(id);
        }
    }
}
