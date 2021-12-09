using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AJ.Extension
{
    public static class Extension
    {
        public static IEnumerable<byte> Append(this IEnumerable<byte> data, byte toAddData)
        {
            List<byte> result = new List<byte>(data);
            if (data.Count() <= 0) return result;

            result.Add(toAddData);

            return result;
        }


        public static IEnumerable<byte> AppendRange(this IEnumerable<byte> data, IEnumerable<byte> toAddData)
        {
            List<byte> result = new List<byte>(data);
            if (data.Count() <= 0) return result;

            result.AddRange(toAddData);

            return result;
        }


        public static string ToHexString(this IEnumerable<byte> data, string connector = " ")
        {
            string result = string.Empty;

            foreach (var item in data)
            {
                result += item.ToString("x2") + connector;
            }

            if (data.Count() > 0) result = result.Substring(0, result.Length - connector.Length); // remove last connector

            return result;
        }
    }
}
