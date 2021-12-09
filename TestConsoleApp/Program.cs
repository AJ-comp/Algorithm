using AJ.Code;
using AJ.Extension;
using Algorithm.Check;
using Encrypt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Algorithm.Check.ExtensionForCRC16;
using static Algorithm.Check.ExtensionForCRC32;
using static Algorithm.Check.ExtensionForCRC8;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<byte> testValue1 = Encoding.ASCII.GetBytes("123456789");
            IEnumerable<byte> testValue2 = Encoding.ASCII.GetBytes("123456789lsdfilksdfksfsopfsdIcanfslfeafysfe");
            IEnumerable<byte> testValue3 = Encoding.ASCII.GetBytes("123456789lsdfilksdfks123FfelsdfiADSFsafkSAFSasdfefadsMLEIRP");

            Console.WriteLine(testValue1.WithCRC16().ToHexString());
            Console.WriteLine(testValue2.WithCRC16().ToHexString());
            Console.WriteLine(testValue3.WithCRC16().ToHexString());

            TestCRC8(CRC8Type.Basic, testValue1, testValue2, testValue3);
            TestCRC8(CRC8Type.Maxim, testValue1, testValue2, testValue3);
            TestCRC16(CRC16Type.Basic, testValue1, testValue2, testValue3);
            TestCRC16(CRC16Type.CCITTxModem, testValue1, testValue2, testValue3);
            TestCRC16(CRC16Type.DNP, testValue1, testValue2, testValue3);
            TestCRC32(CRC32Type.Basic, testValue1, testValue2, testValue3);


            var countries = Country.GetCountryInfoForMobileInfo(310, 260);

            foreach (var country in countries)
                Console.WriteLine($"{country.CountryName} {country.HomeCountry.CountryName}");
        }


        private static void TestCRC8(CRC8Type type, params IEnumerable<byte>[] testValues)
        {
            foreach (var testValue in testValues)
            {
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine($"CRC8 [{type}] test for source [{testValue.ToHexString()}]");
                Console.WriteLine($"crc is 0x{testValue.CRC8(type).ToString("x2")}");
                Console.WriteLine($"source + crc is 0x{testValue.WithCRC8(type).ToHexString()}");
                Console.WriteLine("------------------------------------------------------------------");
            }
        }

        private static void TestCRC16(CRC16Type type, params IEnumerable<byte>[] testValues)
        {
            foreach (var testValue in testValues)
            {
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine($"CRC16 [{type}] test for source [{testValue.ToHexString()}]");
                Console.WriteLine($"crc is 0x{testValue.CRC16(type).ToString("x4")}");
                Console.WriteLine($"source + crc is 0x{testValue.WithCRC16(type).ToHexString()}");
                Console.WriteLine("------------------------------------------------------------------");
            }
        }

        private static void TestCRC32(CRC32Type type, params IEnumerable<byte>[] testValues)
        {
            foreach (var testValue in testValues)
            {
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine($"CRC32 [{type}] test for source [{testValue.ToHexString()}]");
                Console.WriteLine($"crc is 0x{testValue.CRC32(type).ToString("x8")}");
                Console.WriteLine($"source + crc is 0x{testValue.WithCRC32(type).ToHexString()}");
                Console.WriteLine("------------------------------------------------------------------");
            }
        }

        private static void TestCheckSum8(params IEnumerable<byte>[] testValues)
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine($"CheckSum8 [CheckSum8 xor] test");
            foreach (var item in testValues)
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
