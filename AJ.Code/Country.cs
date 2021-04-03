using AJ.Code.Properties;
using System;
using System.Collections.Generic;

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
            _countries.Add(new CountryInfo(Resources.AL, "AL", "ALB", "008", ContinentCode.EU, new MobileInfo(276)));
            _countries.Add(new CountryInfo(Resources.DZ, "DZ", "DZA", "012", ContinentCode.AF, new MobileInfo(603)));
            _countries.Add(new CountryInfo(Resources.AS, "AS", "ASM", "016", ContinentCode.OC, new MobileInfo(544)));
            _countries.Add(new CountryInfo(Resources.AD, "AD", "AND", "020", ContinentCode.EU, new MobileInfo(213)));
            _countries.Add(new CountryInfo(Resources.AO, "AO", "AGO", "024", ContinentCode.AF, new MobileInfo(631)));
            _countries.Add(new CountryInfo(Resources.AI, "AI", "AIA", "660", ContinentCode.NA, new MobileInfo(365)));
            _countries.Add(new CountryInfo(Resources.AQ, "AQ", "ATA", "010", ContinentCode.AN, new MobileInfo(672)));
            _countries.Add(new CountryInfo(Resources.AG, "AG", "ATG", "028", ContinentCode.NA, new MobileInfo(344)));
            _countries.Add(new CountryInfo(Resources.AR, "AR", "ARG", "032", ContinentCode.SA, new MobileInfo(722)));
            _countries.Add(new CountryInfo(Resources.AM, "AM", "ARM", "051", ContinentCode.AS, new MobileInfo(283)));
            _countries.Add(new CountryInfo(Resources.AW, "AW", "ABW", "533", ContinentCode.NA, new MobileInfo(363)));
            _countries.Add(new CountryInfo(Resources.AU, "AU", "AUS", "036", ContinentCode.OC, new MobileInfo(505)));
            _countries.Add(new CountryInfo(Resources.AT, "AT", "AUT", "040", ContinentCode.EU, new MobileInfo(232)));
            _countries.Add(new CountryInfo(Resources.AZ, "AZ", "AZE", "031", ContinentCode.AS, new MobileInfo(400)));
            _countries.Add(new CountryInfo(Resources.BS, "BS", "BHS", "044", ContinentCode.NA, new MobileInfo(364)));
            _countries.Add(new CountryInfo(Resources.BH, "BH", "BHR", "048", ContinentCode.AS, new MobileInfo(426)));
            _countries.Add(new CountryInfo(Resources.BD, "BD", "BGD", "050", ContinentCode.AS, new MobileInfo(470)));
            _countries.Add(new CountryInfo(Resources.BB, "BB", "BRB", "052", ContinentCode.NA, new MobileInfo(342)));
            _countries.Add(new CountryInfo(Resources.BY, "BY", "BLR", "112", ContinentCode.EU, new MobileInfo(257)));
            _countries.Add(new CountryInfo(Resources.BE, "BE", "BEL", "056", ContinentCode.EU, new MobileInfo(206)));
            _countries.Add(new CountryInfo(Resources.BZ, "BZ", "BLZ", "084", ContinentCode.NA, new MobileInfo(702)));
            _countries.Add(new CountryInfo(Resources.BJ, "BJ", "BEN", "204", ContinentCode.AF, new MobileInfo(616)));
            _countries.Add(new CountryInfo(Resources.BM, "BM", "BMU", "060", ContinentCode.NA, new MobileInfo(350)));
            _countries.Add(new CountryInfo(Resources.BT, "BT", "BTN", "064", ContinentCode.AS, new MobileInfo(402)));
            _countries.Add(new CountryInfo(Resources.BO, "BO", "BOL", "068", ContinentCode.SA, new MobileInfo(736)));
            _countries.Add(new CountryInfo(Resources.BQ, "BQ", "BES", "535", ContinentCode.SA, new MobileInfo(362)));
            _countries.Add(new CountryInfo(Resources.BA, "BA", "BIH", "070", ContinentCode.EU, new MobileInfo(218)));
            _countries.Add(new CountryInfo(Resources.BW, "BW", "BWA", "072", ContinentCode.AF, new MobileInfo(652)));
            _countries.Add(new CountryInfo(Resources.BV, "BV", "BVT", "074", ContinentCode.AN, new MobileInfo(257)));
            _countries.Add(new CountryInfo(Resources.BR, "BR", "BRA", "076", ContinentCode.SA, new MobileInfo(724)));
            _countries.Add(new CountryInfo(Resources.IO, "IO", "IOT", "086", ContinentCode.AS, new MobileInfo(995)));
            _countries.Add(new CountryInfo(Resources.BN, "BN", "BRN", "096", ContinentCode.AS, new MobileInfo(528)));
            _countries.Add(new CountryInfo(Resources.BG, "BG", "BGR", "100", ContinentCode.EU, new MobileInfo(284)));
            _countries.Add(new CountryInfo(Resources.BF, "BF", "BFA", "854", ContinentCode.AF, new MobileInfo(613)));
            _countries.Add(new CountryInfo(Resources.BI, "BI", "BDI", "108", ContinentCode.AF, new MobileInfo(642)));
            _countries.Add(new CountryInfo(Resources.CV, "CV", "CPV", "132", ContinentCode.AF, new MobileInfo(625)));
            _countries.Add(new CountryInfo(Resources.KH, "KH", "KHM", "116", ContinentCode.AS, new MobileInfo(456)));
            _countries.Add(new CountryInfo(Resources.CM, "CM", "CMR", "120", ContinentCode.AF, new MobileInfo(624)));
            _countries.Add(new CountryInfo(Resources.CA, "CA", "CAN", "124", ContinentCode.NA, new MobileInfo(302)));
            _countries.Add(new CountryInfo(Resources.KY, "KY", "CYM", "136", ContinentCode.NA, new MobileInfo(346)));
            _countries.Add(new CountryInfo(Resources.CF, "CF", "CAF", "140", ContinentCode.AF, new MobileInfo(623)));
            _countries.Add(new CountryInfo(Resources.TD, "TD", "TCD", "148", ContinentCode.AF, new MobileInfo(622)));
            _countries.Add(new CountryInfo(Resources.CL, "CL", "CHL", "152", ContinentCode.SA, new MobileInfo(730)));
            _countries.Add(new CountryInfo(Resources.CN, "CN", "CHN", "156", ContinentCode.AS, new MobileInfo(460)));
            _countries.Add(new CountryInfo(Resources.CX, "CX", "CXR", "162", ContinentCode.AS, new MobileInfo(505)));
            _countries.Add(new CountryInfo(Resources.CC, "CC", "CCK", "166", ContinentCode.AS));
            _countries.Add(new CountryInfo(Resources.CO, "CO", "COL", "170", ContinentCode.SA, new MobileInfo(732)));
            _countries.Add(new CountryInfo(Resources.KM, "KM", "COM", "174", ContinentCode.AF, new MobileInfo(654)));
            _countries.Add(new CountryInfo(Resources.CG, "CG", "COG", "178", ContinentCode.AF, new MobileInfo(629)));
            _countries.Add(new CountryInfo(Resources.CD, "CD", "COD", "180", ContinentCode.AF, new MobileInfo(630)));
            _countries.Add(new CountryInfo(Resources.CK, "CK", "COK", "184", ContinentCode.OC, new MobileInfo(548)));
            _countries.Add(new CountryInfo(Resources.CR, "CR", "CRI", "188", ContinentCode.NA, new MobileInfo(712)));
            _countries.Add(new CountryInfo(Resources.CI, "CI", "CIV", "384", ContinentCode.AF, new MobileInfo(612)));
            _countries.Add(new CountryInfo(Resources.HR, "HR", "HRV", "191", ContinentCode.EU, new MobileInfo(219)));
            _countries.Add(new CountryInfo(Resources.CU, "CU", "CUB", "192", ContinentCode.NA, new MobileInfo(368)));
            _countries.Add(new CountryInfo(Resources.CW, "CW", "CUW", "531", ContinentCode.SA, new MobileInfo(362)));
            _countries.Add(new CountryInfo(Resources.CY, "CY", "CYP", "196", ContinentCode.AS, new MobileInfo(280)));
            _countries.Add(new CountryInfo(Resources.CZ, "CZ", "CZE", "203", ContinentCode.EU, new MobileInfo(230)));
            _countries.Add(new CountryInfo(Resources.DK, "DK", "DNK", "208", ContinentCode.EU, new MobileInfo(283)));
            _countries.Add(new CountryInfo(Resources.DJ, "DJ", "DJI", "262", ContinentCode.AF, new MobileInfo(638)));
            _countries.Add(new CountryInfo(Resources.DM, "DM", "DMA", "212", ContinentCode.NA, new MobileInfo(366)));
            _countries.Add(new CountryInfo(Resources.DO, "DO", "DOM", "214", ContinentCode.NA, new MobileInfo(370)));
            _countries.Add(new CountryInfo(Resources.EC, "EC", "ECU", "218", ContinentCode.SA, new MobileInfo(740)));
            _countries.Add(new CountryInfo(Resources.EG, "EG", "EGY", "818", ContinentCode.AF, new MobileInfo(602)));
            _countries.Add(new CountryInfo(Resources.SV, "SV", "SLV", "222", ContinentCode.NA, new MobileInfo(706)));
            _countries.Add(new CountryInfo(Resources.GQ, "GQ", "GNQ", "226", ContinentCode.AF, new MobileInfo(627)));
            _countries.Add(new CountryInfo(Resources.ER, "ER", "ERI", "232", ContinentCode.AF, new MobileInfo(657)));
            _countries.Add(new CountryInfo(Resources.EE, "EE", "EST", "233", ContinentCode.EU, new MobileInfo(248)));
            _countries.Add(new CountryInfo(Resources.SZ, "SZ", "SWZ", "748", ContinentCode.AF, new MobileInfo(653)));
            _countries.Add(new CountryInfo(Resources.ET, "ET", "ETH", "231", ContinentCode.AF, new MobileInfo(636)));
            _countries.Add(new CountryInfo(Resources.FK, "FK", "FLK", "238", ContinentCode.SA, new MobileInfo(750)));
            _countries.Add(new CountryInfo(Resources.FO, "FO", "FRO", "234", ContinentCode.EU, new MobileInfo(288)));
            _countries.Add(new CountryInfo(Resources.FJ, "FJ", "FJI", "242", ContinentCode.OC, new MobileInfo(542)));
            _countries.Add(new CountryInfo(Resources.FI, "FI", "FIN", "246", ContinentCode.EU, new MobileInfo(244)));
            _countries.Add(new CountryInfo(Resources.FR, "FR", "FRA", "250", ContinentCode.EU, new MobileInfo(208)));
            _countries.Add(new CountryInfo(Resources.GF, "GF", "GUF", "254", ContinentCode.SA, new MobileInfo(742)));
            _countries.Add(new CountryInfo(Resources.PF, "PF", "PYF", "258", ContinentCode.OC, new MobileInfo(547)));
            _countries.Add(new CountryInfo(Resources.TF, "TF", "ATF", "260", ContinentCode.AN));
            _countries.Add(new CountryInfo(Resources.GA, "GA", "GAB", "266", ContinentCode.AF, new MobileInfo(628)));
            _countries.Add(new CountryInfo(Resources.GM, "GM", "GMB", "270", ContinentCode.AF, new MobileInfo(607)));
            _countries.Add(new CountryInfo(Resources.GE, "GE", "GEO", "268", ContinentCode.AS, new MobileInfo(282)));
            _countries.Add(new CountryInfo(Resources.DE, "DE", "DEU", "276", ContinentCode.EU, new MobileInfo(262)));
            _countries.Add(new CountryInfo(Resources.GH, "GH", "GHA", "288", ContinentCode.AF, new MobileInfo(620)));
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
