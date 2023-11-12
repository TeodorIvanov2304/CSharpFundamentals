using System.IO;

namespace _03._Extract_File_Path
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();
            //Използваме вградения клас Path и функциите му GetFileNameWithoutExtension и GetExtension
            Console.WriteLine($"File name: {Path.GetFileNameWithoutExtension(filePath)}");
            //Реплейсваме . с празно място
            Console.WriteLine($"File extension: {Path.GetExtension(filePath).Replace(".","")}");
        }
    }
}