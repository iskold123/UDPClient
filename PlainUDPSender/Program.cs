﻿using System;

namespace PlainUDPSender
{
    class Program
    {
        static void Main(string[] args)
        {
            UDPSender worker = new UDPSender();
            worker.Start();

            Console.ReadLine();
        }
    }
}
