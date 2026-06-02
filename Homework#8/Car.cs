namespace Homework_8
{
    internal class Car
    {
        decimal _price;
        int _year;

        public Car(string name, string brand, int year, decimal price, string color)
        {
            //Toyota,Corolla,2022,25000,White
            this.Name = name;
            this.Brand = brand;
            this.Year = year;
            this.Price = price;
            this.Color = color;
        }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value <= 1885 || value > 2026)
                    throw new ArgumentException("The car year must be between 1885 and 2026");
                _year = value;
            }
        }


        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("The price cannot be negative or 0");
                _price = value;
            }
        }

        public void DisplayInformation()
        {
            Console.WriteLine($"Name - {Name}, Brand - {Brand}, Year - {Year}, Price - {Price}, Color - {Color}");
        }

        public static decimal GetPriceAverage(Car[] cars)
        {
            if (cars == null)
                throw new ArgumentNullException(nameof(cars));

            if (cars.Length == 0)
                throw new ArgumentException("Given array is empty");

            decimal averagePrice;
            decimal sum = 0;
            for(int i = 0; i < cars.Length; i++)
            {
                sum += cars[i].Price;
            }

            averagePrice = sum / cars.Length;
            return averagePrice;
        }

        public decimal Sale(decimal discountPercent)
        {
            if (discountPercent <= 0)
                throw new ArgumentException("Discount percetn cannot be 0 or negative number");
            return Price - Price * discountPercent / 100;
        }

        public static void SortByPrice(Car[] cars)
        {
            if (cars == null)
                throw new ArgumentNullException(nameof(cars));
            if (cars.Length == 0)
                throw new ArgumentException("Given array is empty");

            for(int i = 0; i< cars.Length - 1; i++)
            {
                for(int j = 0; j < cars.Length - i - 1; j++)
                {
                    if (cars[j].Price > cars[j + 1].Price)
                    {
                        Car temp = cars[j];
                        cars[j] = cars[j + 1];
                        cars[j + 1] = temp;
                    }
                }
            }
        }

    }
}
