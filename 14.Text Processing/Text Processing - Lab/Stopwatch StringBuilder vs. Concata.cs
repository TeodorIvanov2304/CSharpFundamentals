using System.Diagnostics;
using System.Text;

namespace Stopwatch_StringBuilder_vs._Concata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            string text = "";
            for (int i = 0; i < 200000; i++)
            {
                text += i;
                
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);

            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < 200000; i++)
            {
                stringBuilder.Append(i);
            }
            stopwatch2.Stop();
            Console.WriteLine(stopwatch2.ElapsedMilliseconds);
        }
    }
}