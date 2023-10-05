namespace _06._Calculate_Rectangle_Area
{
    internal class CalculateRectangleArea
    {
        static void Main(string[] args)
        {
            //Четем страните на четириъгълника от конзолата
            double width = int.Parse(Console.ReadLine()) ;
            double length = int.Parse(Console.ReadLine());

            //Запазваме резултата от метода в променлива, area. 
            double area = CalculateRectangleAreaMethod(width,length); 

            //Изпечатваме резултата (return) на конзолата
            Console.WriteLine(area);

        }

        //Метод за изчисляване на лицето на четириъгълник area = a * b
        static double CalculateRectangleAreaMethod(double width, double length)
        {
            //Връщаме резултата от умножението
            return width * length;
        }

    }
}