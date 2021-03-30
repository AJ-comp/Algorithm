using AJ.Code;
using Algorithm.Check;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<byte> testValue1 = Encoding.ASCII.GetBytes("123456789");
            IEnumerable<byte> testValue2 = Encoding.ASCII.GetBytes("1234567890");
            IEnumerable<byte> testValue3 = Encoding.ASCII.GetBytes("1234567890abcde");

            TestModule("CRC-16 test", CRC.ComputeCRC16, testValue1, testValue2, testValue3);
            Console.WriteLine();

            TestModule("CRC-CCITT test", CRC.ComputeCCITTxModem, testValue1, testValue2, testValue3);
            Console.WriteLine();

            TestModule("CRC-DNP test", CRC.ComputeDNP, testValue1, testValue2, testValue3);
            Console.WriteLine();
        }

        private static void TestModule(string title,
                                                    Func<IEnumerable<byte>, ushort> func,
                                                    params IEnumerable<byte>[] testValues)
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine(title);
            foreach (var item in testValues)
            {
                Console.WriteLine(string.Format("test result {0}", func(item).ToString("x")));
            }
            Console.WriteLine("------------------------------------------------------------------");
        }
    }
}
