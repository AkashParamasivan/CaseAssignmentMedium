using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp2
{
	class EmployeePromotion:Employee
	{
		
		static void Main(string[] args)
		{
		
			Employee em = new Employee();
			
			//-----inserting details-------
			em.InsertInfo();

			//---------sorting employee list----------------

			//em.SortAndPrintEmployees();


			//----------PrintEmployeeDetails------------

			em.PrintEmployee();


			//---------PrintNameInfo----------------

			//em.PrintNameInfo();

			//----------Find&CompareElderInfo-------

			//em.FindCompareElderInfo();

		
			



			Console.ReadLine();

			
		}
	}
}
