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
            this.points = new Point[points.Length];
            for (int i = 0; i < points.Length; i++)
            {
                this.points[i] = points[i];
            }
        }

        public double Perimeter(Edge[] edges, double perimeter)
        {
            for (int i = 0; i < edges.Length; i++)
            {
                double edgeTriangle = edges[i].Lenght();//вызывается функция из edge  и находится длина
                perimeter += edgeTriangle;
                
            }
            return perimeter;
        }

        public double Area(Edge[] edges, double perimeter, double area)
        {
            //area = корень(p*(p-a)*(p-b)*(p-c))
            double polPerimeter = perimeter / 2;
            double time;                //разность полупериметра и стороны
            double proiztimes=1;          //произведение временных переменных
            for (int i = 0; i < edges.Length; i++)
            {
                time = polPerimeter - edges[i].Lenght();//функция
                proiztimes *= time;

            }
            area = Math.Sqrt(proiztimes * polPerimeter);
            return area;
        }
        public bool Right(Edge[] edges)
        {
            if (edges[0].Lenght() == Math.Sqrt(Math.Pow(edges[1].Lenght(), 2) + Math.Pow(edges[2].Lenght(), 2)))
            {
                return true;
            }
            if (edges[1].Lenght() == Math.Sqrt(Math.Pow(edges[2].Lenght(), 2) + Math.Pow(edges[0].Lenght(), 2)))
            {
                return true;
            }
            if (edges[2].Lenght() == Math.Sqrt(Math.Pow(edges[0].Lenght(), 2) + Math.Pow(edges[1].Lenght(), 2)))
            {
                return true;
            }
            else return false;
        }
        public bool Isosceles(Edge[] edges)
        {
            if (edges[0] == edges[1] || edges[1] == edges[2] || edges[2] == edges[0])
            {
                return true;
            }
            else return false;
        }
        public void VerificationPoints()
        {

        }




    }
}
