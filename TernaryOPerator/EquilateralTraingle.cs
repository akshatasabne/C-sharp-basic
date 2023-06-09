using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOPerator
{
    internal class EquilateralTraingle
    {
        static void Main(string[] args)
        {
            int side;
            double area;
            Console.WriteLine("enter side");
            side=Convert.ToInt32(Console.ReadLine());
            area = (1.732 / 4) * side * side;
            Console.WriteLine("area of equilateral tringle");
        }
    }
}
