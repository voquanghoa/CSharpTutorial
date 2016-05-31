using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicComponents
{
	public partial class BasicComponents : Form
	{
		private void ShowMessage(string message, string caption = "Notice")
		{
			MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public BasicComponents()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var checkboxs = new[]
			{
				cbCSharp,
				cbJava,
				cbPascal,
				cbPython
			};

			var selected = (from cb in checkboxs
							where cb.Checked
							select cb.Text).ToArray();

			if (selected.Length > 0)
			{
				ShowMessage($"You selected {string.Join(", ", selected)}");
			}
			else
			{
				ShowMessage($"You selected (nothing)");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var radioButtons = new[]
			{
				rbMale,
				rbFemale,
				rbGenderOther,
			};
			var selected = radioButtons.Single(x => x.Checked).Text;
			ShowMessage($"You selected {selected}");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			checkListBox.Items.Add("Văn bản hiển thị");
			checkListBox.Items.AddRange(new object[] { "item1", "item2" });
		}

		private void button4_Click(object sender, EventArgs e)
		{
			var stringBuffer = new StringBuilder();
			foreach (var item in checkListBox.CheckedItems)
			{
				stringBuffer.Append(item.ToString()+" ");
			}
			ShowMessage("Select " + stringBuffer.ToString());
		}

		private void cbCSharp_CheckedChanged(object sender, EventArgs e)
		{
			var item = (CheckBox)sender;
			lblCheckbox.Text = "Item " + item.Text + (item.Checked ? " Checked" : " Unchecked");
		}

		private void rbMale_CheckedChanged(object sender, EventArgs e)
		{
			var item = (RadioButton)sender;
			lblGender.Text = "Selected " + item.Text;
		}

		private void checkListBox_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			lblCheckedListBox.Text = "Item " + checkListBox.Items[e.Index] + 
				(e.NewValue == CheckState .Checked? " checked " : " unchecked");
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			var index = comboBox1.SelectedIndex;
			lblComboBox.Text = "Selected item " + comboBox1.Text+" at "+index;
			
		}

		private void button5_Click(object sender, EventArgs e)
		{
			var stringBuffer = new StringBuilder();
			foreach (var item in listBox1.SelectedItems)
			{
				stringBuffer.Append(item.ToString() + " ");
			}
			ShowMessage("Select " + stringBuffer.ToString());
		}
	}
}
