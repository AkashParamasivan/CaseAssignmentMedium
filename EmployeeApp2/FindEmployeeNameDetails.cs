using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp2
{
    class FindEmployeeNameDetails:Employee
    {
        static void Main(string[] args) 
        {
            FindEmployeeNameDetails em2 = new FindEmployeeNameDetails();

            //-----inserting details-------
            em2.InsertInfo();

            //---------sorting employee list----------------

            em2.SortAndPrintEmployees();

            //---------PrintNameInfo----------------

            em2.PrintNameInfo();

            Console.ReadLine();


        }
    }
}
