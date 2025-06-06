// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Boek boek = new Boek("De Avonturen van Tom Sawyer", "Mark Twain", 300);
class Boek
{
    public string Titel;
    public string Auteur;
    public int PaginaAantal;

    public Boek(string titel, string auteur, int paginaAantal)
    {
        Titel = titel;
        Auteur = auteur;
        PaginaAantal = paginaAantal;
    }

    public override string ToString()
    {
        return $"{Titel} - {Auteur} ({PaginaAantal} pagina's)";
    }
}