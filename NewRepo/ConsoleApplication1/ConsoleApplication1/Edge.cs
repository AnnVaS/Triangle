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
            this.pointA.coordinateX = pointA.coordinateX;
            this.pointA.coordinateY = pointA.coordinateY;
            this.pointB.coordinateX = pointB.coordinateX;
            this.pointB.coordinateY = pointB.coordinateY;
            
        }
        
        public double lenght = Math.Sqrt(Math.Pow(pointA.coordinateX - pointB.coordinateX, 2));


    }
}
