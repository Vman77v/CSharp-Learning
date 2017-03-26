using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.MTA.Chapter1
{
    class Chapter1Scenarios
    {
        public static void Scenario1(int n)
        {
            int Discount;
            if (n < 10)
            {
                Discount = 5;
            }
            else if (n < 50)
            {
                Discount = 10;
            }
            else if (n < 100)
            {
                Discount = 15;
            }
            else
            {
                Discount = 20;
            }
            Console.WriteLine("The discount based on your quantity is {0}%", Discount);
        }

        public static int Scenario2(int n)
        {
            int orig = n;
            int fact = 1;
            while (n > 1)
            {
                fact *= n;
                n--;
            }
            Console.WriteLine("The factorial of {0} is {1}", orig, fact);
            return fact;
        }

        public static int Scenario3(int a, int b)
        {
            //TODO
            //need to catch arithmatic errors, casting, or data type conversions
            try
            {
                int result = a / b;
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public static int Scenario4(int n)
        {
            //needs work still arithmetic not setup correctly
            //take in a integer and counts the siginifcant digits in it and uses recursion;         
            if (n == 1)
            {
                //base case
                return n;
            }
            else
            {
                //recursive class
                return n / Scenario4(n/10);
            }

        }
    }
}
