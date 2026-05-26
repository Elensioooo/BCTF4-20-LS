namespace Homework_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Homework#1
            int[][] studentsScore = [
                [52,88,90,100,99],
                [51, 100, 81, 66, 92, 75],
                [88, 100, 99, 91, 95, 98, 97, 100],
                [53,54, 90, 100, 99],
                [53,54, 90, 100, 99, 88, 77, 75],
                [53,54, 90, 100, 99, 92]
            ];

            double average = 0;
            int sum = 0;
            int studentNumeric = 1;
            for (int i = 0; i < studentsScore.Length; i++)
            {
                for(int j = 0; j < studentsScore[i].Length; j++)
                {
                    sum += studentsScore[i][j];
                }

                average = (double)sum / studentsScore[i].Length;
                Console.WriteLine($"Average of student {studentNumeric} = {average}");
                studentNumeric += 1;
            }
            #endregion

            #region Homework#2
            string[] passCodes = new string[10] {"1123", "1111", "1234", "1222", "3222", "2222", "3333", "4444", "7777", "9499"};
            Console.Write("Enter your passcode: ");
            string userPassCode = Console.ReadLine();

            if(userPassCode.Length != 4)
            {
                Console.WriteLine("PassCode must includes 4 symbols!");
            }
            else
            {
                bool foundPass = false;
                for (int i = 0; i < passCodes.Length; i++)
                {
                    if (passCodes[i] == userPassCode)
                    {
                        foundPass = true;
                        break;
                    }
                }

                Console.WriteLine(foundPass ? "Correct" : "Wrong");
            }

                
            #endregion

            #region #Homework#3
            int[] numbers = new int[10] { 10, 5, 8, -5, 2, -88, 22, 21, 99, -100 };

            int max = numbers[0];
            int min = numbers[0];

            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }

                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            #endregion

            #region Homework#4
            string[] names = { "Elene", "Niko", "Sandro", "Demetre", "Salome", "Giorgi", "Valentina" };

            for(int i = 0; i < names.Length; i++)
            {
                Console.Write($"Name {names[i]}: ");
                for(int j = 0; j < names[i].Length; j++)
                {
                    Console.Write($"{names[i][j]}  ");
                }
                Console.WriteLine();
            }
            #endregion

            #region #Homework#5
            string[] emails = {"elene@gmail.com", "eliko@gmail.com",  "random@gmail.com", "randomgmail.com" };
            bool allIncludesAt = true; 

            for(int i = 0; i < emails.Length; i++)
            {
                bool includesAt = false;
                for (int j = 0; j < emails[i].Length; j++)
                {
                    if (emails[i][j] == '@')
                    {
                        includesAt = true;
                        break;
                    }
                }

                if (!includesAt)
                {
                    allIncludesAt = false;
                    break;
                }
            }

            Console.WriteLine(allIncludesAt ? "All Emails have @ " : "Invalid Email suspected" );
            #endregion
        }
    }
}
