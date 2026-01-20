using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalassi1
{
    internal class arr_display
    {
        public void q12()
        {
            float[] a = new float[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter value of a[{0}]:", i);
                a[i] = Convert.ToSingle(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("a[{0}] = {1}", i, a[i]);
            }
            Console.ReadKey();
        }
    }
}
