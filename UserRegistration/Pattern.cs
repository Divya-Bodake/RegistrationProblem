﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Pattern
    {
        const string FirstName = "^[A-Z][a-zA-Z]{2,}$";
        const string LastName = "^[A-Z][a-zA-Z]{2,}$";
        const string Email = "^[a-zA-z]+[.+-_]{0,1}[a-z]+[@][a-zA-Z]+[.][a-z]{2,3}[.][a-z]{2}$";
        const string MobileNumber = "^[0-9]{2}[ ][1-9][0-9]{9}$";

        public void ValidFirstName(string input)
        {
            if (Regex.IsMatch(input, FirstName))
                Console.WriteLine("Your First name is  " +input);
            else
                Console.WriteLine("Unvalid FirstName");
        }
        public void ValidLastName(string input)
        {
            if (Regex.IsMatch(input, LastName))
                Console.WriteLine("Your Last name is  " +input);
            else
                Console.WriteLine("Unvalid LastName");
        }

        public void ValidEmail(string input)
        {
            if (Regex.IsMatch(input, Email))
                Console.WriteLine("Your Email is  " + input);
            else
                Console.WriteLine("Unvalid Email");
        }
        public void ValidMobileNum(string input)
        {
            if (Regex.IsMatch(input, MobileNumber))
                Console.WriteLine("Your MobileNumber is  " + input);
            else
                Console.WriteLine("Unvalid MobileNumber");
        }

    }
}
