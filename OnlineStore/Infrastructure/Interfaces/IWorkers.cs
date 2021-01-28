using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineStore.Models;

namespace OnlineStore.Infrastructure.Interfaces
{
    public interface IWorkers
    {
        IEnumerable<Worker> Get();
        Worker Get(int id);
        bool Delete(int id);
        void Update(Worker worker);
        int Add(Worker worker);
        public int MaxID();
    }
}
