// ------------------------------
// OOP = Objekt Oarentierest Programmieren
// ------------------------------

using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace OOP;

class Schule // class ist fast das gleiche wie ein struct in c
{
    public string name; //member Variable oder Feld
    public int anzahlSchueler;
    public int anzahlLehrer;

    // non static Methode
    public int anzahlPersonen()
    {
        return anzahlLehrer + anzahlSchueler;
    }

    // ToString() Methode
    public override string ToString()
    {
        return $"Schule: {name}, Schüler: {anzahlSchueler}, Lehrer: {anzahlLehrer}";
    }
    
}

class Program
{
    static void Main(string[] args)
    {
        // die adresse vom zeiger schule muss gespeichert werden in einer Variable also htl
        Schule htl = new Schule(); //objekt erstellen oder (instanzieren) 
        htl.name = "HTL Braunau"; // Variable setzten 
        htl.anzahlLehrer = 100;
        htl.anzahlSchueler = 800;
        // aufruf der Methode anzhalPersonen()
        Console.WriteLine($"{htl.name} hat {htl.anzahlPersonen()} Personen");



        // Objekt für die HLW erstellen
        Schule hlw = new Schule();
        hlw.name = "HLW Braunau";
        hlw.anzahlSchueler = 600;
        hlw.anzahlLehrer = 80;

        Console.WriteLine($"{hlw.name} hat {hlw.anzahlPersonen()} Personen");

        //------------------
        int n=42;
        Console.WriteLine(n);
        Console.WriteLine(htl);
        Console.WriteLine(htl.ToString());

        
    }
}
