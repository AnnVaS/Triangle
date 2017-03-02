using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Polygon
    {        
        double area;

        public Point[] points;
        public Edge[] edges;       

        public Polygon(Point[] points, Edge[] edges) //конструктор
        {
            this.points = points;
            this.edges = edges;
        }
        public double Perimeter()
        {
            double perimeter = 0;
            for (int i = 0; i < edges.Length; i++)
            {                
                perimeter += edges[i].SearchLenght;
            }
            return perimeter;
        }
        //находит площадь:
        public double Area()
        {
            double one = 0;
            double two = 0;            
            for (int i = 0; i < points.Length; i++)
            {
                if (i < points.Length - 1)
                {                    
                    one += points[i].coordinateX * points[i + 1].coordinateY;
                }
                else
                {                    
                    one += points[i].coordinateX * points[0].coordinateY;
                }
            }
            for (int i = 0; i < points.Length; i++)
            {
                if (i < points.Length - 1)
                {                    
                    two += points[i].coordinateY * points[i + 1].coordinateX;
                }
                else
                {                    
                    two += points[i].coordinateY * points[0].coordinateX;
                }
            }
            return area = (one - two) / 2;
        }
        // проверяет, не совпадают ли точки
        public bool VerificationPoints()
        {
            for (int i = 0; i < points.Length; i++)
            {
                if (i < points.Length - 1)
                {
                    if (points[i].coordinateX == points[i + 1].coordinateX && points[i].coordinateY == points[i + 1].coordinateY)
                    {
                        return true;
                    }
                }
                else
                {
                    if (points[i].coordinateX == points[0].coordinateX && points[i].coordinateY == points[0].coordinateY)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}