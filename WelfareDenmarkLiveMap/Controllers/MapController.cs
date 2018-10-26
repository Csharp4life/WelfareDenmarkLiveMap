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
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost, Route("data")]
        public IActionResult Data(string countyID)
        {
            return Content(countyID);
            //var counties = _db.County.ToList();
            //var patients = _db.Patients.ToList();
            //var sessions = _db.Session.ToList();
            //var hoverCounty = new County();
            //var hoverPatient = new List<Patient>();
            //var hoverSessions = new List<Session>();
            //foreach (var county in counties)
            //{
            //    if(county.ID == countyID)
            //    {
            //        hoverCounty = county;
            //    }
            //}
            //foreach (var patient in patients)
            //{
            //    if(patient.County == hoverCounty)
            //    {
            //        hoverPatient.Add(patient);
            //            foreach (var session in sessions)
            //            {
            //               if (session.Patient == patient)
            //                 {
            //                    sessions.Add
            //                 }
            //            }
            //    }
            //}
            //return View();
        }

    }
}