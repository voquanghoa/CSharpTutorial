using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseListView
{
	
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			listView1.Items.Add("Chrome", "chrome");
			listView1.Items.Add("Internet Explorer", "ie");
			listView1.Items.Add("Opera", "opera");
			listView1.Items.Add("Safari", "safari");
			listView1.Items.Add("Firefox", "firefox");
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			var radioButton = (RadioButton)sender;
			listView1.View = (View)Enum.Parse(typeof(View), radioButton.Text);
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				if (radioTile.Checked)
				{
					rbViewList.Checked = true;
				}
				radioTile.Enabled = false;
			}
			else
			{
				radioTile.Enabled = true;
			}
			listView1.CheckBoxes = checkBox1.Checked;
		}
	}
}
