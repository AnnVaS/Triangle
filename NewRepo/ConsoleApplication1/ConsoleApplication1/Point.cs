using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Point
    {
        public double coordinateX;//тип поменять не обязательно
        public double coordinateY;

        public Point(double coordinateX, double coordinateY)
        {
            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;
        }
        public void PrintCoordinate()
        {
            Console.WriteLine("Координата Х = {0}, координата Y = {1}", coordinateX, coordinateY); //удалить потом в финальной версии
        }
    }
}
