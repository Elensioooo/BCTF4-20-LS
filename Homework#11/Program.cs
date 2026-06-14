namespace Homework_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[9] { 4, 4, 1, 3, 5, 7, 9, 11, 10 };
            Array numbersArray = new Array(numbers);
            Console.WriteLine($"Evens: ");
            numbersArray.ShowEven();
            Console.WriteLine($"Odds: ");
            numbersArray.ShowOdd();

            int uniqueCount = numbersArray.CountDistinct();
            Console.WriteLine($"Unique numbers Count is: {uniqueCount}");
            Console.WriteLine($"{numbersArray.EqualToValue(22)}");
        }
    }
}
