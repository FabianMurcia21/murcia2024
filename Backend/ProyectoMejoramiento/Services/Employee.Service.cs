using Microsoft.EntityFrameworkCore;
using ProyectoMejoramiento.Models;
using System.Collections.Generic;

namespace ProyectArg.Services
{
    public class EmployeeService
    {
        private readonly AppDbContext _context;

        public EmployeeService(AppDbContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _context.Employee.ToList();
        }

        public void create(Employee employee)
        {
            _context.Employee.Add(employee);
            _context.SaveChanges();
        }
    }
}