using HeerlijkeHerinneringen.Libraries.Services;
using HeerlijkeHerinneringen.Libraries.ViewModels;
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

            // Voeg de nieuwe chef toe aan de service
            _chefService.Add(chef);
            //return View(chef);
            return RedirectToAction("Index");
        }

        // GET: ReceptController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View(_chefService.GetById(id));
        //}

        // POST: ReceptController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(ChefViewModel chef)
        //{
        //    try
        //    {
        //        _chefService.Update(chef);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: ReceptController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View(_chefService.GetById(id));
        //}

        // POST: ReceptController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, ChefViewModel chef)
        //{
        //    try
        //    {
        //        // Verwijder de chef met de opgegeven ID
        //        _chefService.Delete(chef.Id);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
