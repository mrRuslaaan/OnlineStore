using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using OnlineStore.Data;
using OnlineStore.Models;
using OnlineStore.Infrastructure.Interfaces;
using OnlineStore.Infrastructure.Services;
using System.Threading.Tasks;
using OnlineStore.ViewModel;

namespace OnlineStore.Controllers
{
    public class WorkersController : Controller
    {
        private readonly IWorkers _Workers;
        public WorkersController(IWorkers Workers) => _Workers = Workers;

        public IActionResult Index()
        {
            var workers = _Workers.Get();
            return View(workers);
        }

        public IActionResult AdditionalInfo(int id)
        {
            var worker = _Workers.Get(id);
            return View(worker);
        }

        #region Edit
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id < 0)
                BadRequest();

            var worker = _Workers.Get(id);

            if (worker is null)
                NotFound();

            return View(new WorkerViewModel
            {
                ID = worker.ID,
                Name = worker.Name,
                Surname = worker.Surname,
                Patronymic = worker.Patronymic,
                Age = worker.Age
            });  
        }

        [HttpPost]
        public IActionResult Edit(WorkerViewModel model)
        {
            if (model is null)
                return BadRequest();

            var worker = new Worker
            {
                ID = model.ID,
                Name = model.Name,
                Surname = model.Surname,
                Age = model.Age,
                Patronymic = model.Patronymic,
            };

            _Workers.Update(worker);
           
            return RedirectToAction("Index");
        }
        #endregion

        #region Add
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(WorkerViewModel model)
        {
            if (model is null)
                return BadRequest();

            var id = _Workers.MaxID() + 1;

            var worker = new Worker
            {
                ID = id,
                Name = model.Name,
                Surname = model.Surname,
                Patronymic = model.Patronymic,
                Age = model.Age,
            };

            _Workers.Add(worker);

            return RedirectToAction("Index");
        }
        #endregion

        #region Delete
        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id < 0)
                BadRequest();

            var worker = _Workers.Get(id);

            if (worker is null)
                NotFound();

            return View(new WorkerViewModel
            {
                ID = worker.ID,
                Name = worker.Name,
                Surname = worker.Surname,
                Patronymic = worker.Patronymic,
                Age = worker.Age
            });
        }

        [HttpPost]
        public IActionResult Delete(WorkerViewModel model)
        {
            if (model is null)
                return BadRequest();

            _Workers.Delete(model.ID);

            return RedirectToAction("Index");
        }
        #endregion
    }
}
