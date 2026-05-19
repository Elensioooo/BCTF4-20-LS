namespace Homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Homework#1
            string username = "admin";
            string password = "1234";

            Console.Write("Enter your username: ");
            string inputUsername = Console.ReadLine();
            Console.Write("Enter you password: ");
            string inputPassword = Console.ReadLine();

            if (username == inputUsername && password == inputPassword)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Access denied");
            }
            #endregion

            #region Homework#2

            int firstNumber;
            Console.Write("Enter the first number: ");
            bool validFirstNumber = int.TryParse(Console.ReadLine(), out firstNumber);

            int secondNumber;
            Console.Write("Enter the second number: ");
            bool validSecondNumber = int.TryParse(Console.ReadLine(), out secondNumber);

            Console.Write("Enter the operator(+ or - or * or /): ");
            string inputOperator = Console.ReadLine();


            if (validFirstNumber == true && validSecondNumber == true)
            {
                switch (inputOperator)
                {
                    case "+":
                        Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
                        break;
                    case "-":
                        Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                        break;
                    case "*":
                        Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                        break;
                    case "/":
                        Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
                        break;
                    default:
                        Console.WriteLine("Enter Valid Operator from +, -, *, /");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Enter Valid Inputs");
            }

            #endregion

            #region Homework#3
            byte age;
            Console.Write("Enter your age: ");
            bool validAge = byte.TryParse(Console.ReadLine(), out age);

            if(validAge == true)
            {
                if(age >= 0 && age <= 12)
                {
                    Console.WriteLine("Child");
                } else if(age >= 13 && age <= 19)
                {
                    Console.WriteLine("Teenager");
                } else if(age >= 20 && age <= 64)
                {
                    Console.WriteLine("Adult");
                } else if(age >= 65)
                {
                    Console.WriteLine("retired");
                }
            }
            else
            {
                Console.WriteLine("Enter Valid age!");
            }
            #endregion
        }
    }
}
