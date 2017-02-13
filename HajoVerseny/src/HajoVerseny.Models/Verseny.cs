using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HajoVerseny.Models
{
    public class Verseny
    {
        public string Nev { get; set; }
        public List<Hajo> NevezettHajok { get; set; }
    }
}
