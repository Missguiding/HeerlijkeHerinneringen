using HeerlijkeHerinneringen.Data.Models;
using HeerlijkeHerinneringen.Libraries.Services;
using HeerlijkeHerinneringen.Libraries.ViewModels;
using HeerlijkeHerinneringen.Migrations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HeerlijkeHerinneringen.Controllers
{
    public class ChefController : Controller
    {
        public ChefService _chefService;

        public ChefController(ChefService chefService)
        {
            _chefService = chefService;
        }
        // GET: ChefController
        public ActionResult Index()
        {
            return View(_chefService.GetAll());
        }

        // GET: ReceptController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View(_chefService.GetById(id));
        //}

        // GET: ReceptController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReceptController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ChefViewModel chef)
        {

            // Controleer of een chef met dezelfde naam al bestaat
            ChefViewModel existingChef = _chefService.GetAll().
                FirstOrDefault(s => s.VoorNaam.ToLower() == chef.VoorNaam.ToLower());
                

            if (existingChef != null)
            {
                // Voeg een foutmelding toe aan het modelstate als de chef al bestaat
                ModelState.AddModelError("VoorNaam", "Chef bestaat al, selecteer uit de lijst aub.");
                ViewBag.Message = "VoorNaam";
                return View(chef);
            }
            else
            {
                // Voeg de nieuwe chef toe aan de repository
                _chefService.Add(chef);

                return RedirectToAction("Index", "Chef");
            }
        }

        // GET: ReceptController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_chefService.GetById(id));
        }

        // POST: ReceptController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ChefViewModel chef)
        {
            try
            {
                _chefService.Update(chef);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReceptController/Delete/5

        
        public ActionResult Delete(int id)
        {
            return View(_chefService.GetById(id));
        }

        // POST: ReceptController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ChefViewModel chef)
        {
            try
            {
                // Verwijder de chef op basis van ID
                _chefService.Delete(chef.Id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
