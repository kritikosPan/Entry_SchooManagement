using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject_PartA.External;

namespace IndividualProject_PartA.Domain
{
    public class Course
    {
        public static List<Course> Courses = new List<Course>();
        public Course() { }

        public string Title { get; set; }
        public string Stream { get; set; }
        public string Type { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        //Navigation Properties
        public List<Student> Students { get; set; }
        public List<Trainer> Trainers { get; set; }
        public List<Assignment> Assignments { get; set; }

        public Course(string title, string stream, string type, DateTime start_date, DateTime end_date)
        {
            Title = title;
            Stream = stream;
            Type = type;
            Start_Date = start_date;
            End_Date = end_date;
        }

        public static void StringInputCourse()
        {
            Console.Clear();
            Console.WriteLine("TYPE THE DATA OF **COURSE**, THOSE WHICH TO BE ADDED TO THE LIST...PRESS ANY KEY TO ADD.");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            //Console.WriteLine("FOR AUTO COMPLETION WITH SYNTHETIC DATA, MERELY PRESS THE NUMBER....");
            var isValidNumber = int.TryParse(Console.ReadLine(), out int number) && number > 0;
            if (isValidNumber)
            {
                for (int i = 0; i < number; i++) { new Course(); }
            }
            else
            {
                bool addMore;
                do
                {
                    string title; string stream; string type; DateTime start_date; DateTime end_date;
                    Console.WriteLine("Type Title...");
                    Console.WriteLine("Type Stream...");
                    Console.WriteLine("Type the Type...");
                    Console.WriteLine("Type Starting Date (year), (month), (day)...");
                    Console.WriteLine("Type Ending Date (year), (month), (day)...");
                    title = Console.ReadLine();
                    stream = Console.ReadLine();
                    type = Console.ReadLine();
                    start_date = DateTime.Parse(Console.ReadLine());
                    end_date = DateTime.Parse(Console.ReadLine());

                    Course course = new Course(title, stream, type, start_date, end_date);
                    Courses.Add(course);

                    Console.WriteLine("ADD EXTRA COURSE? PRESS Y FOR ***YES***. OTHERWISE, PRESS ANY OTHER KEY TO DISPLAY COURSES LIST.");
                    var answer = Console.ReadLine();

                    if (answer.ToUpper() == "Y") { addMore = true; }
                    else { addMore = false; }
                }
                while (addMore);
            }
        }

        public static void PrintCourses()
        {
            Console.WriteLine($"{Course.Courses.Count} COURSES WERE ADDED. HERE IS THE COURSES LIST:");
            int counter = 0;
            foreach (var course in Course.Courses)
            {
                counter++;
                //Console.WriteLine($"{count} - {course.Title}");
                Console.WriteLine($"No: {counter}, {course.Title}, {course.Stream}, {course.Type}, {course.Start_Date}, {course.End_Date}");
            }
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }

        public static List<Course> SetRandomCourse()
        {
            Random random = new Random();

            List<string> titlesArrayList = new List<string>() { "CB 1", "CB 2", "CB 3", "CB 4", "CB 5", "CB 6", "CB 7", "CB 8", "CB 9", "CB 10", "CB 11", "CB 12", "CB 13", "CB 14", "CB 15", "CB 16" };
            List<string> streamArrayList = new List<string>() { "C", "C++", "C#", "PHP", "JAVA", "JAVASCRIPT", "PYTHON", "VISUAL_BASIC" };
            List<string> typeArrayList = new List<string>() { "FULL-TIME", "PART-TIME" };

            Console.WriteLine("FOR AUTO COMPLETION WITH SYNTHETIC DATA, MERELY PRESS THE NUMBER....");

            int b = int.Parse(Console.ReadLine());

            for (int i = 0; i < b; i++)
            {
                int index = random.Next(titlesArrayList.Count);
                string randomTitle = titlesArrayList[index];

                int index1 = random.Next(streamArrayList.Count);
                string randomStream = streamArrayList[index1];

                int index2 = random.Next(typeArrayList.Count);
                string randomType = typeArrayList[index2];

                string title; string stream; string type; DateTime start_date; DateTime end_date;
                title = randomTitle;
                stream = randomStream;
                type = randomType;

                DateTime datetoday = DateTime.Now;

                int rndYear = random.Next(1980, 2100);
                int rndMonth = random.Next(1, 12);
                int rndDay = random.Next(1, 30);

                DateTime generateDate = new DateTime(rndYear, rndMonth, rndDay);


                start_date = generateDate;
                end_date = generateDate;

                Course course = new Course(title, stream, type, start_date, end_date);
                Courses.Add(course);
            }
            return Courses;
        }

        public void PrintTitle()
        {
            Console.WriteLine(Title);
        }

        public static void PrintStudentsPerCourse()
        {
            Console.Clear();
            Console.WriteLine("LIST STUDENTS PER COURSE...");
            foreach (var course in Course.Courses)
            {
                course.PrintTitle();

                foreach (var student in course.Students)
                {
                    student.PrintFullName();
                }

                Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
            }
        }
    }



}
