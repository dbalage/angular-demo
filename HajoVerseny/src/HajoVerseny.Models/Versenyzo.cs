using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HajoVerseny.Models
{
    public class Versenyzo
    {
        public int Id { get; set; }
        public string Nev { get; set; }
        public string SzuletesiDatum { get; set; }
        public Nem Nem { get; set; }
    }
}
