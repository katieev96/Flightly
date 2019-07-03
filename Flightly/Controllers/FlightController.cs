using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlightTrackly.ViewModels.Flight;
using Microsoft.AspNetCore.Mvc;

namespace FlightTrackly.Controllers
{
    public class FlightController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Log()
        {
            LogFlightViewModel vm = new LogFlightViewModel();
            
            return View(vm);
        }
    }
}