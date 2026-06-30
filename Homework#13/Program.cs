using Homework_13.Models;
using Homework_13.Services;
using System.Collections.Generic;

namespace Homework_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentService manager = new StudentService();

            string chooser = "1";
            while (chooser != "0")
            {
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. find student");
                Console.WriteLine("3. update score");
                Console.WriteLine("4. show all students");
                Console.WriteLine("0. Exit");
                chooser = Console.ReadLine();

                switch (chooser)
                {
                    case "1":
                        try
                        {
                            Console.WriteLine("Add Student");
                            Console.Write("Enter a student name: ");
                            string name = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(name))
                                throw new ArgumentException("Name cannot be empty");
                            Console.Write("Enter a student's score: ");
                            int score;
                            bool isValidScore = int.TryParse(Console.ReadLine(), out score);
                            if (!isValidScore)
                                throw new FormatException("Invalid input!");
                            if (score < 0 || score > 100)
                                throw new ArgumentException("Score must betwee 0 and 100");

                            Student student1 = new Student(name, score);
                            manager.AddStudent(student1);
                            manager.PrintData();
                        }
                        catch(FormatException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "2":
                        try
                        {
                            Console.WriteLine("Find Student");
                            Console.Write("Please Enter a name: ");
                            string name = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(name))
                                throw new ArgumentException("Name cannot be empty");
                            int score =  manager.GetScoreByName(name);
                            Console.WriteLine($"Student {name} has {score} Score");
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "3":
                        try
                        {
                            Console.WriteLine("Update score");
                            Console.Write("Please Enter a name: ");
                            string name = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(name))
                                throw new ArgumentException("Name cannot be empty");
                            if (!manager.NameExists(name))
                                throw new ArgumentException("There is no student with this name");

                            Console.WriteLine($"Student - {name} has {manager.GetScoreByName(name)} score");
                            Console.Write("Please Enter a new Score: ");
                            int newScore;
                            bool isValidNewScore = int.TryParse(Console.ReadLine(), out newScore);
                            if (!isValidNewScore)
                                throw new FormatException("Invalid input!");
                            manager.UpdateStudent(name, newScore);
                            Console.WriteLine($"Student - {name} has {manager.GetScoreByName(name)} score now");
                        }
                        catch(FormatException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "4":
                        try
                        {
                            Console.WriteLine("Show All Students");
                            manager.PrintData();
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "0":

                        Console.WriteLine("Exsit");
                        return;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
             
        }
    }
}
