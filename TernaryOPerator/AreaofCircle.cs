using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOPerator
{
    internal class AreaofCircle
    {
        static void Main(string[] args)
        {
            int r;
            double area;
            Console.WriteLine("Enter Radious");
            r = Convert.ToInt32(Console.ReadLine());
            area = 3.14 * r * r;
            Console.WriteLine("Area of circle=" + area);
        }
    }
}
