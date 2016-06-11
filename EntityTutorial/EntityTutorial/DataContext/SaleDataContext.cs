using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityTutorial.Model;
using System.Data.Entity;

namespace EntityTutorial.DataContext
{
	class SaleDataContext : DbContext
	{
		public SaleDataContext() : base("DefaultConnection") { }
		public DbSet<Bill> Bills { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Product> Products { get; set; }
	}
}
