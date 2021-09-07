using Messenger.Models;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text.Json;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static string Encode<T>(T message)
        {
            return JsonSerializer.Serialize(message);
        }

        static T Decode<T>(string message)
        {
            return JsonSerializer.Deserialize<T>(message);
        }

        static void Main(string[] args)
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Loopback, 8888);
            TcpListener server = new TcpListener(endPoint);

            server.Start();

            do
            {
                TcpClient client = server.AcceptTcpClient();

                Task.Run(() =>
                {
                    using var stream = client.GetStream();
                    using var reader = new StreamReader(stream);
                        
                });
            } while (true);
        }
    }
}
