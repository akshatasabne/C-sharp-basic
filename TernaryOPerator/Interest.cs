using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOPerator
{
    internal class Interest
    {
        static void Main(string[] args)
        {
            double p, t, r, i, ci;
            Console.WriteLine("principal amount");
            p= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("time");
            t= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("rate of interest");
            r =  Convert.ToDouble(Console.ReadLine());
            i = (p * r * t) / 100;
            Console.WriteLine("interst=" + i);
            ci = p + i;
            Console.WriteLine("compound interst=" + ci);
            Console.WriteLine( "demo");

        }

            
        }
    }