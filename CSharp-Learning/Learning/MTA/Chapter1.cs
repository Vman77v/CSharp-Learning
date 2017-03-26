using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.MTA
{
    class Chapter1
    {
        public static void Example1(int n)
        {
            if (n < 10)
            {
                Console.WriteLine("n is less than 10");
            }

            else if (n < 20)
            {
                Console.WriteLine("n is less than 20");
            }

            else if (n < 30)
            {
                Console.WriteLine("n is less than 30");
            }

            else
            {
                Console.WriteLine("n is greater than 30");
            }
        }

        public static void Example2(int op1, int op2, char opr)
        {
            int result;
            switch (opr)
            {
                case '+':
                    result = op1 + op2;
                    break;
                case '-':
                    result = op1 - op2;
                    break;
                case '*':
                    result = op1 * op2;
                    break;
                case '/':
                    result = op1 / op2;
                    break;
                default:
                    Console.WriteLine("Unkown Operator");
                    return;                    
            }
            Console.WriteLine("Result {0}", result);
            return;
        }
    }
}