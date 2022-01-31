using ASP.NET_Core_MVC_Web_App.Data;
using ASP.NET_Core_MVC_Web_App.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_MVC_Web_App.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> categoriesList = _db.Categories;
            return View(categoriesList);
        }
        
        public IActionResult Create()
        {
            return View();
        }
    }
}