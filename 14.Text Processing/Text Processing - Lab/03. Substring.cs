namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filter = Console.ReadLine();
            string text = Console.ReadLine();

            // Въртим цикъла, докато filter се съдържа в text
            while (text.Contains(filter)) 
            {   
                // Премахваме частта от текст(filter) от text с метода Remove, и IndexOf
                // Където filter е началният индекс, от който премахваме
                // До filter.Length , т.е докато свърши филтъра
                int statrIndex = text.IndexOf(filter);
                text = text.Remove(statrIndex, filter.Length);
            }
            Console.WriteLine(text);
        }
    }
}