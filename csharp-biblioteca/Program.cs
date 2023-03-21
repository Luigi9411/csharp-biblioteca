public class Library
{

}

public class User
{
    public string Lastname { get; set; } = "";
    public string Name { get; set; } = "";
    public string Email { get; set; } = "";
    public string Password { get; set; } = "";
    public string Phonenumber { get; set; } = "";

    public User (string lastname, string name, string email, string password, string phonenumber)
    {
        Lastname = lastname;
        Name = name;
        Email = email;
        Password = password;
        Phonenumber = phonenumber;
    }
}


public class Document
{
    public string Id { get; set; } = "";
    public string Year { get; set; } = "";
    public string Sector { get; set; } = "";
    public string Shelf { get; set; } = "";
    public string Author { get; set; } = "";

    public const string SectorHistory = "Storia";
    public const string SectorMath = "Matematica";
    public const string SectorEconomy = "Economia";

    public Document(string id, string year, string sector, string shelf, string authorName, string authorSurname)
    {
        Id = id;
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

public class Book : Document
{
    public int NumberOfPages { get; set; } 
    
    public Book(string id, string year, string sector, string shelf, string authorName, string authorSurname, int numberOfPages) : base(id, year, sector, shelf, authorName, authorSurname)
    {
        this.NumberOfPages = numberOfPages;
    }

    public override string ToString()
    {
        return base.ToString() + NewLine
            + $"posti auto: {NumberOfPages}";
    }
}

public class Dvd : Document
{
    public int Duration { get; set; }

    public Dvd(string id, string year, string sector, string shelf, string authorName, string authorSurname, int duration) : base(id, year, sector, shelf, authorName, authorSurname)
    {
        this.Duration = duration;
    }

    public override string ToString()
    {
        return base.ToString() + NewLine
            + $"posti auto: {Duration}";
    }
}