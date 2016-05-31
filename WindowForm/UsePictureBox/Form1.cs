using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsePictureBox
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				pictureBox1.BackgroundImage = Image.FromFile(textBox1.Text);
			}
			catch
			{
				MessageBox.Show("The image could not be loaded", "Warning");
			}
			
		}

		private void ImageViewType_Click(object sender, EventArgs e)
		{
			var text = ((Button)sender).Text;
			var layout = (ImageLayout)Enum.Parse(typeof(ImageLayout), text);
			pictureBox1.BackgroundImageLayout = layout;
		}
	}
}
