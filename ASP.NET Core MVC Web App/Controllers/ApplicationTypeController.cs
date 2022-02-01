using ASP.NET_Core_MVC_Web_App.Data;
using ASP.NET_Core_MVC_Web_App.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_MVC_Web_App.Controllers
{
    public class ApplicationTypeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ApplicationTypeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<ApplicationType> appTypesList = _db.ApplicationTypes;
            return View(appTypesList);
        }
        
        public IActionResult Create()
        {
            return View();
        }

        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ApplicationType applicationType)
        {
            _db.ApplicationTypes.Add(applicationType);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}