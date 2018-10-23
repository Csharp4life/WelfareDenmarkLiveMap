using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WelfareDenmarkLiveMap.Controllers
{
    [Route("exercise")]
    public class ExerciseController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/generate")]
        public IActionResult Generate()
        {
            return View();
        }
    }
}