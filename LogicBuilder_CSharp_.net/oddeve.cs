using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalassi1
{
    internal class oddeve
    {
        public void q10()
        {
            int a, b, sum = 0;
            Console.WriteLine("enter value of A=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter value of B=");
            b = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 1)
            {
                Console.WriteLine("Enter Even Number");
            }
            else
            {
                sum = a + b;
                Console.WriteLine("Addition of a and b= " + sum);
            }
        }
    }
}
