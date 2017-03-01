﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Triangle
    {
        public Point[] points = new Point[3];
        public Edge[] edges = new Edge[3];

        public Triangle(Point[] points, Edge[] edges) //конструктор
        {
            this.points = points;
            this.edges = edges;            
        }
        //находит периметр:
        public double Perimeter
        {
            get
            {
                double perimeter=0;
                for (int i = 0; i < edges.Length; i++)
                {                    
                    perimeter += edges[i].Lenght;
                }
                return perimeter;
            }
        }
        //находит площадь:
        public double Area
        {
            get
            {
                double area = 1;          //произведение временных переменных
                for (int i = 0; i < edges.Length; i++)
                {
                    area *= (Perimeter / 2 - edges[i].Lenght);
                }
                return Math.Sqrt(area * Perimeter / 2);
            }
        }
        //проверяет, является ли треугольник правильным:
        public bool Right() 
        {
            
            int i = 0;

            if (edges[i].Lenght > edges[i + 1].Lenght)
            {
                if (edges[i].Lenght > edges[i + 2].Lenght)
                {
                    if (Math.Pow(edges[i].Lenght, 2) == (Math.Pow(edges[i + 1].Lenght, 2) + (Math.Pow(edges[i + 2].Lenght, 2))))
                    {
                        return true;
                    }
                }
                else if (Math.Pow(edges[i + 2].Lenght, 2) == (Math.Pow(edges[i + 1].Lenght, 2) + (Math.Pow(edges[i + 2].Lenght, 2))))
                {
                    return true;
                }
            }
            else if (edges[i + 1].Lenght > edges[i + 2].Lenght)
            {
                if (Math.Pow(edges[i + 1].Lenght, 2) == (Math.Pow(edges[i].Lenght, 2) + (Math.Pow(edges[i + 2].Lenght, 2))))
                {
                    return true;
                }
                else if (Math.Pow(edges[i + 2].Lenght, 2) == (Math.Pow(edges[i + 1].Lenght, 2) + (Math.Pow(edges[i].Lenght, 2))))
                {
                    return true;
                }
            }
            return false;
        }
        //проверяет, является ои треугольник равнобедренным:
        public bool Isosceles() 
        {
            if (edges[0] == edges[1] || edges[1] == edges[2] || edges[2] == edges[0])
            {
                return true;
            }
            else return false;
        }
        //проверяет, не совпадают ли точки в треугольнике:
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
        //проверяет, лежат ли точки на одной прямой или нет:
        public bool Points()
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