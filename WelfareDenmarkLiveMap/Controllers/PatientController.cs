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
            Random r = new Random();
            List<string> firstnames = new List<string>
            {
                "Mads",
                "André",
                "Alice",
                "Jens",
                "Peter",
                "Mikael",
                "Lars",
                "Bo",
                "Hans",
                "Emil",
                "Ole",
                "Allan",
                "Henrik",
                "Carsten",
                "Jonas",
                "Mikki",
                "Martin",
                "Simon",
                "Erik",
                "Lars",
                "Alex",
                "Søren",
                "Mia",
                "Charlotte",
                "Kida",
                "Lilje",
                "Rikke",
                "Lisa",
                "Else",
                "Birthe",
                "Stine",
                "Linda",
                "Malene",
                "Louise",
                "Mathilde",
                "Mette",
                "Irene",
                "Gitte",
                "Henriette",
                "Kirsten",
                "Gudrun",
                "Line",
                "Helene",
                "Agnete"
            };
            List<string> lastnames = new List<string>
            {
                "Nielsen",
                "Hansen",
                "Jensen",
                "Thomsen",
                "Larsen",
                "Christensen",
                "Møller",
                "Busch",
                "Beck",
                "Gollubits",
                "Møller",
                "Robert",
                "Damgaard",
                "Daugaard",
                "Henningsen",
                "Wilhelmsen",
                "Rasmussen",
                "Mortensen"
            };
            if (!ModelState.IsValid)
                return View();
            for (int i = 0; i < 100; i++)
            {
                Patient patient = new Patient();
                patient.Name = $"{firstnames[r.Next(0, firstnames.Count)]} {lastnames[r.Next(0, lastnames.Count)]}";
                patient.Sessions = null;
                patient.County = null;
                _db.Patients.Add(patient);
            }
            _db.SaveChanges();

            return RedirectToAction("map", "map", new
            {
            });
        }
    }
}