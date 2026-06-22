namespace Homework_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Student[] studentsArray =
            {
                new Student("Sandro", "Bochorisvhili", 21, "Email@gamil.com", "599555888", 3.0, Faculty.Business),
                new Student("Mariami", "Loria", 19, "Email@gamil.com", "599555888", 2.5, Faculty.Business),
                new Student("Elene", "Morgoshia", 20, "Email@gamil.com", "599555888", 3.5, Faculty.IT),
                new Student("Nikolozi", "Morgoshia", 17, "Email@gamil.com", "599555888", 2.0, Faculty.Design),
                new Student("Alexandre", "Gvaramia", 17, "Email@gamil.com", "599555888", 3.8, Faculty.Business),
                new Student("Demetre", "Vasadze", 18, "Email@gamil.com", "599555888", 4.0, Faculty.IT),
                new Student("Gvantsa", "Vadachkoria", 21, "Email@gamil.com", "599555888", 2.4, Faculty.IT),
                new Student("Lika", "Meladze", 21, "Email@gamil.com", "599555888", 2.1, Faculty.IT),
                new Student("Ana", "Aslanisvhili", 22, "Email@gamil.com", "599555888", 3.9, Faculty.Business),
                new Student("Giorgi", "beroshivili", 20, "Email@gamil.com", "599555888", 4.0, Faculty.Design),
            };

            foreach (Student student in studentsArray)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("The best students are: ");
            Student[] theBestStudents = Student.GetBestStudents(studentsArray);
            foreach (Student student in theBestStudents)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("The best students again(with collection): ");
            List<Student> bestStudents = Student.GetHighestGpaStudents(studentsArray);
            foreach (Student student in bestStudents)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine();
            double gpaAverage = Student.GetGpaAverage(studentsArray);
            Console.WriteLine($"Average of Students GPA: {gpaAverage}");

            Console.WriteLine();
            Console.WriteLine("Please Enter a lastName: ");
            string studentLastName = Console.ReadLine();
            if(Student.ContainsStudent(studentLastName, studentsArray))
            {
                List<Student> resultStudents = Student.GetStudentsByLastName(studentLastName, studentsArray);
                Console.WriteLine($"Students whose lastname is {studentLastName}:");
                foreach (Student student in resultStudents)
                {
                    Console.WriteLine(student.ToString());
                }
            }
            else
            {
                Console.WriteLine("There is no student with this lastName");
            }

            Console.WriteLine();
            Console.WriteLine("Please Enter a lastName: ");
            string lastName = Console.ReadLine();
            if(Student.ContainsStudent(lastName, studentsArray))
            {
                Student[] foundStudents = Student.FindStudentsByLastName(lastName, studentsArray);
                Console.WriteLine($"Students whose lastname is {lastName}: ");
                foreach (Student student in foundStudents)
                {
                    Console.WriteLine(student.ToString());
                }
            }
            else
            {
                Console.WriteLine("There is no student with this lastname");
            }

            Console.WriteLine();
            Console.WriteLine("Students sorted by GPA: ");
            Student[] sortedByGpaStudents = Student.SortByGpa(studentsArray);
            foreach(Student student in sortedByGpaStudents)
            {
                Console.WriteLine(student.ToString());
            }
            Console.ReadKey();
        }
    }
}
