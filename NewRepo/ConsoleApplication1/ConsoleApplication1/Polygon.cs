using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Polygon
    {
        //public static int figure;
        double perimeter;
        double area;
        static int fig;

        public Point[] points = new Point[fig];
        
        public Polygon(Point[] points) //конструктор
        {
            for (int i = 0; i < fig; i++)
            {
                this.points[i] = points[i];
            }
        }
        public double Perimeter(Edge[] edges) 
        {
            for (int i = 0; i < edges.Length; i++)
            {
                double edgePolygon = edges[i].Lenght();//вызывается функция из edge  и находится длина
                perimeter += edgePolygon;

            }
            return perimeter;
        }
        //находит площадь:
        public double Area(Point[] points) 
        {
            double one = 0;
            double two = 0;
            double time;
            for (int i = 0; i < points.Length; i++)
            {
                if (i < points.Length - 1)
                {
                    time = points[i].coordinateX * points[i + 1].coordinateY;
                    one += time;
                }
                else
                {
                    time = points[i].coordinateX * points[0].coordinateY;
                    one += time;
                }
            }
            for (int i = 0; i < points.Length; i++)
            {
                if (i < points.Length-1)
                {
                    time = points[i].coordinateY * points[i + 1].coordinateX;
                    two += time;
                }
                else
                {
                    time = points[i].coordinateY * points[0].coordinateX;
                    two += time;
                }
            }
            return area = (one - two) / 2;
        }
    }
}
