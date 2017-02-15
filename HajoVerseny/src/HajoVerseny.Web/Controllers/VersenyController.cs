using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HajoVerseny.Models;
using HajoVerseny.Web.Services;

namespace HajoVerseny.Web.Controllers
{
    public class VersenyController : Controller
    {
        public IActionResult Index()
        {
            var versenyek = new List<Verseny>
            {
                new Verseny { Nev = "Kékszalag" },
                new Verseny { Nev = "Alba Regia Kupa" },
                new Verseny { Nev = "Silwell Kupa" }
            };

            return View(versenyek);
        }


        public IActionResult Details(string nev)
        {
            var model = new Verseny
            {
                Nev = nev,
                NevezettHajok = HajoService.GetHajok()
            };

            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var hajo = HajoService.GetHajo(id);

            return PartialView(hajo);
        }

        [HttpPost]
        public IActionResult Edit([FromBody]Hajo model)
        {
            return Ok();
        }
    }
}
