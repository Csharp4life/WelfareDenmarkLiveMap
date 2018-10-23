using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WelfareDenmarkLiveMap.Models;

namespace WelfareDenmarkLiveMap.Controllers
{
    [Route("exercise")]
    public class ExerciseController : Controller
    {
        private readonly DataContext _db;

        public ExerciseController(DataContext db)
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

            // #1 Load all exercise types from database and add to list.
            var exerciseTypes =
                _db.ExerciseType.ToList();
            // #2 Load all sessions from database
            // To be implemented

            // #3 Generate random exercise data
            _db.Database.ExecuteSqlCommand("TRUNCATE TABLE [Exercise]");

            int amountOfExerciseTypes = exerciseTypes.Count;
            Random random = new Random();

            var exercises = new List<Exercise>();
            for (int i = 0; i < 100; i++)
            {
                var x = new Exercise { CompletionRate = random.Next(10, 100), Session = null, ExerciseType = exerciseTypes[random.Next(0, amountOfExerciseTypes)] };
                exercises.Add(x);
            }

            _db.AddRange(exercises);
            _db.SaveChanges();

            throw new Exception("FUCK");
        }
    }
}