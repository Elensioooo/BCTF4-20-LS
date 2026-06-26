using Homework_12.Enums;
using Homework_12.Helpers;
using Homework_12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12.Services
{
    internal class StudentManagerService
    {
        public StudentManagerService()
        {
            FillData();
        }

        Student[] students = new Student[0];
        private void FillData()
        {
            //Created 10 students and added to the students array 
            AddStudent(new Student("Elene", "Morgoshia", 21, "elene@gmail.com", "599999999", 3.5, Faculty.IT));
            AddStudent(new Student("Sandro", "Malania", 21, "sandro@gmail.com", "599999999", 4.0, Faculty.IT));
            AddStudent(new Student("Mariami", "Kalandadze", 20, "maraimi@gmail.com", "599999999", 2.5, Faculty.IT));
            AddStudent(new Student("Nikolozi", "Morgoshia", 17, "Nikolozi@gmail.com", "599999999", 3.5, Faculty.IT));
            AddStudent(new Student("Barbare", "Malania", 17, "Barbare@gmail.com", "599999999", 4.0, Faculty.IT));
            AddStudent(new Student("Mariami", "Kalandadze", 18, "maraimi@gmail.com", "599999999", 2.5, Faculty.IT));
            AddStudent(new Student("Akaki", "Morgoshia", 22, "Akaki@gmail.com", "599999999", 3.5, Faculty.IT));
            AddStudent(new Student("Demetre", "Malania", 20, "Demetre@gmail.com", "599999999", 4.0, Faculty.IT));
            AddStudent(new Student("Nino", "Kalandadze", 21, "Ninoi@gmail.com", "599999999", 1.5, Faculty.IT));
            AddStudent(new Student("Ana", "Morgoshia", 20, "Ana@gmail.com", "599999999", 3.5, Faculty.IT));
        }

        public void AddStudent(Student newStudent)
        {
            if (newStudent == null)
                throw new ArgumentNullException(nameof(newStudent));
            ArrayHelper.Add(ref students, newStudent);
        }

        public Student[] GetStudetns()
        {
            return students;
        }

        public Student[] GetBestStudents()
        {
            if (students.Length == 0)
                throw new ArgumentException("Students array is empty");

            int count = 0;
            double highestGPA = students[0].GPA;
            foreach (Student student in students)
            {
                if (student.GPA > highestGPA)
                {
                    highestGPA = student.GPA;
                }
            }

            foreach (Student student in students)
            {
                if (highestGPA == student.GPA)
                {
                    count++;
                }
            }

            Student[] bestStudents = new Student[count];
            int index = 0;
            foreach (Student student in students)
            {
                if (highestGPA == student.GPA)
                {
                    bestStudents[index] = student;
                    index++;
                }
            }

            return bestStudents;
        }

        //with collections
        public  List<Student> GetHighestGpaStudents()
        {
            if (students.Length == 0)
                throw new ArgumentException("Students array is empty");

            double highestGPA = students[0].GPA;
            foreach (Student student in students)
            {
                if (student.GPA > highestGPA)
                    highestGPA = student.GPA;
            }

            List<Student> highestGPAStudents = new List<Student>();
            foreach (Student student in students)
            {
                if (highestGPA == student.GPA)
                    highestGPAStudents.Add(student);
            }

            return highestGPAStudents;
        }

        public  double GetGpaAverage()
        {
            if (students.Length == 0)
                throw new ArgumentException("students array is empty");
            double sum = 0;
            double gpaAevrage;
            foreach (Student student in students)
            {
                sum += student.GPA;
            }

            gpaAevrage = sum / students.Length;
            return gpaAevrage;
        }

        public  bool ContainsLastName(string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Given Lastname is emtpy");

            foreach (Student student in students)
            {
                if (student.LastName.ToLower().Contains(lastName.Trim().ToLower()))
                {
                    return true;
                }
            }
            return false;
        }
        public Student[] FindStudentsByLastName(string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Given Lastname is emtpy");

            int count = 0;
            foreach (Student student in students)
            {
                if (student.LastName.ToLower().Contains(lastName.Trim().ToLower()))
                    count++;
            }

            Student[] foundStudents = new Student[count];
            int index = 0;
            foreach (Student student in students)
            {
                if (student.LastName.ToLower().Contains(lastName.Trim().ToLower()))
                {
                    foundStudents[index] = student;
                    index++;
                }

            }
            return foundStudents;
        }

        //with collections
        public  List<Student> GetStudentsByLastName(string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Given Lastname is emtpy");

            List<Student> resultStudents = new List<Student>();
            foreach (Student student in students)
            {
                if (student.LastName.ToLower().Contains(lastName.Trim().ToLower()))
                    resultStudents.Add(student);
            }

            return resultStudents;
        }

        public  Student[] SortByGpa()
        {
            Array.Sort(students);
            Array.Reverse(students);
            return students;
        }


        public  bool ContainsEmail(string email)
        {
            if (email == null)
                throw new ArgumentNullException(nameof(email));

            foreach (Student student in students)
            {
                if (student.Email.Contains(email))
                    return true;
            }
            return false;
        }

        //with collections
        public void  DeleteStudent(string email)
        {
            if (email == null)
                throw new ArgumentNullException(nameof(email));
            List<Student> studentsList = new List<Student>(students);
            for (int i = 0; i < studentsList.Count; i++)
            {
                if (studentsList[i].Email == email)
                {
                    studentsList.Remove(studentsList[i]);
                    break;
                }
            }
            students = studentsList.ToArray();
        }


    }
}
