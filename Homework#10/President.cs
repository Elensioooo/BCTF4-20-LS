using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
    internal class President : Worker
    {
        
        public President(string name, string surname, string id, decimal salary) 
        {
            this.Name = name;
            this.Surname = surname;
            this.Id = id;
            this.Salary = salary;
            this.Position = "President";
        }


        public override void Print()
        {
            Console.WriteLine("The Worker is President");
        }
    }
}
