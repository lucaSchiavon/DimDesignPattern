using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Strutturali.Adapter
{
   public class Point
    {
        public int X, Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override int GetHashCode()
        {
            unchecked { return (X*397)^Y; } 

        }
    }
}
