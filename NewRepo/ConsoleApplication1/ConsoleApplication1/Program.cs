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
            double averagePerimeter = 0;
            double averageArea = 0;

            int countRight = 0;
            int countIsosceles = 0;            

            Edge[] edges = new Edge[3];
            Point[] points = new Point[3];

            Console.Write("Введите количество треугольников ");
            Triangle[] triangles = new Triangle[Convert.ToInt32(Console.ReadLine())];

            for (int i = 0; i < triangles.Length; i++)
            {
                RandomCoordinatesPointsForTriangle(points, triangles, i, edges);
                EdgesLenght(edges, points);

                if (triangles[i].Right() == true)
                {
                    Console.WriteLine("Прямоугольный");
                    countRight++;                    
                    Console.WriteLine("Периметер " + triangles[i].Perimeter);
                    averagePerimeter += triangles[i].Perimeter;
                }
                if (triangles[i].Isosceles() == true)
                {
                    Console.WriteLine("Равнобедренный");
                    countIsosceles++;                                        
                    Console.WriteLine("Площадь " + triangles[i].Area);
                    averageArea += triangles[i].Area;
                }
                Console.WriteLine();
            }            
            Console.WriteLine("Количество прямоуголных = {0}, их среднее = {1}", countRight, averagePerimeter / countRight);
            Console.WriteLine("Количество равнобедренных = {0}, их среднее = {1}", countIsosceles, averageArea / countIsosceles);


            Console.WriteLine();
            Console.ReadLine();
        }

        //рандомно генерирует и выводит координаты точек треугольника:
        public static void RandomCoordinatesPointsForTriangle(Point[] points, Triangle[] triangles, int numberTriangle, Edge[] edges) //numberTriangle - номер треугольника
        {
            Random gen = new Random();
            for (int i = 0; i < 3; i++)
            {
                points[i] = new Point(gen.Next(0, 5), gen.Next(0, 5));
                points[i].PrintCoordinate();

            }
            triangles[numberTriangle] = new Triangle(points, edges);
        }
        //заполняет массив сторон их длинами:
        public static void EdgesLenght(Edge[] edges, Point[] points)
        {
            for (int i = 0; i < edges.Length; i++)
            {
                if (i < edges.Length - 1)
                {
                    edges[i] = new Edge(points[i], points[i + 1]);

                }
                else edges[i] = new Edge(points[i], points[0]);
                Console.WriteLine("ребро {0}={1}", i, edges[i].Lenght); //подписать ребро такое то и тд // .Lenght - находит длину
            }
        }

    }
}