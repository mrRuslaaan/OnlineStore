using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using OnlineStore.Data;
using OnlineStore.Models;
using System.Threading.Tasks;

namespace OnlineStore.Controllers
{
    public class WorkersController : Controller
    {
        private readonly List<Worker> _Workers;
        public WorkersController() => _Workers = TestData.Workers;
        public IActionResult Index()
        {
            return View(TestData.Workers);
        }

        public IActionResult AdditionalInfo(int id)
        {
            var worker = _Workers.FirstOrDefault(w => w.ID == id);
            return View(worker);
        }
    }
}
