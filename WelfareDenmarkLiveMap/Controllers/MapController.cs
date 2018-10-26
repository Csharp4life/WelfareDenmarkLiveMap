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

        [HttpPost, Route("Data")]
        public JsonResult Data(string countyID)
        {
            var county = _db.County.FirstOrDefault(c => c.CountyNo == countyID);
            var patients = _db.Patients.Where(p => p.County == county).ToList();
            var sessions = _db.Session.Where(s => patients.Contains(s.Patient));

            return Json(sessions);
        }
    }
}