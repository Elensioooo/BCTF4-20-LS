using Homework_13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_13.Services
{
    internal class StudentService
    {
        List<string> names = new List<string>();
        Dictionary<string, int> students = new Dictionary<string, int>();

        public void AddStudent(Student student)
        {
            if (student == null)
                throw new ArgumentNullException(nameof(student));
            if(students.ContainsKey(student.Name))
                throw new ArgumentException("This name already exists");
      
            students.Add(student.Name, student.Score);
            names.Add(student.Name);
        }

        public int GetScoreByName(string userName)
        {
            if (!NameExists(userName))
                throw new ArgumentException("There is no name like that");
            return students[userName];

        }

        public bool NameExists(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
                throw new ArgumentException("name cannot be emtpy");
            if (students.ContainsKey(userName))
                return true;
            return false;
        }

        public void UpdateStudent(string name, int newScore)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("name cannot be empty");
            if (newScore < 0 || newScore > 100)
                throw new ArgumentException("Score must be between 0 and 100");
            if (!NameExists(name))
                throw new ArgumentException("There is no student with thie name");
            students[name] = newScore;
        }
        public void PrintData()
        {
            if (students.Count == 0)
                throw new ArgumentException("Students Dictionary is empty");
            foreach(var student in students)
            {
                Console.WriteLine($"{student.Key} - {student.Value}");
            }
        }
    }
}
