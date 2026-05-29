
namespace Homework_7
{
    internal class Product
    {
        private double _price;
        private double _rating;
        public Product(string id, string name, string description, double price, int quantity, string brand, string category, double rating, bool isAvaliable, double discountPercent)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Quantity = quantity;
            this.Brand = brand;
            this.Category = category;
            this.Rating = rating;
            this.IsAvaliable = isAvaliable;
            this.DiscountPercent = discountPercent;
        }
        public string Id { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price {
            get
            {
                return _price;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Price cannot be 0 or negative");
                _price = value;
            }
        } 
        public int Quantity { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public double Rating 
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value < 1.0 || value > 5.0)
                    throw new ArgumentException("Rating must be form 1.0 to 5.0");
                _rating = value;
            }
        }
        public bool IsAvaliable { get; set; }
        public double DiscountPercent { get; set; }
    
        public double GetDiscountPrice()
        {
            if(DiscountPercent <= 0)
                throw new ArgumentException("Discount Percent cannot be 0 or less than 0");
            
            double finalPrice = Price - (Price * DiscountPercent / 100);
            return finalPrice;
        }
    
        public void GetProductInfo()
        {
            Console.WriteLine($"Id - {Id}; Name - {Name}; Description - {Description}; Price - {Price};" +
                $" Quantity - {Quantity}; Brand - {Brand}; Category - {Category}; Rating - {Rating}; " +
                $" IsAvaliable- {IsAvaliable};  DiscountPercent - {DiscountPercent}");
        }

        public int IncreaseQuantity(int amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Product amount cannot be 0 or less than 0");
            int finalQunatity = Quantity + amount;
            return finalQunatity;
        }

        public bool CheckQuantity()
        {
            if (Quantity > 0)
                return true;
            return false;
        }

        public double ChangeRating(double userRating)
        {
            if (userRating < 1.0 || userRating > 5.0)
                throw new ArgumentException("Rating must be from 1.0 to 5.0");
            _rating = userRating;
            return Rating;
        }
    }
}
