using System.Diagnostics;
using System.Drawing;
using System.Reflection;

namespace Homework_9
{
    internal class Employ
    {
        string _name;
        string _surname;
        DateTime _dateOfBirth;
        Country _country;
        Gender _gender;
        Contacts _contacts;

        public Employ(string name, string surname, DateTime dateOfBirth, Country country, Gender gender, Contacts contacts)
        {
            this.Name = name;
            this.Surname = surname;
            this.DateOfBirth = dateOfBirth;
            this.Country = country;
            this.Gender = gender;
            this.Contacts = contacts;
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
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Surname cannot be empty");
                _surname = value.Trim();
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("Date of birth cannot be in the future");
                _dateOfBirth = value;
            }
        }

        public Country Country
        {
            get
            {
                return _country;
            }
            set
            {
                if (!Country.TryParse(value.ToString(), out _country))
                    throw new ArgumentException("Invalid country");

                _country = value;
            }
        }

        public Gender Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                if (!Gender.TryParse(value.ToString(), out _gender))
                    throw new ArgumentException("Invalid gender");
                _gender = value;
            }
        }

        public Contacts Contacts
        {
            get
            {
                return _contacts;
            }
            set
            {
                if (!Contacts.TryParse(value.ToString(), out _contacts))
                    throw new ArgumentException("Invalid contacts");
                _contacts = Contacts;
            }
        }
   
    
        public int GetAge()
        {
            int age = DateTime.Now.Year - DateOfBirth.Year;
            return age;
        }

       
        public override string? ToString()
        {
            return $"Name - {Name}, Surname - {Surname}, DateOfBirth - {DateOfBirth}, " +
                $"Country - {Country}, Gender - {Gender}, Contacts - {Contacts}";
        }

    }


    public enum Country 
    {
        Georgia,
        Spain,
        Italy,
        Sweden
    }
    public enum Gender: byte
    {
        female,
        male,
        other
    }

    public enum Contacts :byte
    {
        email,
        phoneNumber,
        fax
    }

}
