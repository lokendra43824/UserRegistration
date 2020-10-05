using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName,lastName,emailId;
            Console.WriteLine("Welcome to user registration");
            Console.WriteLine("Enter your first name: ");
            firstName = Console.ReadLine();
            while (!(validateName(firstName)))
            {
                Console.WriteLine("Please enter a valid first name");
                firstName = Console.ReadLine();
            }
            Console.WriteLine("You have entered a valid first name");
            Console.WriteLine("Enter your Last name: ");
            lastName = Console.ReadLine();
            while (!(validateName(lastName)))
            {
                Console.WriteLine("Please enter a valid last name");
                lastName = Console.ReadLine();
            }
            Console.WriteLine("You have entered a valid last name");
            Console.WriteLine("Enter your emailId: ");
            emailId = Console.ReadLine();
            while (!(validateEmailId(emailId)))
            {
                Console.WriteLine("Please enter a valid emailId");
                emailId = Console.ReadLine();
            }
            Console.WriteLine("You have entered a valid emailId");

        }

        public static bool validateName(string firstName)
    {
        string pattern = @"(^[A-Z]{1}[a-z]{2,}$)";
        Regex re = new Regex(pattern);
        if(re.IsMatch(firstName))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
        public static bool validateEmailId(string emailId)
        {
            string pattern = "^[\\w-\\+]+(\\.[\\w]+)*@[\\w-]+(\\.[\\w]+)*(\\.[a-z]{2,})$";
            Regex re = new Regex(pattern);
            if (re.IsMatch(emailId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
