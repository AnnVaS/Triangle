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
            
            Random Gen = new Random();

            Point[] points = new Point[3];
            for (int i = 0; i < 3; i++)
            {
                points[i] = new Point(Gen.Next(-5, 5), Gen.Next(-5, 5));
                points[i].PrintCoordinate();
            }

            

            Console.ReadLine();

        }
        
        
    }
}

