using AJ.Code.Properties;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

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
        public IEnumerable<MobileInfo> MobileCodes => _mobileCodes;
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

        public CountryInfo HomeCountry
        {
            get
            {
                if (Alpha2Code == "MP") return Country.AllCountries.Where(country => country.Alpha2Code == "US").FirstOrDefault();
                if (Alpha2Code == "GU") return Country.AllCountries.Where(country => country.Alpha2Code == "US").FirstOrDefault();
                if (Alpha2Code == "PR") return Country.AllCountries.Where(country => country.Alpha2Code == "US").FirstOrDefault();

                if (Alpha2Code == "BM") return Country.AllCountries.Where(country => country.Alpha2Code == "GB").FirstOrDefault();

                return this;
            }
        }


        public CountryInfo CloneExceptMobileInfo()
            => new CountryInfo(CountryName, Alpha2Code, Alpha3Code, NumericCode, ContinentCode);


        internal CountryInfo(string countryName,
                                   string alpha2Code,
                                   string alpha3Code,
                                   string numericCode,
                                   ContinentCode continentCode = ContinentCode.Unknown,
                                   params MobileInfo[] mobileCodes)
        {
            NumericCode = numericCode;
            Alpha2Code = alpha2Code;
            Alpha3Code = alpha3Code;
            CountryName = countryName;
            ContinentCode = continentCode;

            if (mobileCodes == null) return;
            foreach (var mobileCode in mobileCodes)
            {
                _mobileCodes.Add(mobileCode);
            }
        }


        internal List<MobileInfo> _mobileCodes = new List<MobileInfo>();


        internal CountryInfo MobileFilteredCountry(int mcc)
        {
            CountryInfo result = CloneExceptMobileInfo();

            result._mobileCodes.AddRange(MobileCodes.Where(m => m.MCC == mcc));
            return result;
        }


        private string GetDebuggerDisplay()
        {
            string result = $"[{NumericCode},{Alpha2Code},{Alpha3Code},{CountryName},{ContinentName}]";

            result += "{";
            foreach (var mobileCode in MobileCodes) result += mobileCode.MCC + " ";
            result += "}";

            return result;
        }
    }
}
