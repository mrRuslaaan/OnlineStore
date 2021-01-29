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
    public class BlogsController : Controller
    {
        private readonly IBlog _Blogs;
        public BlogsController (IBlog Blogs) => _Blogs = Blogs;

        public IActionResult Index()
        {
            return View(_Blogs.Get());
        }
    }
}
