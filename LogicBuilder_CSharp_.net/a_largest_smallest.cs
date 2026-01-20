using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalassi1
{
    internal class a_largest_smallest
    {
        public void q13()
        {
            float[] a = new float[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter value of a[{0}]:", i);
                a[i] = Convert.ToSingle(Console.ReadLine());

            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("a[{0}] = {1}", i, a[i]);
            }
            float max = a[0];
            float min = a[0];

            for (int i = 1; i < 5; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine("MAXIMUM ={0} \nMINIMUM = {1}", max, min);

            Console.ReadKey();
        }

    }
}
