using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
      private readonly FactoryContext _db;

      public HomeController(FactoryContext db)
      {
        _db = db;
      }

      [HttpGet("/")]
      public ActionResult Index()
      {
        Machine[] machinas = _db.Machines.ToArray();
        Engineer[] nerds = _db.Engineers.ToArray();
        Dictionary<string,object[]> model = new Dictionary<string, object[]>();
        model.Add("machines", machinas);
        model.Add("engineers", nerds);
        return View(model);
      }
    }
}