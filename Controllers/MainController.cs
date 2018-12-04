using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using LostInTheWoods.Factories;

namespace LostInTheWoods.Models
{
    public class MainController : Controller
    {
        private readonly TrailFactory _trailFactory;
        public MainController(TrailFactory trailfactory)
        {
            _trailFactory = trailfactory;
        }
        // Main View
        [Route("")]
        public IActionResult Index()
        {
            var trails = _trailFactory.GetAllTrails();
            return View("Index", trails);
        }
        [HttpGet("Length")]
        public IActionResult LengthSort()
        {
            var trails = _trailFactory.GetAllTrailsByLength();
            return View("Index", trails);
        }
        [HttpGet("Elevation")]
        public IActionResult ElevationSort()
        {
            var trails = _trailFactory.GetAllTrailsByElevation();
            return View("Index", trails);
        }    

        // View for the New Trail form
        [Route("NewTrail")]
        public IActionResult NewTrail()
        {
            return View("NewTrail");
        }

        // View for the detailed trail information -- will need to edit to include 
        // Trail # in the syntax
        [HttpGet("trails/{id}")]
        public IActionResult ViewTrail(int id)
        {
            var trail = _trailFactory.TrailFind(id);
            if(trail == null)
                return RedirectToAction("Index");
            return View("trails", trail);
        }

        // Route to create a new trail
        [HttpPost("Create")]
        public IActionResult Create(Trail trail)
        {
            // if there are no errors in the form submission proceed, else return to index with error messages
            if(ModelState.IsValid)
            {
                // insert query here
                _trailFactory.AddNewTrail(trail);
                return RedirectToAction("Index");
            }
            else
            {
                return View("NewTrail");
            }
        }
    }
}