using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Nettbutikk.Controllers
{
    public class LogginnController : Controller
    {
        // GET: LogginnController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LogginnController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LogginnController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LogginnController/Create
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

        // GET: LogginnController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LogginnController/Edit/5
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

        // GET: LogginnController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LogginnController/Delete/5
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
