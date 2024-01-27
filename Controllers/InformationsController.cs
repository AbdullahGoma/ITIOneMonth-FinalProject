using ComeToEgypt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using ProjectCompany.DpContext;

namespace ComeToEgypt.Controllers
{
    public class InformationsController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public InformationsController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        // GET: InformationsController
        public ActionResult Index()
        {
            List<Models.Information> locations = _appDbContext.Informations.ToList();
            return View(locations);
        }

        // GET: InformationsController/Details/5
        public ActionResult Details(int id)
        {
            return View(_appDbContext.Informations.Where(x => x.Id == id).FirstOrDefault());
        }

        // GET: InformationsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InformationsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.Information information)
        {
            try
            {
                _appDbContext.Informations.Add(information);
                _appDbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InformationsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_appDbContext.Informations.Where(x => x.Id == id).FirstOrDefault());
        }

        // POST: InformationsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Models.Information information)
        {
            try
            {
                _appDbContext.Entry(information).State = EntityState.Modified;
                _appDbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InformationsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_appDbContext.Informations.Where(x => x.Id == id).FirstOrDefault());
        }

        // POST: InformationsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Models.Information information)
        {
            try
            {
                var information1 = _appDbContext.Informations.Where(x => x.Id == id).FirstOrDefault();
                _appDbContext.Informations.Remove(information1);
                _appDbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
