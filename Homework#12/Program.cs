using Homework_12.Enums;
using Homework_12.Loggers;
using Homework_12.Models;
using Homework_12.Services;


namespace Homework_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentManagerService manager = new StudentManagerService();
            string chooser = "1";
            while (chooser != "8")
            {
                Console.WriteLine("Menu: Select One of them");
                Console.WriteLine("1. Display students");
                Console.WriteLine("2. Find the best student");
                Console.WriteLine("3. Calculate average GPA");
                Console.WriteLine("4. Search student by lastName");
                Console.WriteLine("5. Sort students by GPA");
                Console.WriteLine("6. Add student");
                Console.WriteLine("7. Remove student");
                Console.WriteLine("8. Exit");

                chooser = Console.ReadLine();
                switch (chooser)
                {
                    case "1":
                        Console.WriteLine("Display Studetns: ");
                        Student[] students = manager.GetStudetns();
                        foreach(Student student in students)
                        {
                            Console.WriteLine(student.ToString());
                        }
                        break;

                    case "2":
                        Console.WriteLine("Find the best student(s): ");
                        Student[] bestStudents = manager.GetBestStudents();
                        //List<Student> HighestGpaStudents = manager.GetHighestGpaStudents();
                        foreach (Student student in bestStudents)
                        {
                            Console.WriteLine(student.ToString());
                        }
                        break;

                    case "3":
                        Console.WriteLine("Calculate Average GPA: ");
                        double gpaAverage = manager.GetGpaAverage();
                        Console.WriteLine($"Average GPA: {gpaAverage}");
                        break;

                    case "4":
                        Console.WriteLine("Search student by lastName");
                        try
                        {
                            Console.WriteLine("Enter lastname please: ");
                            string lastName = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(lastName))
                                throw new ArgumentException("Lastname cannot be empty");

                            if (manager.ContainsLastName(lastName))
                            {
                                Student[] studentsByLastname = manager.FindStudentsByLastName(lastName);
                                foreach (Student student in studentsByLastname)
                                {
                                    Console.WriteLine(student.ToString());
                                }
                            }
                            else
                            {
                                Console.WriteLine("There is no student with this lastname");
                            }
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case "5":
                        Console.WriteLine("Sort students by GPA");
                        Student[] studentsSortedByGpa = manager.SortByGpa();
                        foreach(Student student in studentsSortedByGpa)
                        {
                            Console.WriteLine(student.ToString());
                        }
                        break;

                    case "6":
                        Console.WriteLine("Add student");

                        try
                        {
                            //name
                            Console.WriteLine("Please Enter Name: ");
                            string name = Console.ReadLine();
                            if (string.IsNullOrEmpty(name))
                                throw new ArgumentException("name cannot be empty");

                            //lastName
                            Console.WriteLine("Enter Lastname: ");
                            string lastName = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(lastName))
                                throw new ArgumentException("lastName cannot be empty");

                            //age
                            Console.WriteLine("Please Enter Age(student age must be greater than 16)");
                            byte age;
                            bool isValidAge = byte.TryParse(Console.ReadLine(), out age);
                            if (!isValidAge)
                                throw new ArgumentException("Invalid input!");
                            if (age <= 16)
                                throw new ArgumentOutOfRangeException("Age must be grater than 16!");

                            //phone number
                            Console.WriteLine("Please enter phone number: ");
                            string phone = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(phone))
                                throw new ArgumentException("phone cannot be empty");
                            
                            //gpa
                            Console.WriteLine("Please Enter GPA(from 0 to 100): ");
                            double gpa;
                            bool validGpa = double.TryParse(Console.ReadLine(), out gpa);
                            if (!validGpa)
                                throw new ArgumentException("Invalid input");
                            if (gpa < 0 || gpa > 100)
                                throw new ArgumentOutOfRangeException("GPA must be between 0 and 100.");

                            //email
                            Console.WriteLine("Please Enter Email: ");
                            string email = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(email))
                                throw new ArgumentException("email cannot be empty");
                            if (!email.Contains('@'))
                                throw new ArgumentException("Email must contain @ character");


                            Console.WriteLine("Please enter Faculty: IT, Business, Design, Medicine");
                            Faculty faculty;
                            bool validFaculty = Enum.TryParse(Console.ReadLine(), out faculty);
                            if (!validFaculty)
                                throw new ArgumentException("Invalid Input");

                            double convertedGpa = (gpa / 100.0) * 4;
                            Student newStudent = new Student(name, lastName, age, email, phone, convertedGpa, faculty);
                            manager.AddStudent(newStudent);
                            Console.WriteLine("Student Added!");
                            goto case "1";
                        }
                        catch (ArgumentOutOfRangeException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    
                    case "7":
                        Console.WriteLine("Remove student: ");

                        try
                        {
                            Console.WriteLine("Please Enter student's email: ");
                            string email = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(email))
                                throw new ArgumentException("email cannot be empty");
                            if (!email.Contains('@'))
                                throw new ArgumentException("Email must contain @ character");
                            
                            if (manager.ContainsEmail(email))
                            {
                                manager.DeleteStudent(email);
                                Console.WriteLine("Student delated");
                                goto case "1";
                            }
                            else
                            {
                                Console.WriteLine("There is not student with this email");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "8":
                        return;
                    default:
                        Console.WriteLine("Invalid choose");
                        break;
                }

            }

            Console.WriteLine();
            using Logger logger = new Logger();
            logger.Dispose();
            Console.ReadKey();
        }
    }
}
