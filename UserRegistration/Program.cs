namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select:-\n 1.First Name\n 2.LastName\n 3.Email ");
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

                   
                    default:
                        flag = false;
                        break;

                }

            }
        }
    }
           
    
}