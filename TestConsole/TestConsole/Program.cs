using System;
using Renci.SshNet;

namespace TestConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			var host = "";
			var port = 22;
			var user = "";
			var pass = "";

			if (string.IsNullOrWhiteSpace(host))
			{
				Console.WriteLine("host?\r\n");
				host = Console.ReadLine();
				//... Finish this.... maybe
			}

			#region Make Client

			var sftpClient = new SftpClient(host, port, user, pass);
			sftpClient.BufferSize = 1024 * 32 - 100; //Default size can exceed payload max for some reason
			sftpClient.Connect();
			if (!sftpClient.IsConnected)
				throw new Exception("Failed to connect FtpClientSsh");

			#endregion  Make Client

		}
	}
}
