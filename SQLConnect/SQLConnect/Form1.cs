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

namespace SQLConnect
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var connectionString = MakeConnectionString();
			//Tạo đối tượng SqlConnection
			var connection = new SqlConnection(connectionString);

			try
			{
				connection.Open();
				var sqlCommand = connection.CreateCommand();			
				MessageBox.Show("Connection Open ! ");
				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Can not open connection ! \n"+ex.Message);
			}
		}

		private string MakeConnectionString()
		{
			var connect = $"Server={txtServer.Text};Initial Catalog={txtDatabase.Text};Integrated Security={cbConnectType.SelectedIndex == 0};";

			if (cbConnectType.SelectedIndex > 0)
			{
				connect += $"User ID={txtUserName.Text};Password={txtPassword.Text};";
			}

			return connect;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			cbConnectType.SelectedIndex = 0;
		}

		private void Input_Changed(object sender, EventArgs e)
		{
			if(sender == cbConnectType)
			{
				txtUserName.Enabled = cbConnectType.SelectedIndex == 1;
				txtPassword.Enabled = txtUserName.Enabled;
			}

			txtConnectionString.Text = MakeConnectionString();
		}
	}
}
