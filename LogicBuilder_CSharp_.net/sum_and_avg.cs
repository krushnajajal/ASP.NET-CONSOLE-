using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalassi1
{
    internal class sum_and_avg
    {
        public void q14()
        {
            float[] a = new float[8];
            float sum = 0;
            float avg;

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Enter value of a[{0}]:", i);
                a[i] = Convert.ToSingle(Console.ReadLine());
                sum += a[i];
            }
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("a[{0}] = {1}", i, a[i]);
            }
            avg = sum / 8;
            Console.WriteLine("Sum of 8 elements = {0}", sum);
            Console.WriteLine("avg of 8 elements = {0}", avg);
        }
    }
}
