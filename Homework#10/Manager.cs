
namespace Homework_10
{
    internal class Manager : Worker
    {
        public Manager(string name, string surname, string id, decimal salary)
        {
            this.Name = name;
            this.Surname = surname;
            this.Id = id;
            this.Salary = salary;
            this.Position = "Manager";
        }
        public override void Print()
        {
            Console.WriteLine("The Worker is Manager");
        }
    }
}
