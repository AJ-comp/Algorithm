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

            TestModule("CRC-32 test", CRC.ComputeCRC32, testValue1, testValue2, testValue3);
            Console.WriteLine();


            var countries = Country.GetCountryInfoForMobileInfo(450, 2);

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
    }
}
