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
        const string FirstName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public void ValidFirstName(string input)
        {
            if (Regex.IsMatch(input, FirstName))
                Console.WriteLine("Your First name is  " +input);
            else
                Console.WriteLine("Unvalid FirstName");
        }
    }
}
