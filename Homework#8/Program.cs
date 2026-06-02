namespace Homework_8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = @"../../../data.txt";
            string[] lines = File.ReadAllLines(path);
            Car[] cars = new Car[lines.Length];


            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(",");
                Car newCar = new Car(parts[0], parts[1], int.Parse(parts[2]), decimal.Parse(parts[3]), parts[4]);
                cars[i] = newCar;
            }

            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].DisplayInformation();
            }

            decimal average = Car.GetPriceAverage(cars);
            Console.WriteLine($"Average price of cars - {average}");
            Console.WriteLine("After discount of 20 %: ");
            for(int i = 0; i < cars.Length; i++)
            {
                decimal discountPrice = cars[i].Sale(20);
                cars[i].Price = discountPrice;
                cars[i].DisplayInformation();
            }

            Car.SortByPrice(cars);
            Console.WriteLine("Sorted By Price: ");
            for(int i = 0; i < cars.Length; i++)
            {
                cars[i].DisplayInformation();
            }
            Console.ReadKey();
        }
    }
}
