using ComeToEgypt.Models;

namespace ComeToEgypt.DbContext.Services
{
    public interface IEmployeesServise
    {
        Task<IEnumerable<Employee>> GetAllAsync();
        Task<Employee> GetByIdAsync(int id);
        Task AddAsync(Employee employee);
        Task<Employee> UpdateAsync(int id, Employee newEmployee);
        Task DeleteAsync(int id);
    }
}
