namespace Homework_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Homework#1
            int[] evenNumbersArray = new int[4] { 2, 4, 6, 8 };
            int[] oddNumbersArray = new int[6] { 1, 3, 5, 7, 9, 11 };
            int[] resultArray = new int[evenNumbersArray.Length + oddNumbersArray.Length];

            for (int i = 0; i < evenNumbersArray.Length; i++)
            {
                resultArray[i] = evenNumbersArray[i];
            }

            int resultCurrent = evenNumbersArray.Length;
            for (int i = 0; i < oddNumbersArray.Length; i++)
            { 
                resultArray[resultCurrent] = oddNumbersArray[i];
                resultCurrent++;
            }

            for (int i = 0; i < resultArray.Length; i++)
            {
                Console.WriteLine(resultArray[i]);
            }

            #endregion

            #region Homework#2
            int[] numbers = new int[8] { 3, 5, -4, 8, 11, 1, -1, 6 };
            int targetSum;
            Console.Write("Enter the number: ");
            bool validTargetSum = int.TryParse(Console.ReadLine(), out targetSum);

            if (validTargetSum)
            {
                int count = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (numbers[i] + numbers[j] == targetSum)
                        {
                            Console.WriteLine("Yes");
                            count++;
                        }
                    }
                }

                string[] resultNumbersArray = new string[count];
                int currentIndex = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (numbers[i] + numbers[j] == targetSum)
                        {
                            resultNumbersArray[currentIndex] = $"[{numbers[i]}, {numbers[j]}]";
                            currentIndex++;
                        }
                    }
                }

                for (int i = 0; i < resultNumbersArray.Length; i++)
                {
                    Console.WriteLine(resultNumbersArray[i]);
                }

            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }

           
            #endregion

        }
    }
}
