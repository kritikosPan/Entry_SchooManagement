using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject_PartA.Domain;

namespace IndividualProject_PartA.External
{
    public class Run
    {
        public static bool Menu()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("PRESS THE NUMBER ACCORDING TO YOUR CHOICE BELOW    ");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("PRESS 1 TO SET NEW COURSE");
            Console.WriteLine("PRESS 2 TO SET RANDOMLY NEW COURSE");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("PRESS 3 TO SET NEW TRAINER");
            Console.WriteLine("PRESS 4 TO SET RANDOMLY NEW TRAINER");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("PRESS 5 TO SET NEW STUDENT");
            Console.WriteLine("PRESS 6 TO SET RANDOMLY NEW STUDENT");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("PRESS 7 TO SET NEW ASSIGNMENT");
            Console.WriteLine("PRESS 8 TO SET RANDOMLY NEW ASSIGNMENT");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("PRESS 9 FOR STUDENT PER COURSE TO BE DISPLAYED     ");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("PRESS 10 FOR TRAINER PER COURSE TO BE DISPLAYED    ");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("PRESS 11 FOR ASSIGNMENT PER COURSE TO BE DISPLAYED ");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("PRESS 12 FOR ASSIGNMENT PER STUDENT TO BE DISPLAYED ");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("PRESS 13 FOR STUDENT PER COURSE PER ASSIGNMENT PER STUDENT TO BE DISPLAYED");
            Console.WriteLine("PRESS ****** x ****** X ***** TO EXIT..............");

            switch (Console.ReadLine())
            {
                case "1":
                    SetData.SetAndPrintCourses();
                return true;
                case "2":
                    SetData.SetAndPrintRandomCourses();
                    return true;
                case "3":
                    SetData.SetAndPrintTrainers();
                    return true;
                case "4":
                    SetData.SetAndPrintRandomTrainers();
                    return true;
                case "5":
                    SetData.SetAndPrintStudents();
                    return true;
                case "6":
                    SetData.SetAndPrintRandomStudents();
                    return true;
                case "7":
                    SetData.SetAndPrintAssignments();
                    return true;
                case "8":
                    SetData.SetAndPrintRandomAssignments();
                    return true;
                case "9":
                    SetData.SetAndPrintStudentsPerCourse();
                    return true;
                case "10":
                    SetData.SetAndPrintTrainersPerCourse();
                    return true;
                case "11":
                    SetData.SetAndPrintAssignmentsPerCourse();
                    return true;
                case"12":
                    SetData.SetAndPrintAssignmentPerStudent();
                      return true;
                case "13:":
                    SetData.SetAndPrintStudentBelongMoreThankOneCourses();
                    return true;
                case "X":
                    return false;
                case "x":
                    return false;
                default:
                    return true;
            }
        }
    }
}
