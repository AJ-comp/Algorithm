using AJ.Extension;
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
            => data.AppendRange(BitConverter.GetBytes(data.CRC16()));

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
            => data.AppendRange(BitConverter.GetBytes(data.CCITTxModem()));

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
            => data.AppendRange(BitConverter.GetBytes(data.DNP()));

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
            => data.AppendRange(BitConverter.GetBytes(data.CRC32()));
    }
}
