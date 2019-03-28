using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace manveer1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Downloading File");
            Download();
            Console.ReadLine();
        }
        static void Download()
        {
            Network.Download();
        }
    }
    class Network
    {
        static public Task Download()
        {

            return Task.Run() => {Thread.Sleep(3000)});
        }
    }
    }

