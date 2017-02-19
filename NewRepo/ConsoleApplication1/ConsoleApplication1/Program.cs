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

            Random gen = new Random();
            Edge[] edges = new Edge[3];
            Point[] points = new Point[3];
            Triangle triangle = new Triangle(points);
            double perimeter = 0;
            double area = 0;

            for (int i = 0; i < 3; i++)
            {
                points[i] = new Point(gen.Next(-5, 5), gen.Next(-5, 5));
                points[i].PrintCoordinate();

            }
            for (int i = 0; i < edges.Length; i++)
            {
                if (i < edges.Length - 1)
                {
                    edges[i] = new Edge(points[i], points[i + 1]);

                }
                else edges[i] = new Edge(points[i], points[0]);
                Console.WriteLine("ребро {0}={1}", i, edges[i].Lenght()); //подписать ребро такое то и тд
            }
            if (triangle.Right(edges) == true)
            {
                Console.WriteLine("Прямоугольный");
                perimeter = triangle.Perimeter(edges, perimeter);
                Console.WriteLine("Периметер " + perimeter);
            }
            if (triangle.Isosceles(edges) == true)
            {
                Console.WriteLine("Равнобедренный");
                perimeter = triangle.Perimeter(edges, perimeter);
                area = triangle.Area(edges, perimeter, area);
                Console.WriteLine("Площадь "+area);
            }

            Console.ReadLine();

        }
        
        
    }
}

