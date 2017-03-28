using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Learning.MTA.Chapter_1;
using Learning.MTA.Chapter_2;
using Learning.MTA.Chapter_3;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Please enter Chapter integer from 1 to 3 to run code examples");
            var input = Console.ReadLine();
            
            if (input == "1")
            {                
                //Chapter 1 of the MTA book
                Chapter1Overview.MTAChap1();
            
                //Chapter 1 Assessments
                Chapter1Overview.MTAScenario1();                
            }

            if (input == "2")
            {
            //Chapter 2 of the MTA book
            Chapter2Overview.MTAChap2();

            //Chapter 2 Assessments
            Chapter2Overview.MTAScenario2();
            }

            if (input == "3")
            {
            //Chapter 3 of the MTA book
            Chapter3Overview.MTAChap3();

            //Chapter 3S Assessments
            Chapter3Overview.MTAScenario3();
            }
        }
    }
}
