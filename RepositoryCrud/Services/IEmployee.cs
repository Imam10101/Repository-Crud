using RepositoryCrud.Models;

namespace RepositoryCrud.Services
{
    public interface IEmployee
    {
        void Insert(Employee entity);
        void Update(Employee entity);
        void Delete(int Id);
        void Details (int Id); 
        List<Employee> GetAll();
        Employee GetById(int Id);

    }
}
