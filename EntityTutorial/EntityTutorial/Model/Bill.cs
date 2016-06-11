using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTutorial.Model
{
	[Table("Bill")]
	public class Bill
	{
		public int Id { get; set; }

		public Product Product { get; set; }

		public int Quantity { get; set; }

		public int Payment { get; set; }

		public DateTime DateTime { get; set; }

		public Employee Saller { get; set; }
	}
}
