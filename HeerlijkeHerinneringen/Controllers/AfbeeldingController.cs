using HeerlijkeHerinneringen.Data.Models;
using HeerlijkeHerinneringen.Libraries.Services;
using HeerlijkeHerinneringen.Libraries.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HeerlijkeHerinneringen.Controllers
{
    public class AfbeeldingController : Controller
    {
        public AfbeeldingService _afbeeldingService;

        public AfbeeldingController(AfbeeldingService afbeeldingService)
        {
            _afbeeldingService = afbeeldingService;
        }

        // GET: AfbeeldingController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AfbeeldingController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AfbeeldingController/Create
        public IActionResult Create(int receptId)
        {
            var model = new AfbeeldingViewModel
            {
                ReceptId = receptId  // Hiermee koppel je de afbeelding aan een recept
            };

            ViewBag.receptId = receptId;  // Zorg ervoor dat je receptId doorgeeft aan de view
            return View(model);
        }


        // POST: AfbeeldingController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AfbeeldingViewModel model, IFormFile afbeelding, int receptId)
        {
            // Controleer of het ReceptId bestaat in de database
            var recept = _afbeeldingService.GetById(receptId);
            if (recept == null)
            {
                ModelState.AddModelError("", "Het opgegeven ReceptId bestaat niet.");
                return View(model);
            }

            model.ReceptId = receptId;

            if (ModelState.IsValid)
            {
                if (afbeelding != null && afbeelding.Length > 0)
                {
                    // Verwerk de afbeelding en sla deze op
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/Recepten", afbeelding.FileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        afbeelding.CopyTo(stream);
                    }

                    model.AfbeeldingUrl = "/images/Recepten/" + afbeelding.FileName;
                    _afbeeldingService.Add(model); // Voeg de afbeelding toe aan het recept
                    return RedirectToAction("Details", "Recept", new { id = model.ReceptId });
                }
            }

            return View(model);
        }  
    
    // GET: AfbeeldingController/Edit/5
    public ActionResult Edit(int id)
    {
        return View();
    }

    // POST: AfbeeldingController/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: AfbeeldingController/Delete/5
    public ActionResult Delete(int id)
    {
        return View();
    }

    // POST: AfbeeldingController/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }
}
}
