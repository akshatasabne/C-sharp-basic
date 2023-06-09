using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOPerator
{
    internal class MarksOfsub
    {
        static void Main(string[] args)
        {
            int sub1, sub2, sub3, sub4, sub5, total;
            double percentage;
            Console.WriteLine("Enter Marks of sub1");
            sub1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks of sub2");
            sub2 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Enter Marks of sub3");
            sub3= Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("Enter Marks of sub4");
            sub4= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks of sub5");
            sub5=Convert.ToInt32(Console.ReadLine()));       
            total=sub1+sub2+sub3+sub4+sub5;
            Console.WriteLine("Total Marks" + total);
            percentage = totl / 5;
            Console.WriteLine("percentage=" + percentage);
        }
    }
}
