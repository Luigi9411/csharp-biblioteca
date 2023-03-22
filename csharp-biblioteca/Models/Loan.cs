using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca.Models
{
    internal class Loan
    {
        
        public class Prestito
        {
            public Prestito(Document document, User user)
            {
                Document = document;
                User = user;
            }

            public DateTime? LoanDate { get; set; }
            public DateTime? ReturnDate { get; set; }
            public Document Document { get; set; }
            public User User { get; set; }
        }
    }
}
