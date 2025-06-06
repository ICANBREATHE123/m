// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Boek boek = new Boek("Alice in wonderland", "Lewis Caroll", 1000000000);
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

    public void toon()
    {
        Console.WriteLine(Titel);
        Console.WriteLine(Auteur);
        Console.WriteLine(PaginaAantal);
    }
    public void mening()
    {
        Console.WriteLine("ik haat boeken!!!!!");
    }
}