using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp2
{
    class EmployeeSort:Employee
    {
        static void Main(string[] args)
        {
            EmployeeSort em1 = new EmployeeSort();
            //-----inserting details-------
            em1.InsertInfo();
            //---------sorting employee list----------------

            em1.SortAndPrintEmployees();

            //----------PrintEmployeeDetails------------

            em1.PrintEmployee();


            Console.ReadLine();

        }
    }
}
