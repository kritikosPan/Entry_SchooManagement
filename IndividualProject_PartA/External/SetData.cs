using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject_PartA.Domain;
using IndividualProject_PartA.Relationships;

namespace IndividualProject_PartA.External
{
    class SetData
    {

        public static void SetAndPrintCourses()
        {
            Console.Clear();
            Console.WriteLine("TYPE THE DATA BELOW...");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Course.StringInputCourse();
            Course.PrintCourses();
        }

        public static void SetAndPrintStudents()
        {
            Console.Clear();
            Console.WriteLine("TYPE THE DATA BELOW...");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Student.StringInputStudent();
            Student.PrintStudents();
        }

        public static void SetAndPrintRandomCourses()
        {
            Console.Clear();
            Console.WriteLine("TYPE THE DATA BELOW...");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Course.SetRandomCourse();
            Course.PrintCourses();
        }

        public static void SetAndPrintRandomStudents()
        {
            Console.Clear();
            Console.WriteLine("TYPE THE DATA BELOW...");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Student.SetRandomStudent();
            Student.PrintStudents();
        }

        public static void SetAndPrintStudentsPerCourse()
        {
            Console.Clear();
            Console.WriteLine("TYPE THE DATA BELOW...");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            //
            Course.PrintStudentsPerCourse();
        }

        public static void SetAndPrintTrainers()


        {
            Console.Clear();
            Console.WriteLine("TYPE THE DATA BELOW...");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Trainer.StringInputTrainer();
            Trainer.PrintTrainers();
        }

        public static void SetAndPrintRandomTrainers()
        {
            Console.Clear();
            Console.WriteLine("TYPE THE DATA BELOW...");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Trainer.SetRandomTrainers();
            Trainer.PrintTrainers();
        }

        public static void SetAndPrintAssignments()
        {
            Console.Clear();
            Console.WriteLine("TYPE THE DATA BELOW...");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Assignment.StringInputAssignment();
            Assignment.PrintAssignments();
        }

        public static void SetAndPrintRandomAssignments()
        {
            Console.Clear();
            Console.WriteLine("TYPE THE DATA BELOW...");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Assignment.SetRandomAssignments();
            Assignment.PrintAssignments();
        }

        public static void SetAndPrintTrainersPerCourse()
        {
            Console.Clear();
            Console.WriteLine("TYPE THE DATA BELOW...");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            TrainersPerCourse.PrintTrainerPerCourse();
        }

        public static void SetAndPrintAssignmentPerStudent()
        {
            Console.Clear();
            Console.WriteLine("TYPE THE DATA BELOW...");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            AssingmentsPerStudent.AssignmentPerStudent();
            Assignment.PrintAssignments();
            Student.PrintStudents();
        }

        public static void SetAndPrintAssignmentsPerCourse()
        {
            Console.Clear();
            Console.WriteLine("TYPE THE DATA BELOW...");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            AssignmentsPerCourse.SetAssignmentPerCourse();
            //AssignmentsPerCourse.PrintAssignmentPerCourse();
        }

        public static void SetAndPrintStudentBelongMoreThankOneCourses()
        {
        }
    }
}







































        

    


