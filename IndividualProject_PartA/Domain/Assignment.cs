using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject_PartA.Domain
{
    public class Assignment
    {
        public static List<Assignment> Assignments = new List<Assignment>();
        public List<Course> Courses = new List<Course>();
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubDateTime { get; set; }
        public int OralMark { get; set; }
        public int PaperMark { get; set; }
        public int TotalMark { get; set; }
        public Course Course { get; set; }
        public Student Student { get; set; }

        public Assignment(string title, string description, DateTime subDateTime, int oralMark, int paperMark, int totalMark)
        {
            Title = title;
            Description = description;
            SubDateTime = subDateTime;
            OralMark = oralMark;
            PaperMark = paperMark;
            TotalMark = totalMark;
        }

        public Assignment()
        {
        }

        public static void StringInputAssignment()
        {
            Console.Clear();
            Console.WriteLine("TYPE THE DATA OF **ASSIGNMENT**, THOSE WHICH TO BE ADDED TO THE LIST...PRESS ANY KEY TO ADD.");
            Console.WriteLine("-----------------------------------------------------------------------------------------");

            bool addExtra = false;
            do
            {
                string title; string description; DateTime subDateTime; int oralMark; int paperMark; int totalMark;
                Console.WriteLine("Type Title...");
                title = Console.ReadLine();
                Console.WriteLine("Type Description...");
                description = Console.ReadLine();
                Console.WriteLine("Type Submission Date...");
                subDateTime = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Type Oral Mark...");
                oralMark = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Type Paper Mark...");
                paperMark = Int32.Parse(Console.ReadLine());

                totalMark = oralMark + paperMark;

                Assignment assignment = new Assignment(title, description, subDateTime, oralMark, paperMark, totalMark);
                Assignments.Add(assignment);
                Console.WriteLine("ADD EXTRA ASSIGNMENT ? PRESS Y FOR ***YES***. OTHERWISE, PRESS ANY OTHER KEY TO DISPLAY COURSES LIST.");
                var answer = Console.ReadLine();
                if (answer.ToUpper() == "Y")
                {
                    addExtra = true;
                }
                else
                {
                    addExtra = false;
                }
            }
            while (addExtra);
        }

        public static List<Assignment> SetRandomAssignments()
        {
            Random random = new Random();

            List<string> descriptionArrayList = new List<string>() { "C", "C++", "C#", "PHP", "JAVA", "JAVASCRIPT", "PYTHON", "VISUAL_BASIC" };
            List<string> titleArrayList = new List<string>() { "Assignment ", "Assignment 2", "Assignment 3", "Assignment 4", "Assignment 5", "Individual Project PartA", "Individual Project PartA" };

            Console.WriteLine("FOR AUTO COMPLETION WITH SYNTHETIC DATA, MERELY PRESS THE NUMBER....");

            int b = int.Parse(Console.ReadLine());

            for (int i = 0; i < b; i++)
            {
                string title; string description; DateTime subDateTime; int oralMark; int paperMark; int totalMark;

                int index = random.Next(descriptionArrayList.Count);
                string randomdescription = descriptionArrayList[index];

                int index1 = random.Next(titleArrayList.Count);
                string randomTitle = titleArrayList[index1];

                title = randomTitle;
                description = randomdescription;

                DateTime datetoday = DateTime.Now;
                int rndYear = random.Next(0001, 2100);
                int rndMonth = random.Next(1, 12);
                int rndDay = random.Next(1, 30);
                DateTime generateDate = new DateTime(rndYear, rndMonth, rndDay);
                subDateTime = generateDate;

                int num = random.Next(1, 49);
                oralMark = num;

                int num1 = random.Next(1, 49);
                paperMark = num1;

                totalMark = oralMark + paperMark;

                Assignment assignment = new Assignment(title, description, subDateTime, oralMark, paperMark, totalMark);
                Assignments.Add(assignment);
            }
            return Assignments;
        }

        public static void PrintAssignments()
        {
            Console.WriteLine($"{Assignment.Assignments.Count} ASSIGNMENTS WERE ADDED. HERE IS THE TRAINERS LIST:");
            int counter = 0;
            foreach (var assignment in Assignment.Assignments)
            {
                counter++;
                Console.WriteLine($"No:{counter}, Title: {assignment.Title}, Description: {assignment.Description} , SubmissionDate: {assignment.SubDateTime}, TotalMark {assignment.TotalMark} ");
            }
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }

        public void PrintAssignmentPerCourse()
        {
            Console.WriteLine($"Title:{Title} and Description: {Description}");
        }

        
    }

}
