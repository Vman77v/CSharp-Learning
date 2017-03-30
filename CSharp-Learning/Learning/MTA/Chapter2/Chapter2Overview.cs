using Learning.MTA.Chapter2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.MTA.Chapter_2
{
    class Chapter2Overview
    {
        public static void MTAChap2()
        {
            Rectangle rect = new Rectangle()
            {
                Length = 10.0,
                Width = 20.0
            };
            double area = rect.GetArea();
            Console.WriteLine("Area of Rectangle : " + area);                              
        }
    }
}
