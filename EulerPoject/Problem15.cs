using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EulerPoject
{
    internal struct Point
    {
        public int X;
        public int Y;

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        public List<Point> GetNextPoints(Point from, Point maxPoint)
        {
            var output = new List<Point>();
            if (from.X < maxPoint.X)
            {
                output.Add(new Point { X = X + 1, Y = Y });
            }

            if (from.Y < maxPoint.Y)
            {
                output.Add(new Point { X = X, Y = Y + 1 });
            }

            return output;
        }

        public bool IsPreviousTo(Point to)
        {
            bool sameRow = X == to.X && to.Y - Y == 1;
            bool sameCol = Y == to.Y && to.X - X == 1;

            return sameCol || sameRow;
        }
    }

    internal class Problem15
    {
        public void Calculate()
        {
            /*            var n = 20;
                        long suma = 0;
                        for (int i = 1; i <= n; i++)
                        {
                            suma += (long)Math.Pow(2, i);
                        }

                        Console.WriteLine($"suma {suma}");*/

            Point startPoint = new Point { X = 0, Y = 0 };
            Point maxPoint = new Point { X = 20, Y = 20 };

            var numberOfRoutes = NumberOfRoutes(startPoint, maxPoint);

            Console.WriteLine($"Number of rutes {numberOfRoutes}");
        }

        private ulong NumberOfRoutes(Point from, Point maxPoint)
        {
            Console.SetCursorPosition(from.X, from.Y);
            Console.Write(".");
            if (from.IsPreviousTo(maxPoint))
            {
                return 1;

            }
            var nextPoints = from.GetNextPoints(from, maxPoint);
            ulong sum = 0; 
            foreach (var nextPoint in nextPoints)
            {
                var nuberOfRoutes = NumberOfRoutes(nextPoint, maxPoint);
                sum += nuberOfRoutes;
            }

            return sum;
        }

    }
}
