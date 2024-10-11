using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace futasMarkusB
{
    internal class Program
    {
        static void Main(string[] args)
        {
           


        {
            
            {
                double v0;

                // Kérjük be a kezdő sebességet
                do
                {
                    Console.Write("Kérlek, add meg a futó kezdő sebességét (3.00 - 5.00 m/s): ");
                } while (!double.TryParse(Console.ReadLine(), out v0) || v0 < 3.00 || v0 > 5.00);

                // Sebesség kiírása
                for (int d = 0; d <= 100; d += 10)
                {
                    double v;

                    if (d <= 50)
                    {
                        // Gyorsulás szakasz
                        v = v0 + (2.0 * (d / 50.0) * (5.0 - v0)); // Egyszerűsített gyorsulás
                    }
                    else
                    {
                        // Lassulás szakasz
                        v = 5.0 - (5.0 - v0) * ((d - 50) / 50.0);
                    }

                    // Átváltás km/h-ba
                    double v_kmh = v * 3.6;
                    Console.WriteLine($"A {d} méternél a futó sebessége: {v_kmh:F2} km/h");
                }
            }
        }

    }
}
}
