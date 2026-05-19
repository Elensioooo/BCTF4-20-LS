namespace Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Homework#1
            int number;//5
            Console.Write("Enter the number: ");
            bool validNumber = int.TryParse(Console.ReadLine(), out number);
            
            if (validNumber)
            {
                for(int i = 1; i <=10; i++)
                {
                    Console.WriteLine($"{number} * {i} = {number * i}");
                }
            }
            else
            {
                Console.WriteLine("Enter Valid Number!");
            }
            #endregion

            #region Homework#2
            int userInputNumber;
            Console.WriteLine("Enter the number: ");
            bool validUserInputNumber = int.TryParse(Console.ReadLine(), out userInputNumber);

            if (validUserInputNumber)
            {
                for(int i = 1; i <= userInputNumber; i++)
                {
                   //spaces
                   for(int j = 1; j <= userInputNumber - i; j++)
                   {
                        Console.Write(" ");
                   }
                   
                   //stars
                   for(int k = 1; k <= i; k++)
                   {
                        Console.Write("* ");
                   }

                   Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

            #endregion

            #region Homework#3
            int inputNumber; 
            Console.Write("Enter the number: ");
            bool validInputNumber = int.TryParse(Console.ReadLine(), out inputNumber);

            if (validInputNumber)
            {
                int sum = 0;
                for(int i = 0; i < inputNumber; i++)
                {
                   if(i % 2 == 0)
                   {
                        sum += i; 
                   }
                }
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine("Enter valid number");
            }
            #endregion;

            #region Homework#4
            Random random = new Random();
            int randomNumber = random.Next(0,5); 
            int userNumber;

            do
            {
                Console.Write("Enter the number: ");
                bool validUserNumber = int.TryParse(Console.ReadLine(), out userNumber);
                
                if (!validUserNumber)
                {
                    Console.WriteLine("Invalid Input!");
                }
            } while (userNumber != randomNumber);

            #endregion
        }
    }
}
