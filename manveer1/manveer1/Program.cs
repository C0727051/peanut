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
            download();
            Console.ReadLine();
        }
        static void download()
        {
            Thread.Sleep(4000);
            Console.WriteLine("Download Complete");
        }
        
        static int Add(int a, int b) {return a+b;}
    }
}
