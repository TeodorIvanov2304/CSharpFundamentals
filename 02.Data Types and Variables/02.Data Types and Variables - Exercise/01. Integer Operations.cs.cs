using System;

namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a program that receives four integer numbers.
            //You should perform the following operations:
            //• Add first to the second.
            //• Divide(integer) the result of the first operation by the third number.
            //• Multiply the result of the second operation by the fourth number.
            //Print the result after the last operation.
            //Constraints
            //• First number will be in the range[-2, 147, 483, 648…2, 147, 483, 647].
            //• Second number will be in the range[-2, 147, 483, 648…2, 147, 483, 647].
            //• Third number will be in the range[-2, 147, 483, 648…2, 147, 483, 647].
            //• Fourth number will be in the range[-2, 147, 483, 648…2, 147, 483, 647].

            short firstNumber = short.Parse(Console.ReadLine());
            short secondNumber = short.Parse(Console.ReadLine());
            short thirdNumber = short.Parse(Console.ReadLine());
            short fourthNumber = short.Parse(Console.ReadLine());


            int finalNumber = (firstNumber + secondNumber) / thirdNumber * fourthNumber;
            Console.WriteLine(finalNumber);
        }
    }
}