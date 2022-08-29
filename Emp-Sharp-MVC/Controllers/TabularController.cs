using Microsoft.AspNetCore.Mvc;

namespace Emp_Sharp_MVC.Controllers;

public class TabularController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}