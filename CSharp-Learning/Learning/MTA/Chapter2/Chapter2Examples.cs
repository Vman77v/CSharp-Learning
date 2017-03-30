using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.MTA.Chapter2
{
    class Rectangle
    {
        //rule of thumb, data field of a class are private see below two lines
        private double length;
        private double width;

        //to allow access we have public properties that check data values for validity
        //public double Length
        //{
        //get
        //    {
        //        return length;
        //    }
        //set
        //    {
        //        length = value;
        //    }
        //}

        //public double Width
        //{
        //    get
        //    {
        //        return width;
        //    }
        //    set
        //    {
        //        width = value;
        //    }
        //}

        //auto implemented properties - don't need all the code above yay!
        public double Length { get; set; }
        public double Width { get; set; }

        public double GetArea()
        {
            return length * width;

        }
    }
}
