using System;
using System.Collections.Generic;
using System.Drawing;

namespace Homework_12
{
    internal class Student : IComparable<Student>
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

        
        public static Student[] GetBestStudents(Student[] studentsArray)
        {
            if (studentsArray == null)
                throw new ArgumentNullException(nameof(studentsArray));
            if (studentsArray.Length == 0)
                throw new ArgumentException("Given array is empty");

            int count = 0;
            double highestGPA = studentsArray[0].GPA;
            foreach(Student student in studentsArray)
            {
                if(student.GPA > highestGPA)
                {
                    highestGPA = student.GPA;
                }
            }

            foreach(Student student in studentsArray)
            {
                if(highestGPA == student.GPA)
                {
                    count++;
                }
            }

            Student[] bestStudents = new Student[count];
            int index =0;
            foreach(Student student in studentsArray)
            {
                if(highestGPA == student.GPA)
                {
                    bestStudents[index] = student;
                    index++;
                }
            }

            return bestStudents;
        }

        //with collections
        public static List<Student> GetHighestGpaStudents(Student[] studentsArray)
        {
            if (studentsArray == null)
                throw new ArgumentNullException(nameof(studentsArray));
            if (studentsArray.Length == 0)
                throw new ArgumentException("Given array is empty");

            double highestGPA = studentsArray[0].GPA;
            foreach(Student student in studentsArray)
            {
                if (student.GPA > highestGPA)
                    highestGPA = student.GPA;
            }

            List<Student> highestGPAStudents = new List<Student>();
            foreach (Student student in studentsArray)
            {
                if (highestGPA == student.GPA)
                    highestGPAStudents.Add(student);
            }

            return highestGPAStudents;
        }

        public static double GetGpaAverage(Student[] studentsArray)
        {
            if (studentsArray == null)
                throw new ArgumentNullException(nameof(studentsArray));
            if (studentsArray.Length == 0)
                throw new ArgumentException("Given array is empty");

            double sum = 0;
            double gpaAevrage;
            foreach(Student student in studentsArray)
            {
                sum += student.GPA;
            }

            gpaAevrage = sum / studentsArray.Length;
            return gpaAevrage;
        }

        //with collections
        public static List<Student> GetStudentsByLastName(string lastName, Student[] studentsArray)
        {
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Given Lastname is emtpy");
            if(studentsArray == null)
                throw new ArgumentNullException(nameof(studentsArray));
            if (studentsArray.Length == 0)
                throw new ArgumentException("Given Array is empty");

            List<Student> resultStudents = new List<Student>();
            foreach(Student student in studentsArray)
            {
                if (student.LastName.ToLower().Contains(lastName.Trim().ToLower()))
                    resultStudents.Add(student);
            }

            return resultStudents;
        }

        public static Student[] FindStudentsByLastName(string lastName, Student[] studentsArray)
        {
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Given Lastname is emtpy");
            if (studentsArray == null)
                throw new ArgumentNullException(nameof(studentsArray));
            if (studentsArray.Length == 0)
                throw new ArgumentException("Given Array is empty");

            int count = 0;
            foreach(Student student in studentsArray)
            {
                if (student.LastName.ToLower().Contains(lastName.Trim().ToLower()))
                    count++;
            }

            Student[] foundStudents = new Student[count];
            int index = 0;
            foreach(Student student in studentsArray)
            {
                if (student.LastName.ToLower().Contains(lastName.Trim().ToLower()))
                {
                    foundStudents[index] = student;
                    index++;
                }
                    
            }
            return foundStudents;
        }

        public static bool ContainsStudent(string lastName, Student[] studentsArray)
        {
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Given Lastname is emtpy");
            if (studentsArray == null)
                throw new ArgumentNullException(nameof(studentsArray));
            if (studentsArray.Length == 0)
                throw new ArgumentException("Given Array is empty");

            foreach(Student student in studentsArray)
            {
                if (student.LastName.ToLower().Contains(lastName.Trim().ToLower()))
                {
                    return true;
                }
            }
            return false;
        }
    
        public static Student[] SortByGpa(Student[] studentsArray)
        {
            if (studentsArray == null)
                throw new ArgumentNullException(nameof(studentsArray));
            if (studentsArray.Length == 0)
                throw new ArgumentException("Given Array is empty");

            Array.Sort(studentsArray);
            Array.Reverse(studentsArray);
            return studentsArray;
        }

        public int CompareTo(Student student)
        {
            if (student == null)
                throw new ArgumentNullException(nameof(student));
            return GPA.CompareTo(student.GPA);
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
