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
            Console.Write("Введите количество треугольников ");
            int countTriangle = Convert.ToInt32(Console.ReadLine());

            Random gen = new Random();
            Edge[] edges = new Edge[3];
            Point[] points = new Point[3];
            double perimeter = 0;
            double area = 0;
            Triangle[] triangles = new Triangle[countTriangle];
            double averagePerimeter=0;
            double averageArea=0;
            int countRight = 0;
            int countIsosceles = 0;

            for (int i = 0; i < triangles.Length; i++)
            {

                RandomCoordinatesPoints(gen, points, triangles, i);
                EdgesLenght(edges, points);

                if (triangles[i].Right(edges) == true)
                {
                    Console.WriteLine("Прямоугольный");                    
                    countRight++;
                    perimeter = triangles[i].Perimeter(edges, perimeter);
                    Console.WriteLine("Периметер " + perimeter);
                    averagePerimeter += perimeter;
                }
                if (triangles[i].Isosceles(edges) == true)
                {
                    Console.WriteLine("Равнобедренный");                    
                    countIsosceles++;
                    perimeter = triangles[i].Perimeter(edges, perimeter);
                    area = triangles[i].Area(edges, perimeter, area);
                    Console.WriteLine("Площадь " + area);
                    averageArea += area;
                }
                Console.WriteLine();
            }
            averagePerimeter = averagePerimeter / countRight;
            averageArea = averageArea / countIsosceles;
            Console.WriteLine("Количество прямоуголных = {0}, их среднее = {1}", countRight, averagePerimeter);
            Console.WriteLine("Количество равнобедренных = {0}, их среднее = {1}", countIsosceles, averageArea);

            Console.ReadLine();

        }
        public static void RandomCoordinatesPoints(Random gen, Point[] points, Triangle[] triangles, int numberTriangle) //numberTriangle - номер треугольника
        {
            for (int i = 0; i < 3; i++)
            {
                points[i] = new Point(gen.Next(0, 5), gen.Next(0, 5));
                points[i].PrintCoordinate();
                

            }
            triangles[numberTriangle] = new Triangle(points);
        }
        public static void EdgesLenght(Edge[] edges, Point[] points)
        {
            for (int i = 0; i < edges.Length; i++)
            {
                if (i < edges.Length - 1)
                {
                    edges[i] = new Edge(points[i], points[i + 1]);

                }
                else edges[i] = new Edge(points[i], points[0]);
                Console.WriteLine("ребро {0}={1}", i, edges[i].Lenght()); //подписать ребро такое то и тд
            }
        }
    }
}

