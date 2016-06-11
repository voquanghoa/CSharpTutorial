﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTutorial.Model
{
	[Table("Product")]
	public class Product
	{
		[Required]
		[Key]
		public int Id { get; set; }

		public string Name { get; set; }

		public int Price { get; set; }

		public int Description { get; set; }

		public Category Category { get; set; }
	}
}
