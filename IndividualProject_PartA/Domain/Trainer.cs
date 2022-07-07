using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject_PartA.Domain
{
    public class Trainer
    {
        public static List<Trainer> Trainers = new List<Trainer>();

        public Trainer() { }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public Course Course { get; set; }

        public Trainer(string firstName, string lastName, string subject)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
        }

        public static void StringInputTrainer()
        {
            Console.Clear();
            Console.WriteLine("TYPE THE DATA OF **TRAINER**, THOSE WHICH TO BE ADDED TO THE LIST...PRESS ANY KEY TO ADD.");
            Console.WriteLine("-----------------------------------------------------------------------------------------");

            bool addExtra = false;
            do
            {

                string firstName; string lastName; string subject;
                Console.WriteLine("Type First Name...");
                firstName = Console.ReadLine();
                Console.WriteLine("Type Last Name...");
                lastName = Console.ReadLine();
                Console.WriteLine("Type Subject...");
                subject = Console.ReadLine();

                Trainer trainer = new Trainer(firstName, lastName, subject);
                Trainers.Add(trainer);
                Console.WriteLine("ADD EXTRA TRAINER ? PRESS Y FOR ***YES***. OTHERWISE, PRESS ANY OTHER KEY TO DISPLAY COURSES LIST.");
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

        public static List<Trainer> SetRandomTrainers()
        {
            Random random = new Random();

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            List<string> subjectArrayList = new List<string>() { "C", "C++", "C#", "PHP", "JAVA", "JAVASCRIPT", "PYTHON", "VISUAL_BASIC" };

            Console.WriteLine("FOR AUTO COMPLETION WITH SYNTHETIC DATA, MERELY PRESS THE NUMBER....");

            int b = int.Parse(Console.ReadLine());

            for (int i = 0; i < b; i++)
            {
                string firstName; string lastName; string subject;

                string randomFirstName = new string(Enumerable.Repeat(chars, 5).Select(s => s[random.Next(s.Length)]).ToArray());
                firstName = randomFirstName;
                string randomLastName = new string(Enumerable.Repeat(chars, 7).Select(s => s[random.Next(s.Length)]).ToArray());
                lastName = randomLastName;

                int index = random.Next(subjectArrayList.Count);
                string randomSubject = subjectArrayList[index];
                subject = randomSubject;

                Trainer trainer = new Trainer(firstName, lastName, subject);
                Trainers.Add(trainer);
            }
            return Trainers;
        }

        public static void PrintTrainers()
        {
            Console.WriteLine($"{Trainer.Trainers.Count} TRAINERS WERE ADDED. HERE IS THE TRAINERS LIST:");
            int counter = 0;
            foreach (var trainer in Trainer.Trainers)
            {
                counter++;
                Console.WriteLine($"No:{counter}, FullName {trainer.FirstName} {trainer.LastName}, Subject {trainer.Subject}");
            }
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }

        public void PrintFullNameTrainer()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }



    }
}
