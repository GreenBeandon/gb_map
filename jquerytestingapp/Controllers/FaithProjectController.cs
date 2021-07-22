using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace jquerytestingapp.Controllers
{
    public class FaithProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}