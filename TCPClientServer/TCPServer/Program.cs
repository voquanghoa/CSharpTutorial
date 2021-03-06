﻿using System;
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
		private TcpClient tcpClient;

		private NetworkStream stream;
		private StreamReader reader;
		private StreamWriter writer;

		public Waiter(TcpClient tcpClient)
		{
			this.tcpClient = tcpClient;
			this.stream = tcpClient.GetStream();
			this.reader = new StreamReader(stream);
			this.writer = new StreamWriter(stream);
		}

		public void Start()
		{
			new Thread(Listen).Start();
		}

		private void Listen()
		{
			while (tcpClient.Connected)
			{
				//Đọc dữ liệu được gửi lên
				var data = reader.ReadLine();
				Console.WriteLine("Receive "+data);
				//Xử lý nếu dữ liệu là Exit thì thoát
				if (data == "Exit")
				{
					writer.WriteLine("Bye bye and never see you again");
					writer.Flush();
					break;
				}
				//Đảo chuổi được gửi đến
				data = new string(data.Reverse().ToArray());
				//Gửi kết quả
				writer.WriteLine(data);
				writer.Flush();//Đảm bảo dữ liệu được đẩy về client ngay
			}
			//Kết thúc thread, đóng các kết nối
			Console.WriteLine("Close");
			stream.Close();
			tcpClient.Close();
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
				var tcpClient = tcpListener.AcceptTcpClient();
				Console.WriteLine("New client");
				new Waiter(tcpClient).Start();
			}
		}
	}
}
