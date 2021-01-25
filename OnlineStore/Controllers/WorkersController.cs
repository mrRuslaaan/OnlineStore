using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using OnlineStore.Data;
using System.Threading.Tasks;

namespace OnlineStore.Controllers
{
    public class WorkersController : Controller
    {
        public IActionResult Index()
        {
            return View(TestData.Workers);
        }

        public IActionResult AdditionalInfo(int id)
        {
            return View();
        }
    }
}
