
namespace Homework_10
{
    internal class Engineer : Worker
    {
        public Engineer(string name, string surname, string id, decimal salary)
        {
            this.Name = name;
            this.Surname = surname;
            this.Id = id;
            this.Salary = salary;
            this.Position = "Engineer";
        }
        public override void Print()
        {
            Console.WriteLine("The worker is Engineer");
        }
    }
}
