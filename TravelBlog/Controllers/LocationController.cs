﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelBlog.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TravelBlog.Controllers
{
    public class LocationController : Controller
    {
        private TravelBlogDbContext db = new TravelBlogDbContext();
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Location> model = db.Locations.ToList();
            return View();
        }
    }
}
