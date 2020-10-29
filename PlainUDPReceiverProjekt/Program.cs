using System;

namespace PlainUDPReceiverProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            UDPReseiver worker = new UDPReseiver();
            worker.Start();

            Console.ReadLine();
        }
    }
}
