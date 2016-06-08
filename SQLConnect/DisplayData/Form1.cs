using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayData
{
	public partial class Form1 : Form
	{
		private SqlConnection sqlConnection;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			var strConnection = @"Server=DESKTOP-3VKEQ47\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True;";
			sqlConnection = new SqlConnection(strConnection);
			try
			{
				sqlConnection.Open();

				var sqlCommand = sqlConnection.CreateCommand();

				sqlCommand.CommandText = "Select * from GiaoVien";
				var reader = sqlCommand.ExecuteReader();
				var dataTable = new DataTable();
				dataTable.Load(reader);

				dataGridView1.DataSource = dataTable;
				comboBox1.DataSource = dataTable;
				comboBox1.ValueMember = "Id";
				comboBox1.DisplayMember = "Hoten";

				listBox1.DataSource = dataTable;
				listBox1.DisplayMember = "Hoten";
				listBox1.ValueMember = "Id";
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				Close();
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				sqlConnection.Close();
			}
			catch { }
		}

		private void listBox1_SelectedValueChanged(object sender, EventArgs e)
		{
			Text ="Selected "+ string.Join(",", listBox1.SelectedItems.Cast<DataRowView>().Select(x=>x[1]).ToArray());
		}
	}
}
