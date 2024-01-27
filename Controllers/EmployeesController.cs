using ComeToEgypt.DbContext.Services;
using ComeToEgypt.Models;
using Microsoft.AspNetCore.Mvc;
using ProjectCompany.DpContext;

namespace ComeToEgypt.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeesServise _service;
        public EmployeesController(IEmployeesServise service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //Get: Employees/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Employee employee)
        {
            ////////////////////////Here
            if (ModelState.IsValid)
            {
                return View(employee);
            }
            await _service.AddAsync(employee);
            return RedirectToAction("Index");   
        }
        //Get: Employees/Edit
        public async Task<IActionResult> Edit(int id)
        {
            var employeeDetails = await _service.GetByIdAsync(id);

            if (employeeDetails == null) return View("NotFound");
            return View(employeeDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Employee employee)
        {
            ////////////////////////Here
            employee.Id = id;
            if (ModelState.IsValid)
            {
                return View(employee);
            }
            await _service.UpdateAsync(id, employee);
            return RedirectToAction(nameof(Index));
        }

        //Get: Employee/Details/1

        public async Task<IActionResult> Details(int id)
        {
            var employeeDetails = await _service.GetByIdAsync(id);

            if (employeeDetails == null) return View("NotFound");
            return View(employeeDetails);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var employeeDetails = await _service.GetByIdAsync(id);
            if (employeeDetails == null) return View("NotFound");
            return View(employeeDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employeeDetails = await _service.GetByIdAsync(id);
            if (employeeDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
