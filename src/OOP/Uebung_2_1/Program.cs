
using System.Dynamic;
using System.Net.Security;

class Schulklasse
{
    public int schueler;
    public string name;


    public Schulklasse() : this("Strasser", 20)
    {

    }
    public Schulklasse(string klassenvorstand, int anzahlschueler)
    {
        this.name = klassenvorstand;
        this.schueler = anzahlschueler;
    }

    public void dazu()
    {
        schueler++;
    }

    public void raus(int minus)
    {
        schueler -= minus;
    }

    public void Klassenwechselnach(Schulklasse target)
    {
        schueler--;
        target.dazu();
    }

    // Ausgabe mit ToString
    public override string ToString()
    {
        return $"Schueler = {schueler} und der Klassenvorstand ist {name}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Schulklasse ahits = new Schulklasse();

        Schulklasse bhme = new Schulklasse("Hurensohn", 25);
        ahits.Klassenwechselnach(bhme);

        Console.WriteLine(ahits.ToString());

    }

}

