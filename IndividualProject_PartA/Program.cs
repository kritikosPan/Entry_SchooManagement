using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject_PartA.Domain;
using IndividualProject_PartA.External;


namespace IndividualProject_PartA
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;

            while (displayMenu)
            {
                displayMenu = Run.Menu();
            }
        }
    }
}
