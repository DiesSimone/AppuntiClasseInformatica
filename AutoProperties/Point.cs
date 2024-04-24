using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProperties
{
    public class Point
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public Point():this(0.0,0.0) 
        { }

        public double X { get; set; }
        public double Y { get; set; }

    }
}
