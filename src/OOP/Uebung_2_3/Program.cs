// ------------------------------
// Uebung_2_3
// ------------------------------

namespace Uebung_2_3;

class Bankkonto
{
    public double kontostand;
    public double zinsatz;
    public string kontoinhaber;

    public Bankkonto() : this(500, 0.5, "Mohamed Ali")
    {

    }
    public Bankkonto(double kontostand, double zinsatz, string kontoinhaber)
    {
        this.kontostand = kontostand;
        this.zinsatz = zinsatz;
        this.kontoinhaber = kontoinhaber;
    }

    public void ein(int einzahlung)
    {
        kontostand+= einzahlung;
    }

    public void aus(int auszahlung)
    {
        kontostand-=auszahlung;
    }

    public double Jahresabschluss()
    {
        double Zinsen = kontostand * (zinsatz/100);
        kontostand+= Zinsen;
        return Zinsen;
    }

    public void zinsplus(int plus)
    {
        zinsatz += plus/10;
    }

    public void zinsminus(int minus)
    {
        zinsatz -= minus/10;
    }

    public override string ToString()
    {
        return $"{kontoinhaber} , {kontostand} , {zinsatz}";
    }
}
class Program
{
    static void Main(string[] args)
    {
        Bankkonto Rich = new Bankkonto();


        Console.WriteLine(Rich.ToString());
    }
}
