﻿using AJ.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Check
{
    public static class ExtensionForCRC32
    {
        public enum CRC32Type
        {
            Basic,
        }

        /*******************************************/
        /// <summary>
        /// This function returns the CRC32 value
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type">This parameter means crc32 algorithm type.</param>
        /// <returns></returns>
        /*******************************************/
        public static uint CRC32(this IEnumerable<byte> data, CRC32Type type = CRC32Type.Basic)
        {
            uint result = 0;

            if (type == CRC32Type.Basic) result = CRC.ComputeCRC32(data);

            return result;
        }

        /*******************************************/
        /// <summary>
        /// This function returns the byte array included crc32 value.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type">This parameter means crc32 algorithm type.</param>
        /// <returns></returns>
        /*******************************************/
        public static IEnumerable<byte> WithCRC32(this IEnumerable<byte> data, CRC32Type type = CRC32Type.Basic)
        {
            if (type == CRC32Type.Basic) return data.AppendRange(BitConverter.GetBytes(data.CRC32(type)));

            return new List<byte>();
        }
    }
}
