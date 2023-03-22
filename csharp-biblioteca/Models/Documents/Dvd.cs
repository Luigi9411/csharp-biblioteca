using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca.Models.Documents
{
    internal class Dvd : Document
    {
        public int? Duration { get; set; }

        public Dvd(string id, string year, string sector, string shelf, string authorName, string authorSurname, int duration) : base(id, year, sector, shelf, authorName, authorSurname) { }
    }
}
