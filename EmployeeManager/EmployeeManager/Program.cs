using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager
{
	class Program
	{
		static void CreateSomeData(EmployeeManagerDBContext dbContext)
		{
			var employee1 = new Employee()
			{
				//Address = "123 Ong Ich Khiem",
				Birthday = new DateTime(1990, 2, 2),
				Name = "Nguyen Cao Hoang"
			};

			var employee2 = new Employee()
			{
				//Address = "456 Tran Cao Lam",
				Birthday = new DateTime(1989, 3, 3),
				Name = "Do Tien Dat"
			};

			var employee3 = new Employee()
			{
				//Address = "100 Nguyen Luong Bang",
				Birthday = new DateTime(1970, 4, 4),
				Name = "Nguyen Cao Hoang"
			};

			var department1 = new Department()
			{
				Name = "Phong giam doc",
				Employees = new List<Employee>()
					{
						employee1, employee2
					}
			};

			var department2 = new Department()
			{
				Name = "Phong hanh chinh",
				Employees = new List<Employee>()
					{
						employee3
					}
			};

			var dp1 = dbContext.Departments.Add(department1);
			var dp2 = dbContext.Departments.Add(department2);

			dbContext.SaveChanges();
		}

		static void ClearDataBase(EmployeeManagerDBContext dbContext)
		{
			dbContext.Employees.RemoveRange(dbContext.Employees);
			dbContext.Departments.RemoveRange(dbContext.Departments);
			dbContext.SaveChanges();
		}

		static void Main(string[] args)
		{
			using(var dbContext = new EmployeeManagerDBContext())
			{
				ClearDataBase(dbContext);

				CreateSomeData(dbContext);

				//Use breakpoint too see the value of variables
				var allDepartments = dbContext.Departments.ToList();

				var atleast2employees = dbContext.Departments.First(x => x.Employees.Count >= 2);

				var employee1990 = dbContext.Employees.First(x=>x.Birthday.Year==1989);

				var someEmployee = dbContext.Employees.First(x => Math.Abs(x.Id) > 1);

				someEmployee.Birthday = new DateTime(1956, 10, 2);
				dbContext.Employees.Attach(someEmployee);
				dbContext.Entry(someEmployee).State = EntityState.Modified;
				dbContext.SaveChanges();

				var employeesToDelete = dbContext.Employees.Where(x => x.Birthday.Year == 1990);
				dbContext.Employees.RemoveRange(employeesToDelete);
				dbContext.SaveChanges();
			}
		}
	}
}

