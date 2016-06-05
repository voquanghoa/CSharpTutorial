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
		private TcpClient client;

		private NetworkStream stream;
		private StreamReader reader;
		private StreamWriter writer;
		private Thread thread;
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
				writer.WriteLine(txtInput.Text);
				AppendText($"Send {txtInput.Text}\n");
				writer.Flush();
				txtInput.Text = "";
			}
		}
		private void AppendText(string text)
		{
			Action action = () => txtLog.AppendText(text);

			Invoke(action);
		}

		private void Receive()
		{
			while (true)
			{
				var data = reader.ReadLine();
				if (!string.IsNullOrEmpty(data))
				{
					AppendText("Received : "+data+"\n");
				}
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			thread.Abort();
		}
	}
}
