using AJ.Code.Properties;
using System;
using System.Collections.Generic;
using System.Text;

namespace AJ.Code
{
    public class Country
    {
        /*******************************************************************/
        /// <summary>
        /// Get all country information that registered.
        /// 등록된 모든 국가정보를 가져옵니다.
        /// </summary>
        /*******************************************************************/
        public static IEnumerable<CountryInfo> AllCountries => _countries;


        /*******************************************************************/
        /// <summary>
        /// Get the country information for MCC.
        /// MCC에 대한 국가정보를 가져옵니다.
        /// </summary>
        /// <param name="mcc"></param>
        /// <returns></returns>
        /*******************************************************************/
        public static CountryInfo GetCountryInfoForMCC(int mcc)
            => GetCountryInfoCore((country) => country.MobileCode.MCC == mcc);


        /*******************************************************************/
        /// <summary>
        /// Get the country information for alpha2 code.
        /// 알파2 코드에 대한 국가정보를 가져옵니다.
        /// </summary>
        /// <param name="alpha2Code"></param>
        /// <returns></returns>
        /*******************************************************************/
        public static CountryInfo GetCountryInfoForAlpha2Code(string alpha2Code)
            => GetCountryInfoCore((country) => country.Alpha2Code == alpha2Code);


        /*******************************************************************/
        /// <summary>
        /// Get the country information for alpha3 code.
        /// 알파3 코드에 대한 국가정보를 가져옵니다.
        /// </summary>
        /// <param name="alpha3Code"></param>
        /// <returns></returns>
        /*******************************************************************/
        public static CountryInfo GetCountryInfoForAlpha3Code(string alpha3Code)
            => GetCountryInfoCore((country) => country.Alpha3Code == alpha3Code);


        /*******************************************************************/
        /// <summary>
        /// Get the country information list for the continent code.
        /// 대륙코드에 대한 국가 정보목록을 가져옵니다.
        /// </summary>
        /// <param name="continentCode"></param>
        /// <returns></returns>
        /*******************************************************************/
        public static IEnumerable<CountryInfo> GetCountryInfoForContinentCode(ContinentCode continentCode)
            => GetCountryInfoListCore((country) => country.ContinentCode == continentCode);


