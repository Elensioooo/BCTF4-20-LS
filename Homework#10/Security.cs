

namespace Homework_10
{
    internal class Security : Worker
    {
        public Security(string name, string surname, string id, decimal salary)
        {
            this.Name = name;
            this.Surname = surname;
            this.Id = id;
            this.Salary = salary;
            this.Position = "Security";
        }
        public override void Print()
        {
            Console.WriteLine("The Worker is Security");
        }
    }
}
