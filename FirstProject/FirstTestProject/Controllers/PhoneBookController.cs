using FirstTestProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstTestProject.Controllers
{
    public class PhoneBookController : Controller
    {
        public IActionResult Index()
        {
            return View(DataContext.Contacts);
        }

        [HttpPost]
        public IActionResult Add(Contact model)
        {
            if (ModelState.IsValid)
            {

                DataContext.Contacts.Add(model);
            }

            return RedirectToAction(nameof(Index));
            
            
        }
    }
}
