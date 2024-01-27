using ComeToEgypt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectCompany.DpContext;

namespace ComeToEgypt.Controllers
{
    public class TouristsController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public TouristsController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        // GET: TouristsController
        public ActionResult Index()
        {
            List<Tourist> tourists = _appDbContext.Tourists.ToList();
            return View(tourists);
        }

        // GET: TouristsController/Details/5
        public ActionResult Details(int id)
        {
            return View(_appDbContext.Tourists.Where(x => x.Id == id).FirstOrDefault());
        }

        // GET: TouristsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TouristsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Tourist tourist)
        {
            try
            {
                _appDbContext.Tourists.Add(tourist);
                _appDbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TouristsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_appDbContext.Tourists.Where(x => x.Id == id).FirstOrDefault());
        }

        // POST: TouristsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Tourist tourist)
        {
            try
            {
                _appDbContext.Entry(tourist).State = EntityState.Modified;
                _appDbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TouristsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_appDbContext.Tourists.Where(x => x.Id == id).FirstOrDefault());
        }

        // POST: TouristsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Tourist tourist)
        {
            try
            {
                var tourist1 = _appDbContext.Tourists.Where(x => x.Id == id).FirstOrDefault();
                _appDbContext.Tourists.Remove(tourist1);
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
