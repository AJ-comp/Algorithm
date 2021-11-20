using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Check
{
    public static class ExtensionForCRC
    {
        /*******************************************/
        /// <summary>
        /// This function returns the CRC16 value
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        /*******************************************/
        public static ushort CRC16(this IEnumerable<byte> data) => CRC.ComputeCRC16(data);

        /*******************************************/
        /// <summary>
        /// This function returns the byte array included crc16 value.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        /*******************************************/
        public static IEnumerable<byte> WithCRC16(this IEnumerable<byte> data)
            => WithCheckSum(data, BitConverter.GetBytes(data.CRC16()));

        /*******************************************/
        /// <summary>
        /// This function returns the CRC CCITT (xModem) value
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        /*******************************************/
        public static ushort CCITTxModem(this IEnumerable<byte> data) => CRC.ComputeCCITTxModem(data);

        /*******************************************/
        /// <summary>
        /// This function returns the byte array included crc-ccitt (x modem) value.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        /*******************************************/
        public static IEnumerable<byte> WithCCITTxModem(this IEnumerable<byte> data)
            => WithCheckSum(data, BitConverter.GetBytes(data.CCITTxModem()));

        /*******************************************/
        /// <summary>
        /// This function returns the CRC DNP (xModem) value
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        /*******************************************/
        public static ushort DNP(this IEnumerable<byte> data) => CRC.ComputeDNP(data);

        /*******************************************/
        /// <summary>
        /// This function returns the byte array included crc-dnp value.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        /*******************************************/
        public static IEnumerable<byte> WithDNP(this IEnumerable<byte> data)
            => WithCheckSum(data, BitConverter.GetBytes(data.DNP()));

        /*******************************************/
        /// <summary>
        /// This function returns the CRC32 value
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        /*******************************************/
        public static uint CRC32(this IEnumerable<byte> data) => CRC.ComputeCRC32(data);

        /*******************************************/
        /// <summary>
        /// This function returns the byte array included crc32 value.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        /*******************************************/
        public static IEnumerable<byte> WithCRC32(this IEnumerable<byte> data)
            => WithCheckSum(data, BitConverter.GetBytes(data.CRC32()));


        /*****************************************************/
        /// <summary>
        /// This function returns 1byte checksum that NMEA format use. <br/>
        /// </summary>
        /// <remarks>checksum8 xor</remarks>
        /// <param name="data"></param>
        /// <see cref="https://nmeachecksum.eqth.net/"/>
        /// <returns></returns>
        /*****************************************************/
        public static byte NMEACheckSum(this IEnumerable<byte> data) => data.CheckSum8Xor();

        /*****************************************************/
        /// <summary>
        /// This function returns the byte array included NMEA checksum value.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        /*****************************************************/
        public static IEnumerable<byte> WithNMEACheckSum(this IEnumerable<byte> data) => data.WithCheckSum8Xor();

        /*****************************************************/
        /// <summary>
        /// This function returns 1byte checksum. [xor]
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type">checksum8 algorithm type</param>
        /// <see cref="https://www.scadacore.com/tools/programming-calculators/online-checksum-calculator/"/>
        /// <returns></returns>
        /*****************************************************/
        public static byte CheckSum8Xor(this IEnumerable<byte> data)
        {
            byte result = 0;

            for (int i = 0; i < data.Count(); i++) result ^= data.ElementAt(i);

            return result;
        }

        /*****************************************************/
        /// <summary>
        /// This function returns the byte array included 1byte checksum [xor] value.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        /*****************************************************/
        public static IEnumerable<byte> WithCheckSum8Xor(this IEnumerable<byte> data)
            => WithCheckSum(data, BitConverter.GetBytes(data.CheckSum8Xor()));

        /*****************************************************/
        /// <summary>
        /// This function returns 1byte checksum. [modulo-256]
        /// </summary>
        /// <param name="data"></param>
        /// <see cref="https://www.scadacore.com/tools/programming-calculators/online-checksum-calculator/"/>
        /// <returns></returns>
        /*****************************************************/
        public static byte CheckSum8Modulo256(this IEnumerable<byte> data)
        {
            byte result = 0;

            UInt64 sum = 0;
            for (int i = 0; i < data.Count(); i++) sum += data.ElementAt(i);
            result = (byte)(sum % 256);

            return result;
        }

        /*****************************************************/
        /// <summary>
        /// This function returns the byte array included 1byte checksum [modulo-256] value.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        /*****************************************************/
        public static IEnumerable<byte> WithCheckSum8Modulo256(this IEnumerable<byte> data)
            => WithCheckSum(data, BitConverter.GetBytes(data.CheckSum8Modulo256()));

        /*****************************************************/
        /// <summary>
        /// This function returns 1byte checksum. [2's complement]
        /// </summary>
        /// <param name="data"></param>
        /// <see cref="https://www.scadacore.com/tools/programming-calculators/online-checksum-calculator/"/>
        /// <returns></returns>
        /*****************************************************/
        public static byte CheckSum8TwosComplement(this IEnumerable<byte> data)
        {
            byte result = 0;

            UInt64 sum = 0;
            for (int i = 0; i < data.Count(); i++) sum += data.ElementAt(i);
            result = (byte)(0x100 - sum);

            return result;
        }

        /*****************************************************/
        /// <summary>
        /// This function returns the byte array included 1byte checksum [2's complement] value.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        /*****************************************************/
        public static IEnumerable<byte> WithCheckSum8TwosComplement(this IEnumerable<byte> data)
            => WithCheckSum(data, BitConverter.GetBytes(data.CheckSum8TwosComplement()));



        private static IEnumerable<byte> WithCheckSum(this IEnumerable<byte> data, IEnumerable<byte> checksum)
        {
            List<byte> result = new List<byte>(data);
            if (data.Count() <= 0) return result;

            result.AddRange(checksum);

            return result;
        }
    }
}
