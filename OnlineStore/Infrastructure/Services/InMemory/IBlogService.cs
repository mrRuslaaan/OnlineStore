using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineStore.Infrastructure.Interfaces;
using OnlineStore.Models;
using OnlineStore.Data;

namespace OnlineStore.Infrastructure.Services.InMemory
{
    public class IBlogService : IBlog
    {
        private List<Blog> _Blogs = TestData.Blogs;
        public int Add(Blog blog)
        {
            if (blog is null)
                throw new ArgumentNullException(nameof(blog));



            return blog.ID;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Blog> Get()
        {
            var selectedBlogs = from b in _Blogs
                               where b.AuthorID != 1
                               select b;
            return selectedBlogs;
        }

        public Blog Get(int id)
        {
            if (id < 0)
                throw new ArgumentException();

            return _Blogs.FirstOrDefault(w => w.ID == id);
        }

        public int MaxID()
        {
            throw new NotImplementedException();
        }

        public void Update(Blog blog)
        {
            throw new NotImplementedException();
        }

        public Blog GetMainBlog()
        {
            var selectedBlog = from b in _Blogs
                               where b.AuthorID == 1
                               select b;
            return selectedBlog.LastOrDefault();
        }
    }
}
