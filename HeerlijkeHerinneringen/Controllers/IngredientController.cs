using HeerlijkeHerinneringen.Libraries.Services;
using HeerlijkeHerinneringen.Libraries.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HeerlijkeHerinneringen.Controllers
{
    public class IngredientController : Controller
    {

        public IngredientService _ingredientService;
        

        public IngredientController(IngredientService ingredientService)
        {
            _ingredientService = ingredientService;
           
        }
        // GET: IngredientController
        public ActionResult Index()
        {
            return View(_ingredientService.GetAll());
        }

        // GET: IngredientController/Details/5
        public ActionResult Details(int id)
        {
            return View(_ingredientService.GetById(id));
        }

        // GET: IngredientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IngredientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IngredientViewModel ingredient)
        {
            // Controleer of ingredient al bestaat
            IngredientViewModel existingIngredient = _ingredientService.GetAll()
                .FirstOrDefault(s => s.Name.ToLower() == ingredient.Name.ToLower());

            if (existingIngredient != null)
            {
                // Voeg een foutmelding toe aan het modelstate als ingredient al bestaat
                ModelState.AddModelError("Name", "Ingredient bestaat al, selecteer uit de lijst aub.");
                ViewBag.Message = "Ingredient";
                return View(ingredient);
            }
            else
            {
                // Voeg de nieuw ingredient toe aan de repository
                _ingredientService.Add(ingredient);

                return RedirectToAction("Index", "Ingredient");
            }

        }

        // GET: IngredientController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_ingredientService.GetById(id));
        }

        // POST: IngredientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IngredientViewModel ingredient)
        {
            try
            {
                _ingredientService.Update(ingredient);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: IngredientController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_ingredientService.GetById(id));
        }

        // POST: IngredientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IngredientViewModel ingredient)
        {
            try
            {
                _ingredientService.Delete(ingredient.Id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
