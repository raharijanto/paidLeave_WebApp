using Microsoft.AspNetCore.Mvc;
using paidLeave_WebApp.Context;
using paidLeave_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paidLeave_WebApp.Controllers
{
    public class NettoController : Controller
    {
        MyContext myContext;

        public NettoController(MyContext myContext)
        {
            this.myContext = myContext;
        }

        // GET Net Salary
        public IActionResult Index()
        {
            var dataGet = myContext.Netto.ToList();
            return View(dataGet);
        }

        // Count Net Salary
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Netto netto)
        {
            if (ModelState.IsValid)
            {
                myContext.Netto.Add(netto);
                var dataCreate = myContext.SaveChanges();
                if (dataCreate > 0)
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
    }
}
