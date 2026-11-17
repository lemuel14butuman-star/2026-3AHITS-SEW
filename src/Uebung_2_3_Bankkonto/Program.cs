// ------------------------------
// OOP = Objekt Oarentierest Programmieren
// ------------------------------

using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace Konto;

class Kont // class ist fast das gleiche wie ein struct in c
{
    public string Kontoinhaber; //member Variable oder Feld
    public double Kontostand;
    public double Zinssatz;


    public Kont (string Kontoinhaber, double Kontostand, double Zinssatz)
    {
        this.Kontoinhaber = Kontoinhaber;
        this.Kontostand = Kontostand;
        this.Zinssatz = Zinssatz;
    }

    public ein (double einzahlung)
    {
        Kontostand+=einzahlung;
    }

    public aus (double auszahlung)
    {
        Kontostand+=auszahlung;
    }

    

    // ToString() Methode
    public override string ToString()
    {
        return $"Name des Kontoinhabers: {Kontoinhaber}, Zinssatz: {Zinssatz}, Kontostand: {Kontoinhaber}";
    }
    
}

class Program
{
    static void Main(string[] args)
    {
       Kont Lemuel = new Kont("lemuel", 2433.12, 2);


    }
}
