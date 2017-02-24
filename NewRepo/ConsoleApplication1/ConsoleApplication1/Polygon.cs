using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Polygon
    {
        static int figure;
        double perimeter;
        double area;
        public Point[] points = new Point[figure];

        public Polygon(Point[] points) //конструктор
        {
            for (int i = 0; i < points.Length; i++)
            {
                this.points[i] = points[i];
            }
        }
        public double Perimeter(Edge[] edges) //убрала "perimeter"
        {
            for (int i = 0; i < edges.Length; i++)
            {
                double edgePolygon = edges[i].Lenght();//вызывается функция из edge  и находится длина
                perimeter += edgePolygon;

            }
            return perimeter;
        }
        //находит площадь:
        public double Area() //убрала "double perimeter, double area"
        {
            for (int i = 0; i < points.Length; i++)
            {

            }
        }
    }
}
