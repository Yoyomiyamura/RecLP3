
using Microsoft.AspNetCore.Mvc;
using RecLP3.Models;

namespace F1Pharmacy.Controllers;

public class EmployeeController : Controller
{
    private readonly RecLP3Context _context;

    public EmployeeController (RecLP3Context context)
    {
        _context = context;
    }

    public IActionResult Index () => View(_context.Employees);

    public IActionResult Show(int id)
    {
        Employee employee = _context.Employees.Find(id);

        if(employee == null)
        {
            return RedirectToAction("Index");
        }

        return View(employee);
    }

    public IActionResult Delete(int id){
        _context.Employees.Remove(_context.Employees.Find(id));
        _context.SaveChanges();
        return View();
    }

    [HttpGet]
    public IActionResult Create(){
                
        return View();
    }

    [HttpPost]
    public IActionResult Create(Employee employee){
        
        if(_context.Employees.Find(employee.Id) != null)
        {
            return Content("Funcionário já cadastrado");
        }
        
        _context.Employees.Add(employee);
        _context.SaveChanges();
        return RedirectToAction("Create");
    }

    [HttpGet]
    public IActionResult Update([FromRoute] int id){
        Employee employee = _context.Employees.Find(id);

        if(employee == null)
        {
            return NotFound();
        }

        return View(employee);
    }

    [HttpPost]
    public IActionResult Update(Employee customerUpdated){

        try
        {
            _context.Employees.Update(customerUpdated);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        catch
        {
            return NotFound();
        }
    }
}