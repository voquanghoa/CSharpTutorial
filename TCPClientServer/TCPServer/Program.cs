using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace TCPServer
{
	class Waiter
	{
		private TcpClient socket;

		private NetworkStream stream;
		private StreamReader reader;
		private StreamWriter writer;

		public Waiter(TcpClient socket)
		{
			this.socket = socket;
			this.stream = socket.GetStream();
			this.reader = new StreamReader(stream);
			this.writer = new StreamWriter(stream);
		}

		public void Start()
		{
			new Thread(Listen).Start();
		}
		private void Listen()
		{
			while (true)
			{
				var data = reader.ReadLine();
				Console.WriteLine("Receive "+data);
				if (data == "Exit")
				{
					break;
				}

				data = new string(data.Reverse().ToArray());
				writer.WriteLine(data);
				writer.Flush();
			}
			Console.WriteLine("Close");
			stream.Close();
			socket.Close();
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			var port = 8000;
			var tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"), port);
			tcpListener.Start();

			Console.WriteLine($"Server started at port: {port}");
			while (true)
			{
				var socket = tcpListener.AcceptTcpClient();
				Console.WriteLine("New client");
				new Waiter(socket).Start();
			}
		}
	}
}
