using System.Xml.Linq;

namespace _04._Array_Rotation
{
    internal class ArrayRotation
    {
        static void Main(string[] args)
        {
            //Create a program that receives an array and several rotations that you have to perform.The rotations are done by moving the first element of the array from the front to the back. Print the resulting array.

            //Четем string масив от конзолата
            string[] array = Console.ReadLine()
                          .Split();
            //Четем броят ротации
            int rotations = int.Parse(Console.ReadLine());
            //Създаваме цикъл, който ще върти ротациите
            for (int i = 0; i < rotations; i++)
            {
                //Създаваме променлива, която ще пази 0-евият елемент, който ще се върти
                string elementToRotate = array[0];

                //Започваме брояча от 1, защото вече сме взели първият елемент в отделна променлива
                for (int j = 1; j < array.Length; j++)
                {   
                    //Взимаме сегашният елемент и го записваме в променлива
                    string currentElement = array[j];

                    //Връщаме местата на елементите с едно назад
                    array[j-1] = currentElement;
                }
                //Слагаме 0-евият елемент на последно място
                array[array.Length-1] = elementToRotate;
            }

            Console.WriteLine(string.Join(" ", array));

        }
    }
}