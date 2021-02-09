using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineStore.Models;

namespace OnlineStore.Infrastructure.Interfaces
{
    public interface IBlog
    {
        IEnumerable<Blog> Get();
        Blog Get(int id);
        bool Delete(int id);
        void Update(Blog blog);
        int Add(Blog blog);
        public int MaxID();
        public Blog GetMainBlog();
    }
}
