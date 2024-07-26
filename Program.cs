using System;

namespace HospitalBillCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("HOSPITAL BILL CALCULATOR");

            Console.WriteLine("1. Log in");
            Console.WriteLine("2. Sign up");
            Console.Write("Choose an option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Login();
                    break;

                case 2:
                    Signup();
                    break;

                default:
                    Console.WriteLine("Wrong option. Try again.");
                    break;
            }
        }

        public static void Signup()
        {
            Console.WriteLine("SIGN UP");
            Console.Write("Username: ");
            string user = Console.ReadLine();
            Console.Write("Password: ");
            string pass = Console.ReadLine();

            if (Account.Users.ContainsKey(user))
            {
                Console.WriteLine("The username already exists.");
                Console.WriteLine("Try to Log in.");
				Console.WriteLine();
                Login();
            }
            else
            {
                Account.Users.Add(user, pass);
                Console.WriteLine("Try to Log in");
				Console.WriteLine();
                Login();
            }
        }

        public static void Login()
        {
            Console.WriteLine("LOGIN");
            Console.Write("Username: ");
            string user = Console.ReadLine();
            Console.Write("Password: ");
            string pass = Console.ReadLine();

            if (Account.Accs(user, pass))
            {
                Menu.Show();
            }
            else
            {
                Console.WriteLine("Account does not exist.");
                Console.WriteLine("You'll be proceed to sign up.");
				Console.WriteLine();
                Signup();
            }
        }
    }
}
