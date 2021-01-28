using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using OnlineStore.Data;
using OnlineStore.Models;
using OnlineStore.Infrastructure.Interfaces;
using OnlineStore.Infrastructure.Services;
using System.Threading.Tasks;

namespace OnlineStore.Controllers
{
    public class WorkersController : Controller
    {
        private readonly IWorkers _Workers;
        public WorkersController(IWorkers Workers) => _Workers = Workers;

        public IActionResult Index()
        {
            return View(_Workers);
        }

        public IActionResult AdditionalInfo(int id)
        {
            var worker = _Workers.Get(id);
            return View(worker);
        }
    }
}
