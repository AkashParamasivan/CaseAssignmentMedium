using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp2
{
	class Employee
	{
		int id, age;
		string name;
		double salary;
		int Ch = 1;

		IDictionary<int, Tuple<string, int, double>> employees = new Dictionary<int, Tuple<string, int, double>>();
		public Employee()
		{
		}
		public Employee(int id, int age, string name, double salary)
		{
			this.id = id;
			this.age = age;
			this.name = name;
			this.salary = salary;
		}
		public void TakeEmployeeDetailsFromUser()
		{
			Console.WriteLine("Please enter the employee ID");
			id = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Please enter the employee name");
			name = Console.ReadLine();
			Console.WriteLine("Please enter the employee age");
			age = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Please enter the employee salary");
			salary = Convert.ToDouble(Console.ReadLine());
		}

		public void InsertInfo()
		{
			do
			{
				TakeEmployeeDetailsFromUser();
				employees.Add(Id, Tuple.Create(Name, Age,Salary));
				Console.WriteLine("To continue entering employee details enter 1, to exit enter 0");
				Ch = Convert.ToInt32(Console.ReadLine());
			} while (Ch == 1);


		}

		public void SortAndPrintEmployees()
		{
			Console.WriteLine("The sorted employee list");
			foreach (var emp in employees.OrderBy(key => key.Value.Item3))
			{

				Console.WriteLine("Employee ID:{0}\nName:{1}\nAge:{2}\nSalary:{3}", emp.Key, emp.Value.Item1, emp.Value.Item2, emp.Value.Item3);
				Console.WriteLine("-------------------------------");


			}
		}

		public void PrintEmployee()
		{
			Console.WriteLine("Please enter the employee ID");
			int id1 = Convert.ToInt32(Console.ReadLine());
			//var result =from i in employees where i.Key == id1 select i;
			//Console.WriteLine(result);
			foreach (var obj in employees)
			{
				if (obj.Key == id1)
				{
					Console.WriteLine("Employee ID:{0}\nName:{1}\nAge:{2}\nSalary:{3}", obj.Key, obj.Value.Item1, obj.Value.Item2, obj.Value.Item3);


				}
			}


		}

		public void PrintNameInfo()
		{
			Console.WriteLine("Please enter the employee name");
			string name1 = Console.ReadLine();
			foreach (var obj in employees)
			{
				if (obj.Value.Item1 == name1)
				{
					Console.WriteLine("Employee ID:{0}\nName:{1}\nAge:{2}\nSalary:{3}", obj.Key, obj.Value.Item1, obj.Value.Item2, obj.Value.Item3);

					continue;
				}
			}

		}

		public void FindCompareElderInfo()
		{
		    Console.WriteLine("Please enter the employee ID");
			int id1 = Convert.ToInt32(Console.ReadLine());
			int Com_age = 0;


			foreach (var obj in employees)
			{
				if (obj.Key == id1)
				{
					Com_age = obj.Value.Item2;
				}
			}
			foreach (var obj in employees)
			{
				if (obj.Value.Item2 > Com_age)
				{
					Console.WriteLine("Employee ID:{0}\nName:{1}\nAge:{2}\nSalary:{3}", obj.Key, obj.Value.Item1, obj.Value.Item2, obj.Value.Item3);

				}
			}

		}



		public override string ToString()
		{
			return "Employee ID : " + id + "\nName : " + name + "\nAge : " + age +
		   "\nSalary : " + salary;
		}
		public int Id { get => id; set => id = value; }
		public int Age { get => age; set => age = value; }
		public string Name { get => name; set => name = value; }
		public double Salary { get => salary; set => salary = value; }



		
	}
}
