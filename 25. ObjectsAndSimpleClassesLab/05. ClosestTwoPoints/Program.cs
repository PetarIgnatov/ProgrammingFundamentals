using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._ClosestTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Point> points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                Point currentPoint = Point.ParsePoint(Console.ReadLine());
                points.Add(currentPoint);
            }

            double minDistance = double.MaxValue;

            Point[] bestPoints = new Point[2];

            for (int i = 0; i < points.Count; i++)
            {
                for (int a = i + 1; a < points.Count; a++)
                {
                    double distance = CalcDistance(points[i], points[a]);

                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        bestPoints[0] = points[i];
                        bestPoints[1] = points[a];
                        //bestPoints = new Point[] { points[i], points[a]};
                    }
                }
            }

            Console.WriteLine($"{minDistance:F3}");
            Console.WriteLine(bestPoints[0]);
            Console.WriteLine(bestPoints[1]);
        }

        private static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            double sideA = Math.Pow((firstPoint.X - secondPoint.X), 2);
            double sideB = Math.Pow((firstPoint.Y - secondPoint.Y), 2);

            return Math.Sqrt(sideA + sideB);
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int xSide, int ySide)
        {
            X = xSide;
            Y = ySide;
        }
        public static Point ParsePoint(string input)
        {
            int[] inputData = input.Split(' ').Select(int.Parse).ToArray();

            return new Point(inputData[0], inputData[1]);
        }
        public override String ToString()
        {
            return String.Format($"({X}, {Y})");
        }
    }
}
