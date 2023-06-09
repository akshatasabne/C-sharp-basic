using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOPerator
{
    internal class fartocel
    {
        double cel, far;
        Console.WriteLine("Enter Celcious=");
            cel = Convert.ToDouble(Console.ReadLine());
            far = (cel* 9 / 5) + 32;
            Console.WriteLine("Farehenhit=" + far);
    }
}
