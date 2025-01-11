using HeerlijkeHerinneringen.Libraries.Services;
using HeerlijkeHerinneringen.Libraries.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HeerlijkeHerinneringen.Controllers
{
    public class ReceptStapController : Controller
    {
        public ReceptStapService _receptStapService;

        public ReceptStapController(ReceptStapService receptStapService)
        {
            _receptStapService = receptStapService;
        }


        // GET: ReceptStapController
        public ActionResult Index()
        {
            return View(_receptStapService.GetAll());
        }

        // GET: ReceptStapController/Details/5
        public ActionResult Details(int id)
        {
            return View(_receptStapService.GetById(id));
        }

        // GET: ReceptStapController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReceptStapController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ReceptStapViewModel stap)
        {
            //er moet een recept id worden toegevoegd aan een stappenplan
           _receptStapService.Add(stap);
            return View();
        }

        // GET: ReceptStapController/Edit/5
        public ActionResult Edit(int id)
        {
            
            return View(_receptStapService.GetById(id));
        }

        // POST: ReceptStapController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ReceptStapViewModel stap)
        {
            try
            {
                _receptStapService.Update(stap);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReceptStapController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_receptStapService.GetById(id));
        }

        // POST: ReceptStapController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ReceptStapViewModel stap)
        {
            try
            {
                _receptStapService.Delete(stap.Id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
