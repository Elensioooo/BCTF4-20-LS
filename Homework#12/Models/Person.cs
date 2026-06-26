using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12.Models
{
    abstract class Person
    {
        private string _name;
        private string _lastName;
        private byte _age;

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
                if (value <= 16)
                    throw new ArgumentException("Age must be greater than 16");
                _age = value;
            }
        }
    }
}
