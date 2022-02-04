using System;

namespace UnitTestingLab
{
    public class Program
    {
        public static decimal Balance = 11400.54m;

        public static void Main(string[] args)
        {
            UserInterFace();
        }

        public static void UserInterFace()
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("Please choose from the following options:");
            string options = "1. View Balance \n2. Deposit \n3. Withdraw \n4. Exit";
            Console.WriteLine(options);
            
            string menuChoice = Console.ReadLine();
            while(menuChoice != "1" && menuChoice != "2" && menuChoice != "3" && menuChoice != "4")
            {
                Console.WriteLine("Please choose a valid input:");
                Console.WriteLine(options);
                menuChoice = Console.ReadLine();
                Console.WriteLine(menuChoice);
            }

            if(menuChoice == "1")
            {
                Console.Clear();
                decimal balance = ViewBalance(Balance);
                Console.WriteLine($"Your balance is: {balance}");
                ReturnHome();
            }
            else if(menuChoice == "2")
            {
                Console.Clear();
                Console.WriteLine("Enter deposit amount:");
                decimal depositAmount = Convert.ToInt32(Console.ReadLine());
                Deposit(depositAmount);
                Console.WriteLine($"Successfully deposited {depositAmount}");
                Console.WriteLine($"Your new balance is: {Balance}");
                ReturnHome();
            }
        }

        public static decimal ViewBalance(decimal balance)
        {
            return balance;
        }

        public static decimal Withdraw(decimal amount, decimal balance)
        {
            if(amount <= 0)
            {
                return balance;
            }
            else if(amount > balance)
            {
                return balance;
            }
            else
            {
                balance -= amount;
                return balance;
            }
        }

        public static decimal Deposit(decimal amount)
        {
            if(amount < 0)
            {
                return -1;
            }
            Balance += amount;
            return Balance;
        }

        public static void ReturnHome()
        {
            Console.WriteLine("Press 1 to return");
            string menuChoice = Console.ReadLine();
            while (menuChoice != "1")
            {
                Console.WriteLine("Invalid input. Please press 1 to return");
                menuChoice = Console.ReadLine();
            }
            Console.Clear();
            UserInterFace();
        }
    }
}
