using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOPerator
{
    internal class Angle
    {
        static void Main(string[] args)
        {
            int first_angle, second_angle, third_angle;
            Console.WriteLine("Enter first angle");
            first_angle = Convert.ToInt32(Console.ReadLine());
            Console .WriteLine("Enter second angle);
            second_angle=Convert.ToInt32(Console.ReadLine()));
            third_angle = 360 - first_angle + second_angle;
            Console.WriteLine("third angle of triangle is" + third_angle);
        
        }
    }
}
