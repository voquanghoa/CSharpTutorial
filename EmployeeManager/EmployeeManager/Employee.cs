﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager
{
	public class Employee
	{
		[Key]
		public int Id { get; set; }

		public string Name { get; set; }

		public int Salary { get; set; }

		public DateTime Birthday { get; set; }

		public virtual Department Department { set; get; }
	}
}
