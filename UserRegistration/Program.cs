﻿namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select:-\n 1.First Name\n 2.LastName\n 3.Email \n 4.MobileNumber \n 5.PasswordRule1 \n 6.PasswordRule2 \n 7.PasswordRule3");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter your First name");
                        string FirstName = Console.ReadLine();
                        pattern.ValidFirstName(FirstName);
                        break;
                    case 2:
                        Console.WriteLine("Enter your Last name");
                        string LastName = Console.ReadLine();
                        pattern.ValidLastName(LastName);
                        break;
                    case 3:
                        Console.WriteLine("Enter Email");
                        string Email = Console.ReadLine();
                        pattern.ValidEmail(Email);
                        break;
                    case 4:
                        Console.WriteLine("Enter your Mobile Number");
                        string MobileNumber = Console.ReadLine();
                        pattern.ValidMobileNum(MobileNumber);
                        break;
                    case 5:
                        Console.WriteLine("Enter your Password");
                        string PASSWORD_RULE1 = Console.ReadLine();
                        pattern.ValidPassword1(PASSWORD_RULE1);
                        break;
                    case 6:
                        Console.WriteLine("Enter your Password");
                        string PASSWORD_RULE2 = Console.ReadLine();
                        pattern.ValidPassword2(PASSWORD_RULE2);
                        break;
                    case 7:
                        Console.WriteLine("Enter your Password");
                        string PASSWORD_RULE3 = Console.ReadLine();
                        pattern.ValidPassword3(PASSWORD_RULE3);
                        break;

                    default:
                        flag = false;
                        break;

                }

            }
        }
    }
           
    
}