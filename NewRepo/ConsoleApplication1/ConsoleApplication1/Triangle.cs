using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Triangle
    {
        public Point[] points = new Point[3];
                
        public Triangle(Point[] points)
        {
            this.points = points;
            for (int i = 0; i < points.Length; i++)
            {
                this.points[i] = points[i];
            }
        }
        

        
    }
}
