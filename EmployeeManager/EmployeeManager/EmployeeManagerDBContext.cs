namespace EmployeeManager
{
	using System;
	using System.Data.Entity;
	using System.Linq;

	public class EmployeeManagerDBContext : DbContext
	{
		public EmployeeManagerDBContext()
			: base("name=EmployeeManagerDBContext")
		{
		}
		public virtual DbSet<Department> Departments { get; set; }
		public virtual DbSet<Employee> Employees { get; set; }
	}
}