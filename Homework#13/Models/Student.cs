using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_13.Models
{
    internal class Student
    {
        private string _name;
        private int _score;
        
        public Student(string name, int score)
        {
            this.Name = name;
            this.Score = score;
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
                    throw new ArgumentException("Name cannot be empty");
                _name = value.Trim();
            }
        }

        public int Score 
        {
            get
            {
                return _score;
            }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("Score must be between 0 and 100");
                _score = value;
            }
        }

    }
}
