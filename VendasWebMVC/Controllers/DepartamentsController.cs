using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VendasWebMVC.Models;

namespace VendasWebMVC.Controllers
{
    public class DepartamentsController : Controller
    {
        public IActionResult Index()
        {
            var List = new List<Departament>();
            List.Add(new Departament { Id = 1, Name = "Eletronics" });
            List.Add(new Departament { Id = 1, Name = "Fashion" });

            return View(List);
        }
    }
}