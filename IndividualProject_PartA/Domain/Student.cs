using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject_PartA.External;

namespace IndividualProject_PartA.Domain
{
    public class Student
    {
        public static List<Student> Students = new List<Student>();
        

        public Student() { }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int TuitionFees { get; set; }
        public Course Course { get; set; }
        public List<Assignment> Assignments { get; set; }


        public Student(string firstName, string lastName, DateTime dateOfBirth, int tuitionFees)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            TuitionFees = tuitionFees;
        }

        public static void StringInputStudent()
        {
            Console.Clear();
            Console.WriteLine("TYPE THE DATA OF **STUDENT**, THOSE WHICH TO BE ADDED TO THE LIST...PRESS ANY KEY TO ADD.");
            Console.WriteLine("-----------------------------------------------------------------------------------------");

            bool addExtra = false;
            do
            {
                Console.WriteLine("Type First Name...");
                string firstName = Console.ReadLine();
                Console.WriteLine("Type Last Name...");
                string lastName = Console.ReadLine();
                Console.WriteLine("Type Date of Birth (year), (month), (day)...");
                DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Type Tuition Fees...");
                int tuitionFees = Int32.Parse(Console.ReadLine());

                Student student = new Student();
                Students.Add(student);

                //Course course = new Course();
                //course.CourseStudents.Add(student);

                Console.WriteLine("ADD EXTRA STUDENT ? PRESS Y FOR ***YES***. OTHERWISE, PRESS ANY OTHER KEY TO DISPLAY COURSES LIST.");
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

        public static void PrintStudents()
        {
            Console.WriteLine($"{Student.Students.Count} STUDENTS WERE ADDED. HERE IS THE COURSES LIST:");
            int counter = 0;
            foreach (var student in Student.Students)
            {
                counter++;
                Console.WriteLine($"No:{counter}, {student.FirstName}, {student.LastName}, {student.DateOfBirth}, {student.TuitionFees}");
            }
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }

        public static List<Student> SetRandomStudent()

        {
            Random random = new Random();

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            Console.WriteLine("FOR AUTO COMPLETION WITH SYNTHETIC DATA, MERELY PRESS THE NUMBER....");

            int b = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < b; i++)
            {
                string firstName; string lastName; DateTime dateOfBirth; int tuitionFees;

                string randomFirstName = new string(Enumerable.Repeat(chars, 5).Select(s => s[random.Next(s.Length)]).ToArray());
                firstName = randomFirstName;
                string randomLastName = new string(Enumerable.Repeat(chars, 7).Select(s => s[random.Next(s.Length)]).ToArray());
                lastName = randomLastName;
                int num = random.Next(0, 9000000);
                tuitionFees = num;

                DateTime datetoday = DateTime.Now;

                int rndYear = random.Next(2010, datetoday.Year);
                int rndMonth = random.Next(1, 6);
                int rndDay = random.Next(1, 15);

                DateTime generateDate = new DateTime(rndYear, rndMonth, rndDay);
                dateOfBirth = generateDate;

                Student student = new Student(firstName, lastName, dateOfBirth, tuitionFees);
                Students.Add(student);
            }
            return Students;
            
        }

        public void PrintFullName()
        {
            Console.WriteLine($"STUDENT FULLNAME: {FirstName}  {LastName}");
        }

        
        
    }

}
