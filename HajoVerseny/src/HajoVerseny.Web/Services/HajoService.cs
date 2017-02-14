using HajoVerseny.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HajoVerseny.Web.Services
{
    public static class HajoService
    {
        private static List<Hajo> hajok = new List<Hajo>
        {
            new Hajo
            {
                Id = 1,
                Nev = "Albatrosz",
                Tipus = HajoTipus.Finn,
                VitorlaSzam = 2,
                Versenyzok = new List<Versenyzo>
                {
                    new Versenyzo
                    {
                        Id = 1,
                        Nev = "Liszi László",
                        SzuletesiDatum = "1969.04.17.",
                        Nem = Nem.Ferfi
                    },
                    new Versenyzo
                    {
                        Id = 2,
                        Nev = "Pataki Mátyás",
                        SzuletesiDatum = "1978.08.23.",
                        Nem = Nem.Ferfi
                    }
                }
            },
            new Hajo
            {
                Id = 2,
                Nev = "Alibi",
                Tipus = HajoTipus.Kadett,
                VitorlaSzam = 772,
                Versenyzok = new List<Versenyzo>
                {
                    new Versenyzo
                    {
                        Id = 3,
                        Nev = "Csomor Ildikó",
                        Nem = Nem.No,
                        SzuletesiDatum = "1985.02.12."
                    },
                    new Versenyzo
                    {
                        Id = 4,
                        Nev = "Farmosi János",
                        Nem = Nem.Ferfi,
                        SzuletesiDatum = "1967.01.21" 
                    }
                }
            },
            new Hajo
            {
                Id = 3,
                Nev = "Bobó",
                Tipus = HajoTipus.Kaloz,
                VitorlaSzam = 567,
                Versenyzok = new List<Versenyzo>
                {
                    new Versenyzo
                    {
                        Id = 5,
                        Nev = "Sörös Róbert",
                        Nem = Nem.No,
                        SzuletesiDatum = "1965.04.17."
                    },
                    new Versenyzo
                    {
                        Id = 6,
                        Nev = "Tél Ferenc",
                        Nem = Nem.Ferfi,
                        SzuletesiDatum = "1977.11.20"
                    }
                }
            },
            new Hajo
            {
                Id = 4,
                Nev = "Balhé",
                Tipus = HajoTipus.Optimist,
                VitorlaSzam = 567,
                Versenyzok = new List<Versenyzo>
                {
                    new Versenyzo
                    {
                        Id = 7,
                        Nev = "Sörös Róbert",
                        Nem = Nem.No,
                        SzuletesiDatum = "1965.04.17."
                    },
                    new Versenyzo
                    {
                        Id = 8,
                        Nev = "Tél Ferenc",
                        Nem = Nem.Ferfi,
                        SzuletesiDatum = "1977.11.20"
                    }
                }
            }
        };

        public static List<Hajo> GetHajok ()
        {
            return hajok;
        }

        public static Hajo GetHajo (int id)
        {
            return hajok.SingleOrDefault(h => h.Id == id);
        }

    }
}
