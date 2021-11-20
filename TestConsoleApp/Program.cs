using AJ.Code;
using Algorithm.Check;
using Encrypt;
using System;
using System.Collections.Generic;
using System.Linq;
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

            TestModule("CRC-32 test", CRC.ComputeCRC32, testValue1, testValue2, testValue3);
            Console.WriteLine();

            TestCheckSum8(testValue1, testValue2, testValue3);


            var countries = Country.GetCountryInfoForMobileInfo(310, 260);

            foreach (var country in countries)
                Console.WriteLine($"{country.CountryName} {country.HomeCountry.CountryName}");
        }



        private static void TestModule<T>(string title,
                                                    Func<IEnumerable<byte>, T> func, 
                                                    params IEnumerable<byte>[] testValues)
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine(title);
            foreach (var item in testValues)
            {
                Console.WriteLine(string.Format("test result 0x{0}", string.Format("{0:x2}", func(item))));
            }
            Console.WriteLine("------------------------------------------------------------------");
        }


        private static void TestCheckSum8(params IEnumerable<byte>[] testValues)
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine($"CheckSum8 [CheckSum8 xor] test");
            foreach(var item in testValues)
            {
                Console.WriteLine($"test result 0x{item.CheckSum8Xor().ToString("x2")}");
            }
            Console.WriteLine("------------------------------------------------------------------");

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine($"CheckSum8 [CheckSum8 modulo-256] test");
            foreach (var item in testValues)
            {
                Console.WriteLine($"test result 0x{item.CheckSum8Modulo256().ToString("x2")}");
            }
            Console.WriteLine("------------------------------------------------------------------");

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine($"CheckSum8 [CheckSum8 2's complement] test");
            foreach (var item in testValues)
            {
                Console.WriteLine($"test result 0x{item.CheckSum8TwosComplement().ToString("x2")}");
            }
            Console.WriteLine("------------------------------------------------------------------");
        }
    }
}
