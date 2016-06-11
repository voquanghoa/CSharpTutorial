using EntityTutorial.DataContext;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTutorial.Migrations
{
	class Configuration : DbMigrationsConfiguration<SaleDataContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = false;
		}
	}
}
