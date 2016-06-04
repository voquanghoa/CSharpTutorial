using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace UseThread
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void UpdateData(int percent)
		{
			progressBar1.Value = percent;
			this.Text = $"Progress {percent}";
		}
		private void button1_Click(object sender, EventArgs e)
		{
			new Thread(() =>
			{
				for(int i = 0; i <= 100; i++)
				{
					Action updateProgress = ()=> progressBar1.Value = i;
					//or Action updateProgress = ()=> UpdateData(i);
					Invoke(updateProgress);
					Thread.Sleep(100);
				}
			}).Start();
		}
	}
}
