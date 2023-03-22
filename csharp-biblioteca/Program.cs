using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using csharp_biblioteca.Models;
using csharp_biblioteca.Models.Documents;


namespace csharp_biblioteca
{
    
    public class Library
    {
        readonly List<Document> documents = new();
        readonly List<User> users = new();
        readonly List<Loan> loans = new();

        public void AddDocument(Document document) => documents.Add(document);
        public void AddUser(User user) => users.Add(user);
        public void AddLoan(Loan loan) => loans.Add(loan);


        public Document? SearchDocumentById(string id) => documents.FirstOrDefault(document => document.Id == id);
        public IEnumerable<Document> SearchDocumentByTitle(string title) => documents.Where(document => document.Title == title);

        public IEnumerable<Loan> SearchLoan(string nameUser, string lastNameUser) =>
            loans.Where(loan => loan.User.Name == nameUser && loan.User.Lastname == lastNameUser);
    }
}