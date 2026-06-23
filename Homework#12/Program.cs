using System;
using System.Numerics;

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
            if (Student.ContainsLastName(studentLastName, studentsArray))
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
            if (Student.ContainsLastName(lastName, studentsArray))
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
            foreach (Student student in sortedByGpaStudents)
            {
                Console.WriteLine(student.ToString());
            }


            Console.WriteLine();
            try
            {
                Console.WriteLine("Please Enter the student information: ");

                Console.WriteLine("Enter Name: ");
                string userName = Console.ReadLine();
                if (string.IsNullOrEmpty(userName))
                    throw new ArgumentNullException(nameof(userName));

                Console.WriteLine("Enter Lastname: ");
                string userLastName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userLastName))
                    throw new ArgumentNullException(nameof(userLastName));

                Console.WriteLine("Enter Age: ");
                byte age;
                bool validUserAge = byte.TryParse(Console.ReadLine(), out age);
                if (!validUserAge)
                    throw new FormatException();
                if (age <= 16)
                    throw new ArgumentOutOfRangeException("Age must be greater than 16!");

                Console.WriteLine("Enter Email: ");
                string email = Console.ReadLine();
                if (email == null)
                    throw new ArgumentNullException(nameof(email));
                if (!email.Contains('@'))
                    throw new FormatException("Email must contain @ character");


                Console.WriteLine("Enter phone number: ");
                string phoneNumber = Console.ReadLine();
                if (phoneNumber == null)
                    throw new ArgumentNullException(nameof(phoneNumber));

                Console.WriteLine("Enter GPA(0 - 100)");
                double gpa;
                bool validGpa = double.TryParse(Console.ReadLine(), out gpa);
                if (!validGpa)
                    throw new FormatException("Invalid input");
                if (gpa < 0 || gpa > 100)
                    throw new ArgumentOutOfRangeException("GPA must be between 0 and 100.");

                Console.WriteLine("Enter Faculty: IT, Business, Design, Medicine");
                Faculty faculty;
                bool validFaculty = Enum.TryParse(Console.ReadLine(), out faculty);
                if (!validFaculty)
                    throw new FormatException("Invalid Input");

                double convertedGpa = (gpa / 100.0) * 4;
                Student newStudent = new Student(userName, userLastName, age, email, phoneNumber, convertedGpa, faculty);
                Student[] updatedStudentsArray = Student.AddStudent(newStudent, studentsArray);
                foreach (Student student in updatedStudentsArray)
                {
                    Console.WriteLine(student.ToString());
                }

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine("Delate the student: ");
            Console.WriteLine("Enter the student's Email: ");
            string studentEmail = Console.ReadLine();
            if(Student.ContainsEmail(studentEmail, studentsArray))
            {
                List<Student> updatedStudents = Student.DeleteStudent(studentEmail, studentsArray);
                foreach(Student student in updatedStudents)
                {
                    Console.WriteLine(student.ToString());
                }
            }
            else
            {
                Console.WriteLine("There is no student with the given email");
            }


            Console.WriteLine("Compare Students(using operators): ");
            Student student1 = new Student("Sandro", "Mamageishvili", 20, "Email@gamil.com", "599555888", 3.5, Faculty.IT);
            Student student2 = new Student("Elene", "Morgoshia", 20, "Email@gamil.com", "599555888", 4.0, Faculty.IT);
            if(student1 > student2)
            {
                Console.WriteLine($"Student1 has better gpa");
            }
            else
            {
                Console.WriteLine("Student2 has better gpa");
            }


            Console.WriteLine();
            using Logger logger = new Logger();
            logger.Dispose();
            Console.ReadKey();
        }
    }
}
