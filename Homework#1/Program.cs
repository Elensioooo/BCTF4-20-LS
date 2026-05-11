namespace Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Homework#1
            Console.Write("Enter Your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Congratulatoins! You can Vote");
            }
            else
            {
                Console.WriteLine("Unfortunately, You can't vote");
            }

            //Homework#2
            Console.Write("Enter a number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number: ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2 && number1 > number3)
            {
                Console.WriteLine($"The max number is : {number1}");
            }
            else if (number2 > number1 && number2 > number3)
            {
                Console.WriteLine($"The max number is: {number2}");
            }
            else if (number3 > number1 && number3 > number2)
            {
                Console.WriteLine($"The max number is: {number3}");
            }
            else
            {
                Console.WriteLine("Numbers are equal");
            }

            //Homework#3
            Console.Write("Enter a number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            if (firstNumber != secondNumber)
            {
                sum = firstNumber + secondNumber;
            }
            else
            {
                sum = 3 * (firstNumber + secondNumber);
            }

            Console.WriteLine($"Sum = {sum}");
            Console.ReadKey();
        }
    }
}
