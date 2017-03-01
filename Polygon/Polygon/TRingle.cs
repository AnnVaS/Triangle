using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Triangle
    {
        double perimeter;
        double area;
        public Point[] points = new Point[3];

        public Triangle(Point[] points) //конструктор
        {
            //this.points = new Point[points.Length];
            for (int i = 0; i < points.Length; i++)
            {
                this.points[i] = points[i];
            }
        }
        //находит периметр:
        public double Perimeter(Edge[] edges)
        {
            for (int i = 0; i < edges.Length; i++)
            {
                double edgeTriangle = edges[i].Lenght();//вызывается функция из edge  и находится длина
                perimeter += edgeTriangle;

            }
            return perimeter;
        }
        //находит площадь:
        public double Area(Edge[] edges)
        {

            double polPerimeter = perimeter / 2;
            double time;                //разность полупериметра и стороны
            double proiztimes = 1;          //произведение временных переменных
            for (int i = 0; i < edges.Length; i++)
            {
                time = polPerimeter - edges[i].Lenght(); // часть функции, а именно (p-a)*(p-b)*(p-c)
                proiztimes *= time;

            }
            area = Math.Sqrt(proiztimes * polPerimeter);
            return area;
        }
        public bool Right(Edge[] edges) //проверяет, является ли треугольник правильным
        {
            /*if (edges[0].Lenght() == Math.Sqrt(Math.Pow(edges[1].Lenght(), 2) + Math.Pow(edges[2].Lenght(), 2)))
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
            else return false;*///версия 1.0
            int i = 0;

            if (edges[i].Lenght() > edges[i + 1].Lenght())
            {
                if (edges[i].Lenght() > edges[i + 2].Lenght())
                {
                    if (Math.Pow(edges[i].Lenght(), 2) == (Math.Pow(edges[i + 1].Lenght(), 2) + (Math.Pow(edges[i + 2].Lenght(), 2))))
                    {
                        return true;
                    }
                }
                else if (Math.Pow(edges[i + 2].Lenght(), 2) == (Math.Pow(edges[i + 1].Lenght(), 2) + (Math.Pow(edges[i + 2].Lenght(), 2))))
                {
                    return true;
                }
            }
            else if (edges[i + 1].Lenght() > edges[i + 2].Lenght())
            {
                if (Math.Pow(edges[i + 1].Lenght(), 2) == (Math.Pow(edges[i].Lenght(), 2) + (Math.Pow(edges[i + 2].Lenght(), 2))))
                {
                    return true;
                }
                else if (Math.Pow(edges[i + 2].Lenght(), 2) == (Math.Pow(edges[i + 1].Lenght(), 2) + (Math.Pow(edges[i].Lenght(), 2))))
                {
                    return true;
                }
            }
            return false;
        }
        public bool Isosceles(Edge[] edges) //проверяет, является ои треугольник равнобедренным
        {
            if (edges[0] == edges[1] || edges[1] == edges[2] || edges[2] == edges[0])
            {
                return true;
            }
            else return false;
        }
        public bool VerificationPoints() //проверяет, не совпадают ли точки в треугольнике
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
        public bool Points()//проверяет, лежат ли точки на одной прямой или нет
        {
            if ((points[2].coordinateX - points[0].coordinateX) / (points[1].coordinateX - points[0].coordinateX) ==
                (points[2].coordinateY - points[0].coordinateY) / (points[1].coordinateY - points[0].coordinateY))
            {
                return true;
            }
            return false;
        }
    }
}