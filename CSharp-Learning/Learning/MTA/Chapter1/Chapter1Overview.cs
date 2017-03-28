using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Learning.MTA.Chapter1;

namespace Learning.MTA.Chapter_1
{
    class Chapter1Overview
    {    
        public static void MTAChap1()
        {
            //Example problems in the book
            Chapter1Examples.Example1If(10);
            Chapter1Examples.Example2Case(10, 20, '+');
            Chapter1Examples.Example3While();
            Chapter1Examples.Example4DoWhile();
            Chapter1Examples.Example5For();
            Chapter1Examples.Example6ForEach();
            Chapter1Examples.Example7RecursionFactorial(5);
            Chapter1Examples.Example8Exception();
            Chapter1Examples.Example9TryCatchFinally();
        }

        public static void MTAScenario1()
        {
            Chapter1Scenarios.Scenario1(50);
            Chapter1Scenarios.Scenario2(10);
            Chapter1Scenarios.Scenario3(50, 10);            
            Chapter1Scenarios.Scenario4(20, 0);                
        }
    }
}
