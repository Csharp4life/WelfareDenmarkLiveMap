using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WelfareDenmarkLiveMap.Models;

namespace WelfareDenmarkLiveMap.Controllers
{
    [Route("patient")]
    public class PatientController : Controller
    {
        private readonly DataContext _db;

        public PatientController(DataContext db)
        {
            _db = db;
        }

        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("create")]
        public IActionResult Create()
        {
            if (!ModelState.IsValid)
                return View();
            Patient patient = new Patient();

            patient.Name = "Mads";
            patient.Sessions = null;
            patient.County = null;

            _db.Patients.Add(patient);
            _db.SaveChanges();

            return RedirectToAction("map", "map", new
            {
            });
        }
    }
}