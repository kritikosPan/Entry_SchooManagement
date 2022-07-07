using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject_PartA.Domain;

namespace IndividualProject_PartA.Relationships
{
    public class TrainersPerCourse
    {
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();

        public List<Course> Courses { get; set; } = new List<Course>();

        public List<Trainer> CourseTrainers { get; set; } = new List<Trainer>();

        public TrainersPerCourse()
        {





            //Trainer t1 = new Trainer()
            //{
            //    FirstName = "Aleksios",
            //    LastName = "Kaparakis",
            //    Subject = "Java"
            //};


            //Trainer t2 = new Trainer()
            //{
            //    FirstName = "Vasili",
            //    LastName = "Kara",
            //    Subject = "C++"
            //};

            //Trainer t3 = new Trainer()
            //{
            //    FirstName = "Georgios",
            //    LastName = "Kritikos",
            //    Subject = "Javascript"
            //};


            //Course c1 = new Course()
            //{
            //    Type = "Paertime",
            //    Title = "CB 1",
            //    Stream = ".NET",
            //    Start_Date = DateTime.Now,
            //    End_Date = DateTime.Now
            //};

            //Course c2 = new Course()
            //{
            //    Type = "FullTime",
            //    Title = "CB 200000",
            //    Stream = "AZURE",
            //    Start_Date = DateTime.Now,
            //    End_Date = DateTime.Now
            //};

            //Course c3 = new Course()
            //{
            //    Type = "SUMMERCAMP",
            //    Title = "CB 123456789",
            //    Stream = "CLOUDSERVICES",
            //    Start_Date = DateTime.Now,
            //    End_Date = DateTime.Now
            //};

            //c1.Trainers = new List<Trainer> { t1, t2 };
            //t1.Course = c1;
            //t1.Course = c2;

            //c2.Trainers = new List<Trainer> { t2, t3 };
            //t2.Course = c2;
            //t3.Course = c2;

            //c3.Trainers = new List<Trainer> { t1, t2, t3 };
            //t2.Course = c2;
            //t3.Course = c2;
            //t1.Course = c2;


            ////populate

            //List<Trainer> Listtrainer = new List<Trainer>() { t1, t2, t3 };
            //Trainers.AddRange(Listtrainer);


            //List<Course> CourseList = new List<Course>() { c1, c2, c3 };
            //Courses.AddRange(CourseList);



        }

        //public static void PrintTrainerPerCourse()
        //{
        //    Trainer t1 = new Trainer()
        //    {
        //        FirstName = "Aleksios",
        //        LastName = "Kaparakis",
        //        Subject = "Java"
        //    };


        //    Trainer t2 = new Trainer()
        //    {
        //        FirstName = "Vasili",
        //        LastName = "Kara",
        //        Subject = "C++"
        //    };

        //    Trainer t3 = new Trainer()
        //    {
        //        FirstName = "Georgios",
        //        LastName = "Kritikos",
        //        Subject = "Javascript"
        //    };


        //    Course c1 = new Course()
        //    {
        //        Type = "Paertime",
        //        Title = "CB 1",
        //        Stream = ".NET",
        //        Start_Date = DateTime.Now,
        //        End_Date = DateTime.Now
        //    };

        //    Course c2 = new Course()
        //    {
        //        Type = "FullTime",
        //        Title = "CB 200000",
        //        Stream = "AZURE",
        //        Start_Date = DateTime.Now,
        //        End_Date = DateTime.Now
        //    };

        //    Course c3 = new Course()
        //    {
        //        Type = "SUMMERCAMP",
        //        Title = "CB 123456789",
        //        Stream = "CLOUDSERVICES",
        //        Start_Date = DateTime.Now,
        //        End_Date = DateTime.Now
        //    };

        //    c1.Trainers = new List<Trainer> { t1, t2 };
        //    t1.Course = c1;
        //    t1.Course = c2;

        //    c2.Trainers = new List<Trainer> { t2, t3 };
        //    t2.Course = c2;
        //    t3.Course = c2;

        //    c3.Trainers = new List<Trainer> { t1, t2, t3 };
        //    t2.Course = c2;
        //    t3.Course = c2;
        //    t1.Course = c2;


        //    //populate

        //    List<Trainer> Listtrainer = new List<Trainer>() { t1, t2, t3 };
        //    Trainer.Trainers.AddRange(Listtrainer);


        //    List<Course> CourseList = new List<Course>() { c1, c2, c3 };
        //    Course.Courses.AddRange(CourseList);



        //    Console.ReadKey();
        //    Console.Clear();
        //    Console.WriteLine("LIST TRAINER PER COURSE...");
        //    foreach (var course in Course.Courses)
        //    {
        //        course.PrintTitle();

        //        foreach (var trainer in course.Trainers)
        //        {
        //            Console.WriteLine($"{trainer.FirstName} {trainer.LastName}");
        //        }
        //        Console.WriteLine("PRESS ANY KEY TO CONTINUE");
        //        Console.ReadKey();
        //    }

        public static void PrintTrainerPerCourse()
        {
            Trainer t1 = new Trainer()
            {
                FirstName = "Aleksios",
                LastName = "Kaparakis",
                Subject = "Java"
            };


            Trainer t2 = new Trainer()
            {
                FirstName = "Vasili",
                LastName = "Kara",
                Subject = "C++"
            };

            Trainer t3 = new Trainer()
            {
                FirstName = "Georgios",
                LastName = "Kritikos",
                Subject = "Javascript"
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
                Title = "CB 200000",
                Stream = "AZURE",
                Start_Date = DateTime.Now,
                End_Date = DateTime.Now
            };

            Course c3 = new Course()
            {
                Type = "SUMMERCAMP",
                Title = "CB 3",
                Stream = "CLOUDSERVICES",
                Start_Date = DateTime.Now,
                End_Date = DateTime.Now
            };



            c1.Trainers = new List<Trainer> { t1, t2 };
            t1.Course = c1;
            t2.Course = c1;

            c2.Trainers = new List<Trainer> { t2, t3 };
            t2.Course = c2;
            t3.Course = c2;

            c3.Trainers = new List<Trainer> { t1, t2, };
            t1.Course = c3;
            t2.Course = c3;
            //t3.Course = c3;


            //populate

            List<Trainer> TrainersList = new List<Trainer>() { t1, t2, t3 };
            Trainer.Trainers.AddRange(TrainersList);

            List<Course> CourseList = new List<Course>() { c1, c2, c3 };
            Course.Courses.AddRange(CourseList);


            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("LIST TRAINER PER COURSE...");
            if (Course.Courses.Count == 0)
            {
                Console.WriteLine("EMPTY LISTS");
            }
            else
            {
                foreach (var course in Course.Courses)
                {
                    course.PrintTitle();


                    foreach (var trainer in Trainer.Trainers)
                    {
                        trainer.PrintFullNameTrainer();
                    }
                    Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                    Console.ReadKey();
                }
            }


        }


    }
}
