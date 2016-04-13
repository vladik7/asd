using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
           var a = Console.ReadLine();
           var b = Console.ReadLine();
           var c = Console.ReadLine();
            double a1 = 0;
            double b1 = 0;
            double c1 = 0;
            if (double.TryParse(a, out a1) && double.TryParse(b, out b1) && double.TryParse(c, out c1))
            {
                double d = b1 * b1 - 4 * a1 * c1;
                if (d >= 0)
                {
                    if (d > 0)
                    {
                        double x1 = (-b1+Math.Pow(d,0.5))/(2*a1);
                        double x2 = (-b1 - Math.Pow(d, 0.5)) / (2 * a1);
                        Console.WriteLine("x1 = {0}",x1);
                        Console.WriteLine("x2 = {0}",x2);
                    }
                    else
                    {
                        double x1 = (-b1 + Math.Pow(d, 0.5)) / (2 * a1);
                        Console.WriteLine("x1 = x2 = {0}",x1);
                    }
                }
                else
                {
                    Console.WriteLine("Kornei net");
                }
            }
            else
            {
                Console.WriteLine("Vvedi chisla");
            }
        }
    }
}
