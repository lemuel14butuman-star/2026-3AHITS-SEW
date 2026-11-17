// ------------------------------
// Uebung_3_3_Apfelmaennchen
// ------------------------------
using System;
using SkiaSharp;

class PNGCreator
{
  string filename;
  SKBitmap bitmap;
  SKCanvas canvas;

  public PNGCreator(int width, int height, string filename)
  {
    bitmap = new SKBitmap(width, height);
    canvas = new SKCanvas(bitmap);
    canvas.Clear(SKColors.White);
    this.filename = filename;
  }
  public void SetPixel(float x, float y, SKColor color)
  {
    using (var paint = new SKPaint())
    {
      paint.Color = color;
      canvas.DrawRect(new SKRect(x, y, x + 1, y + 1), paint);
    }
  }

  public void Save()
  {
    // Save the bitmap as a PNG file
    using (var image = SKImage.FromBitmap(bitmap))
    using (var data = image.Encode(SKEncodedImageFormat.Png, 100))
    using (var stream = new System.IO.FileStream(filename, System.IO.FileMode.Create))
    {
      data.SaveTo(stream);
    }
  }

}

class Program
{

  static void Main(string[] args)
  {
    Console.WriteLine("[+]");
    Console.WriteLine("Having fun with mandelbrot set ...");
    CreateMandelbrot();
    string relativePath = "apfel.png";
    string absolutePath = Path.GetFullPath(relativePath);
    Console.WriteLine("apfel.png created!");
    Console.WriteLine($"Zum Öffnen im Terminal eingeben:\ncode {absolutePath}");
  }


  public static void CreateMandelbrot()
  {
    var pngCreator = new PNGCreator(800, 600, "apfel.png");

    int steps_x = 800;
    int steps_y = 600;

    double start_x = -2;
    double start_y = 1.1;
    double end_x = 1.1;
    double end_y = -1.1;
    double step_x = (end_x - start_x) / steps_x;
    double step_y = (end_y - start_y) / steps_y;

    float png_x = 0.0F;
    float png_y = 0.0F;

    for (double y = start_y; y > end_y; y += step_y, png_y += 1.0F)
    {
      png_x = 0.0F;
      for (double x = start_x; x < end_x; x += step_x, png_x += 1.0F)
      {
        Complex c = new Complex(x, y);
        Complex z = new Complex(0, 0);
        double r = 0; // distance
        int cnt = 100;
        while (cnt-- > 0 && r <= 2)
        {
          z = z.Times(z);
          z = z.Plus(c);
          r = z.Abs();
        }
        if (cnt == -1)
        {
          pngCreator.SetPixel(png_x, png_y, SKColors.Black);
        }
        else if (cnt < 70)
        {
          pngCreator.SetPixel(png_x, png_y, SKColors.Red);
        }
        else if (cnt < 85)
        {
          pngCreator.SetPixel(png_x, png_y, SKColors.Green);
        }
        else if (cnt < 90)
        {
          pngCreator.SetPixel(png_x, png_y, SKColors.Blue);
        }
        else
        {
          //outside
        }
      }
    }
    pngCreator.Save();
  }
}
