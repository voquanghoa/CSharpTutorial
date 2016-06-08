using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPClient
{
	public partial class Form1 : Form
	{
		private TcpClient client;//Chứa thông tin kết nối

		private NetworkStream stream;
		private StreamReader reader;
		private StreamWriter writer;
		private Thread thread;//Thread đọc
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.client = new TcpClient("127.0.0.1", 8000);
			this.stream = client.GetStream();
			this.reader = new StreamReader(stream);
			this.writer = new StreamWriter(stream);
			this.thread = new Thread(Receive);
			this.thread.Start();
		}

		private void btSend_Click(object sender, EventArgs e)
		{
			if (txtInput.TextLength > 0)
			{
				//Ghi chuổi người dùng nhập vào
				writer.WriteLine(txtInput.Text);
				txtLog.AppendText($"Send     : {txtInput.Text}\n");
				writer.Flush();
				txtInput.Text = "";
			}
		}

		private void Receive()
		{
			while (true)
			{
				var data = reader.ReadLine();
				if (!string.IsNullOrEmpty(data))
				{
					var log = $"Receive: {data}\n";
					Action action = () => txtLog.AppendText(log);

					Invoke(action);
				}
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			thread.Abort();
			client.Close();
		}
	}
}
