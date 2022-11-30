using System;
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
    }
}
