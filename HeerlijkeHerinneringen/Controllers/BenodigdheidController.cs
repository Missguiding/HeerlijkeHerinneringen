using HeerlijkeHerinneringen.Data.Models;
using HeerlijkeHerinneringen.Libraries.Repositories;
using HeerlijkeHerinneringen.Libraries.Services;
using HeerlijkeHerinneringen.Libraries.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HeerlijkeHerinneringen.Controllers
{
    public class BenodigdheidController : Controller
    {
        public BenodigdheidService _benodigdheidService;
        //public BenodigdheidRepo _benodigdheidRepo;

        public BenodigdheidController(BenodigdheidService benodigdheidService /*BenodigdheidRepo benodigdheidRepo*/)
        {
            _benodigdheidService = benodigdheidService;
            //_benodigdheidRepo = benodigdheidRepo;
        }
        // GET: BenodigdheidController
        public ActionResult Index()
        {
            return View(_benodigdheidService.GetAll());
        }

        // GET: BenodigdheidController/Details/5
        public ActionResult Details(int id)
        {
            return View(_benodigdheidService.GetById(id));
        }


        // GET: BenodigdheidController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BenodigdheidController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BenodigdheidViewModel benodigdheid)
        {

            // Controleer of een benodigdheid met dezelfde naam al bestaat
            BenodigdheidViewModel existingBenodigdheid = _benodigdheidService.GetAll()
                .FirstOrDefault(s => s.Naam.ToLower() == benodigdheid.Naam.ToLower());

            if (existingBenodigdheid != null)
            {
                // Voeg een foutmelding toe aan het modelstate als de specialisatie al bestaat
                ModelState.AddModelError("Naam", "Benodigdheid bestaat al, selecteer uit de lijst aub.");
                ViewBag.Message = "Benodigdheid";
                return View(benodigdheid);
            }
            else
            {
                // Voeg de nieuwe specialisatie toe aan de repository
                _benodigdheidService.Add(benodigdheid);

                return RedirectToAction("Index", "Benodigdheid");
            }


            // Voeg de nieuwe benodigheid toe aan de service/data
            _benodigdheidService.Add(benodigdheid);
           
            return RedirectToAction("Index");
        }

        // GET: BenodigdheidController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_benodigdheidService.GetById(id));
        }

        // POST: BenodigdheidController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, BenodigdheidViewModel benodigdheid)
        {
            try
            {
                _benodigdheidService.Update(benodigdheid);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BenodigdheidController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_benodigdheidService.GetById(id));
        }

        // POST: BenodigdheidController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, BenodigdheidViewModel benodigdheid)
        {
            try
            {
                _benodigdheidService.Delete(benodigdheid.Id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
