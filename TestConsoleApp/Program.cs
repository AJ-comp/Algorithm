using System;
using System.Text;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Algorithm.Check.CRC.ComputeCCITTxModem(Encoding.ASCII.GetBytes("123456789"));
            data = Algorithm.Check.CRC.ComputeCCITTxModem(Encoding.ASCII.GetBytes("1234567890"));
            Console.WriteLine("Hello World!");
        }
    }
}
