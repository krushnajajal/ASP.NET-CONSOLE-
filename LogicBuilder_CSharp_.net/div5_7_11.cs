using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalassi1
{
    internal class div5_7_11
    {
        public void q8()
        {
            int a;
            Console.WriteLine("Enter Value");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 5 == 0)
            {
                Console.WriteLine("Multiple of 5");
            }
            else
            {
                Console.WriteLine("NOT Multiple of 5");
            }
            if (a % 7 == 0 && a % 11 != 0)
            {
                Console.WriteLine("The number is divisible by 7 but NOT by 11");
            }
            else
            {
                Console.WriteLine("The number does NOT meet the condition for 7 and 11 thing");
            }
        }
    }
}
