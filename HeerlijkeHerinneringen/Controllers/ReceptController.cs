using HeerlijkeHerinneringen.Data.Models;
using HeerlijkeHerinneringen.Libraries.Services;
using HeerlijkeHerinneringen.Libraries.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HeerlijkeHerinneringen.Controllers
{
    public class ReceptController : Controller
    {
        public ReceptService _receptService;

        public ReceptController(ReceptService receptService)
        {
            _receptService = receptService;
        }


        // GET: ReceptController
        public ActionResult Index()
        {
            return View(_receptService.GetAll());
        }

        // GET: ReceptController/Details/5
        public ActionResult Details(int id)
        {  
           
            return View(_receptService.GetById(id));
        }

        // GET: ReceptController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReceptController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ReceptViewModel recept)
        {
            try
            {
                if (!_receptService.ReceptExistsByName(recept.Titel))
                {
                    // Voeg de nieuw recept toe aan de service
                    _receptService.Add(recept);


                    return View(recept);
                }
                else
                {
                    return RedirectToAction(nameof(Index));
                }

            }
            catch
            {
                return View(recept);
            }
        }

        // GET: ReceptController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_receptService.GetById(id));
        }

        // POST: ReceptController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ReceptViewModel recept)
        {
            try
            {
                _receptService.Update(recept);
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
            return View(_receptService.GetById(id));
        }

        // POST: ReceptController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ReceptViewModel recept)
        {
            try
            {
                // Verwijder het recept met de opgegeven ID
                _receptService.Delete(recept.Id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
