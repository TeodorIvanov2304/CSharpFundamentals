using System.Text;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();

            StringBuilder fileName = new StringBuilder();
            StringBuilder extension = new StringBuilder();

            int lastDashIndex = filePath.LastIndexOf("\\");
            int dotIndex = filePath.IndexOf(".");
            for (int i = lastDashIndex + 1; i < dotIndex; i++)
            {

                fileName.Append(filePath[i]);
            }

            for (int i = dotIndex+1; i < filePath.Length; i++)
            {
                extension.Append(filePath[i]);
            }

            
            Console.WriteLine($"File name: {fileName}\nFile extension: {extension}");
        }
    }
}