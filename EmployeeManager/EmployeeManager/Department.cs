using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager
{
	public class Department
	{
		[Key]
		public int Id { get; set; }

		public string Name { get; set; }

		public virtual IList<Employee> Employees { set; get; }

		public string Location { set; get; }
	}

}
