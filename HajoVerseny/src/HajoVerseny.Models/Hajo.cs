using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HajoVerseny.Models
{
    public class Hajo
    {
        public int Id { get; set; }
        public string Nev { get; set; }
        public int VitorlaSzam { get; set; }
        public HajoTipus Tipus { get; set; }
        public List<Versenyzo> Versenyzok { get; set; }

        public Hajo()
        {

        }
    }
}
