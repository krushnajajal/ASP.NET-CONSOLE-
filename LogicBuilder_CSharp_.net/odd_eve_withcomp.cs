using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalassi1
{
    internal class odd_eve_withcomp
    {
        public void q6()
        {
            int a, b, c;
            Console.WriteLine("Enter A:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter C:");
            c = Convert.ToInt32(Console.ReadLine());

            var large = new largerst();
            large.largest(a, b, c);
            large.smallesst(a, b, c);


            Console.ReadKey();
        }
    }

    class largerst
    {

        public void largest(int a, int b, int c)
        {
            int largest;
            if (a > b && a > c)
            {
                Console.WriteLine("{0}=A is larger ", a);
                largest = a;

            }
            else if (b > a && b > c)
            {
                largest = b;
                Console.WriteLine("{0}=B is larger ", b);
            }
            else
            {
                largest = c;
                Console.WriteLine("{0}=C is larger ", c);
            }
            if (largest % 2 == 0)
            {
                Console.WriteLine("{0}=A is even ", largest);
            }
            else
            {
                Console.WriteLine("{0}=A is odd ", largest);
            }
        }

        public void smallesst(int a, int b, int c)
        {
            int smallest;
            if (a < b && b < c)
            {
                Console.WriteLine("{0} A is smallest of all", a);
                smallest = a;
            }
            else if (b > a && b > c)
            {
                smallest = b;
                Console.WriteLine("{0}=B is smallest ", b);
            }
            else
            {
                smallest = c;
                Console.WriteLine("{0}=C is smallest ", c);
            }
            if (smallest % 2 == 1)
            {
                Console.WriteLine("{0}=A is odd ", smallest);
            }
            else
            {
                Console.WriteLine("{0}=A is even ", smallest);
            }
        }

    }
}
