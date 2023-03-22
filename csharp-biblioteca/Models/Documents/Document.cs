using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca.Models.Documents
{
    internal class Document
    {

    public string Id { get; set; } = "";

    public string Title { get; set; } = "";
    public string Year { get; set; } = "";
    public string Sector { get; set; } = "";
    public string Shelf { get; set; } = "";
    public string Author { get; set; } = "";

    public const string SectorHistory = "Storia";
    public const string SectorMath = "Matematica";
    public const string SectorEconomy = "Economia";

    public Document(string id, string title, string year, string sector, string shelf, string authorName, string authorSurname)
    {
        Id = id;
        Title = title;
        Year = year;
        SetSector(sector);
        Shelf = shelf;
        Author = $"{authorName} {authorSurname}";
    }

        public void SetSector(string sector)
        {
            if (sector == SectorHistory || sector == SectorMath || sector == SectorEconomy)
            {
                Sector = sector;
            }
            else
            {
                throw new ArgumentException($"Settore non valido: {sector}");
            }
        }
    }