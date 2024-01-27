using ComeToEgypt.Models;
using Microsoft.EntityFrameworkCore;
using ProjectCompany.DpContext;

namespace ComeToEgypt.DbContext.Services
{
    public class EmployeesService : IEmployeesServise
    {
        private readonly AppDbContext _AppDbContext;
        public EmployeesService(AppDbContext AppDbContext)
        {
            _AppDbContext = AppDbContext;
        }
        public async Task AddAsync(Employee employee)
        {
            await _AppDbContext.Employees.AddAsync(employee);
            await _AppDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _AppDbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);
            _AppDbContext.Employees.Remove(result);
            await _AppDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            var result = await _AppDbContext.Employees.ToListAsync();
            return result;
        }

        public async Task<Employee> GetByIdAsync(int id)
        {
            var result = await _AppDbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public async Task<Employee> UpdateAsync(int id, Employee newEmployee)
        {
            _AppDbContext.Update(newEmployee);
            await _AppDbContext.SaveChangesAsync();
            return newEmployee;
        }
    }
}
