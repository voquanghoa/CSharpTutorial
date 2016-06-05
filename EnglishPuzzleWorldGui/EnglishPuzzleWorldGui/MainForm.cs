using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishPuzzleWorldGui
{
	public partial class MainMenu : Form
	{
		public MainMenu()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			View.Export(this);
		}
	}
}
