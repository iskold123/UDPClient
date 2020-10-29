using System;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace PlainUDPSender
{
    internal class UDPSender
    {

        public void Start()
        {
            UdpClient client = new UdpClient();

            byte[] buffer;

            //Sender
            IPEndPoint modtagerEP = new IPEndPoint(IPAddress.Loopback, 11001);
            string str = "Hej Mads";
            byte[] outbuffer = Encoding.UTF8.GetBytes(str.ToCharArray());
            client.Send(outbuffer, outbuffer.Length, modtagerEP);

            //Modtager
            IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
            buffer = client.Receive(ref remoteEP);

            Console.WriteLine("hej");

            string incomingstr = Encoding.UTF8.GetString(buffer);

            Console.WriteLine("Tekst modtaget" + incomingstr);
        }
    }
}