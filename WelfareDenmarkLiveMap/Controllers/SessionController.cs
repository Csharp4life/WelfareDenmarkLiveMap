using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WelfareDenmarkLiveMap.Models;

namespace WelfareDenmarkLiveMap.Controllers
{
    [Route("session")]
    public class SessionController : Controller
    {
        private readonly DataContext _db;

        public SessionController(DataContext db)
        {
            _db = db;
        }
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("Create")]
        public IActionResult Create()
        {
            var patients = _db.Patients.ToList();
            var exercises = _db.Exercise.ToList();
            Random random = new Random();
            var maxExercises = random.Next(6, 20);
            var Sessions = new List<Session>();
            var completedExercises = new List<Exercise>();
            DateTime dateTime = new DateTime();
            

            for (int i = 0; i < maxExercises; i++)
            {
                var randomExercise = random.Next(1, 20);            
                completedExercises.Add(exercises[randomExercise]);
            }
            
                foreach (var Patient in  patients) {
                var session = new Session
                {
                    CompletionRate = random.Next(10, 100),
                    Time = dateTime.Date,
                    Patient = Patient,
                    Exercises = completedExercises

                };
                Sessions.Add(session);
            };
            _db.AddRange(Sessions);
            _db.SaveChanges();
            return View();
        }
    }
}