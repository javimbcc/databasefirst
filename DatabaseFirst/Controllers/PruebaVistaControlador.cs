using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseFirst.Controllers
{
    public class PruebaVistaControlador : Controller
    {
        // GET: PruebaVistaControlador
        public ActionResult Index()
        {
            return View();
        }

        // GET: PruebaVistaControlador/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PruebaVistaControlador/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PruebaVistaControlador/Create
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

        // GET: PruebaVistaControlador/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PruebaVistaControlador/Edit/5
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

        // GET: PruebaVistaControlador/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PruebaVistaControlador/Delete/5
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
