using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace PlainUDPReceiverProjekt
{
    internal class UDPReseiver
    {
        public void Start()
        {
            UdpClient client = new UdpClient(11001);

            byte[] buffer;

            while (true)
            {
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
                buffer = client.Receive(ref remoteEP);

                Console.WriteLine($"hej");



                //Console.WriteLine($"Har modtaget en pakke fra ip{Tostring} og port {remoteEP.Port}");
                string str = Encoding.UTF8.GetString(buffer);

                Console.WriteLine($"tekst modtaget " + str);

                byte[] outbuffer = Encoding.UTF8.GetBytes(str.ToCharArray());
                client.Send(outbuffer, outbuffer.Length, remoteEP);
            }
        }


    }
}