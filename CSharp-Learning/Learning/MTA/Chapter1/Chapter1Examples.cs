using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.MTA
{
    internal class Chapter1Examples
    {
        public static void Example1If(int n)
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

        public static void Example2Case(int op1, int op2, char opr)
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

        public static void Example3While()
        {
            int i = 1;
            while (i <=5)
            {
                Console.WriteLine("the value of i = {0}", i);
                i++;
            }
        }

        public static void Example4DoWhile()
        {
            int i = 1;
            do
            {
                Console.WriteLine("The value of i = {0}", i);
                i++;
            } while (i <=5);
        }

        public static void Example5For()
        {
            for(int i = 1; i<= 5; i++)
            {
                Console.WriteLine("This value of i = {0}", i);
            }
        }

        public static void Example6ForEach()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (var i in numbers)
            {
                Console.WriteLine("The value of i = {0}", i);
            }
        }

        public static int Example7RecursionFactorial(int n)
        {
            //This method is a good example of recusion where a method calls itself to compute a result 
            if (n == 0)
            {
                //base case
                return 1;
            }
            else
            {
                //recursive class
                return n * Example7RecursionFactorial(n - 1);
            }
        }

        public static void Example8Exception()
        {
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(@"C:\data.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Example9TryCatchFinally()
        {
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(@"C:\data.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
    }
}