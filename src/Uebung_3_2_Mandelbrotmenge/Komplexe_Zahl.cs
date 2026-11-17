using System;

public class Complex {
    private readonly double re;   // Realteil
    private readonly double im;   // Imaginärteil

    public Complex(double real, double imag) {
        this.re = real;
        this.im = imag;
    }

    public override string ToString() {
        return $" {Math.Round(re,4)} + {Math.Round(im,4)}i";
    }

    public double Abs() {
        return Math.Sqrt(re * re + im * im); // Math.Sqrt ist für die wurzel
    }

    public Complex Plus(Complex b) {
        return new Complex(re + b.re, im + b.im);
    }

    public Complex Times(Complex b) {
        return new Complex
        (
            re * b.re - im * b.im,
            re * b.im + im * b.re
        );
    }
}

