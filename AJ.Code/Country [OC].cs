using System;
using System.Collections.Generic;
using System.Text;
using AJ.Code.Properties;
using static AJ.Code.MNCInfo;

namespace AJ.Code
{
    public partial class Country
    {
        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "AS". <br/>
        /// Alpha2Cod2 AS 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForAS()
        {
            // mobile info for MCC 311
            List<MNCInfo> mncListfor311 = new List<MNCInfo>();
            mncListfor311.Add(new MNCInfo("780", "ASTCA", "American Samoa Telecommunications", OperStatus.Operational,
                                                                                           BandType.LTE700));
            var mobile311 = new MobileInfo(311, mncListfor311);

            // mobile info for MCC 544
            List<MNCInfo> mncListfor544 = new List<MNCInfo>();
            mncListfor544.Add(new MNCInfo("11", "Bluesky", "Bluesky", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1900));
            var mobile544 = new MobileInfo(544, mncListfor544);

            _countries.Add(new CountryInfo(Resources.AS, "AS", "ASM", "016", ContinentCode.OC, mobile311, mobile544));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "AU". <br/>
        /// Alpha2Cod2 AU 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForAU()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Telstra", "Telstra Corporation Limited", OperStatus.Operational,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.LTE2600,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("02", "Optus", "Singtel Optus Pty Ltd", OperStatus.Operational,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.LTE2600,
                                                                                               BandType.TD5G2300,
                                                                                               BandType.FiveG3500,
                                                                                               BandType.FiveG28000));

