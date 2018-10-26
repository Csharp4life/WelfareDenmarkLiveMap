using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WelfareDenmarkLiveMap.Models;

namespace WelfareDenmarkLiveMap.Controllers
{
    [Route("map")]
    public class MapController : Controller
    {
        private readonly DataContext _db;
        public MapController(DataContext db)
        {
            _db = db;
        }
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, Route("data")]
        public IActionResult Data(string countyID)
        {
            var county = _db.County.Find(countyID);
            var patients = _db.Patients.Where(p => p.County == county).ToList();
            foreach(var patient in patients)
            {
            var sessions = _db.Session.Where(s => s.Patient == patient).ToList(); ;
            }
            return View();
        }

    }
}