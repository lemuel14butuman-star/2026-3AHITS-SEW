namespace Uebung_3_1;

class Program
{
    static void Main(string[] args)
    {
        Complex z1 = new Complex(0.2,-0.3);
        Complex z2 = new Complex(-0.1,0.25);

        Complex c = z1.Plus(z2); // c =  0.1 - 0.05i
        Console.WriteLine("Addieren:"+ c.ToString());

        Complex d = z2.Times(z1); // 0.055 + 0.08i
        Console.WriteLine("Multiplizieren:"+ d.ToString());

        double r = c.Abs(); // 0.1118
        Console.WriteLine("Absolut:"+ r.ToString());

    }
}