using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)

        {
            double averagePerimeterRightTringles = 0;
            double averageAreaIsoscelesTriangles = 0;

            int countRightTriangles = 0;
            int countIsoscelesTriangles = 0;

            Edge[] edges = new Edge[3];
            Point[] points = new Point[3];

            Console.Write("Введите количество треугольников ");
            Triangle[] triangles = new Triangle[Convert.ToInt32(Console.ReadLine())];

            for (int i = 0; i < triangles.Length; i++)
            {
                RandomCoordinatesPointsForTriangle(points, triangles, i, edges);
                Console.WriteLine("Треугольник {0}: ", i+1);
                LenghtsOfEdges(edges, points);

                if (triangles[i].Right() == true)
                {
                    Console.WriteLine("Прямоугольный");
                    countRightTriangles++;
                    Console.WriteLine("Периметер " + triangles[i].Perimeter);
                    averagePerimeterRightTringles += triangles[i].Perimeter;
                }
                if (triangles[i].Isosceles() == true)
                {
                    Console.WriteLine("Равнобедренный");
                    countIsoscelesTriangles++;
                    Console.WriteLine("Площадь " + triangles[i].Area);
                    averageAreaIsoscelesTriangles += triangles[i].Area;
                }
                else
                {
                    Console.WriteLine("Обычный треугольник\nПериметер = {0}\nПлощадь = {1}\n", triangles[i].Perimeter, triangles[i].Area);
                }
            }
            Console.WriteLine("Количество прямоуголных = {0}, их среднее = {1}", countRightTriangles, averagePerimeterRightTringles / countRightTriangles);
            Console.WriteLine("Количество равнобедренных = {0}, их среднее = {1}", countIsoscelesTriangles, averageAreaIsoscelesTriangles / countIsoscelesTriangles);

            Console.WriteLine();
            Console.ReadLine();
        }

        //рандомно генерирует и выводит координаты точек треугольника:
        public static void RandomCoordinatesPointsForTriangle(Point[] points, Triangle[] triangles, int numberTriangle, Edge[] edges) 
        {
            Random gen = new Random();            
                do
                {
                    for (int i = 0; i < 3; i++)
                    {
                    points[i] = new Point(gen.Next(0, 5), gen.Next(0, 5));
                    }
                    triangles[numberTriangle] = new Triangle(points, edges);
                } while (triangles[numberTriangle].VerificationPoints() == true || triangles[numberTriangle].VerificationPointsOnTheLine() == true);                   
                       
            triangles[numberTriangle] = new Triangle(points, edges);
        }
        //заполняет массив сторон их длинами:
        public static void LenghtsOfEdges(Edge[] edges, Point[] points)
        {
            for (int i = 0; i < edges.Length; i++)
            {
                if (i < edges.Length - 1)
                {
                    edges[i] = new Edge(points[i], points[i + 1]);

                }
                else edges[i] = new Edge(points[i], points[0]);
                Console.WriteLine("ребро {0}={1}", i, edges[i].SearchLenght); 
            }
        }
    }
}
