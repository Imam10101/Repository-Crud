using Microsoft.AspNetCore.Mvc;
using RepositoryCrud.Models;
using RepositoryCrud.Services;

namespace RepositoryCrud.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployee employee;
        public EmployeeController(IEmployee employee)
        {
            this.employee = employee;
        }

        public IActionResult Index()
        {
            return View(employee.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            employee.Insert(emp);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int Id)
        {
            return View(employee.GetById(Id));
        }
        [HttpPost]
        public IActionResult Edit(Employee eMployee)
        {
            employee.Update(eMployee);

            return RedirectToAction("Index");
        }
        public ActionResult Details(int Id)
        {
            employee.Details(Id);
            return View();
        }
        public IActionResult Delete(int id)
        {
            employee.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
