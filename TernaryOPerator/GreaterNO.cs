using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOPerator
{
    internal class GreaterNO
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("enter num1")
                num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2");
            num2=Convert.ToInt32(Console.ReadLine());
            if(num1>num2)
            {
                Console.WriteLine("greater number");

            }
            else
            {
                Console.WriteLine("smaller number");

            }


        }
    }
}
