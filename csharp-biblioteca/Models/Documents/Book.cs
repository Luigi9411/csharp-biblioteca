using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca.Models.Documents
{
    public class Book : Document
    {

        public Book(string id, string title, string year, string sector, string shelf, string authorName, string authorSurname, int numberOfPages) : base(id, title, year, sector, shelf, authorName, authorSurname) { }
        public int? NumberOfPages { get; set; }

    }
}
