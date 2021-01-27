using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp2
{
    class FindElderEmployee:Employee
    {
        static void Main(string[] args)
        {
            FindElderEmployee em3 = new FindElderEmployee();

            //-----inserting details-------
            em3.InsertInfo();
            //----------Find & CompareElderInfo------ -

            em3.FindCompareElderInfo();

            Console.ReadKey();
        }

    }
}
