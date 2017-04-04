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
//            Find The Parity Outlier

//You are given an array(which will have a length of at least 3, but could be very large) containing integers. 
//The array is either entirely comprised of odd integers or entirely comprised of even integers except for a single integer N.
//Write a method that takes the array as an argument and returns N.

//For example:

//[2, 4, 0, 100, 4, 11, 2602, 36]

//Should return: 11

//[160, 3, 1719, 19, 11, 13, -21]

//Should return: 160


//* *Sum it up one number is not like the rest(odd vs even) find that number.

            //better solution
            var evenNumbers = numbers.Where(integer => integer % 2 == 0);
            var oddNumbers = numbers.Where(integer => integer % 2 == 1);
            return evenNumbers.Count() == 1 ? evenNumbers.First() : oddNumbers.First();

            //One Liner??
            //return numbers.Count(a => a % 2 == 1) > 1 ? numbers.Single(a => a % 2 == 0) : numbers.Single(a => a % 2 == 1);

            //My Example beaten by linq ;)
            //var output = numbers.Select(x => x % 2 == 0).ToList();
            //var even = 0;
            //var odd = 0;
            //foreach (var item in output)
            //{

            //    if (item == true) even++; else odd++;

            //}
            //foreach (var number in numbers)
            //{
            //    if (even > odd && number % 2 != 0)
            //    {
            //        Console.WriteLine("Found the odd number in a collection of even numbers " + number);
            //        return number;
            //    }
            //    if (odd > even && number % 2 == 0)
            //    {
            //        Console.WriteLine("Found the even number in a collection of odd numbers " + number);
            //        return number;
            //    }
            //}
            //return -1;

        }
    }
}
