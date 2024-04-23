using Microsoft.EntityFrameworkCore;
using RepositoryCrud.Models;

namespace RepositoryCrud.Services
{
    public class EmployeeRepo : IEmployee
    {
        private readonly DbEmployee _context;
        private DbSet<Employee> _employee;
        public EmployeeRepo(DbEmployee emp)
        {
            this._context = emp;
            _employee=_context.Set<Employee>();
        }
        public void Delete(int Id)
        {
            _context.Employees.Remove(_context.Employees.Find(Id));
            _context.SaveChanges();
        }

        public void Details(int Id)
        {
            _context.Employees.Find(Id);
          
        }


        public List<Employee> GetAll()
        {
           return _context.Employees.ToList();
        }

        public Employee GetById(int Id)
        {
            return _context.Employees.Find(Id);
        }

        public void Insert(Employee entity)
        {
           _context.Employees.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Employee entity)
        {
           _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
