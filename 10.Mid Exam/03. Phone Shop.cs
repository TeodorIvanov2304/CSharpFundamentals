/*
 
HuaweiP20, XiaomiNote
Remove - Samsung 
Bonus phone - XiaomiNote:Iphone5  
*/
namespace _03._Phone_Shop
{
    internal class PhoneShop
    {
        static void Main(string[] args)
        {
            List<string> phones = Console.ReadLine()
                                         .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                         .ToList();

            string commands = "";
            //Създаваме променлива delimiters, защото ще делим по два резделителя - и :
            string[] delimiters = {" - ",":" }; 
            while ((commands = Console.ReadLine()) != "End") 
            {
                string[] commandArgs = commands.Split(delimiters,                                    StringSplitOptions.RemoveEmptyEntries)
                                               .ToArray();
                
                string command = commandArgs[0];
                string phone = "";
                switch(command)
                {
                    case "Add":
                        phone = commandArgs[1];
                        if (!phones.Contains(phone)) 
                        {
                            phones.Add(phone);
                        }
                        break;
                    case "Remove":
                        phone = commandArgs[1];
                        if (phones.Contains(phone)) 
                        {
                            phones.Remove(phone);
                        }
                        break;
                    case "Bonus phone":
                        
                        phone = commandArgs[1];
                        string newPhone = commandArgs[2];
                        if (phones.Contains(phone))
                        {
                            phones.Insert(phones.IndexOf(phone)+1, newPhone);
                        }
                        break;
                    case "Last":
                        phone = commandArgs[1];
                        if (phones.Contains(phone))
                        {
                            string tempPhone = phone;
                            phones.Remove(phone);
                            phones.Add(tempPhone);
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", phones));
        }
    }
}