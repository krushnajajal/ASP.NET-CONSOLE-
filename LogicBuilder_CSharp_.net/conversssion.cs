using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalassi1
{
    internal class conversssion
    {
        public void q4()
        {
            double km;
            Console.WriteLine("Enter Kilometer");
            km = Convert.ToDouble(Console.ReadLine());
            double meter = km * 1000;
            double cm = meter * 1000;
            double inch = cm / 2.5;
            double feet = inch / 12;
            Console.WriteLine("data converted\n\nmeter {0}\ncm {1}\ninch {2}\nfeet {3} ", meter, cm, inch, feet);
        }

    }
}
