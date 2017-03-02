using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Edge
    {
        public Point pointA;
        public Point pointB;

        public Edge(Point pointA, Point pointB)
        {
            this.pointA = pointA;
            this.pointB = pointB;

        }
        public double SearchLenght
        {
            get
            {
                return Math.Sqrt(Math.Pow(pointB.coordinateX - pointA.coordinateX, 2) + Math.Pow(pointB.coordinateY - pointA.coordinateY, 2));
            }
        }


    }
}