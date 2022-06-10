using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers;

    public class HomeController : Controller
    {



        [HttpGet("")]
        public ViewResult Index()
        {
            return View("Index");
        }
   
        [HttpPost("Results")]
        public IActionResult Result(Submit user)
        {
            if(ModelState.IsValid)
            {
                return View(user);
            }
            else
            {
                return Index();
            }
        }
    }

