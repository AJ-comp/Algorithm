using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Check
{
    public static class ExtensionForCRC
    {
        public static ushort CRC16(this IEnumerable<byte> data) => CRC.ComputeCRC16(data);
        public static ushort CCITTxModem(this IEnumerable<byte> data) => CRC.ComputeCCITTxModem(data);
        public static ushort DNP(this IEnumerable<byte> data) => CRC.ComputeDNP(data);
        public static uint CRC32(this IEnumerable<byte> data) => CRC.ComputeCRC32(data);
    }
}
