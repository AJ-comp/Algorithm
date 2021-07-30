using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace AJ.Code
{
    public class MobileInfo
    {
        public int MCC { get; private set; }
        public IEnumerable<MNCInfo> MNC => _mnc;


        public MobileInfo(int mcc, params MNCInfo[] mncInfos)
        {
            MCC = mcc;

            if (mncInfos == null) return;
            foreach (var mncInfo in mncInfos) _mnc.Add(mncInfo);
        }


        public MobileInfo(int mcc, IEnumerable<MNCInfo> mncList)
            : this(mcc, mncList?.ToArray())
            {
            }


        internal void AddMNCInfo(MNCInfo mnc) => _mnc.Add(mnc);



        private List<MNCInfo> _mnc = new List<MNCInfo>();

        public override bool Equals(object obj)
        {
            return obj is MobileInfo info &&
                   MCC == info.MCC;
        }

        public override int GetHashCode()
        {
            return -121810666 + MCC.GetHashCode();
        }

        public static bool operator ==(MobileInfo left, MobileInfo right)
        {
            return EqualityComparer<MobileInfo>.Default.Equals(left, right);
        }

        public static bool operator !=(MobileInfo left, MobileInfo right)
        {
            return !(left == right);
        }
    }




    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class MNCInfo
    {
        public enum OperStatus
        {
            Unknown,
            Operational,
            Not_Operational,
        }

        public enum BandType
        {
            [Description("GSM-R")] GSMR,
            [Description("GSM 900")] GSM900,
            [Description("GSM-R 900")] GSMR900,
            [Description("GSM 1800")] GSM1800,
            [Description("UMTS 900")] UMTS900,
            [Description("UMTS 2100")] UMTS2100,
            [Description("LTE")] LTE,
            [Description("LTE 800")] LTE800,
            [Description("LTE 1800")] LTE1800,
            [Description("LTE 2100")] LTE2100,
            [Description("LTE 2600")] LTE2600,
            [Description("TD-LTE 2300")] TDLTE2300,
            [Description("WiMAX 3500")] WiMAX3500,
            [Description("5G")] FiveG,
            [Description("5G 700")] FiveG700,
            [Description("5G 3500")] FiveG3500,
            [Description("MVNO")] MVNO,
            [Description("Unknown")] Unknown,
        }

        public string MNC { get; private set; }
        public string Brand { get; private set; }
        public string Operator { get; private set; }
        public OperStatus Status { get; private set; }
        public IEnumerable<BandType> Bands => _bands;


        private List<BandType> _bands = new List<BandType>();

        public MNCInfo(string mNC, string brand, string @operator, OperStatus status, params BandType[] bands)
        {
            MNC = mNC;
            Brand = brand;
            Operator = @operator;
            Status = status;

            if (bands == null) return;
            foreach (var band in bands) _bands.Add(band);
        }

        public override bool Equals(object obj)
        {
            return obj is MNCInfo info &&
                   MNC == info.MNC;
        }

        public override int GetHashCode()
        {
            return -175252757 + EqualityComparer<string>.Default.GetHashCode(MNC);
        }

        public static bool operator ==(MNCInfo left, MNCInfo right)
        {
            return EqualityComparer<MNCInfo>.Default.Equals(left, right);
        }

        public static bool operator !=(MNCInfo left, MNCInfo right)
        {
            return !(left == right);
        }

        private string GetDebuggerDisplay()
            => string.Format($"{MNC},{Brand},{Operator}");
    }
}
