using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WelfareDenmarkLiveMap.Models;

namespace WelfareDenmarkLiveMap.Controllers
{
    public class PatientController : Controller
    {
        private readonly DataContext _db;

        public PatientController(DataContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, Route("create")]
        public IActionResult Create(Patient patient)
        {
            if (!ModelState.IsValid)
                return View();

            patient.Name = "Mads";
            patient.Sessions = new List<Session>();
            patient.County = new County();

            _db.Patients.Add(patient);
            _db.SaveChanges();

            return RedirectToAction("map", "map", new
            {
            });
        }
    }
}