using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyHobbies;

namespace MVC_Oefeningenreeks_1.Controllers
{
    public class BandController : Controller
    {
        private IBandStorage bandStorage = new BandStorage();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Lijst()
        {
            ViewBag.bandStorage = bandStorage;
            return View();
        }

        public IActionResult LijstMetLeden()
        {
            ViewBag.bandStorage = bandStorage;
            return View();
        }

        public IActionResult Maak(String naam, int jaar)
        {
            Band band = new Band(jaar, naam);
            bandStorage.AddBand(band);
            ViewBag.band = band;
            return View();
        }
    }
}