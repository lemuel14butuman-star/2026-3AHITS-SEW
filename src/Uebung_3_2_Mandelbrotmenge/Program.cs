// ------------------------------
// Mandelbrotmenge
// ------------------------------
 
using System;

class Program
{
    static bool Mandelbrot(Complex c)
    {
        Complex z = new Complex(0, 0);

        for (int i = 0; i < 100; i++)
        {
            z = z.Times(z).Plus(c);

            if (z.Abs() > 2)
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        Complex a = new Complex(-1.2, 0.1);
        Complex b = new Complex(-1.2, 0.5);
        Complex c = new Complex(0.1, -0.6);
        Complex d = new Complex(0, 0.8);

        Console.WriteLine(a + " : " + Mandelbrot(a));
        Console.WriteLine(b + " : " + Mandelbrot(b));
        Console.WriteLine(c + " : " + Mandelbrot(c));
        Console.WriteLine(d + " : " + Mandelbrot(d));
    }
}