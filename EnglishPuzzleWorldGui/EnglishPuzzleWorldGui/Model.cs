using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishPuzzleWorldGui
{
	class View
	{
		public int X { get; set; }
		public int Y { get; set; }

		public int Width { get; set; }
		public int Height { get; set; }

		public bool Action { get; set; }

		public string Image { get; set; }
		public string Name { get; set; }

		public View(PictureBox pictureBox)
		{
			Width = pictureBox.Width;
			Height = pictureBox.Height;

			X = pictureBox.Left + Width/2;
			Y = pictureBox.Top + Height/2;

			Action = pictureBox.Enabled;
			Image = pictureBox.Tag.ToString();
			Name = pictureBox.Name;
		}

		public static void Export(Form form)
		{
			var views = (from pic in form.Controls.OfType<PictureBox>()
						 orderby pic.Height * pic.Width descending
						 select new View(pic as PictureBox)).ToList();
			var dir = @"D:\Project\EnglishPuzzleWorldIOS\data";
			var fileName = form.Name + ".json";

			File.WriteAllText(Path.Combine(dir, fileName), JsonConvert.SerializeObject(views));
			form.Close();
		}
	}
}
