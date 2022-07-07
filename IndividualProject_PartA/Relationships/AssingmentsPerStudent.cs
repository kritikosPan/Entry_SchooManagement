using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject_PartA.Domain;

namespace IndividualProject_PartA.Relationships
{
    public class AssingmentsPerStudent
    {
        public List<Assignment> assignments { get; set; } = new List<Assignment>();

        public List<Student> students { get; set; } = new List<Student>();

        public static void AssignmentPerStudent()
        {
            Assignment.SetRandomAssignments();

            Student.SetRandomStudent();

        }












}
}
