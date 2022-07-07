using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject_PartA.Domain;

namespace IndividualProject_PartA.Relationships
{
    public class AssignmentsPerCourse
    {

        AssignmentsPerCourse assignmentsPerCourse = new AssignmentsPerCourse();

        public List<Assignment> Assignments { get; set; } = new List<Assignment>();


        public static void SetAssignmentPerCourse()
        {
            Assignment a1 = new Assignment()
            {
                Title = "Assignment 1",
                Description = "C",
                SubDateTime = DateTime.Now,
                OralMark = 50,
                PaperMark = 50,
                TotalMark = 100
            };

            Assignment a2 = new Assignment()
            {
                Title = "Assignment 2",
                Description = "C++",
                SubDateTime = DateTime.Now,
                OralMark = 15,
                PaperMark = 60,
                TotalMark = 75
            };

            Assignment a3 = new Assignment()
            {
                Title = "Assignment 3",
                Description = "C#",
                SubDateTime = DateTime.Now,
                OralMark = 55,
                PaperMark = 30,
                TotalMark = 85
            };

            Assignment a4 = new Assignment()
            {
                Title = "Assignment 4",
                Description = "Java",
                SubDateTime = DateTime.Now,
                OralMark = 35,
                PaperMark = 35,
                TotalMark = 70
            };

            Assignment a5 = new Assignment()
            {
                Title = "Assignment 5",
                Description = "JavaScript",
                SubDateTime = DateTime.Now,
                OralMark = 60,
                PaperMark = 30,
                TotalMark = 90
            };

            Assignment a6 = new Assignment()
            {
                Title = "Individual Project PartA",
                Description = "Pascal",
                SubDateTime = DateTime.Now,
                OralMark = 40,
                PaperMark = 20,
                TotalMark = 60
            };

            Assignment a7 = new Assignment()
            {
                Title = "Individual Project PartB",
                Description = "C",
                SubDateTime = DateTime.Now,
                OralMark = 75,
                PaperMark = 5,
                TotalMark = 80
            };


            Course c1 = new Course()
            {
                Type = "Paertime",
                Title = "CB 1",
                Stream = ".NET",
                Start_Date = DateTime.Now,
                End_Date = DateTime.Now
            };

            Course c2 = new Course()
            {
                Type = "FullTime",
                Title = "CB 2",
                Stream = "AZURE",
                Start_Date = DateTime.Now,
                End_Date = DateTime.Now
            };

            Course c3 = new Course()
            {
                Type = "SUMMERCAMP",
                Title = "CB 3",
                Stream = "CLOUDS SERVICES",
                Start_Date = DateTime.Now,
                End_Date = DateTime.Now
            };

            Course c4 = new Course()
            {
                Type = "ADVANCE",
                Title = "CB 4",
                Stream = "JAVA",
                Start_Date = DateTime.Now,
                End_Date = DateTime.Now
            };

            Course c5 = new Course()
            {
                Type = "PART-TIME",
                Title = "CB 5",
                Stream = "VISUAL BASIC",
                Start_Date = DateTime.Now,
                End_Date = DateTime.Now
            };


            c1.Assignments = new List<Assignment> { a1, a2, a3, a4, a5, a6, a7 };
            c2.Assignments = new List<Assignment> { a1, a2, a3, a4, a5, a6, a7 };
            c3.Assignments = new List<Assignment> { a1, a2, a3, a4, a5, a6, a7 };
            c4.Assignments = new List<Assignment> { a1, a2, a3, a4, a5, a6, a7 };
            c5.Assignments = new List<Assignment> { a1, a2, a3, a4, a5, a6, a7 };

            a1.Courses = new List<Course> { c1, c2, c3, c4, c5 };
            a2.Courses = new List<Course> { c1, c2, c3, c4, c5 };
            a3.Courses = new List<Course> { c1, c2, c3, c4, c5 };
            a4.Courses = new List<Course> { c1, c2, c3, c4, c5 };
            a5.Courses = new List<Course> { c1, c2, c3, c4, c5 };

            List<Course> lista = new List<Course> { c1, c2, c3, c4, c5 };
            Course.Courses.AddRange(lista);

            List<Assignment> listb = new List<Assignment> { a1, a2, a3, a4, a5, a6, a7 };
            Assignment.Assignments.AddRange(listb);

        }

        public static void PrintAssignmentPerCourse(List<Course> Courses, string message)
        {
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("LIST ASSIGNMENT PER COURSE...");
            Console.WriteLine(message);


            foreach (var course in Course.Courses)
            {
                course.PrintTitle();
                
                foreach (var assignment in course.Assignments)
                {
                    assignment.PrintAssignmentPerCourse();
                                    }
                Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
            }
        }

        
    }
}










