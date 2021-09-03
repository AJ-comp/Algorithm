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
            FourG_and_FiveG_pilot_networks,
            Implement_Design,
            Planned,
            Reserved,
            Testing,
            TestNetwork,
            Unknown,
            Upcoming,
            Operational,
            Temporary_operational,
            Not_Operational,
        }

        public enum BandType
        {
            [Description("2500")] two500,
            [Description("1900")] one900,
            [Description("800")] eight00,
            [Description("AMPS")] AMPS,
            [Description("AMPS800")] AMPS800,
            [Description("CDMA")] CDMA,
            [Description("CDMA420")] CDMA420,
            [Description("CDMA450")] CDMA450,
            [Description("CDMA800")] CDMA800,
            [Description("CDMA 850")] CDMA850,
            [Description("CDMA1900")] CDMA1900,
            [Description("CDMA2000")] CDMA2000,
            [Description("CDMA2000 450")] CDMA2000450,
            [Description("CDMA2000 800")] CDMA2000800,
            [Description("CDMA2000 850")] CDMA2000850,
            [Description("CDMA2000 1700")] CDMA20001700,
            [Description("CDMA2000 1900")] CDMA20001900,
            [Description("DAMPS")] DAMPS,
            [Description("DMR")] DMR,
            [Description("GSM")] GSM,
            [Description("GSM 850")] GSM850,
            [Description("GSM 900")] GSM900,
            [Description("GSM 1800")] GSM1800,
            [Description("GSM 1900")] GSM1900,
            [Description("GSM-R")] GSMR,
            [Description("GSM-R 900")] GSMR900,
            [Description("GSM-R 1800")] GSMR1800,
            [Description("PrivateGSM 1800")] PrivateGSM1800,
            [Description("PHS 1900")] PHS1900,
            [Description("iDEN")] iDEN,
            [Description("iDEN 900")] iDEN900,
            [Description("iDEN 800")] iDEN800,
            [Description("UMTS")] UMTS,
            [Description("UMTS 850")] UMTS850,
            [Description("UMTS 900")] UMTS900,
            [Description("UMTS 1700")] UMTS1700,
            [Description("UMTS 1900")] UMTS1900,
            [Description("UMTS 2100")] UMTS2100,
            [Description("UMTS-TDD 700")] UMTSTDD700,
            [Description("UMTS-TDD 2000")] UMTSTDD2000,
            [Description("LTE")] LTE,
            [Description("LTE 410")] LTE410,
            [Description("LTE 450")] LTE450,
            [Description("LTE 700")] LTE700,
            [Description("LTE 800")] LTE800,
            [Description("LTE 850")] LTE850,
            [Description("LTE 900")] LTE900,
            [Description("LTE 1500")] LTE1500,
            [Description("LTE 1700")] LTE1700,
            [Description("LTE 1800")] LTE1800,
            [Description("LTE 1900")] LTE1900,
            [Description("LTE 2100")] LTE2100,
            [Description("LTE 2300")] LTE2300,
            [Description("LTE 2500")] LTE2500,
            [Description("LTE 2600")] LTE2600,
            [Description("LTE 3500")] LTE3500,
            [Description("Test")] Test,
            [Description("TETRA")] TETRA,
            [Description("TD-LTE")] TDLTE,
            [Description("TD-LTE 2300")] TDLTE2300,
            [Description("TD-LTE 2500")] TDLTE2500,
            [Description("TD-LTE 2600")] TDLTE2600,
            [Description("TD-LTE 3500")] TDLTE3500,
            [Description("TD-LTE 3700")] TDLTE3700,
            [Description("TD-SCDMA")] TDSCDMA,
            [Description("TD-5G 2300")] TD5G2300,
            [Description("TD-5G 2500")] TD5G2500,
            [Description("TD-5G 2600")] TD5G2600,
            [Description("WiMAX")] WiMAX,
            [Description("WiMAX 2300")] WiMAX2300,
            [Description("WiMAX 3500")] WiMAX3500,
            [Description("WiMAX 3700")] WiMAX3700,
            [Description("5G")] FiveG,
            [Description("5G 600")] FiveG600,
            [Description("5G 700")] FiveG700,
            [Description("5G 850")] FiveG850,
            [Description("5G 1700")] FiveG1700,
            [Description("5G 1800")] FiveG1800,
            [Description("5G 2100")] FiveG2100,
            [Description("5G 2300")] FiveG2300,
            [Description("5G 2500")] FiveG2500,
            [Description("5G 2600")] FiveG2600,
            [Description("5G 3500")] FiveG3500,
            [Description("5G 3600")] FiveG3600,
            [Description("5G 4700")] FiveG4700,
            [Description("5G 26000")] FiveG26000,
            [Description("5G 28000")] FiveG28000,
            [Description("5G mmWave")] FiveGmmWave,
            [Description("NB-IoT 700")] NBIoT700,
            [Description("MVNE")] MVNE,
            [Description("MVNO")] MVNO,
            [Description("MVNO/MVNE")] MVNO_MVNE,
            [Description("Satellite")] Satellite,
            [Description("Satellite CDMA")] SatelliteCDMA,
            [Description("Satellite MVNO")] SatelliteMVNO,
            [Description("TDMA 800")] TDMA800,
            [Description("TDMA PCS")] TDMAPCS,
            [Description("paging")] paging,
            [Description("various")] Various,
            [Description("Unknown")] Unknown,
            [Description("Unknown 1700")] Unknown1700,
            [Description("Empty")] Empty,
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
