using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.TESTS
{
    class Outlier
    {
        public static int Find(int[] numbers)
        {
            var output = numbers.Select(x => x % 2 == 0).ToList();
            var even = 0;
            var odd = 0;
            foreach (var item in output)
            {

                if (item == true) even++; else odd++;

            }
            foreach (var number in numbers)
            {
                if (even > odd && number % 2 != 0)
                {
                    Console.WriteLine("Found the odd number in a collection of even numbers " + number);
                    return number;
                }
                if (odd > even && number % 2 == 0)
                {
                    Console.WriteLine("Found the even number in a collection of odd numbers " + number);
                    return number;
                }
            }
            return -1;
        }
    }
}
