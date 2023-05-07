using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp3_var10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tdX:");
            double tdX = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("p:");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("n:");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("xnul:");
            double xnul = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("xk:");
            double xk = Convert.ToDouble(Console.ReadLine());

            double J = 0;
            while (xnul <= xk)
            {
                double s1 = (0.5 * (Math.Cos(a)) + (Math.Pow(x, a)));
                double s2 = Math.Tan(Math.Pow((Math.Pow(a, 2)) + p - n, (1.0 / 3.0)));
                J = s1 / s2 + (Math.Pow(a, 3) * Math.Pow(2.7, x));
                Console.WriteLine("xnul:" + xnul + "=" + Math.Round(J, 4));
                xnul = xnul + tdX;
            }
           // xnul = tdX;
        }
    }
}

