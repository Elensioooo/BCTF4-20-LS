

namespace Homework_10
{
    internal abstract class Worker
    {
        private string _name;
        private string _surname;
        private string _id;
        private decimal _salary;
        private string _position;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empyty!");
                _name = value.Trim();
            }
        }

     
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Surname cannot be empty!");
                _surname = value.Trim();
            }
        }
        public string Id 
        {
            get
            {
                return _id;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Id cannot be empty");
                if (value.Length != 11)
                    throw new ArgumentException("Id must include 11 characters");

                foreach(char item in value)
                {
                    if (!char.IsDigit(item))
                        throw new ArgumentException("Id must include only digit numbers");
                }
                _id = value.Trim();
            }
        
        }

        public decimal Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Salary cannot be 0 or less than 0");
                _salary = value;
            }
        }

        public string Position
        {
            get
            {
                return _position;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Position cannot be empty");
                _position = value.Trim();
            }
        }

        public override string ToString()
        {
            return $"Position - {Position}, Name - {Name}, Surname - {Surname}, Id - {Id}, Salary - {Salary}";
        }
        public abstract void Print();
    }
}
