// ------------------------------
// Uebung_2_2
// ------------------------------

namespace Uebung_2_2;

class Rechteck
{
    public double Sb;
    public double Sa;

    public Rechteck() : this(10, 20)
    {

    }
    public Rechteck(double a, double b)
    {
        this.Sb = b;
        this.Sa = a;
    }

    public void resize()
    {
        if (Sa < Sb)
        {
            Sb -= Sa;
        }
        if (Sb < Sa)
        {
            Sa -= Sb;
        }

    }

    public void infalte(double Prozent)
    {
        Sa = Sa + Sa * (Prozent / 100);
        Sb = Sb + Sb * (Prozent / 100);
    }

    public double aspectratio()
    {
        return Sa / Sb;
    }

    public void setmaxside(double airy)
    {
        double ratio = aspectratio();
        if (Sa <= Sb)
        {
            Sb = airy;
            Sa = Sb * ratio;
        }
        if (Sb <= Sa)
        {
            Sa = airy;
            Sb = Sa / ratio;
        }

    }

    public double area()
    {
        return Sa * Sb;
    }

    public int tile(Rechteck target)
    {
        return (int)Math.Round(area() / target.area());
    }

    public override string ToString()
    {
        return $"Seite a = {Sa} , Seite b = {Sb}";
    }

}

class Program
{
    static void Main(string[] args)
    {
        Rechteck Monkey = new Rechteck();
        Rechteck Osman = new Rechteck(2, 1);


        Console.WriteLine("Es geht " + Monkey.tile(Osman) + " mal");
    }
}
