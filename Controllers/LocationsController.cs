using ComeToEgypt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectCompany.DpContext;

namespace ComeToEgypt.Controllers
{
    public class LocationsController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public LocationsController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        // GET: LocationsController
        public ActionResult Index()
        {
            List<Location> locations = _appDbContext.Locations.ToList();
            return View(locations);
        }

        // GET: LocationsController/Details/5
        public ActionResult Details(int id)
        {
            return View(_appDbContext.Locations.Where(x => x.Id == id).FirstOrDefault());
        }

        // GET: LocationsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LocationsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Location location)
        {
            try
            {
                _appDbContext.Locations.Add(location);
                _appDbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LocationsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_appDbContext.Locations.Where(x => x.Id == id).FirstOrDefault());
        }

        // POST: LocationsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Location locationt)
        {
            try
            {
                _appDbContext.Entry(locationt).State = EntityState.Modified;
                _appDbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LocationsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_appDbContext.Locations.Where(x => x.Id == id).FirstOrDefault());
        }

        // POST: LocationsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Location locationt)
        {
            try
            {
                var locationt1 = _appDbContext.Locations.Where(x => x.Id == id).FirstOrDefault();
                _appDbContext.Locations.Remove(locationt1);
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
