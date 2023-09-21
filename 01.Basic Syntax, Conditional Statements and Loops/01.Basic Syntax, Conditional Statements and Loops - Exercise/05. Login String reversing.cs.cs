using System;

namespace _05._Login_String_reversing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            int count = 0;
            // обръщане на username и пълнене на password с него
            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }
            
            while(true)
            {
                string currentUser= Console.ReadLine();

                if(currentUser !=password)

                {
                    count++;
                    if(count == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    Console.WriteLine($"Incorrect password. Try again.");
                }
                else
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
            }
        }
	    //string text = "text";
            //string reversed = new string(text.Reverse().ToArray());
            //Console.WriteLine(reversed);
	    // Лесно обръщане с метода Reverse и ToArray()
    }
}