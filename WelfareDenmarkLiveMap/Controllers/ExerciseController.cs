using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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

        [Route("generate")]
        public IActionResult Generate()
        {
            if (!ModelState.IsValid) // If the model has errors, abort action and return to view.
                return View();

            // #1 Load all exercise types from database and add to list.
            var exerciseTypes =
                _db.ExerciseType.ToList();
            // #2 Load all patients from database
            

            //var exercises = new List<Exercise>
            //{
            //    new Exercise { Name = "Siddende knæekstension, venstre, sværdhedsgrad 2" },
            //};
            //_db.AddRange(exercises);
            //_db.SaveChanges();

            throw new Exception(exerciseTypes);
        }
    }
}