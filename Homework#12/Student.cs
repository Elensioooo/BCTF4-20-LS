
using System.Drawing;

namespace Homework_12
{
    internal class Student
    {
        private string _name;
        private string _lastName;
        private byte _age;
        private string _email;
        private string _phone;
        private double _gpa;
        private Faculty _faculty;

        public Student(string name, string lastName, byte age, string email, string phone, double gpa, Faculty faculty)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Age = age;
            this.Email = email;
            this.Phone = phone;
            this.GPA = gpa;
            this.Faculty = faculty;
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empyty");
                _name = value.Trim();
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Lastname cannot be empty");
                _lastName = value.Trim();
            }
        }
        public byte Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Age cannot be negative or 0");
                _age = value;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !value.Contains('@') || !value.Contains('.'))
                    throw new ArgumentException("Invalid Email");
                _email = value.Trim();
            }
        }
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length != 9)
                    throw new ArgumentException("Phone number must include 9 digits");
                foreach(char c in value)
                {
                    if (!char.IsDigit(c))
                        throw new ArgumentException("Phone number must inlude only digits");

                }
                _phone = value.Trim();
            }
        }

        public double GPA
        {
            get
            {
                return _gpa;
            }
            set
            {
                if (value < 0 || value > 4)
                    throw new ArgumentException("GPA has to be between 0.0 to 4.0");
                _gpa = value;
            }
        }

        public Faculty Faculty
        {
            get
            {
                return _faculty;
            }
            set
            {
                _faculty = value;
            }
        }
    }

    enum Faculty : byte
    {
        IT,
        Business,
        Design,
        Medicine
    }

}
