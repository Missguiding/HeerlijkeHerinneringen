using HeerlijkeHerinneringen.Libraries.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HeerlijkeHerinneringen.Controllers
{
    public class MenuGangController : Controller
    {
        public MenuGangService _menuGangService;


        public MenuGangController(MenuGangService menuGangService)
        {
            _menuGangService = menuGangService;

        }

        // GET: MenuGangController
        public ActionResult Index()
        {
            return View(_menuGangService.GetAll());
        }

        //// GET: MenuGangController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: MenuGangController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MenuGangController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        //// GET: MenuGangController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: MenuGangController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: MenuGangController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: MenuGangController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
