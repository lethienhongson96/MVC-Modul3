using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreManagement.Models;

namespace StoreManagement.Controllers
{
    public class AccountController : Controller
    {
        public AccountController()
        {

        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ApplicationUser applicationUser)
        {
            return View();
        }
    }
}