        static Country()
        {
            _countries.Add(new CountryInfo(Resources.AF, "AF", "AFG", "004", ContinentCode.AS, new MobileInfo(412)));
            _countries.Add(new CountryInfo(Resources.AL, "AL", "ALB", "008"));
            _countries.Add(new CountryInfo("Algeria", "DZ", "DZA", "012"));
            _countries.Add(new CountryInfo("American Samoa", "AS", "ASM", "016"));
            _countries.Add(new CountryInfo("Andorra", "AD", "AND", "020"));
            _countries.Add(new CountryInfo("Angola", "AO", "AGO", "024"));
            _countries.Add(new CountryInfo("Anguilla", "AI", "AIA", "660"));
            _countries.Add(new CountryInfo("Antarctica", "AQ", "ATA", "010"));
            _countries.Add(new CountryInfo("Antigua and Barbuda", "AG", "ATG", "028"));
            _countries.Add(new CountryInfo("Argentina", "AR", "ARG", "032"));
            _countries.Add(new CountryInfo("Armenia", "AM", "ARM", "051"));
            _countries.Add(new CountryInfo("Aruba", "AW", "ABW", "533"));
            _countries.Add(new CountryInfo("Australia", "AU", "AUS", "036"));
            _countries.Add(new CountryInfo("Austria", "AT", "AUT", "040"));
            _countries.Add(new CountryInfo("Azerbaijan", "AZ", "AZE", "031"));
            _countries.Add(new CountryInfo("Bahamas", "BS", "BHS", "044"));
            _countries.Add(new CountryInfo("Bahrain", "BH", "BHR", "048"));
            _countries.Add(new CountryInfo("Bangladesh", "BD", "BGD", "050"));
            _countries.Add(new CountryInfo("Barbados", "BB", "BRB", "052"));
            _countries.Add(new CountryInfo("Belarus", "BY", "BLR", "112"));
            _countries.Add(new CountryInfo("Belgium", "BE", "BEL", "056"));
            _countries.Add(new CountryInfo("Belize", "BZ", "BLZ", "084"));
            _countries.Add(new CountryInfo("Benin", "BJ", "BEN", "204"));
            _countries.Add(new CountryInfo("Bermuda", "BM", "BMU", "060"));
            _countries.Add(new CountryInfo("Bhutan", "BT", "BTN", "064"));
            _countries.Add(new CountryInfo("Bolivia, Plurinational State of", "BO", "BOL", "068"));
            _countries.Add(new CountryInfo("Bonaire, Sint Eustatius and Saba", "BQ", "BES", "535"));
            _countries.Add(new CountryInfo("Bosnia and Herzegovina", "BA", "BIH", "070"));
            _countries.Add(new CountryInfo("Botswana", "BW", "BWA", "072"));
            _countries.Add(new CountryInfo("Bouvet Island", "BV", "BVT", "074"));
            _countries.Add(new CountryInfo("Brazil", "BR", "BRA", "076"));
            _countries.Add(new CountryInfo("British Indian Ocean Territory", "IO", "IOT", "086"));
            _countries.Add(new CountryInfo("Brunei Darussalam", "BN", "BRN", "096"));
            _countries.Add(new CountryInfo("Bulgaria", "BG", "BGR", "100"));
            _countries.Add(new CountryInfo("Burkina Faso", "BF", "BFA", "854"));
            _countries.Add(new CountryInfo("Burundi", "BI", "BDI", "108"));
            _countries.Add(new CountryInfo("Cabo Verde", "CV", "CPV", "132"));
            _countries.Add(new CountryInfo("Cambodia", "KH", "KHM", "116"));
            _countries.Add(new CountryInfo("Cameroon", "CM", "CMR", "120"));
            _countries.Add(new CountryInfo("Canada", "CA", "CAN", "124"));
            _countries.Add(new CountryInfo("Cayman Islands", "KY", "CYM", "136"));
            _countries.Add(new CountryInfo("Central African Republic", "CF", "CAF", "140"));
            _countries.Add(new CountryInfo("Chad", "TD", "TCD", "148"));
            _countries.Add(new CountryInfo("Chile", "CL", "CHL", "152"));
            _countries.Add(new CountryInfo("China", "CN", "CHN", "156"));
            _countries.Add(new CountryInfo("Christmas Island", "CX", "CXR", "162"));
            _countries.Add(new CountryInfo("Cocos (Keeling) Islands", "CC", "CCK", "166"));
            _countries.Add(new CountryInfo("Colombia", "CO", "COL", "170"));
            _countries.Add(new CountryInfo("Comoros", "KM", "COM", "174"));
            _countries.Add(new CountryInfo("Congo", "CG", "COG", "178"));
            _countries.Add(new CountryInfo("Congo, the Democratic Republic of the", "CD", "COD", "180"));
            _countries.Add(new CountryInfo("Cook Islands", "CK", "COK", "184"));
            _countries.Add(new CountryInfo("Costa Rica", "CR", "CRI", "188"));
            _countries.Add(new CountryInfo("Côte d'Ivoire", "CI", "CIV", "384"));
            _countries.Add(new CountryInfo("Croatia", "HR", "HRV", "191"));
            _countries.Add(new CountryInfo("Cuba", "CU", "CUB", "192"));
            _countries.Add(new CountryInfo("Curaçao", "CW", "CUW", "531"));
            _countries.Add(new CountryInfo("Cyprus", "CY", "CYP", "196"));
            _countries.Add(new CountryInfo("Czechia", "CZ", "CZE", "203"));
            _countries.Add(new CountryInfo("Denmark", "DK", "DNK", "208"));
            _countries.Add(new CountryInfo("Djibouti", "DJ", "DJI", "262"));
            _countries.Add(new CountryInfo("Dominica", "DM", "DMA", "212"));
            _countries.Add(new CountryInfo("Dominican Republic", "DO", "DOM", "214"));
            _countries.Add(new CountryInfo("Ecuador", "EC", "ECU", "218"));
            _countries.Add(new CountryInfo("Egypt", "EG", "EGY", "818"));
            _countries.Add(new CountryInfo("El Salvador", "SV", "SLV", "222"));
            _countries.Add(new CountryInfo("Equatorial Guinea", "GQ", "GNQ", "226"));
            _countries.Add(new CountryInfo("Eritrea", "ER", "ERI", "232"));
            _countries.Add(new CountryInfo("Estonia", "EE", "EST", "233"));
            _countries.Add(new CountryInfo("Eswatini", "SZ", "SWZ", "748"));
            _countries.Add(new CountryInfo("Ethiopia", "ET", "ETH", "231"));
            _countries.Add(new CountryInfo("Falkland Islands (Malvinas)", "FK", "FLK", "238"));
            _countries.Add(new CountryInfo("Faroe Islands", "FO", "FRO", "234"));
            _countries.Add(new CountryInfo("Fiji", "FJ", "FJI", "242"));
            _countries.Add(new CountryInfo("Finland", "FI", "FIN", "246"));
            _countries.Add(new CountryInfo("France", "FR", "FRA", "250"));
            _countries.Add(new CountryInfo("French Guiana", "GF", "GUF", "254"));
            _countries.Add(new CountryInfo("French Polynesia", "PF", "PYF", "258"));
            _countries.Add(new CountryInfo("French Southern Territories", "TF", "ATF", "260"));
            _countries.Add(new CountryInfo("Gabon", "GA", "GAB", "266"));
            _countries.Add(new CountryInfo("Gambia", "GM", "GMB", "270"));
            _countries.Add(new CountryInfo("Georgia", "GE", "GEO", "268"));
            _countries.Add(new CountryInfo("Germany", "DE", "DEU", "276"));
            _countries.Add(new CountryInfo("Ghana", "GH", "GHA", "288"));
            _countries.Add(new CountryInfo("Gibraltar", "GI", "GIB", "292"));
            _countries.Add(new CountryInfo("Greece", "GR", "GRC", "300"));
            _countries.Add(new CountryInfo("Greenland", "GL", "GRL", "304"));
            _countries.Add(new CountryInfo("Grenada", "GD", "GRD", "308"));
            _countries.Add(new CountryInfo("Guadeloupe", "GP", "GLP", "312"));
            _countries.Add(new CountryInfo("Guam", "GU", "GUM", "316"));
            _countries.Add(new CountryInfo("Guatemala", "GT", "GTM", "320"));
            _countries.Add(new CountryInfo("Guernsey", "GG", "GGY", "831"));
            _countries.Add(new CountryInfo("Guinea", "GN", "GIN", "324"));
            _countries.Add(new CountryInfo("Guinea-Bissau", "GW", "GNB", "624"));
            _countries.Add(new CountryInfo("Guyana", "GY", "GUY", "328"));
            _countries.Add(new CountryInfo("Haiti", "HT", "HTI", "332"));
            _countries.Add(new CountryInfo("Heard Island and McDonald Islands", "HM", "HMD", "334"));
            _countries.Add(new CountryInfo("Holy See", "VA", "VAT", "336"));
            _countries.Add(new CountryInfo("Honduras", "HN", "HND", "340"));
            _countries.Add(new CountryInfo("Hong Kong", "HK", "HKG", "344"));
            _countries.Add(new CountryInfo("Hungary", "HU", "HUN", "348"));
            _countries.Add(new CountryInfo("Iceland", "IS", "ISL", "352"));
            _countries.Add(new CountryInfo("India", "IN", "IND", "356"));
            _countries.Add(new CountryInfo("Indonesia", "ID", "IDN", "360"));
            _countries.Add(new CountryInfo("Iran, Islamic Republic of", "IR", "IRN", "364"));
            _countries.Add(new CountryInfo("Iraq", "IQ", "IRQ", "368"));
            _countries.Add(new CountryInfo("Ireland", "IE", "IRL", "372"));
            _countries.Add(new CountryInfo("Isle of Man", "IM", "IMN", "833"));
            _countries.Add(new CountryInfo("Israel", "IL", "ISR", "376"));
            _countries.Add(new CountryInfo("Italy", "IT", "ITA", "380"));
            _countries.Add(new CountryInfo("Jamaica", "JM", "JAM", "388"));
            _countries.Add(new CountryInfo("Japan", "JP", "JPN", "392"));
            _countries.Add(new CountryInfo("Jersey", "JE", "JEY", "832"));
            _countries.Add(new CountryInfo("Jordan", "JO", "JOR", "400"));
            _countries.Add(new CountryInfo("Kazakhstan", "KZ", "KAZ", "398"));
            _countries.Add(new CountryInfo("Kenya", "KE", "KEN", "404"));
            _countries.Add(new CountryInfo("Kiribati", "KI", "KIR", "296"));
            _countries.Add(new CountryInfo("Korea, Democratic People's Republic of", "KP", "PRK", "408"));
            _countries.Add(new CountryInfo("Korea, Republic of", "KR", "KOR", "410"));
            _countries.Add(new CountryInfo("Kuwait", "KW", "KWT", "414"));
            _countries.Add(new CountryInfo("Kyrgyzstan", "KG", "KGZ", "417"));
            _countries.Add(new CountryInfo("Lao People's Democratic Republic", "LA", "LAO", "418"));
            _countries.Add(new CountryInfo("Latvia", "LV", "LVA", "428"));
            _countries.Add(new CountryInfo("Lebanon", "LB", "LBN", "422"));
            _countries.Add(new CountryInfo("Lesotho", "LS", "LSO", "426"));
            _countries.Add(new CountryInfo("Liberia", "LR", "LBR", "430"));
            _countries.Add(new CountryInfo("Libya", "LY", "LBY", "434"));
            _countries.Add(new CountryInfo("Liechtenstein", "LI", "LIE", "438"));
            _countries.Add(new CountryInfo("Lithuania", "LT", "LTU", "440"));
            _countries.Add(new CountryInfo("Luxembourg", "LU", "LUX", "442"));
            _countries.Add(new CountryInfo("Macao", "MO", "MAC", "446"));
            _countries.Add(new CountryInfo("Madagascar", "MG", "MDG", "450"));
            _countries.Add(new CountryInfo("Malawi", "MW", "MWI", "454"));
            _countries.Add(new CountryInfo("Malaysia", "MY", "MYS", "458"));
            _countries.Add(new CountryInfo("Maldives", "MV", "MDV", "462"));
            _countries.Add(new CountryInfo("Mali", "ML", "MLI", "466"));
            _countries.Add(new CountryInfo("Malta", "MT", "MLT", "470"));
            _countries.Add(new CountryInfo("Marshall Islands", "MH", "MHL", "584"));
            _countries.Add(new CountryInfo("Martinique", "MQ", "MTQ", "474"));
            _countries.Add(new CountryInfo("Mauritania", "MR", "MRT", "478"));
            _countries.Add(new CountryInfo("Mauritius", "MU", "MUS", "480"));
            _countries.Add(new CountryInfo("Mayotte", "YT", "MYT", "175"));
            _countries.Add(new CountryInfo("Mexico", "MX", "MEX", "484"));
            _countries.Add(new CountryInfo("Micronesia, Federated States of", "FM", "FSM", "583"));
            _countries.Add(new CountryInfo("Moldova, Republic of", "MD", "MDA", "498"));
            _countries.Add(new CountryInfo("Monaco", "MC", "MCO", "492"));
            _countries.Add(new CountryInfo("Mongolia", "MN", "MNG", "496"));
            _countries.Add(new CountryInfo("Montenegro", "ME", "MNE", "499"));
            _countries.Add(new CountryInfo("Montserrat", "MS", "MSR", "500"));
            _countries.Add(new CountryInfo("Morocco", "MA", "MAR", "504"));
            _countries.Add(new CountryInfo("Mozambique", "MZ", "MOZ", "508"));
            _countries.Add(new CountryInfo("Myanmar", "MM", "MMR", "104"));
            _countries.Add(new CountryInfo("Namibia", "NA", "NAM", "516"));
            _countries.Add(new CountryInfo("Nauru", "NR", "NRU", "520"));
            _countries.Add(new CountryInfo("Nepal", "NP", "NPL", "524"));
            _countries.Add(new CountryInfo("Netherlands", "NL", "NLD", "528"));
            _countries.Add(new CountryInfo("New Caledonia", "NC", "NCL", "540"));
            _countries.Add(new CountryInfo("New Zealand", "NZ", "NZL", "554"));
            _countries.Add(new CountryInfo("Nicaragua", "NI", "NIC", "558"));
            _countries.Add(new CountryInfo("Niger", "NE", "NER", "562"));
            _countries.Add(new CountryInfo("Nigeria", "NG", "NGA", "566"));
            _countries.Add(new CountryInfo("Niue", "NU", "NIU", "570"));
            _countries.Add(new CountryInfo("Norfolk Island", "NF", "NFK", "574"));
            _countries.Add(new CountryInfo("Northern Mariana Islands", "MP", "MNP", "580"));
            _countries.Add(new CountryInfo("North Macedonia", "MK", "MKD", "807"));
            _countries.Add(new CountryInfo("Norway", "NO", "NOR", "578"));
            _countries.Add(new CountryInfo("Oman", "OM", "OMN", "512"));
            _countries.Add(new CountryInfo("Pakistan", "PK", "PAK", "586"));
            _countries.Add(new CountryInfo("Palau", "PW", "PLW", "585"));
            _countries.Add(new CountryInfo("Palestine, State of", "PS", "PSE", "275"));
            _countries.Add(new CountryInfo("Panama", "PA", "PAN", "591"));
            _countries.Add(new CountryInfo("Papua New Guinea", "PG", "PNG", "598"));
            _countries.Add(new CountryInfo("Paraguay", "PY", "PRY", "600"));
            _countries.Add(new CountryInfo("Peru", "PE", "PER", "604"));
            _countries.Add(new CountryInfo("Philippines", "PH", "PHL", "608"));
            _countries.Add(new CountryInfo("Pitcairn", "PN", "PCN", "612"));
            _countries.Add(new CountryInfo("Poland", "PL", "POL", "616"));
            _countries.Add(new CountryInfo("Portugal", "PT", "PRT", "620"));
            _countries.Add(new CountryInfo("Puerto Rico", "PR", "PRI", "630"));
            _countries.Add(new CountryInfo("Qatar", "QA", "QAT", "634"));
            _countries.Add(new CountryInfo("Réunion", "RE", "REU", "638"));
            _countries.Add(new CountryInfo("Romania", "RO", "ROU", "642"));
            _countries.Add(new CountryInfo("Russian Federation", "RU", "RUS", "643"));
            _countries.Add(new CountryInfo("Rwanda", "RW", "RWA", "646"));
            _countries.Add(new CountryInfo("Saint Barthélemy", "BL", "BLM", "652"));
            _countries.Add(new CountryInfo("Saint Helena, Ascension and Tristan da Cunha", "SH", "SHN", "654"));
            _countries.Add(new CountryInfo("Saint Kitts and Nevis", "KN", "KNA", "659"));
            _countries.Add(new CountryInfo("Saint Lucia", "LC", "LCA", "662"));
            _countries.Add(new CountryInfo("Saint Martin (French part)", "MF", "MAF", "663"));
            _countries.Add(new CountryInfo("Saint Pierre and Miquelon", "PM", "SPM", "666"));
            _countries.Add(new CountryInfo("Saint Vincent and the Grenadines", "VC", "VCT", "670"));
            _countries.Add(new CountryInfo("Samoa", "WS", "WSM", "882"));
            _countries.Add(new CountryInfo("San Marino", "SM", "SMR", "674"));
            _countries.Add(new CountryInfo("Sao Tome and Principe", "ST", "STP", "678"));
            _countries.Add(new CountryInfo("Saudi Arabia", "SA", "SAU", "682"));
            _countries.Add(new CountryInfo("Senegal", "SN", "SEN", "686"));
            _countries.Add(new CountryInfo("Serbia", "RS", "SRB", "688"));
            _countries.Add(new CountryInfo("Seychelles", "SC", "SYC", "690"));
            _countries.Add(new CountryInfo("Sierra Leone", "SL", "SLE", "694"));
            _countries.Add(new CountryInfo("Singapore", "SG", "SGP", "702"));
            _countries.Add(new CountryInfo("Sint Maarten (Dutch part)", "SX", "SXM", "534"));
            _countries.Add(new CountryInfo("Slovakia", "SK", "SVK", "703"));
            _countries.Add(new CountryInfo("Slovenia", "SI", "SVN", "705"));
            _countries.Add(new CountryInfo("Solomon Islands", "SB", "SLB", "090"));
            _countries.Add(new CountryInfo("Somalia", "SO", "SOM", "706"));
            _countries.Add(new CountryInfo("South Africa", "ZA", "ZAF", "710"));
            _countries.Add(new CountryInfo("South Georgia and the South Sandwich Islands", "GS", "SGS", "239"));
            _countries.Add(new CountryInfo("South Sudan", "SS", "SSD", "728"));
            _countries.Add(new CountryInfo("Spain", "ES", "ESP", "724"));
            _countries.Add(new CountryInfo("Sri Lanka", "LK", "LKA", "144"));
            _countries.Add(new CountryInfo("Sudan", "SD", "SDN", "729"));
            _countries.Add(new CountryInfo("Suriname", "SR", "SUR", "740"));
            _countries.Add(new CountryInfo("Svalbard and Jan Mayen", "SJ", "SJM", "744"));
            _countries.Add(new CountryInfo("Sweden", "SE", "SWE", "752"));
            _countries.Add(new CountryInfo("Switzerland", "CH", "CHE", "756"));
            _countries.Add(new CountryInfo("Syrian Arab Republic", "SY", "SYR", "760"));
            _countries.Add(new CountryInfo("Taiwan, Province of China", "TW", "TWN", "158"));
            _countries.Add(new CountryInfo("Tajikistan", "TJ", "TJK", "762"));
            _countries.Add(new CountryInfo("Tanzania, United Republic of", "TZ", "TZA", "834"));
            _countries.Add(new CountryInfo("Thailand", "TH", "THA", "764"));
            _countries.Add(new CountryInfo("Timor-Leste", "TL", "TLS", "626"));
            _countries.Add(new CountryInfo("Togo", "TG", "TGO", "768"));
            _countries.Add(new CountryInfo("Tokelau", "TK", "TKL", "772"));
            _countries.Add(new CountryInfo("Tonga", "TO", "TON", "776"));
            _countries.Add(new CountryInfo("Trinidad and Tobago", "TT", "TTO", "780"));
            _countries.Add(new CountryInfo("Tunisia", "TN", "TUN", "788"));
            _countries.Add(new CountryInfo("Turkey", "TR", "TUR", "792"));
            _countries.Add(new CountryInfo("Turkmenistan", "TM", "TKM", "795"));
            _countries.Add(new CountryInfo("Turks and Caicos Islands", "TC", "TCA", "796"));
            _countries.Add(new CountryInfo("Tuvalu", "TV", "TUV", "798"));
            _countries.Add(new CountryInfo("Uganda", "UG", "UGA", "800"));
            _countries.Add(new CountryInfo("Ukraine", "UA", "UKR", "804"));
            _countries.Add(new CountryInfo("United Arab Emirates", "AE", "ARE", "784"));
            _countries.Add(new CountryInfo("United Kingdom of Great Britain and Northern Ireland", "GB", "GBR", "826"));
            _countries.Add(new CountryInfo("United States of America", "US", "USA", "840"));
            _countries.Add(new CountryInfo("United States Minor Outlying Islands", "UM", "UMI", "581"));
            _countries.Add(new CountryInfo("Uruguay", "UY", "URY", "858"));
            _countries.Add(new CountryInfo("Uzbekistan", "UZ", "UZB", "860"));
            _countries.Add(new CountryInfo("Vanuatu", "VU", "VUT", "548"));
            _countries.Add(new CountryInfo("Venezuela, Bolivarian Republic of", "VE", "VEN", "862"));
            _countries.Add(new CountryInfo("Viet Nam", "VN", "VNM", "704"));
            _countries.Add(new CountryInfo("Virgin Islands, British", "VG", "VGB", "092"));
            _countries.Add(new CountryInfo("Virgin Islands, U.S.", "VI", "VIR", "850"));
            _countries.Add(new CountryInfo("Wallis and Futuna", "WF", "WLF", "876"));
            _countries.Add(new CountryInfo("Western Sahara", "EH", "ESH", "732"));
            _countries.Add(new CountryInfo("Yemen", "YE", "YEM", "887"));
            _countries.Add(new CountryInfo("Zambia", "ZM", "ZMB", "894"));
            _countries.Add(new CountryInfo("Zimbabwe", "ZW", "ZWE", "716"));
            _countries.Add(new CountryInfo("Åland Islands", "AX", "ALA", "248"));
        }



        private static List<CountryInfo> _countries = new List<CountryInfo>();

        private static CountryInfo GetCountryInfoCore(Func<CountryInfo, bool> condition)
        {
            CountryInfo result = null;

            foreach (var country in AllCountries)
            {
                if (!condition(country)) continue;

                result = country;
                break;
            }

            return result;
        }


        private static IEnumerable<CountryInfo> GetCountryInfoListCore(Func<CountryInfo, bool> condition)
        {
            List<CountryInfo> result = new List<CountryInfo>();

            foreach (var country in AllCountries)
            {
                if (!condition(country)) continue;

                result.Add(country);
            }

            return result;
        }
    }
}
