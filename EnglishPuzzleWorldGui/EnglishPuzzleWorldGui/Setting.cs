﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishPuzzleWorldGui
{
	public partial class Setting : Form
	{
		public Setting()
		{
			InitializeComponent();
		}

		private void Setting_Load(object sender, EventArgs e)
		{
			View.Export(this);
		}
	}
}
