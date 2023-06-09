using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOPerator
{
    internal class PerimOfRect
    {
        static void Main(string[] args)
        {
            int length, breadth, perimeter;
            Console.WriteLine("Enter length");
            length = Convert.ToInt32(Console.ReadLine()); ;
            Console.WriteLine("Enter breadth");
            breadth = Convert.ToInt32(Console.ReadLine());
        perimeter = 2*(length + breadth);
        Console.WriteLine("perimeter of rectangle=" + perimeter);
      
        }
    }
}
