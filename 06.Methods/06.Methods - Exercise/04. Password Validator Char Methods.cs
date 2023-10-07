namespace _04._Password_Validator_Another
{
    internal class PasswordValidatorCharMethods
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            //bool isValidLength = ValidateLength(password);
            //bool isValidLettersAndDigits = ValidateLetterAndDigits(password);
            //bool isTwoDigits = PasswordHasTwoNumbers(password);
            bool isValidPassword = ValidateLength(password)
                                && ValidateLetterAndDigits(password)
                                && PasswordHasTwoNumbers(password);
           if (isValidPassword) 
            {
                Console.WriteLine("Password is valid");
            }
           else
            {
                if (!ValidateLength(password))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (!ValidateLetterAndDigits(password))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!PasswordHasTwoNumbers(password)) 
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }

        private static bool PasswordHasTwoNumbers(string password)
        {
            int count = 0;

            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }
            if (count >= 2) 
            {
                return true;
            }

            return false;
        }

        private static bool ValidateLetterAndDigits(string password)
        {
            foreach (char c in password) 
            {   
                //Проверяваме дали char c е буква или цифра
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
                
            }
            return true;
        }

        private static bool ValidateLength(string password)
        {
            if(password.Length>=6 && password.Length<=10)
            {
                bool isTrue = true;
                return isTrue;
                //return true;
            }
            return false;
        }
    }
}