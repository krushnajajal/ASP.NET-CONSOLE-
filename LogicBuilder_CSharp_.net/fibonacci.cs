using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalassi1
{
    internal class fibonacci
    {
        public void q11()
        {
            int a = 0, b = 1, c;

            Console.WriteLine("Fibonacci series up to 300:");

            Console.WriteLine(a);
            Console.WriteLine(b);

            c = a + b;

            while (c <= 300)
            {
                Console.WriteLine(c);
                a = b;
                b = c;
                c = a + b;
            }
       }
    }
}
