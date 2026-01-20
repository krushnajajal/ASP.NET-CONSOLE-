using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalassi1
{
    internal class swappping
    {
        public void q3()
        {
            var sw = new swapping();
            sw.swapp();
            Console.ReadKey();
        }
    }
    class swapping
    {
        int a, b;
        public void swapp()
        {
            Console.WriteLine("Enter the value of a ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of b ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("before swapping=" + "{0} , {1}", a, b);

            a += b;
            b = a - b;
            a -= b;
            Console.WriteLine("after swapping= " + "{0} , {1}", a, b);
        }
    }

}
