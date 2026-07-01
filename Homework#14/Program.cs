using Homework_14.Models;

namespace Homework_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(50);
            numbers.Add(-20);
            numbers.Add(500);
            numbers.Add(-50);
            numbers.Add(250);
            numbers.Add(400);
            numbers.Add(800);
            numbers.Add(250);
            numbers.Add(-50);

            IEnumerable<int> positiveNumbers = Algorithms.MyWhere(numbers, number => number > 0);
            foreach(int number in positiveNumbers)
            {
                Console.WriteLine(number);
            }

            Student student1 = new Student(2.5, 21);
            Student student2 = new Student(4.0, 21);
            Student student3 = new Student(2.0, 21);
            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            IEnumerable<Student> sortedByGpa = Algorithms.MyOrderBy(students, (Student student) => student.GPA);
            foreach(Student student in sortedByGpa)
            {
                Console.WriteLine(student.ToString());
            }

            int firstElement = Algorithms.MyFirst(numbers);
            Console.WriteLine($"first Element - {firstElement}");

            Console.WriteLine("first element that is greater than 200 in numbers colleciton: ");
            Console.WriteLine(Algorithms.MyFirstOrDefault(numbers, number => number > 200));

            Console.WriteLine("Element that is grater than 500");
            Console.WriteLine(Algorithms.MySingle(numbers, number => number > 500));

            Console.WriteLine();
            Console.WriteLine(Algorithms.myAny(numbers, number => number > 200));

            Console.WriteLine();
            Console.WriteLine(Algorithms.myCount(numbers, number => number > 200));
            Console.WriteLine(Algorithms.myCount(numbers, null));

            Console.WriteLine();
            IEnumerable<int> uniqueNumbers = Algorithms.MyDistinct(numbers);
            foreach(int number in uniqueNumbers)
            {
                Console.WriteLine(number);
            }

        }

    }

    

}
