using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Learning.MTA.Chapter_1;
using Learning.MTA.Chapter_2;
using Learning.MTA.Chapter_3;
using Learning.CSharpTechniques;
using Interfaces;
using Learning.TESTS;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {

            //Chapter 1 of the MTA book
            Chapter1Overview.MTAChap1();

            //Chapter 1 Assessments
            Chapter1Overview.MTAScenario1();

            //Chapter 2 of the MTA book
            Chapter2Overview.MTAChap2();

            //Chapter 3 of the MTA book
            Chapter3Overview.MTAChap3();

            //Chapter 3S Assessments
            Chapter3Overview.MTAScenario3();

        }
    }
}
