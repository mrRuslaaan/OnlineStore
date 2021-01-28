﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineStore.Infrastructure.Interfaces;
using OnlineStore.Models;

namespace OnlineStore.Infrastructure.Services
{
    public class IWorkerService : IWorkers
    {
        private IEnumerable<Worker> _Workers = Data.TestData.Workers;
        public int Add(Worker worker)
        {
            if (worker is null)
                throw new ArgumentException(nameof(worker));

            if (_Workers.Contains(worker))
                return worker.ID;

            var lastWorkerInEnum = _Workers
                .LastOrDefault();

            _Workers
                .ToList()
                .Add(worker);

            return worker.ID = lastWorkerInEnum.ID + 1;
        }

        public bool Delete(int id)
        {
            var worker = Get(id);

            if (worker is null)
                return false;

            return _Workers
                .ToList()
                .Remove(worker);
        }

        public IEnumerable<Worker> Get()
        {
            return _Workers;
        }

        public Worker Get(int id)
        {
            if (id < 0)
                throw new ArgumentException();

            return _Workers.FirstOrDefault(w => w.ID == id);
        }

        public void Update(Worker worker)
        {
            if (worker is null)
                throw new ArgumentException(nameof(worker));

            var db_item = Get(worker.ID);

            if (db_item is null)
                return;

            db_item.Name = worker.Name;
            db_item.Surname = worker.Surname;
            db_item.Patronymic = worker.Patronymic;  
        }
    }
}