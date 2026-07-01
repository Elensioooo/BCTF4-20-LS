using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_14.Models
{
    internal class Student
    {
        double _gpa;
        int _age;

        public Student(double gpa, int age )
        {
            this.GPA = gpa;
            this.Age = age;
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

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 16)
                    throw new ArgumentException("student age must be grater than 16!");
                _age = value;
            }
        }

        public override string ToString()
        {
            return $"Age - {Age}, GPA - {GPA}";
        }
    }
}
