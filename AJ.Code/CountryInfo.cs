using AJ.Code.Properties;
using System.Diagnostics;

namespace AJ.Code
{
    public enum ContinentCode
    {
        Unknown,
        AF,
        AN,
        AS,
        OC,
        EU,
        NA,
        SA,
    }

    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class CountryInfo
    {
        public string NumericCode { get; private set; }
        public string Alpha2Code { get; private set; }
        public string Alpha3Code { get; private set; }
        public string CountryName { get; private set; }
        public ContinentCode ContinentCode { get; internal set; } = ContinentCode.Unknown;
        public string ContinentName
        {
            get
            {
                string result = Resources.Unknown;
                if (ContinentCode == ContinentCode.AF) result = Resources.AFRICA;
                else if (ContinentCode == ContinentCode.AN) result = Resources.ANTARCTICA;
                else if (ContinentCode == ContinentCode.AS) result = Resources.ASIA;
                else if (ContinentCode == ContinentCode.OC) result = Resources.OCEANIA;
                else if (ContinentCode == ContinentCode.EU) result = Resources.EUROPE;
                else if (ContinentCode == ContinentCode.NA) result = Resources.NORTH_AMERICA;
                else if (ContinentCode == ContinentCode.SA) result = Resources.SOUTH_AMERICA;

                return result;
            }
        }
        public MobileInfo MobileCode { get; internal set; }


        internal CountryInfo(string countryName, 
                                   string alpha2Code,
                                   string alpha3Code,
                                   string numericCode,
                                   ContinentCode continentCode = ContinentCode.Unknown,
                                   MobileInfo mobileCode = null)
        {
            NumericCode = numericCode;
            Alpha2Code = alpha2Code;
            Alpha3Code = alpha3Code;
            CountryName = countryName;
            ContinentCode = continentCode;
            MobileCode = mobileCode;
        }

        private string GetDebuggerDisplay()
            => string.Format($"[{NumericCode},{Alpha2Code},{Alpha3Code},{CountryName},{ContinentName}]");
    }
}
