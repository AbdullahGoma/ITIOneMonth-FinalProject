using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectCompany.DpContext;
using ComeToEgypt.DbContext.Base;
using ComeToEgypt.DbContext.Services;
using ComeToEgypt.Models;

namespace ComeToEgypt.Controllers
{
    //[Authorize(Roles = UserRoles.Admin)]
    public class TicketsController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public TicketsController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        // GET: TicketsController
        public ActionResult Index()
        {
            List<Ticket> tickets = _appDbContext.Tickets.ToList();
            return View(tickets);
        }

        // GET: TicketsController/Details/5
        public ActionResult Details(int id)
        {
            return View(_appDbContext.Tickets.Where(x => x.Id == id).FirstOrDefault());
        }

        // GET: TicketsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TicketsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Ticket ticket)
        {
            try
            {
                _appDbContext.Tickets.Add(ticket);
                _appDbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TicketsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_appDbContext.Tickets.Where(x => x.Id == id).FirstOrDefault());
        }

        // POST: TicketsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Ticket ticket)
        {
            try
            {
                _appDbContext.Entry(ticket).State = EntityState.Modified;
                _appDbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TicketsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_appDbContext.Tickets.Where(x => x.Id == id).FirstOrDefault());
        }

        // POST: TicketsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Ticket ticket)
        {
            try
            {
                var ticket1 = _appDbContext.Tickets.Where(x => x.Id == id).FirstOrDefault();
                _appDbContext.Tickets.Remove(ticket1);
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
