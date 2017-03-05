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
            Console.Write("Введите количество точек в полигоне ");            

            Edge[] edges = new Edge[Convert.ToInt32(Console.ReadLine())];
            Point[] points = new Point[edges.Length];
                        
            Console.Write("Введите количество полигонов ");            

            Polygon[] polygons = new Polygon[Convert.ToInt32(Console.ReadLine())];

            for (int i = 0; i < polygons.Length; i++)
            {
                RandomCoordinatesPointsForPolygon(points, polygons, i, edges);
                Console.WriteLine("\nПолигон №{0}: ", i+1);
                EdgesLenght(edges, points);
                                
                Console.WriteLine("Периметер " + polygons[i].Perimeter());
                Console.WriteLine("Площадь " + polygons[i].Area());
            }            
            Console.ReadLine();
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
                Console.WriteLine("ребро {0}={1}", i, edges[i].SearchLenght); 
            }
        }
        //рандомно генерирует и выводит координаты точек многоугольника:
        public static void RandomCoordinatesPointsForPolygon(Point[] points, Polygon[] polygons, int numberPolygon, Edge[] edges) 
        {
            Random gen = new Random();
            do
            {
                for (int i = 0; i < points.Length; i++)
                {
                    points[i] = new Point(gen.Next(0, 10), gen.Next(0, 10));                
                }
                polygons[numberPolygon] = new Polygon(points, edges);
            } while (polygons[numberPolygon].VerificationPoints() == true);
            polygons[numberPolygon] = new Polygon(points, edges);
        }

    }
}
