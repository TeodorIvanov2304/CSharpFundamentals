namespace _03._Longer_Line
{
    internal class LongerLine
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double resultA = FindTheLongerLine(x1, x2, y1, y2);
            double resultB = FindTheLongerLine(x3, x4, y3, y4);
            double sumA = 0;
            double sumB = 0;
            FindClosestCoordinates(x1, y1, x2, y2, x3, y3, x4, y4, resultA, resultB, ref sumA, ref sumB);
        }

        static void FindClosestCoordinates(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, double resultA, double resultB, ref double sumA, ref double sumB)
        {
            if (resultA > resultB)
            {
                sumA = SumCoordinates(x1, y1);
                sumB = SumCoordinates(x2, y2);

                PrintResult(x1, y1, x2, y2, sumA, sumB);
            }
            else if (resultB > resultA)
            {
                sumA = SumCoordinates(x3, y3);
                sumB = SumCoordinates(x4, y4);
                PrintResult(x3, y3, x4, y4, sumA, sumB);
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
        }

        static void PrintResult(double x1, double y1, double x2, double y2, double sumA, double sumB)
        {
            if (sumA < sumB)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else if (sumB < sumA)
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
        }

        static double SumCoordinates(double x, double y)
        {
            return Math.Abs(x) + Math.Abs(y);
        }

        static double FindTheLongerLine(double x1, double x2, double y1, double y2)
        {
            double length = Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2);
            length = Math.Sqrt(length);

            return length;
            
        }

        
    }
}
  