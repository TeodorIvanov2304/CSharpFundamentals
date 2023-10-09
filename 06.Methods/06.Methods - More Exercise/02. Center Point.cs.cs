namespace _02._Center_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] firstPoint = new double[2];
            //Enter X, Y for point A
            firstPoint[0] = double.Parse(Console.ReadLine());
            firstPoint[1] = double.Parse(Console.ReadLine());

            //Enter X, Y for point B
            double[] secondPoint = new double[2];
            secondPoint[0] = double.Parse(Console.ReadLine());
            secondPoint[1] = double.Parse(Console.ReadLine());

            //Creating empty array for closest points
            FindClosestPoint(firstPoint, secondPoint);
        }

        static void FindClosestPoint(double[] firstPoint, double[] secondPoint)
        {
            double[] closestPoint = new double[2];

            //Creating two variables for pointASum and pointBSum
            double sumA = 0;
            double sumB = 0;

            //Summing the points
            sumA = SumCoordinates(firstPoint, sumA);
            sumB = SumCoordinates(secondPoint, sumB);
            
            //Findinc closest points
            if (sumA > sumB)
            {
                closestPoint[0] = secondPoint[0];
                closestPoint[1] = secondPoint[1];
            }

            else if (sumB > sumA)
            {
                closestPoint[0] = firstPoint[0];
                closestPoint[1] = firstPoint[1];
            }

            else
            {
                closestPoint[0] = firstPoint[0];
                closestPoint[1] = firstPoint[1];
            }

            //Print result
            Console.WriteLine($"({string.Join(", ", closestPoint)})");
        }

        private static double SumCoordinates(double[] points, double sum)
        {
            foreach (double i in points)
            {
                sum += Math.Abs(i);
            }

            return sum;
        }
    }
}