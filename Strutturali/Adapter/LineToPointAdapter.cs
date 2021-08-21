using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DesignPatternDimitri.Strutturali.Adapter
{
    public class LineToPointAdapter//:Collection<Point>
    {
        //private static int count =0;
        private static Dictionary<int,List<Point>> cache 
            =new Dictionary<int,List<Point>>();
        private int hash;
        public LineToPointAdapter(Line line)
        {
            hash = line.GetHashCode();
            if (cache.ContainsKey(hash)) return;

            List<Point> points = new List<Point>();

            int left = Math.Min(line.Start.X, line.End.X);
            int right = Math.Max(line.Start.X, line.End.X);

            int top = Math.Min(line.Start.Y, line.End.Y);
            int bottom = Math.Max(line.Start.Y, line.End.Y);

            if (right - left == 0)
            {
                for (int y = top; y <= bottom; ++y)
                {
                    points.Add(new Point(left, y));
                    //Add(new Point(left, y));
                }
               
            }
            else if (line.End.Y - line.Start.Y == 0)
            {
                for (int x = left; x <= right; ++x)
                {
                    points.Add(new Point(x, top));
                    //Add(new Point(x, top));
                }
            }
            cache.Add(hash, points);
        }
        public IEnumerator<Point> GetEnumerator()
        {
            return cache[hash].GetEnumerator();
        }
    }
}
