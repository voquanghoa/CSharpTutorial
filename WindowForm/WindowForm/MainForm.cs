using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowForm
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void btSolve_Click(object sender, EventArgs e)
		{
			var a = double.Parse(txta.Text);
			var b = double.Parse(txtb.Text);
			var c = double.Parse(txtc.Text);
			var delta = b * b - 4 * a * c;
			if(delta > 0)
			{
				var x1 = (-b + Math.Sqrt(delta)) / (2 * a);
				var x2 = (-b - Math.Sqrt(delta)) / (2 * a);
				lblResult.Text = $"Phương trình có 2 nghiệm\n" +
					$"X1 = {x1}\nX2 = {x2}";
			}
			else if (delta < 0)
			{
				lblResult.Text = $"Phương trình vô nghiệm";
			}
			else
			{
				lblResult.Text = $"Phương trình có 1 nghiệm {-b/2/a}";
			}
		}

		private void Input_Enter(object sender, EventArgs e)
		{
			((TextBox)sender).SelectAll();
		}
	}
}
