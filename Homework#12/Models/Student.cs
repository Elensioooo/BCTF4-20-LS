using Homework_12.Enums;
using Homework_12.Interfaces;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12.Models
{
    internal class Student : Person, IComparable<Student>, IPrintable
    {
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
                foreach (char c in value)
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


        public override string ToString()
        {
            return $"Name: {Name}, LastName: {LastName}, Age: {Age}, Email: {Email}, Phone: {Phone}, GPA: {GPA}, Faculty: {Faculty}";
        }

        public int CompareTo(Student? student)
        {
            if (student == null)
                throw new ArgumentNullException(nameof(student));
            return GPA.CompareTo(student.GPA);
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}
