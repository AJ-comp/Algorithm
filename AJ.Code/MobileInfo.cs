using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AJ.Code
{
    public class MobileInfo
    {
        public int MCC { get; private set; }
        public IEnumerable<MNCInfo> MNC => _mnc;


        public MobileInfo(int mCC, params MNCInfo[] mncInfos)
        {
            MCC = mCC;

            if (mncInfos == null) return;
            foreach (var mncInfo in mncInfos) _mnc.Add(mncInfo);
        }



        private List<MNCInfo> _mnc = new List<MNCInfo>();
    }


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
            [Description("GSM 1800")] GSM1800,
            [Description("UMTS 2100")] UMTS2100,
            [Description("LTE")] LTE,
            [Description("LTE 1800")] LTE1800,
        }

        public int MNC { get; private set; }
        public string Brand { get; private set; }
        public string Operator { get; private set; }
        public OperStatus Status { get; private set; }
        public IEnumerable<BandType> Bands => _bands;


        private List<BandType> _bands = new List<BandType>();

        public MNCInfo(int mNC, string brand, string @operator, OperStatus status, params BandType[] bands)
        {
            MNC = mNC;
            Brand = brand;
            Operator = @operator;
            Status = status;

            if (bands == null) return;
            foreach (var band in bands) _bands.Add(band);
        }
    }
}
