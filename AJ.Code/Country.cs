using AJ.Code.Properties;
using System;
using System.Collections.Generic;
using System.Linq;

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
        /// Get the country information list for MCC.
        /// MCC에 대한 국가정보목록을 가져옵니다.
        /// </summary>
        /// <param name="mcc"></param>
        /// <returns></returns>
        /*******************************************************************/
        public static IEnumerable<CountryInfo> GetCountryInfoForMCC(int mcc)
            => GetCountryInfoListCore((country) => country.MobileCodes.Contains(new MobileInfo(mcc)));


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
        /// 대륙코드에 대한 국가정보목록을 가져옵니다.
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
            _countries.Add(new CountryInfo(Resources.GI, "GI", "GIB", "292", ContinentCode.EU, new MobileInfo(266)));
            _countries.Add(new CountryInfo(Resources.GR, "GR", "GRC", "300", ContinentCode.EU, new MobileInfo(202)));
            _countries.Add(new CountryInfo(Resources.GL, "GL", "GRL", "304", ContinentCode.NA, new MobileInfo(290)));
            _countries.Add(new CountryInfo(Resources.GD, "GD", "GRD", "308", ContinentCode.NA, new MobileInfo(352)));
            _countries.Add(new CountryInfo(Resources.GP, "GP", "GLP", "312", ContinentCode.NA, new MobileInfo(340)));
            _countries.Add(new CountryInfo(Resources.GU, "GU", "GUM", "316", ContinentCode.OC, new MobileInfo(310), new MobileInfo(311)));
            _countries.Add(new CountryInfo(Resources.GT, "GT", "GTM", "320", ContinentCode.NA, new MobileInfo(704)));
            _countries.Add(new CountryInfo(Resources.GG, "GG", "GGY", "831", ContinentCode.EU, new MobileInfo(234)));
            _countries.Add(new CountryInfo(Resources.GN, "GN", "GIN", "324", ContinentCode.AF, new MobileInfo(611)));
            _countries.Add(new CountryInfo(Resources.GW, "GW", "GNB", "624", ContinentCode.AF, new MobileInfo(632)));
            _countries.Add(new CountryInfo(Resources.GY, "GY", "GUY", "328", ContinentCode.SA, new MobileInfo(738)));
            _countries.Add(new CountryInfo(Resources.HT, "HT", "HTI", "332", ContinentCode.NA, new MobileInfo(372)));
            _countries.Add(new CountryInfo(Resources.HM, "HM", "HMD", "334", ContinentCode.AN));
            _countries.Add(new CountryInfo(Resources.VA, "VA", "VAT", "336", ContinentCode.EU));
            _countries.Add(new CountryInfo(Resources.HN, "HN", "HND", "340", ContinentCode.NA, new MobileInfo(708)));
            _countries.Add(new CountryInfo(Resources.HK, "HK", "HKG", "344", ContinentCode.AS, new MobileInfo(454)));
            _countries.Add(new CountryInfo(Resources.HU, "HU", "HUN", "348", ContinentCode.EU, new MobileInfo(216)));
            _countries.Add(new CountryInfo(Resources.IS, "IS", "ISL", "352", ContinentCode.EU, new MobileInfo(274)));
            _countries.Add(new CountryInfo(Resources.IN, "IN", "IND", "356", ContinentCode.AS, new MobileInfo(404), new MobileInfo(405), new MobileInfo(406)));
            _countries.Add(new CountryInfo(Resources.ID, "ID", "IDN", "360", ContinentCode.AS, new MobileInfo(510)));
            _countries.Add(new CountryInfo(Resources.IR, "IR", "IRN", "364", ContinentCode.AS, new MobileInfo(432)));
            _countries.Add(new CountryInfo(Resources.IQ, "IQ", "IRQ", "368", ContinentCode.AS, new MobileInfo(418)));
            _countries.Add(new CountryInfo(Resources.IE, "IE", "IRL", "372", ContinentCode.EU, new MobileInfo(272)));
            _countries.Add(new CountryInfo(Resources.IM, "IM", "IMN", "833", ContinentCode.EU, new MobileInfo(234)));
            _countries.Add(new CountryInfo(Resources.IL, "IL", "ISR", "376", ContinentCode.AS, new MobileInfo(425)));
            _countries.Add(new CountryInfo(Resources.IT, "IT", "ITA", "380", ContinentCode.EU, new MobileInfo(222)));
            _countries.Add(new CountryInfo(Resources.JM, "JM", "JAM", "388", ContinentCode.NA, new MobileInfo(338)));
            _countries.Add(new CountryInfo(Resources.JP, "JP", "JPN", "392", ContinentCode.AS, new MobileInfo(440), new MobileInfo(441)));
            _countries.Add(new CountryInfo(Resources.JE, "JE", "JEY", "832", ContinentCode.EU, new MobileInfo(234)));
            _countries.Add(new CountryInfo(Resources.JO, "JO", "JOR", "400", ContinentCode.AS, new MobileInfo(416)));
            _countries.Add(new CountryInfo(Resources.KZ, "KZ", "KAZ", "398", ContinentCode.AS, new MobileInfo(401)));
            _countries.Add(new CountryInfo(Resources.KE, "KE", "KEN", "404", ContinentCode.AF, new MobileInfo(639)));
            _countries.Add(new CountryInfo(Resources.KI, "KI", "KIR", "296", ContinentCode.OC, new MobileInfo(545)));
            _countries.Add(new CountryInfo(Resources.KP, "KP", "PRK", "408", ContinentCode.AS, new MobileInfo(467)));
            _countries.Add(new CountryInfo(Resources.KR, "KR", "KOR", "410", ContinentCode.AS, new MobileInfo(450)));
            _countries.Add(new CountryInfo(Resources.KW, "KW", "KWT", "414", ContinentCode.AS, new MobileInfo(419)));
            _countries.Add(new CountryInfo(Resources.KG, "KG", "KGZ", "417", ContinentCode.AS, new MobileInfo(437)));
            _countries.Add(new CountryInfo(Resources.LA, "LA", "LAO", "418", ContinentCode.AS, new MobileInfo(457)));
            _countries.Add(new CountryInfo(Resources.LV, "LV", "LVA", "428", ContinentCode.EU, new MobileInfo(247)));
            _countries.Add(new CountryInfo(Resources.LB, "LB", "LBN", "422", ContinentCode.AS, new MobileInfo(415)));
            _countries.Add(new CountryInfo(Resources.LS, "LS", "LSO", "426", ContinentCode.AF, new MobileInfo(651)));
            _countries.Add(new CountryInfo(Resources.LR, "LR", "LBR", "430", ContinentCode.AF, new MobileInfo(618)));
            _countries.Add(new CountryInfo(Resources.LY, "LY", "LBY", "434", ContinentCode.AF, new MobileInfo(606)));
            _countries.Add(new CountryInfo(Resources.LI, "LI", "LIE", "438", ContinentCode.EU, new MobileInfo(295)));
            _countries.Add(new CountryInfo(Resources.LT, "LT", "LTU", "440", ContinentCode.EU, new MobileInfo(246)));
            _countries.Add(new CountryInfo(Resources.LU, "LU", "LUX", "442", ContinentCode.EU, new MobileInfo(270)));
            _countries.Add(new CountryInfo(Resources.MO, "MO", "MAC", "446", ContinentCode.AS, new MobileInfo(455)));
            _countries.Add(new CountryInfo(Resources.MG, "MG", "MDG", "450", ContinentCode.AF, new MobileInfo(646)));
            _countries.Add(new CountryInfo(Resources.MW, "MW", "MWI", "454", ContinentCode.AF, new MobileInfo(650)));
            _countries.Add(new CountryInfo(Resources.MY, "MY", "MYS", "458", ContinentCode.AS, new MobileInfo(502)));
            _countries.Add(new CountryInfo(Resources.MV, "MV", "MDV", "462", ContinentCode.AS, new MobileInfo(472)));
            _countries.Add(new CountryInfo(Resources.ML, "ML", "MLI", "466", ContinentCode.AF, new MobileInfo(610)));
            _countries.Add(new CountryInfo(Resources.MT, "MT", "MLT", "470", ContinentCode.EU, new MobileInfo(278)));
            _countries.Add(new CountryInfo(Resources.MH, "MH", "MHL", "584", ContinentCode.OC, new MobileInfo(551)));
            _countries.Add(new CountryInfo(Resources.MQ, "MQ", "MTQ", "474", ContinentCode.NA, new MobileInfo(340)));
            _countries.Add(new CountryInfo(Resources.MR, "MR", "MRT", "478", ContinentCode.AF, new MobileInfo(609)));
            _countries.Add(new CountryInfo(Resources.MU, "MU", "MUS", "480", ContinentCode.AF, new MobileInfo(617)));
            _countries.Add(new CountryInfo(Resources.YT, "YT", "MYT", "175", ContinentCode.AF));
            _countries.Add(new CountryInfo(Resources.MX, "MX", "MEX", "484", ContinentCode.NA, new MobileInfo(334)));
            _countries.Add(new CountryInfo(Resources.FM, "FM", "FSM", "583", ContinentCode.OC, new MobileInfo(550)));
            _countries.Add(new CountryInfo(Resources.MD, "MD", "MDA", "498", ContinentCode.EU, new MobileInfo(259)));
            _countries.Add(new CountryInfo(Resources.MC, "MC", "MCO", "492", ContinentCode.EU, new MobileInfo(212)));
            _countries.Add(new CountryInfo(Resources.MN, "MN", "MNG", "496", ContinentCode.AS, new MobileInfo(428)));
            _countries.Add(new CountryInfo(Resources.ME, "ME", "MNE", "499", ContinentCode.EU, new MobileInfo(297)));
            _countries.Add(new CountryInfo(Resources.MS, "MS", "MSR", "500", ContinentCode.NA, new MobileInfo(354)));
            _countries.Add(new CountryInfo(Resources.MA, "MA", "MAR", "504", ContinentCode.AF, new MobileInfo(604)));
            _countries.Add(new CountryInfo(Resources.MZ, "MZ", "MOZ", "508", ContinentCode.AF, new MobileInfo(643)));
            _countries.Add(new CountryInfo(Resources.MM, "MM", "MMR", "104", ContinentCode.AS, new MobileInfo(414)));
            _countries.Add(new CountryInfo(Resources.NA, "NA", "NAM", "516", ContinentCode.AF, new MobileInfo(649)));
            _countries.Add(new CountryInfo(Resources.NR, "NR", "NRU", "520", ContinentCode.OC, new MobileInfo(536)));
            _countries.Add(new CountryInfo(Resources.NP, "NP", "NPL", "524", ContinentCode.AS, new MobileInfo(429)));
            _countries.Add(new CountryInfo(Resources.NL, "NL", "NLD", "528", ContinentCode.EU, new MobileInfo(204)));
            _countries.Add(new CountryInfo(Resources.NC, "NC", "NCL", "540", ContinentCode.OC, new MobileInfo(546)));
            _countries.Add(new CountryInfo(Resources.NZ, "NZ", "NZL", "554", ContinentCode.OC, new MobileInfo(530)));
            _countries.Add(new CountryInfo(Resources.NI, "NI", "NIC", "558", ContinentCode.NA, new MobileInfo(710)));
            _countries.Add(new CountryInfo(Resources.NE, "NE", "NER", "562", ContinentCode.AF, new MobileInfo(614)));
            _countries.Add(new CountryInfo(Resources.NG, "NG", "NGA", "566", ContinentCode.AF, new MobileInfo(621)));
            _countries.Add(new CountryInfo(Resources.NU, "NU", "NIU", "570", ContinentCode.OC, new MobileInfo(555)));
            _countries.Add(new CountryInfo(Resources.NF, "NF", "NFK", "574", ContinentCode.OC, new MobileInfo(505)));
            _countries.Add(new CountryInfo(Resources.MP, "MP", "MNP", "580", ContinentCode.OC, new MobileInfo(310)));
            _countries.Add(new CountryInfo(Resources.MK, "MK", "MKD", "807", ContinentCode.EU, new MobileInfo(294)));
            _countries.Add(new CountryInfo(Resources.NO, "NO", "NOR", "578", ContinentCode.EU, new MobileInfo(242)));
            _countries.Add(new CountryInfo(Resources.OM, "OM", "OMN", "512", ContinentCode.AS, new MobileInfo(422)));
            _countries.Add(new CountryInfo(Resources.PK, "PK", "PAK", "586", ContinentCode.AS, new MobileInfo(410)));
            _countries.Add(new CountryInfo(Resources.PW, "PW", "PLW", "585", ContinentCode.OC, new MobileInfo(552)));
            _countries.Add(new CountryInfo(Resources.PS, "PS", "PSE", "275", ContinentCode.AS, new MobileInfo(425)));
            _countries.Add(new CountryInfo(Resources.PA, "PA", "PAN", "591", ContinentCode.NA, new MobileInfo(714)));
            _countries.Add(new CountryInfo(Resources.PG, "PG", "PNG", "598", ContinentCode.OC, new MobileInfo(537)));
            _countries.Add(new CountryInfo(Resources.PY, "PY", "PRY", "600", ContinentCode.SA, new MobileInfo(744)));
            _countries.Add(new CountryInfo(Resources.PE, "PE", "PER", "604", ContinentCode.SA, new MobileInfo(716)));
            _countries.Add(new CountryInfo(Resources.PH, "PH", "PHL", "608", ContinentCode.AS, new MobileInfo(515)));
            _countries.Add(new CountryInfo(Resources.PN, "PN", "PCN", "612", ContinentCode.OC));
            _countries.Add(new CountryInfo(Resources.PL, "PL", "POL", "616", ContinentCode.EU, new MobileInfo(260)));
            _countries.Add(new CountryInfo(Resources.PT, "PT", "PRT", "620", ContinentCode.EU, new MobileInfo(268)));
            _countries.Add(new CountryInfo(Resources.PR, "PR", "PRI", "630", ContinentCode.NA, new MobileInfo(330)));
            _countries.Add(new CountryInfo(Resources.QA, "QA", "QAT", "634", ContinentCode.AS, new MobileInfo(427)));
            _countries.Add(new CountryInfo(Resources.RE, "RE", "REU", "638", ContinentCode.AF, new MobileInfo(647)));
            _countries.Add(new CountryInfo(Resources.RO, "RO", "ROU", "642", ContinentCode.EU, new MobileInfo(226)));
            _countries.Add(new CountryInfo(Resources.RU, "RU", "RUS", "643", ContinentCode.EU, new MobileInfo(250)));
            _countries.Add(new CountryInfo(Resources.RW, "RW", "RWA", "646", ContinentCode.AF, new MobileInfo(635)));
            _countries.Add(new CountryInfo(Resources.BL, "BL", "BLM", "652", ContinentCode.NA, new MobileInfo(340)));
            _countries.Add(new CountryInfo(Resources.SH, "SH", "SHN", "654", ContinentCode.AF, new MobileInfo(658)));
            _countries.Add(new CountryInfo(Resources.KN, "KN", "KNA", "659", ContinentCode.NA, new MobileInfo(356)));
            _countries.Add(new CountryInfo(Resources.LC, "LC", "LCA", "662", ContinentCode.NA, new MobileInfo(358)));
            _countries.Add(new CountryInfo(Resources.MF, "MF", "MAF", "663", ContinentCode.NA, new MobileInfo(340)));
            _countries.Add(new CountryInfo(Resources.PM, "PM", "SPM", "666", ContinentCode.NA, new MobileInfo(308)));
            _countries.Add(new CountryInfo(Resources.VC, "VC", "VCT", "670", ContinentCode.NA, new MobileInfo(360)));
            _countries.Add(new CountryInfo(Resources.WS, "WS", "WSM", "882", ContinentCode.OC, new MobileInfo(549)));
            _countries.Add(new CountryInfo(Resources.SM, "SM", "SMR", "674", ContinentCode.EU, new MobileInfo(292)));
            _countries.Add(new CountryInfo(Resources.ST, "ST", "STP", "678", ContinentCode.AF, new MobileInfo(626)));
            _countries.Add(new CountryInfo(Resources.SA, "SA", "SAU", "682", ContinentCode.AS, new MobileInfo(420)));
            _countries.Add(new CountryInfo(Resources.SN, "SN", "SEN", "686", ContinentCode.AF, new MobileInfo(608)));
            _countries.Add(new CountryInfo(Resources.RS, "RS", "SRB", "688", ContinentCode.EU, new MobileInfo(220)));
            _countries.Add(new CountryInfo(Resources.SC, "SC", "SYC", "690", ContinentCode.AF, new MobileInfo(633)));
            _countries.Add(new CountryInfo(Resources.SL, "SL", "SLE", "694", ContinentCode.AF, new MobileInfo(619)));
            _countries.Add(new CountryInfo(Resources.SG, "SG", "SGP", "702", ContinentCode.AS, new MobileInfo(525)));
            _countries.Add(new CountryInfo(Resources.SX, "SX", "SXM", "534", ContinentCode.NA, new MobileInfo(362)));
            _countries.Add(new CountryInfo(Resources.SK, "SK", "SVK", "703", ContinentCode.EU, new MobileInfo(231)));
            _countries.Add(new CountryInfo(Resources.SI, "SI", "SVN", "705", ContinentCode.EU, new MobileInfo(293)));
            _countries.Add(new CountryInfo(Resources.SB, "SB", "SLB", "090", ContinentCode.OC, new MobileInfo(540)));
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
