using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HajoVerseny.Models;


namespace HajoVerseny.Web.Controllers
{
    public class VersenyController : Controller
    {


        public IActionResult Details()
        {
            Verseny verseny = new Verseny
            {
                Nev = "Kék szalag",
                NevezettHajok = new List<Hajo>
                {
                    new Hajo
                    {
                        Nev = "Diablo",
                        Tipus = HajoTipus.Finn,
                        VitorlaSzam = 1466,
                        Versenyzok = new List<Versenyzo>
                        {

                        }
                    },
                }
            };

            return View();
        }
    }
}
