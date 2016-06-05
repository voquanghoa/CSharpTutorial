using System;
using System.Collections.Generic;
using System.Text;

namespace ExportModule
{
    class Export
    {
		public static void Export()
		{
			var views = (from pic in Controls.OfType<PictureBox>()
						 orderby pic.Height * pic.Width descending
						 select new View(pic as PictureBox)).ToList();
			var dir = @"D:\Project\EnglishPuzzleWorldIOS\data";
			var fileName = Name + ".json";

			File.WriteAllText(Path.Combine(dir, fileName), JsonConvert.SerializeObject(views));
			Close();
		}
    }
}
