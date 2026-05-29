namespace Homework_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Iphone17Pro", "Iphone 17 Pro Max", "The best phone", 5000, 50, "Apple", "Phones", 3.2, true, 15);
            product1.GetProductInfo();
            Console.WriteLine(product1.GetDiscountPrice());
            Console.WriteLine($"Quantity of product1 is: {product1.IncreaseQuantity(70)}");
            Console.WriteLine(product1.CheckQuantity());

            double userRating;
            bool validUserRating;
            do
            {
                Console.Write("Enter the rating from 1.0 to 5.0: ");
                validUserRating = double.TryParse(Console.ReadLine(), out userRating);

                if (!validUserRating || userRating < 1.0 || userRating > 5.0)
                {
                    Console.WriteLine("Please Enter Valid Rating");
                    validUserRating = false;
                }
            } while (!validUserRating);

            Console.WriteLine($"New rating of product1 is: {product1.ChangeRating(userRating)}");
        }
    }
}
