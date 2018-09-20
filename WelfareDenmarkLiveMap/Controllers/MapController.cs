using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WelfareDenmarkLiveMap.Models;

namespace WelfareDenmarkLiveMap.Controllers
{
    public class MapController : Controller
    {
        public IActionResult Map()
        {
            return View();
        }
    }
}