using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Square, 2. Rectangel, 3. Circle, 4. Kite, 5. Diamond");
            Console.WriteLine("Choose: ");
            int i = Convert.ToInt16(Console.ReadLine());
            switch (i)
            {
                case 1:
                    var sq = new Square();
                    Console.WriteLine("Side Value is: ");
                    sq.aturside(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Area is: " + sq.area());
                    Console.WriteLine("Around is: " + sq.around());
                    break;
                
                    case 2:
                    var pp = new Rectangle();
                    Console.WriteLine("Long value is:");
                    pp.setLong(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Wide value is:");
                    pp.setWide(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Rectangel Area is: " + pp.area());
                    Console.WriteLine("Rectangel Around is: " + pp.around());
                    break;
               /* case 3:
                    double r;
                    const double phi = 3.14;
                    double areaC;
                    double aroundC;
                    Console.WriteLine("Insert Radius: ");
                    r = Convert.ToInt16(Console.ReadLine());

                    areaC = phi * r * r;
                    aroundC = 2 * phi * r;

                    Console.WriteLine("Area: " + areaC);
                    Console.WriteLine("Around: " + aroundC);
                    break;*/


            }
        }
    }
}

