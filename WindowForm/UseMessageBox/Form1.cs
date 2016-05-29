using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseMessageBox
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		#region Methor overload
		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This is a simple MessageBox");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This is a simple MessageBox", "Caption");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This is a simple MessageBox", "Caption", MessageBoxButtons.OKCancel);
		}


		private void button4_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This is a simple MessageBox", "Caption", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		}
		#endregion

		private void buttonMessageIcon_Click(object sender, EventArgs e)
		{
			var iconText = ((Button)sender).Text;
			var iconType = (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), iconText);
			MessageBox.Show("This is a simple MessageBox", "Caption", MessageBoxButtons.OK, iconType);
		}

		private void messageType_Click(object sender, EventArgs e)
		{
			var buttonText = ((Button)sender).Text;
			var buttonType = (MessageBoxButtons)Enum.Parse(typeof(MessageBoxButtons), buttonText);
			MessageBox.Show("This is a simple MessageBox", "Caption", buttonType, MessageBoxIcon.Information);
		}
	}
}