            mncList.Add(new MNCInfo("03", "Vodafone", "Vodafone Hutchison Australia Pty Ltd", OperStatus.Operational,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.FiveG700,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("04", "", "Department of Defence", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("05", "Ozitel", "", OperStatus.Not_Operational,
                                                                                               BandType.Empty));

            mncList.Add(new MNCInfo("06", "3", "Vodafone Hutchison Australia Pty Ltd", OperStatus.Not_Operational,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("07", "Vodafone", "Vodafone Network Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("08", "One.Tel", "One.Tel Limited", OperStatus.Not_Operational,
                                                                                               BandType.GSM900));

            mncList.Add(new MNCInfo("09", "Airnet", "", OperStatus.Not_Operational,
                                                                                               BandType.Empty));

            mncList.Add(new MNCInfo("10", "Norfolk Is.", "Norfolk Telecom", OperStatus.Operational,
                                                                                               BandType.GSM900));

            mncList.Add(new MNCInfo("11", "Telstra", "Telstra Corporation Limited", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("12", "3", "Vodafone Hutchison Australia Pty Ltd", OperStatus.Not_Operational,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("13", "RailCorp", "Railcorp, Transport for NSW", OperStatus.Operational,
                                                                                               BandType.GSMR1800));

            mncList.Add(new MNCInfo("14", "AAPT", "TPG Telecom", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("15", "3GIS", "", OperStatus.Not_Operational,
                                                                                               BandType.Empty));

            mncList.Add(new MNCInfo("16", "VicTrack", "Victorian Rail Track", OperStatus.Operational,
                                                                                               BandType.GSMR1800));

            mncList.Add(new MNCInfo("17", "", "Optus", OperStatus.Operational,
                                                                                               BandType.TDLTE2300));

            mncList.Add(new MNCInfo("18", "Pactel", "Pactel International Pty Ltd", OperStatus.Not_Operational,
                                                                                               BandType.Empty));

            mncList.Add(new MNCInfo("19", "Lycamobile", "Lycamobile Pty Ltd", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("20", "", "Ausgrid Corporation", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("21", "", "Queensland Rail Limited", OperStatus.Unknown,
                                                                                               BandType.GSMR1800));

            mncList.Add(new MNCInfo("22", "", "iiNet Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("23", "", "Challenge Networks Pty Ltd", OperStatus.Operational,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100));

            mncList.Add(new MNCInfo("24", "", "Advanced Communications Technologies Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("25", "", "Pilbara Iron Company Services Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("26", "", "Dialogue Communications Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("27", "", "Nexium Telecommunications", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("28", "", "RCOM International Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("30", "", "Compatel Limited", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("31", "", "BHP", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("32", "", "Thales Australia", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("33", "", "CLX Networks Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("34", "", "Santos Limited", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("35", "", "MessageBird Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("36", "Optus", "Optus Mobile Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("37", "", "Yancoal Australia Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("38", "Truphone", "Truphone Pty Ltd", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("39", "Telstra", "Telstra Corporation Ltd.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("40", "", "CITIC Pacific Mining", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("41", "", "Aqura Technologies Pty", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("42", "GEMCO", "Groote Eylandt Mining Company Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("43", "", "Arrow Energy Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("44", "", "Roy Hill Iron Ore Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("45", "", "Clermont Coal Operations Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("46", "", "AngloGold Ashanti Australia Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("47", "", "Woodside Energy Limited", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("48", "", "Titan ICT Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("49", "", "Field Solutions Group Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("50", "", "Pivotel Group Pty Ltd", OperStatus.Operational,
                                                                                               BandType.Satellite));

            mncList.Add(new MNCInfo("51", "", "Fortescue Metals Group", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("52", "", "OptiTel Australia", OperStatus.Operational,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.FiveG1800,
                                                                                               BandType.FiveG2100));

            mncList.Add(new MNCInfo("53", "", "Shell Australia Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("61", "CommTel NS", "Commtel Network Solutions Pty Ltd", OperStatus.Implement_Design,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100));

            mncList.Add(new MNCInfo("62", "NBN", "National Broadband Network Co.", OperStatus.Operational,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.TDLTE3500));

            mncList.Add(new MNCInfo("68", "NBN", "National Broadband Network Co.", OperStatus.Operational,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.TDLTE3500));

            mncList.Add(new MNCInfo("71", "Telstra", "Telstra Corporation Limited", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("72", "Telstra", "Telstra Corporation Limited", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("88", "", "Pivotel Group Pty Ltd", OperStatus.Operational,
                                                                                               BandType.Satellite));

            mncList.Add(new MNCInfo("90", "Optus", "Singtel Optus Proprietary Ltd", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("99", "One.Tel", "One.Tel", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            _countries.Add(new CountryInfo(Resources.AU, "AU", "AUS", "036", ContinentCode.OC, new MobileInfo(505, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "CK". <br/>
        /// Alpha2Cod2 CK 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForCK()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Vodafone", "Telecom Cook Islands", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS900,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1800));

            _countries.Add(new CountryInfo(Resources.CK, "CK", "COK", "184", ContinentCode.OC, new MobileInfo(548, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "FJ". <br/>
        /// Alpha2Cod2 FJ 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForFJ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Vodafone", "Vodafone Fiji", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("02", "Digicel", "Digicel Fiji", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1800,
                                                                                               BandType.WiMAX));

            mncList.Add(new MNCInfo("03", "TFL", "Telecom Fiji Ltd", OperStatus.Operational,
                                                                                               BandType.CDMA2000850,
                                                                                               BandType.LTE700));

            _countries.Add(new CountryInfo(Resources.FJ, "FJ", "FJI", "242", ContinentCode.OC, new MobileInfo(542, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "PF". <br/>
        /// Alpha2Cod2 PF 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForPF()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("05", "Ora", "VITI", OperStatus.Operational,
                                                                                               BandType.WiMAX,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("10", "", "Mara Telecom", OperStatus.Not_Operational,
                                                                                               BandType.GSM900));

            mncList.Add(new MNCInfo("15", "Vodafone", "Pacific Mobile Telecom", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE2100));

            mncList.Add(new MNCInfo("20", "Vini", "Onati S.A.S.", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE2100));

            _countries.Add(new CountryInfo(Resources.PF, "PF", "PYF", "258", ContinentCode.OC, new MobileInfo(547, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "GU". <br/>
        /// Alpha2Cod2 GU 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForGU()
        {
            // mobile info for MCC 310
            List<MNCInfo> mncListfor310 = new List<MNCInfo>();
            mncListfor310.Add(new MNCInfo("032", "IT&E Wireless", "IT&E Overseas, Inc", OperStatus.Operational,
                                                                                               BandType.CDMA1900,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE700));

            mncListfor310.Add(new MNCInfo("033", "", "Guam Telephone Authority", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("140", "GTA Wireless", "Teleguam Holdings, LLC", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE1700));

            mncListfor310.Add(new MNCInfo("370", "Docomo", "NTT DoCoMo Pacific", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE700));

            mncListfor310.Add(new MNCInfo("400", "IT&E Wireless", "IT&E Overseas, Inc", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE700));

            mncListfor310.Add(new MNCInfo("470", "Docomo", "NTT DoCoMo Pacific", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("480", "IT&E Wireless", "IT&E Overseas, Inc", OperStatus.Operational,
                                                                                               BandType.iDEN));
            var mobile310 = new MobileInfo(310, mncListfor310);

            // mobile info for MCC 311
            List<MNCInfo> mncListfor311 = new List<MNCInfo>();
            mncListfor311.Add(new MNCInfo("120", "IT&E Wireless", "IT&E Overseas, Inc", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("250", "IT&E Wireless", "IT&E Overseas, Inc", OperStatus.Operational,
                                                                                               BandType.Unknown));
            var mobile311 = new MobileInfo(311, mncListfor311);

            _countries.Add(new CountryInfo(Resources.GU, "GU", "GUM", "316", ContinentCode.OC, mobile310, mobile311));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "KI". <br/>
        /// Alpha2Cod2 KI 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForKI()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Kiribati - ATH", "Amalgamated Telecom Holdings Kiribati Limited", OperStatus.Operational,
                                                                                               BandType.UMTS900,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("02", "", "OceanLink", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("09", "Kiribati - Frigate Net", "Amalgamated Telecom Holdings Kiribati Limited", OperStatus.Operational,
                                                                                               BandType.GSM900));

            _countries.Add(new CountryInfo(Resources.KI, "KI", "KIR", "296", ContinentCode.OC, new MobileInfo(545, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "MH". <br/>
        /// Alpha2Cod2 MH 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForMH()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "", "Marshall Islands National Telecommunications Authority (MINTA)", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.LTE700));

            _countries.Add(new CountryInfo(Resources.MH, "MH", "MHL", "584", ContinentCode.OC, new MobileInfo(551, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "FM". <br/>
        /// Alpha2Cod2 FM 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForFM()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "", "FSMTC", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.LTE1800));

            _countries.Add(new CountryInfo(Resources.FM, "FM", "FSM", "583", ContinentCode.OC, new MobileInfo(550, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "NR". <br/>
        /// Alpha2Cod2 NR 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForNR()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("02", "Digicel", "Digicel (Nauru) Corporation", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            _countries.Add(new CountryInfo(Resources.NR, "NR", "NRU", "520", ContinentCode.OC, new MobileInfo(536, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "NC". <br/>
        /// Alpha2Cod2 NC 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForNC()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Mobilis", "OPT New Caledonia", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600));

            _countries.Add(new CountryInfo(Resources.NC, "NC", "NCL", "540", ContinentCode.OC, new MobileInfo(546, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "NZ". <br/>
        /// Alpha2Cod2 NZ 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForNZ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("00", "Telecom", "Telecom New Zealand", OperStatus.Not_Operational,
                                                                                               BandType.AMPS800,
                                                                                               BandType.TDMA800));

            mncList.Add(new MNCInfo("01", "Vodafone", "Vodafone New Zealand", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("02", "Telecom", "Telecom New Zealand", OperStatus.Not_Operational,
                                                                                               BandType.CDMA2000800));

            mncList.Add(new MNCInfo("03", "Woosh", "Woosh Wireless", OperStatus.Operational,
                                                                                               BandType.UMTSTDD2000));

            mncList.Add(new MNCInfo("04", "Vodafone", "TelstraClear New Zealand", OperStatus.Not_Operational,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("05", "Spark", "Spark New Zealand", OperStatus.Operational,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1800,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.LTE2600,
                                                                                               BandType.FiveG2600,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("06", "Skinny", "Spark New Zealand", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("07", "Spark New Zealand", "Bluereach Limited", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("24", "2degrees", "2degrees", OperStatus.Operational,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800));

            _countries.Add(new CountryInfo(Resources.NZ, "NZ", "NZL", "554", ContinentCode.OC, new MobileInfo(530, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "NU". <br/>
        /// Alpha2Cod2 NU 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForNU()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Telecom Niue", "Telecom Niue", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.LTE700));

            _countries.Add(new CountryInfo(Resources.NU, "NU", "NIU", "570", ContinentCode.OC, new MobileInfo(555, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "NF". <br/>
        /// Alpha2Cod2 NF 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForNF()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("10", "Norfolk Telecom", "Norfolk Telecom", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.LTE1800));

            _countries.Add(new CountryInfo(Resources.NF, "NF", "NFK", "574", ContinentCode.OC, new MobileInfo(505, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "MP". <br/>
        /// Alpha2Cod2 MP 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForMP()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("110", "IT&E Wireless", "PTI Pacifica Inc.", OperStatus.Operational,
                                                                                               BandType.CDMA,
                                                                                               BandType.GSM850,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE700));

            mncList.Add(new MNCInfo("370", "Docomo", "NTT DoCoMo Pacific", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS,
                                                                                               BandType.LTE));

            _countries.Add(new CountryInfo(Resources.MP, "MP", "MNP", "580", ContinentCode.OC, new MobileInfo(310, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "PW". <br/>
        /// Alpha2Cod2 PW 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForPW()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "PNCC", "Palau National Communications Corp.", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS900,
                                                                                               BandType.LTE700));

            mncList.Add(new MNCInfo("02", "PT Waves", "Palau Equipment Company Inc.", OperStatus.Operational,
                                                                                               BandType.GSM900));

            mncList.Add(new MNCInfo("80", "Palau Mobile", "Palau Mobile Corporation", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncList.Add(new MNCInfo("99", "PMCI", "Palau Mobile Communications Inc.", OperStatus.Operational,
                                                                                               BandType.LTE));

            _countries.Add(new CountryInfo(Resources.PW, "PW", "PLW", "585", ContinentCode.OC, new MobileInfo(552, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "PG". <br/>
        /// Alpha2Cod2 PG 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForPG()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "bmobile", "Bemobile Limited", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS900));

            mncList.Add(new MNCInfo("02", "citifon", "Telikom PNG Ltd.", OperStatus.Operational,
                                                                                               BandType.CDMA2000450,
                                                                                               BandType.LTE700));

            mncList.Add(new MNCInfo("03", "Digicel", "Digicel PNG", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS900,
                                                                                               BandType.LTE));

            _countries.Add(new CountryInfo(Resources.PG, "PG", "PNG", "598", ContinentCode.OC, new MobileInfo(537, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "PN". <br/>
        /// Alpha2Cod2 PN 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForPN()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.PN, "PN", "PCN", "612", ContinentCode.OC));
            /// This does not have MNC. In Wiki, there is not nation alpha-2 code PN.
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "WS". <br/>
        /// Alpha2Cod2 WS 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForWS()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("00", "Digicel", "Digicel Pacific Ltd.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("01", "Digicel", "Digicel Pacific Ltd.", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("27", "Vodafone", "Vodafone Samoa Ltd.", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1800));

            _countries.Add(new CountryInfo(Resources.WS, "WS", "WSM", "882", ContinentCode.OC, new MobileInfo(549, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "SB". <br/>
        /// Alpha2Cod2 SB 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForSB()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "BREEZE", "Our Telekom", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("02", "BeMobile", "BMobile (SI) Ltd", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100));

            _countries.Add(new CountryInfo(Resources.SB, "SB", "SLB", "090", ContinentCode.OC, new MobileInfo(540, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "TK". <br/>
        /// Alpha2Cod2 TK 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForTK()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "", "Teletok", OperStatus.Operational,
                                                                                               BandType.LTE700));

            _countries.Add(new CountryInfo(Resources.TK, "TK", "TKL", "772", ContinentCode.OC, new MobileInfo(554, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "TO". <br/>
        /// Alpha2Cod2 TO 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForTO()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "U-Call", "Tonga Communications Corporation", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS900,
                                                                                               BandType.LTE));

            mncList.Add(new MNCInfo("43", "", "Shoreline Communication", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("88", "Digicel", "Digicel (Tonga) Limited", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1800));

            _countries.Add(new CountryInfo(Resources.TO, "TO", "TON", "776", ContinentCode.OC, new MobileInfo(539, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "TV". <br/>
        /// Alpha2Cod2 TV 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForTV()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "TTC", "Tuvalu Telecom", OperStatus.Operational,
                                                                                               BandType.UMTS900,
                                                                                               BandType.LTE850));

            _countries.Add(new CountryInfo(Resources.TV, "TV", "TUV", "798", ContinentCode.OC, new MobileInfo(553, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "UM". <br/>
        /// Alpha2Cod2 UM 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForUM()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.UM, "UM", "UMI", "581", ContinentCode.OC));
            /// This does not have MNC. In Wiki, there is not nation alpha-2 code UM.
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "VU". <br/>
        /// Alpha2Cod2 VU 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForVU()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("00", "AIL", "ACeS International (AIL)", OperStatus.Operational,
                                                                                               BandType.GSM900));

            mncList.Add(new MNCInfo("01", "SMILE", "Telecom Vanuatu Ltd", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.LTE700));

            mncList.Add(new MNCInfo("05", "Digicel", "Digicel Vanuatu Ltd", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS900,
                                                                                               BandType.LTE700));

            mncList.Add(new MNCInfo("07", "WanTok", "WanTok Vanuatu Ltd", OperStatus.Operational,
                                                                                               BandType.TDLTE2300));

            _countries.Add(new CountryInfo(Resources.VU, "VU", "VUT", "548", ContinentCode.OC, new MobileInfo(541, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "WF". <br/>
        /// Alpha2Cod2 WF 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForWF()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Manuia", "Service des Postes et Télécommunications des Îles Wallis et Futuna (SPT)", OperStatus.Operational,
                                                                                               BandType.UMTS900,
                                                                                               BandType.LTE));

            _countries.Add(new CountryInfo(Resources.WF, "WF", "WLF", "876", ContinentCode.OC, new MobileInfo(543, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "AX". <br/>
        /// Alpha2Cod2 AX 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForAX()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.AX, "AX", "ALA", "248", ContinentCode.OC));
         /// This does not have MNC. In Wiki, there is not nation alpha-2 code AX.
        }
    }
}
