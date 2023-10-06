using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;

namespace _04._Password_Validator
{
    internal class PasswordValidator
    {
        static void Main(string[] args)
        {
            // Create a program that checks if a given password is valid.
            //The password validation rules are:
            //• It should contain 6 – 10 characters(inclusive)
            //• It should contain only letters and digits
            //• It should contain at least 2 digits
            //If it is not valid, for any unfulfilled rule print the corresponding message:
            //• "Password must be between 6 and 10 characters"
            //• "Password must consist only of letters and digits"
            //• "Password must have at least 2 digits"

            string password = Console.ReadLine();
            CheckPassword(password);
        }

        static void CheckPassword(string password) 
        {
            int digitCounter = 0;
            bool isValid = true;
            if (password.Length < 6 || password.Length > 10)
            {
                ShortOrLongPassword();
                isValid = false;
            }

            for (int i = 0; i < password.Length; i++)
            {
                char currentLetter = password[i];

                if (currentLetter > 47 && currentLetter < 58)
                {
                    digitCounter++;
                }
                if (currentLetter < 48
                    || currentLetter > 57 && currentLetter < 65
                    || currentLetter > 90 && currentLetter < 97
                    || currentLetter > 122)
                {
                    OnlyLettersOrDiggits();
                    isValid = false;
                    break;
                }

            }

            if (digitCounter < 2)
            {
                isValid = false;
                AtLeastTwoDigits();
            }

            if (isValid)
            {
                ValidPassword();
            }

        }
        static void ShortOrLongPassword()
        {
            Console.WriteLine("Password must be between 6 and 10 characters");
        }

        static void OnlyLettersOrDiggits()
        {
            Console.WriteLine("Password must consist only of letters and digits");
        }

        static void AtLeastTwoDigits()
        {
            Console.WriteLine("Password must have at least 2 digits");
        }
        static void ValidPassword()
        {
            Console.WriteLine("Password is valid");
        }
    }
}