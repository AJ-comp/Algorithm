using AJ.Code.Properties;
using System;
using System.Collections.Generic;
using System.Text;
using static AJ.Code.MNCInfo;

namespace AJ.Code
{
    public partial class Country
    {
        /*************************************************/        
        /// <summary>
        /// Add information for the alpha2 code "AL". <br/>
        /// Alpha2Cod2 AL 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForAL()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Telekom.al", "Telekom Albania", OperStatus.Operational,
                                                                                                BandType.GSM900,
                                                                                                BandType.GSM1800,
                                                                                                BandType.UMTS2100,
                                                                                                BandType.LTE2600,
                                                                                                BandType.LTE1800));

            mncList.Add(new MNCInfo("02", "Vodafone", "Vodafone Albania", OperStatus.Operational,
                                                                                                BandType.GSM900,
                                                                                                BandType.GSM1800,
                                                                                                BandType.UMTS2100,
                                                                                                BandType.LTE2600,
                                                                                                BandType.LTE1800));

            mncList.Add(new MNCInfo("03", "Eagle Mobile", "Albtelecom", OperStatus.Operational,
                                                                                                BandType.GSM900,
                                                                                                BandType.GSM1800,
                                                                                                BandType.UMTS2100,
                                                                                                BandType.LTE1800));

            mncList.Add(new MNCInfo("04", "Plus Communication", "Plus Communication", OperStatus.Not_Operational,
                                                                                                BandType.GSM900,
                                                                                                BandType.GSM1800,
                                                                                                BandType.UMTS2100));

            _countries.Add(new CountryInfo(Resources.AL, "AL", "ALB", "008", ContinentCode.EU, new MobileInfo(276, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "AD". <br/>
        /// Alpha2Cod2 AD 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForAD()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("03", "Som, Mobiland", "Andorra Telecom", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800));

            _countries.Add(new CountryInfo(Resources.AD, "AD", "AND", "020", ContinentCode.EU, new MobileInfo(213, mncList)));
        }

        /*************************************************/ 
        /// <summary>
        /// Add information for the alpha2 code "AT". <br/>
        /// Alpha2Cod2 AT 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForAT()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "A1.net", "A1 Telekom Austria", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("02", "", "A1 Telekom Austria", OperStatus.Reserved));

            mncList.Add(new MNCInfo("03", "Magenta", "T-Mobile Austria GmbH", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG700,
                                                                                              BandType.FiveG2600,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("04", "Magenta", "T-Mobile Austria GmbH", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("05", "3", "Hutchison Drei Austria", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE900,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("06", "Orange AT", "Orange Austria GmbH", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("07", "Magenta-T", "T-Mobile Austria", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("08", "Lycamobile", "Lycamobile Austria", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("09", "Tele2Mobil", "A1 Telekom Austria", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("10", "3", "Hutchison Drei Austria", OperStatus.Operational,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("11", "bob", "A1 Telekom Austria", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("12", "yesss!", "A1 Telekom Austria", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("13", "Magenta", "T-Mobile Austria GmbH", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("14", "", "Hutchison Drei Austria", OperStatus.Reserved,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("15", "Vectone Mobile", "Mundio Mobile Austria", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("16", "", "	Hutchison Drei Austria", OperStatus.Reserved,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("17", "", "MASS Response Service GmbH", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("18", "", "smartspace GmbH", OperStatus.Unknown,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("19", "", "Hutchison Drei Austria", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("20", "m:tel", "MTEL Austrija GmbH", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("21", "", "Salzburg AG für Energie, Verkehr und Telekommunikation", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("22", "", "Plintron Austria Limited", OperStatus.Unknown,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("23", "Magenta", "T-Mobile Austria GmbH", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("24", "", "Smartel Services GmbH", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("25", "", "Holding Graz Kommunale Dienstleistungen GmbH", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("26", "", "LIWEST Kabelmedien GmbH", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("91", "GSM-R A", "ÖBB", OperStatus.Operational,
                                                                                              BandType.GSMR));

            mncList.Add(new MNCInfo("92", "ArgoNET", "ArgoNET GmbH", OperStatus.Operational,
                                                                                              BandType.CDMA450,
                                                                                              BandType.LTE450));

            _countries.Add(new CountryInfo(Resources.AT, "AT", "AUT", "040", ContinentCode.EU, new MobileInfo(232, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "BY". <br/>
        /// Alpha2Cod2 BY 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForBY()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "A1", "A1 Belarus", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100));

            mncList.Add(new MNCInfo("02", "MTS", "Mobile TeleSystems", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100));

            mncList.Add(new MNCInfo("03", "DIALLOG", "BelCel", OperStatus.Not_Operational,
                                                                                              BandType.CDMA450));

            mncList.Add(new MNCInfo("04", "life:)", "Belarusian Telecommunications Network", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100));

            mncList.Add(new MNCInfo("05", "byfly", "Beltelecom", OperStatus.Not_Operational,
                                                                                              BandType.WiMAX3500));

            mncList.Add(new MNCInfo("06", "beCloud", "Belorussian Cloud Technologies", OperStatus.Operational,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600));

            _countries.Add(new CountryInfo(Resources.BY, "BY", "BLR", "112", ContinentCode.EU, new MobileInfo(257, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "BE". <br/>
        /// Alpha2Cod2 BE 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForBE()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("00", "Proximus", "Belgacom Mobile", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("01", "Proximus", "Belgacom Mobile", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG2100,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("02", "", "Infrabel", OperStatus.Operational,
                                                                                              BandType.GSMR));

            mncList.Add(new MNCInfo("03", "Citymesh Connect", "Citymesh NV", OperStatus.Operational,
                                                                                              BandType.LTE2600,
                                                                                              BandType.LTE3500));

            mncList.Add(new MNCInfo("04", "MWingz", "Proximus/Orange Belgium", OperStatus.Planned,
                                                                                              BandType.UMTS2100));

            mncList.Add(new MNCInfo("05", "Telenet", "Telenet", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("06", "Lycamobile", "Lycamobile sprl", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("07", "Vectone Mobile", "Mundio Mobile Belgium nv", OperStatus.Reserved,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("08", "VOO", "Nethys [fr]", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("09", "Voxbone", "Voxbone mobile", OperStatus.Not_Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("10", "Orange Belgium", "Orange S.A.", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("11", "L-mobi", "L-Mobi Mobile", OperStatus.Not_Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("15", "", "Elephant Talk Communications Schweiz GmbH", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("16", "", "NextGen Mobile Ltd.", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("20", "Base", "Telenet", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("22", "Febo.mobi", "FEBO Telecom", OperStatus.Not_Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("25", "", "Dense Air Belgium SPRL", OperStatus.Unknown,
                                                                                              BandType.TDLTE2600));

            mncList.Add(new MNCInfo("28", "", "BICS", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("29", "", "TISMI", OperStatus.Not_Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("30", "Mobile Vikings", "Unleashed NV", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("33", "", "Ericsson NV", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("40", "JOIN", "JOIN Experience (Belgium)", OperStatus.Not_Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("50", "", "IP Nexia", OperStatus.Not_Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("71", "", "test", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("72", "", "test", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("73", "", "test", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("74", "", "test", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("99", "", "e-BO Enterprises", OperStatus.Unknown,
                                                                                              BandType.LTE));

            _countries.Add(new CountryInfo(Resources.BE, "BE", "BEL", "056", ContinentCode.EU, new MobileInfo(206, mncList)));

            /// There are two MNC codes for MCC number 270. 
            /// mncList.Add(new MNCInfo("77", "", "Proximus Luxembourg S.A.", OperStatus.Unknown,
            ///                                                                                   BandType.Unknown));
            ///
            /// mncList.Add(new MNCInfo("99", "", "Orange Communications Luxembourg S.A.", OperStatus.Unknown,
            ///                                                                                   BandType.Unknown));

        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "BA". <br/>
        /// Alpha2Cod2 BA 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForBA()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("03", "HT-ERONET", "Public Enterprise Croatian Telecom Ltd.", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE));

            mncList.Add(new MNCInfo("05", "m:tel BiH", "RS Telecommunications JSC Banja Luka", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE));

            mncList.Add(new MNCInfo("90", "BH Mobile", "BH Telecom", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE));

            _countries.Add(new CountryInfo(Resources.BA, "BA", "BIH", "070", ContinentCode.EU, new MobileInfo(218, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "BG". <br/>
        /// Alpha2Cod2 BG 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForBG()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "A1", "A1 Bulgaria", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE900,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("03", "Vivacom", "BTC", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE900,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.FiveG1800,
                                                                                              BandType.FiveG2100));

            mncList.Add(new MNCInfo("05", "Telenor", "Telenor (Bulgaria)", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("07", "НКЖИ", "НАЦИОНАЛНА КОМПАНИЯ ЖЕЛЕЗОПЪТНА ИНФРАСТРУКТУРА", OperStatus.Operational,
                                                                                              BandType.GSMR));

            mncList.Add(new MNCInfo("09", "", "COMPATEL LIMITED", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("11", "", "Bulsatcom", OperStatus.Operational,
                                                                                              BandType.LTE1800));

            mncList.Add(new MNCInfo("13", "Ти.ком", "Ti.com JSC", OperStatus.Operational,
                                                                                              BandType.LTE1800));

            _countries.Add(new CountryInfo(Resources.BG, "BG", "BGR", "100", ContinentCode.EU, new MobileInfo(284, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "HR". <br/>
        /// Alpha2Cod2 HR 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForHR()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "T-Mobile", "T-Hrvatski Telekom", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.FiveG2100));

            mncList.Add(new MNCInfo("02", "", "Telemach", OperStatus.Operational,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("04", "", "NTH Mobile d.o.o.", OperStatus.Unknown,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("10", "A1", "A1 Hrvatska", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800));

            mncList.Add(new MNCInfo("12", "", "TELE FOCUS d.o.o.", OperStatus.Unknown,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("20", "T-Mobile", "T-Hrvatski Telekom", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            _countries.Add(new CountryInfo(Resources.HR, "HR", "HRV", "191", ContinentCode.EU, new MobileInfo(219, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "CZ". <br/>
        /// Alpha2Cod2 CZ 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForCZ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "T-Mobile", "T-Mobile Czech Republic", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG1800,
                                                                                              BandType.FiveG2100));

            mncList.Add(new MNCInfo("02", "O₂", "O2 Czech Republic", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600,
                                                                                              BandType.TDLTE2600,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("03", "Vodafone", "Vodafone Czech Republic", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG1800,
                                                                                              BandType.FiveG2100));

            mncList.Add(new MNCInfo("04", "", "Nordic Telecom s.r.o.", OperStatus.Operational,
                                                                                              BandType.MVNO,
                                                                                              BandType.LTE410));

            mncList.Add(new MNCInfo("05", "", "PODA a.s.", OperStatus.Operational,
                                                                                              BandType.TDLTE3700));

            mncList.Add(new MNCInfo("06", "", "Nordic Telecom 5G a.s.", OperStatus.Operational,
                                                                                              BandType.TDLTE3700));

            mncList.Add(new MNCInfo("07", "T-Mobile", "T-Mobile Czech Republic", OperStatus.Operational,
                                                                                              BandType.LTE800));

            mncList.Add(new MNCInfo("08", "", "Compatel s.r.o.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("09", "Vectone Mobile", "Mundio Distribution Czech Republic s.r.o.", OperStatus.Not_Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("98", "", "Správa železniční dopravní cesty, s.o", OperStatus.Operational,
                                                                                              BandType.GSMR900));

            mncList.Add(new MNCInfo("99", "Vodafone", "Vodafone Czech Republic", OperStatus.Not_Operational,
                                                                                              BandType.GSM1800));

            _countries.Add(new CountryInfo(Resources.CZ, "CZ", "CZE", "203", ContinentCode.EU, new MobileInfo(230, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "DK". <br/>
        /// Alpha2Cod2 DK 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForDK()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "TDC", "TDC A/S", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("02", "Telenor", "Telenor Denmark", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("03", "", "Syniverse Technologies", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("04", "", "Nexcon.io ApS", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("05", "TetraNet", "Dansk Beredskabskommunikation A/S", OperStatus.Operational,
                                                                                              BandType.TETRA));

            mncList.Add(new MNCInfo("06", "3", "Hi3G Denmark ApS", OperStatus.Operational,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE900,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.TDLTE2600,
                                                                                              BandType.FiveG700,
                                                                                              BandType.FiveG1800));

            mncList.Add(new MNCInfo("07", "Vectone Mobile", "Mundio Mobile (Denmark) Limited", OperStatus.Not_Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("08", "Voxbone", "Voxbone mobile", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("09", "SINE", "Dansk Beredskabskommunikation A/S", OperStatus.Operational,
                                                                                              BandType.TETRA));

            mncList.Add(new MNCInfo("10", "TDC", "TDC A/S", OperStatus.Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("11", "SINE", "Dansk Beredskabskommunikation A/S", OperStatus.Operational,
                                                                                              BandType.TETRA));

            mncList.Add(new MNCInfo("12", "Lycamobile", "Lycamobile Denmark Ltd", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("13", "", "Compatel Limited", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("14", "", "Monty UK Global Limited", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("15", "Net 1", "Cibicom", OperStatus.Operational,
                                                                                              BandType.LTE450));

            mncList.Add(new MNCInfo("16", "", "Tismi B.V.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("17", "", "Gotanet AB", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("18", "", "Cubic Telecom", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("20", "Telia", "Telia", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("23", "GSM-R DK", "Banedanmark", OperStatus.Operational,
                                                                                              BandType.GSMR));

            mncList.Add(new MNCInfo("25", "Viahub", "SMS Provider Corp.", OperStatus.Unknown,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("28", "", "LINK Mobile A/S", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("30", "", "Interactive digital media GmbH", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("40", "", "Ericsson Danmark A/S", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("42", "", "Greenwave Mobile IoT ApS", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("43", "", "MobiWeb Limited", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("66", "", "TT-Netværket P/S", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800));

            mncList.Add(new MNCInfo("73", "", "Onomondo ApS", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("77", "Telenor", "Telenor Denmark", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800));

            mncList.Add(new MNCInfo("88", "", "Cobira ApS", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("96", "Telia", "Telia Danmark", OperStatus.Unknown,
                                                                                              BandType.Unknown));


            _countries.Add(new CountryInfo(Resources.DK, "DK", "DNK", "208", ContinentCode.EU, new MobileInfo(283, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "EE". <br/>
        /// Alpha2Cod2 EE 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForEE()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Telia", "Telia Eesti", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG));

            mncList.Add(new MNCInfo("02", "Elisa", "Elisa Eesti", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("03", "Tele2", "Tele2 Eesti", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100));

            mncList.Add(new MNCInfo("04", "Top Connect", "OY Top Connect", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("05", "CSC Telecom", "CSC Telecom Estonia OÜ", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("06", "", "Progroup Holding", OperStatus.Not_Operational,
                                                                                              BandType.UMTS2100));

            mncList.Add(new MNCInfo("07", "Kou", "Televõrgu AS", OperStatus.Not_Operational,
                                                                                              BandType.CDMA2000450));

            mncList.Add(new MNCInfo("08", "VIVEX", "VIVEX OU", OperStatus.Not_Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("09", "", "Bravo Telecom", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("10", "", "Telcotrade OÜ", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("11", "", "UAB Raystorm Eesti filiaal", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("12", "", "Ntel Solutions OÜ", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("13", "", "elia Eesti AS", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("14", "", "Estonian Crafts OÜ", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("15", "", "Premium Net International S.R.L. Eesti filiaal", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("16", "dzinga", "SmartTel Plus OÜ", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("17", "", "Baltergo OÜ", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("18", "", "Cloud Communications OÜ", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("19", "", "OkTelecom OÜ", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("20", "", "DOTT Telecom OÜ", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("21", "", "Tismi B.V.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("71", "", "Siseministeerium (Ministry of Interior)", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            _countries.Add(new CountryInfo(Resources.EE, "EE", "EST", "233", ContinentCode.EU, new MobileInfo(248, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "FO". <br/>
        /// Alpha2Cod2 FO 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForFO()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Føroya Tele", "Føroya Tele", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800));

            mncList.Add(new MNCInfo("02", "Hey", "Nema", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE1800));

            mncList.Add(new MNCInfo("03", "TOSA", "Tosa Sp/F", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE1800));

            _countries.Add(new CountryInfo(Resources.FO, "FO", "FRO", "234", ContinentCode.EU, new MobileInfo(288, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "FI". <br/>
        /// Alpha2Cod2 FI 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForFI()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("03", "DNA", "DNA Oy", OperStatus.Operational,
                                                                                              BandType.GSM1800));

            mncList.Add(new MNCInfo("04", "DNA", "DNA Oy", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("05", "Elisa", "Elisa Oyj", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.LTE700,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.TDLTE2600,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("06", "Elisa", "Elisa Oyj", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("07", "Nokia", "Nokia Solutions and Networks Oy", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600,
                                                                                              BandType.TDLTE2600));

            mncList.Add(new MNCInfo("08", "Nokia", "Nokia Solutions and Networks Oy", OperStatus.Unknown,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS2100));

            mncList.Add(new MNCInfo("09", "", "Nokia Solutions and Networks Oy", OperStatus.Unknown,
                                                                                              BandType.GSM900));

            mncList.Add(new MNCInfo("10", "", "Traficom", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("11", "", "Traficom", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("12", "DNA", "DNA Oy", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.LTE700,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("13", "DNA", "DNA Oy", OperStatus.Not_Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800));

            mncList.Add(new MNCInfo("14", "Ålcom", "Ålands Telekommunikation Ab", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800));

            mncList.Add(new MNCInfo("15", "", "Telit Wireless Solutions GmbH", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("16", "", "Digita Oy", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("17", "", "Liikennevirasto", OperStatus.Operational,
                                                                                              BandType.GSMR));

            mncList.Add(new MNCInfo("20", "", "Telia Finland Oyj", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("21", "lisa- Saunalahti", "Elisa Oyj", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("22", "", "EXFO Oy", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("23", "", "EXFO Oy", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("24", "", "Nord Connect UAB", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("25", "", "Fortum Power and Heat Oy", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("26", "Compatel", "Compatel Ltd", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("27", "", "Teknologian tutkimuskeskus VTT Oy", OperStatus.Operational,
                                                                                              BandType.LTE450,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG3500,
                                                                                              BandType.FiveGmmWave));

            mncList.Add(new MNCInfo("28", "", "Teknologian tutkimuskeskus VTT Oy", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("29", "", "Teknologian tutkimuskeskus VTT Oy", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("30", "", "Teknologian tutkimuskeskus VTT Oy", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("31", "", "Teknologian tutkimuskeskus VTT Oy", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("32", "Voxbone", "Voxbone SA", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("33", "VIRVE", "Suomen Virveverkko Oy", OperStatus.Operational,
                                                                                              BandType.TETRA));

            mncList.Add(new MNCInfo("34", "Bittium Wireless", "Bittium Wireless Oy", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("35", "", "Edzcom Oy", OperStatus.Operational,
                                                                                              BandType.LTE450,
                                                                                              BandType.TDLTE2600));

            mncList.Add(new MNCInfo("36", "Telia / DNA", "Telia Finland Oyj / Suomen Yhteisverkko Oy", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE900,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("37", "Tismi", "Tismi", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("38", "", "Nokia Solutions and Networks Oy", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("39", "", "Nokia Solutions and Networks Oy", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("40", "", "Nokia Solutions and Networks Oy", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("41", "", "Nokia Solutions and Networks Oy", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("42", "", "SMS Provider Corp.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("43", "", "Telavox AB / Telavox Oy", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("44", "", "Turun ammattikorkeakoulu Oy", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("45", "", "Suomen Turvallisuusverkko Oy", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("46", "", "Suomen Turvallisuusverkko Oy", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("47", "", "Suomen Turvallisuusverkko Oy", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("50", "", "Aalto-korkeakoulusäätiö sr", OperStatus.Testing,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("51", "", "Aalto-korkeakoulusäätiö sr", OperStatus.Operational,
                                                                                              BandType.NBIoT700));

            mncList.Add(new MNCInfo("52", "", "Aalto-korkeakoulusäätiö sr", OperStatus.Operational,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("53", "", "Aalto-korkeakoulusäätiö sr", OperStatus.Testing,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("54", "", "Aalto-korkeakoulusäätiö sr", OperStatus.Testing,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("55", "", "Aalto-korkeakoulusäätiö sr", OperStatus.Testing,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("56", "", "Aalto-korkeakoulusäätiö sr", OperStatus.Testing,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("57", "", "Aalto-korkeakoulusäätiö sr", OperStatus.Testing,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("58", "", "Aalto-korkeakoulusäätiö sr", OperStatus.Testing,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("59", "", "Aalto-korkeakoulusäätiö sr", OperStatus.Testing,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("91", "Telia", "Telia Finland Oyj", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.LTE700,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("92", "Sonera", "TeliaSonera Finland Oyj", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("95", "", "Säteilyturvakeskus", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("99", "", "Oy L M Ericsson Ab", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            _countries.Add(new CountryInfo(Resources.FI, "FI", "FIN", "246", ContinentCode.EU, new MobileInfo(244, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "FR". <br/>
        /// Alpha2Cod2 FR 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForFR()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Orange", "Orange S.A.", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE700,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG2100,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("02", "Orange", "Orange S.A.", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE700,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG2100,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("03", "MobiquiThings", "MobiquiThings", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("04", "Sisteer", "Societe d'ingenierie systeme telecom et reseaux", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("05", "", "Globalstar Europe", OperStatus.Operational,
                                                                                              BandType.Satellite));

            mncList.Add(new MNCInfo("06", "", "Globalstar Europe", OperStatus.Operational,
                                                                                              BandType.Satellite));

            mncList.Add(new MNCInfo("07", "", "Globalstar Europe", OperStatus.Operational,
                                                                                              BandType.Satellite));

            mncList.Add(new MNCInfo("08", "SFR", "Altice", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("09", "SFR", "Altice", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG2100,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("10", "SFR", "Altice", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG2100,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("11", "SFR", "Altice", OperStatus.Operational,
                                                                                              BandType.UMTS2100));

            mncList.Add(new MNCInfo("12", "Truphone", "Truphone France", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("13", "SFR", "Altice", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("14", "SNCF Réseau", "SNCF Réseau", OperStatus.Operational,
                                                                                              BandType.GSMR));

            mncList.Add(new MNCInfo("15", "Free", "Free Mobile", OperStatus.Operational,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE700,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG700,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("16", "Free", "Free Mobile", OperStatus.Operational,
                                                                                              BandType.LTE700,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("17", "LEGOS", "Local Exchange Global Operation Services", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("18", "Voxbone", "Voxbone mobile", OperStatus.Not_Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("19", "", "Haute-Garonne numérique", OperStatus.Operational,
                                                                                              BandType.LTE));

            mncList.Add(new MNCInfo("20", "Bouygues", "Bouygues Telecom", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE700,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG2100,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("21", "Bouygues", "Bouygues Telecom", OperStatus.Unknown,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100));

            mncList.Add(new MNCInfo("22", "Transatel Mobile", "Transatel", OperStatus.Unknown,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("23", "", "Syndicat mixte ouvert Charente Numérique", OperStatus.Operational,
                                                                                              BandType.TDLTE));

            mncList.Add(new MNCInfo("24", "MobiquiThings", "MobiquiThings", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("25", "LycaMobile", "LycaMobile", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("26", "NRJ Mobile", "Euro-Information Telecom SAS", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("27", "", "Coriolis Telecom", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("28", "", "Airmob Infra Full", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("29", "", "Cubic télécom France", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("30", "", "Syma Mobile", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("31", "Vectone Mobile", "Mundio Mobile", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("32", "Orange", "Orange S.A.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("33", "Fibre64", "Département des Pyrénées-Atlantiques", OperStatus.Unknown,
                                                                                              BandType.WiMAX));

            mncList.Add(new MNCInfo("34", "", "Cellhire France", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("35", "Free", "Free Mobile", OperStatus.Operational,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE700,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("36", "Free", "Free Mobile", OperStatus.Operational,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE700,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("37", "", "IP Directions", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("38", "", "Lebara France Ltd", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("50168", "", "Butachimie", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("50244", "", "General Electric Digital Services Europe SAS", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("700", "", "Weaccess group", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("701", "", "GIP Vendée numérique", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("702", "", "17-Numerique", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("703", "", "Nivertel", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("704", "", "Axione Limousin", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("705", "", "Hautes-Pyrénées Numérique", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("706", "", "Tours Métropole Numérique", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("707", "", "Sartel THD", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("708", "", "Melis@ territoires ruraux", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("709", "", "Quimper communauté télécom", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("710", "", "Losange", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("711", "", "Nomotech", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("712", "", "Syndicat Audois d'énergies et du Numérique", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("713", "", "SD NUM SAS", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("714", "", "Département de l'Isère", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("86", "", "SEM@FOR77", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("87", "RATP", "Régie autonome des transports parisiens", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("88", "Bouygues", "Bouygues Telecom", OperStatus.Unknown,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE700,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG2100,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("89", "", "Hub One", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("90", "", "Images & Réseaux", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("91", "", "Orange S.A.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("92", "Com4Innov", "Association Plate-forme Télécom", OperStatus.Not_Operational,
                                                                                              BandType.TDLTE2300,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("93", "", "Thales Communications & Security SAS", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("94", "", "Halys", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("95", "", "Orange S.A.", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("96", "", "Région Bourgogne-Franche-Comté", OperStatus.Operational,
                                                                                              BandType.LTE));

            mncList.Add(new MNCInfo("97", "", "Thales Communications & Security SAS", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("98", "", "Société Air France", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            _countries.Add(new CountryInfo(Resources.FR, "FR", "FRA", "250", ContinentCode.EU, new MobileInfo(208, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "DE". <br/>
        /// Alpha2Cod2 DE 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForDE()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Telekom", "Telekom Deutschland GmbH", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.LTE700,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE900,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG2100,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("02", "Vodafone", "Vodafone D2 GmbH", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.LTE700,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE900,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG700,
                                                                                              BandType.FiveG1800,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("03", "O₂", "Telefónica Germany GmbH & Co. oHG", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE700,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE900,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("04", "Vodafone", "Vodafone D2 GmbH", OperStatus.Reserved,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100));

            mncList.Add(new MNCInfo("05", "O₂", "Telefónica Germany GmbH & Co. oHG", OperStatus.Reserved,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100));

            mncList.Add(new MNCInfo("06", "Telekom", "Telekom Deutschland GmbH", OperStatus.Reserved,
                                                                                              BandType.GSM900,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE900,
                                                                                              BandType.LTE1500,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG2100,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("07", "O₂", "Telefónica Germany GmbH & Co. oHG", OperStatus.Not_Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("08", "O₂", "Telefónica Germany GmbH & Co. oHG", OperStatus.Reserved,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100));

            mncList.Add(new MNCInfo("09", "Vodafone", "Vodafone D2 GmbH", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("10", "", "DB Netz AG", OperStatus.Operational,
                                                                                              BandType.GSMR));

            mncList.Add(new MNCInfo("11", "O₂", "Telefónica Germany GmbH & Co. oHG", OperStatus.Reserved,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100));

            mncList.Add(new MNCInfo("12", "Simquadrat", "sipgate GmbH", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("13", "", "Mobilcom Multimedia", OperStatus.Not_Operational,
                                                                                              BandType.UMTS2100));

            mncList.Add(new MNCInfo("14", "", "Group 3G UMTS", OperStatus.Not_Operational,
                                                                                              BandType.UMTS2100));

            mncList.Add(new MNCInfo("15", "Airdata", "", OperStatus.Operational,
                                                                                              BandType.TDSCDMA));

            mncList.Add(new MNCInfo("16", "", "Telogic Germany GmbH", OperStatus.Not_Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("17", "O₂", "Telefónica Germany GmbH & Co. oHG", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("18", "", "NetCologne", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("19", "450connect", "Alliander AG [ nl ]", OperStatus.Operational,
                                                                                              BandType.LTE450));

            mncList.Add(new MNCInfo("20", "Voiceworks", "Voiceworks GmbH", OperStatus.Operational,
                                                                                              BandType.MVNE));

            mncList.Add(new MNCInfo("21", "", "Multiconnect GmbH", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("22", "", "sipgate Wireless GmbH", OperStatus.Unknown,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("23", "", "Drillisch Online AG", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("24", "", "TelcoVillage GmbH", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("33", "simquadrat", "sipgate GmbH", OperStatus.Not_Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("41", "", "First Telecom GmbH", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("42", "CCC Event", "Chaos Computer Club", OperStatus.Temporary_operational,
                                                                                              BandType.GSM1800));

            mncList.Add(new MNCInfo("43", "Lycamobile", "Lycamobile", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("60", "", "DB Telematik", OperStatus.Operational,
                                                                                              BandType.GSMR900));

            mncList.Add(new MNCInfo("70", "", "BDBOS", OperStatus.Operational,
                                                                                              BandType.TETRA));

            mncList.Add(new MNCInfo("71", "", "GSMK", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("72", "", "Ericsson GmbH", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("73", "", "Nokia", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("74", "", "Qualcomm CDMA Technologies GmbH", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("75", "", "Core Network Dynamics GmbH", OperStatus.Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("76", "", "Siemens AG", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("77", "O₂", "Telefónica Germany GmbH & Co. oHG", OperStatus.Unknown,
                                                                                              BandType.GSM900));

            mncList.Add(new MNCInfo("78", "Telekom", "Telekom Deutschland GmbH", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("79", "", "ng4T GmbH", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("92", "", "Nash Technologies", OperStatus.Not_Operational,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100));

            _countries.Add(new CountryInfo(Resources.DE, "DE", "DEU", "276", ContinentCode.EU, new MobileInfo(262, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "GI". <br/>
        /// Alpha2Cod2 GI 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForGI()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "GibTel", "Gibtelecom", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("03", "Gibfibrespeed", "GibFibre Ltd", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("06", "CTS Mobile", "CTS Gibraltar", OperStatus.Not_Operational,
                                                                                              BandType.UMTS2100));

            mncList.Add(new MNCInfo("09", "Shine", "Eazitelecom", OperStatus.Not_Operational,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100));

            _countries.Add(new CountryInfo(Resources.GI, "GI", "GIB", "292", ContinentCode.EU, new MobileInfo(266, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "GR". <br/>
        /// Alpha2Cod2 GR 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForGR()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Cosmote", "COSMOTE - Mobile Telecommunications S.A.", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG2100,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("02", "Cosmote", "COSMOTE - Mobile Telecommunications S.A.", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG2100,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("03", "", "OTE", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("04", "", "OSE", OperStatus.Unknown,
                                                                                              BandType.GSMR));

            mncList.Add(new MNCInfo("05", "Vodafone", "Vodafone Greece", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("06", "", "Cosmoline", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("07", "", "AMD Telecom", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("09", "Wind", "Wind Hellas Telecommunications S.A.", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG2100,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("10", "Wind", "Wind Hellas Telecommunications S.A.", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG2100,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("11", "", "interConnect", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("12", "", "Yuboto", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("13", "", "Compatel Limited", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("14", "Cyta Hellas", "CYTA", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("15", "", "BWS", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("16", "", "	Inter Telecom", OperStatus.Operational,
                                                                                              BandType.MVNO));

            _countries.Add(new CountryInfo(Resources.GR, "GR", "GRC", "300", ContinentCode.EU, new MobileInfo(202, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "GG". <br/>
        /// Alpha2Cod2 GG 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForGG()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("03", "Airtel-Vodafone", "Guernsey Airtel Ltd", OperStatus.Operational,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("50", "JT", "JT Group Limited", OperStatus.Operational,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("55", "Sure Mobile", "Sure (Guernsey) Limited", OperStatus.Operational,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600));

            _countries.Add(new CountryInfo(Resources.GG, "GG", "GGY", "831", ContinentCode.EU, new MobileInfo(234, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "VA". <br/>
        /// Alpha2Cod2 VA 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForVA()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.VA, "VA", "VAT", "336", ContinentCode.EU));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "HU". <br/>
        /// Alpha2Cod2 HU 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForHU()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Telenor Hungary", "Telenor Magyarország Zrt.", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("02", "", "MVM Net Ltd.", OperStatus.Operational,
                                                                                              BandType.LTE450));

            mncList.Add(new MNCInfo("03", "DIGI", "DIGI Telecommunication Ltd.", OperStatus.Operational,
                                                                                              BandType.LTE1800,
                                                                                              BandType.TDLTE3700));

            mncList.Add(new MNCInfo("04", "", "Invitech ICT Services Ltd.", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("30", "Telekom", "Magyar Telekom Plc", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG2100,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("70", "Vodafone", "Vodafone Magyarország Zrt.", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("71", "upc", "Vodafone Magyarország Zrt.", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("99", "MAV GSM-R", "Magyar Államvasutak", OperStatus.Operational,
                                                                                              BandType.GSMR900));

            _countries.Add(new CountryInfo(Resources.HU, "HU", "HUN", "348", ContinentCode.EU, new MobileInfo(216, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "IS". <br/>
        /// Alpha2Cod2 IS 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForIS()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Síminn", "Iceland Telecom", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("02", "Vodafone", "Sýn", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100));

            mncList.Add(new MNCInfo("03", "Vodafone", "Sýn", OperStatus.Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("04", "Viking", "IMC Island ehf", OperStatus.Operational,
                                                                                              BandType.GSM1800));

            mncList.Add(new MNCInfo("05", "", "Halló Frjáls fjarskipti hf.", OperStatus.Not_Operational,
                                                                                              BandType.GSM1800));

            mncList.Add(new MNCInfo("06", "", "Núll níu ehf", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("07", "IceCell", "IceCell ehf", OperStatus.Not_Operational,
                                                                                              BandType.GSM1800));

            mncList.Add(new MNCInfo("08", "On-waves", "Iceland Telecom", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800));

            mncList.Add(new MNCInfo("11", "Nova", "Nova ehf", OperStatus.Operational,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("12", "Tal", "IP fjarskipti", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("16", "", "Tismi BV", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("22", "", "Landhelgisgæslan (Icelandic Coast Guard)", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("31", "Síminn", "Iceland Telecom", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("91", "", "Neyðarlínan", OperStatus.Operational,
                                                                                              BandType.TETRA));

            _countries.Add(new CountryInfo(Resources.IS, "IS", "ISL", "352", ContinentCode.EU, new MobileInfo(274, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "IE". <br/>
        /// Alpha2Cod2 IE 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForIE()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Vodafone", "Vodafone Ireland", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("02", "3", "Hutchison 3G Ireland limited", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100));

            mncList.Add(new MNCInfo("03", "Eir", "Eir Group plc", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("04", "", "Access Telecom", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("05", "3", "Hutchison 3G Ireland limited", OperStatus.Operational,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("07", "Eir", "Eir Group plc", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100));

            mncList.Add(new MNCInfo("08", "Eir", "Eir Group plc", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("09", "", "Clever Communications Ltd.", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("11", "Tesco Mobile", "Liffey Telecom", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("13", "Lycamobile", "Lycamobile", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("15", "Virgin Mobile", "UPC", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("16", "Carphone Warehouse", "Carphone Warehouse", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("17", "3", "Hutchison 3G Ireland limited", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("18", "", "Carphone Warehouse", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("21", "", "Net Feasa Limited", OperStatus.Operational,
                                                                                              BandType.MVNO));


            _countries.Add(new CountryInfo(Resources.IE, "IE", "IRL", "372", ContinentCode.EU, new MobileInfo(272, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "IM". <br/>
        /// Alpha2Cod2 IM 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForIM()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("18", "Cloud 9 Mobile", "Cloud 9 Mobile Communications PLC	", OperStatus.Not_Operational,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100));

            mncList.Add(new MNCInfo("36", "Sure Mobile", "Sure Isle of Man Ltd.", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100));

            mncList.Add(new MNCInfo("58", "Pronto GSM", "Manx Telecom", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800));

            mncList.Add(new MNCInfo("73", "", "Bluewave Communications Ltd.", OperStatus.Operational,
                                                                                              BandType.TDLTE3500));

            _countries.Add(new CountryInfo(Resources.IM, "IM", "IMN", "833", ContinentCode.EU, new MobileInfo(234, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "IT". <br/>
        /// Alpha2Cod2 IT 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForIT()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "TIM", "Telecom Italia S.p.A.", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1500,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("02", "Elsacom", "", OperStatus.Not_Operational,
                                                                                              BandType.Satellite));

            mncList.Add(new MNCInfo("04", "Intermatica", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("05", "Telespazio", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("06", "Vodafone", "Vodafone Italia S.p.A.", OperStatus.Operational,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("07", "Kena Mobile", "Noverca", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("08", "Fastweb", "Fastweb S.p.A.", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("10", "Vodafone", "Vodafone Italia S.p.A.", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1500,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("30", "RFI", "Rete Ferroviaria Italiana", OperStatus.Operational,
                                                                                              BandType.GSMR900));

            mncList.Add(new MNCInfo("33", "Poste Mobile", "Poste Mobile S.p.A.", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("34", "BT Italia", "BT Italia", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("35", "Lycamobile", "Lycamobile", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("36", "Digi Mobil", "Digi Italy S.r.l.", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("37", "WINDTRE", "Wind Tre", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("38", "LINKEM", "Linkem S.p.A.", OperStatus.Operational,
                                                                                              BandType.TDLTE3500,
                                                                                              BandType.FiveG3500,
                                                                                              BandType.FiveG26000));

            mncList.Add(new MNCInfo("39", "SMS Italia", "SMS Italia S.r.l.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("43", "TIM", "Telecom Italia S.p.A.", OperStatus.Operational,
                                                                                              BandType.FiveG3500,
                                                                                              BandType.FiveG26000));

            mncList.Add(new MNCInfo("47", "Fastweb", "Fastweb S.p.A.", OperStatus.Operational,
                                                                                              BandType.TDLTE3500,
                                                                                              BandType.FiveG3500,
                                                                                              BandType.FiveG26000));

            mncList.Add(new MNCInfo("48", "TIM", "Telecom Italia S.p.A.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("49", "Vianova", "Welcome Italia S.p.A.", OperStatus.Unknown,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("50", "Iliad", "Iliad Italia", OperStatus.Operational,
                                                                                              BandType.UMTS900,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("53", "COOP Voce", "COOP Voce", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("54", "Plintron", "", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("56", "Spusu", "Mass Response GmbH", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("77", "IPSE 2000", "", OperStatus.Not_Operational,
                                                                                              BandType.UMTS2100));

            mncList.Add(new MNCInfo("88", "WINDTRE", "Wind Tre", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG1800,
                                                                                              BandType.FiveG2600,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("98", "BLU", "BLU S.p.A.", OperStatus.Not_Operational,
                                                                                              BandType.GSM900));

            mncList.Add(new MNCInfo("99", "WINDTRE", "Wind Tre", OperStatus.Operational,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600));

            _countries.Add(new CountryInfo(Resources.IT, "IT", "ITA", "380", ContinentCode.EU, new MobileInfo(222, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "JE". <br/>
        /// Alpha2Cod2 JE 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForJE()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("03", "Airtel-Vodafone", "Jersey Airtel Limited", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800));

            mncList.Add(new MNCInfo("28", "", "Marathon Telecom Limited", OperStatus.Not_Operational,
                                                                                              BandType.UMTS2100));

            mncList.Add(new MNCInfo("50", "JT", "JT Group Limited", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("55", "Sure Mobile", "Sure (Jersey) Limited", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800));

            _countries.Add(new CountryInfo(Resources.JE, "JE", "JEY", "832", ContinentCode.EU, new MobileInfo(234, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "JE". <br/>
        /// Alpha2Cod2 JE 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForXK()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "	Vala", "Telecom of Kosovo J.S.C.", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.LTE1800));

            mncList.Add(new MNCInfo("02", "IPKO", "IPKO", OperStatus.Not_Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.LTE1800));

            mncList.Add(new MNCInfo("06", "Z Mobile", "Dardaphone.Net LLC", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("07", "D3 Mobile", "Dukagjini Telecommunications LLC", OperStatus.Operational,
                                                                                              BandType.MVNO));

            _countries.Add(new CountryInfo(Resources.XK, "XK", "XXK", "383", ContinentCode.EU, new MobileInfo(221, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "LV". <br/>
        /// Alpha2Cod2 LV 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForLV()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "LMT", "Latvian Mobile Telephone", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("02", "Tele2", "Tele2", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("03", "TRIATEL", "Telekom Baltija", OperStatus.Operational,
                                                                                              BandType.CDMA450));

            mncList.Add(new MNCInfo("04", "", "Beta Telecom", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("05", "Bite", "Bite Latvija", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("06", "", "Rigatta", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("07", "", "SIA \"MEGATEL\"", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("08", "IZZI", "IZZI", OperStatus.Not_Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("09", "Xomobile", "Camel Mobile", OperStatus.Operational,
                                                                                              BandType.MVNO));

            _countries.Add(new CountryInfo(Resources.LV, "LV", "LVA", "428", ContinentCode.EU, new MobileInfo(247, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "LI". <br/>
        /// Alpha2Cod2 LI 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForLI()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Swisscom", "Swisscom Schweiz AG", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE1800));

            mncList.Add(new MNCInfo("02", "7acht", "Salt Liechtenstein AG", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE1800));

            mncList.Add(new MNCInfo("05", "FL1", "Telecom Liechtenstein AG", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800));

            mncList.Add(new MNCInfo("06", "Cubic Telecom", "Cubic Telecom AG", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("07", "", "First Mobile AG", OperStatus.Not_Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("09", "", "EMnify GmbH", OperStatus.Unknown,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("10", "", "Soracom LI Ltd.", OperStatus.Unknown,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("11", "", "DIMOCO Messaging AG", OperStatus.Unknown,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("77", "Alpmobil", "Alpcom AG", OperStatus.Not_Operational,
                                                                                              BandType.MVNO));

            _countries.Add(new CountryInfo(Resources.LI, "LI", "LIE", "438", ContinentCode.EU, new MobileInfo(295, mncList)));
        }
      
        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "LT". <br/>
        /// Alpha2Cod2 LT 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForLT()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Telia", "Telia Lietuva", OperStatus.Operational,
                                                                                                BandType.GSM900,
                                                                                                BandType.GSM1800,
                                                                                                BandType.UMTS900,
                                                                                                BandType.LTE800,
                                                                                                BandType.LTE1800,
                                                                                                BandType.LTE2100,
                                                                                                BandType.LTE2600));

            mncList.Add(new MNCInfo("02", "BITĖ", "UAB Bitė Lietuva", OperStatus.Operational,
                                                                                                    BandType.GSM900,
                                                                                                    BandType.GSM1800,
                                                                                                    BandType.UMTS900,
                                                                                                    BandType.UMTS2100,
                                                                                                    BandType.LTE800,
                                                                                                    BandType.LTE1800,
                                                                                                    BandType.LTE2600));

            mncList.Add(new MNCInfo("03", "Tele2", "UAB Tele2 (Tele2 AB, Sweden)", OperStatus.Operational,
                                                                                                    BandType.GSM900,
                                                                                                    BandType.GSM1800,
                                                                                                    BandType.UMTS900,
                                                                                                    BandType.UMTS2100,
                                                                                                    BandType.LTE800,
                                                                                                    BandType.LTE1800,
                                                                                                    BandType.LTE2600));

            mncList.Add(new MNCInfo("04", "", "LR vidaus reikalų ministerija (Ministry of the Interior)", OperStatus.Unknown,
                                                                                                    BandType.Unknown));

            mncList.Add(new MNCInfo("05", "LitRail", "Lietuvos geležinkeliai (Lithuanian Railways)", OperStatus.Operational,
                                                                                                    BandType.GSMR900));

            mncList.Add(new MNCInfo("06", "Mediafon", "UAB Mediafon", OperStatus.Operational,
                                                                                                    BandType.Unknown));

            mncList.Add(new MNCInfo("07", "", "	Compatel Ltd.", OperStatus.Unknown,
                                                                                                    BandType.Unknown));

            mncList.Add(new MNCInfo("08", "MEZON", "Lietuvos radijo ir televizijos centras", OperStatus.Operational,
                                                                                                    BandType.WiMAX3500,
                                                                                                    BandType.TDLTE2300));

            mncList.Add(new MNCInfo("09", "", "Interactive Digital Media GmbH", OperStatus.Unknown,
                                                                                                    BandType.Unknown));

            mncList.Add(new MNCInfo("11", "", "DATASIM OU", OperStatus.Unknown,
                                                                                                    BandType.Unknown));

            mncList.Add(new MNCInfo("12", "", "Nord connect OU", OperStatus.Unknown,
                                                                                                    BandType.Unknown));

            mncList.Add(new MNCInfo("13", "", "Travel Communication SIA", OperStatus.Unknown,
                                                                                                    BandType.Unknown));

            mncList.Add(new MNCInfo("14", "", "Tismi BV", OperStatus.Unknown,
                                                                                                    BandType.Unknown));

            mncList.Add(new MNCInfo("15", "", "	Esim telecom, UAB", OperStatus.Unknown,
                                                                                                    BandType.Unknown));

            _countries.Add(new CountryInfo(Resources.LT, "LT", "LTU", "440", ContinentCode.EU, new MobileInfo(246, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "LU". <br/>
        /// Alpha2Cod2 LU 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForLU()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "POST", "POST Luxembourg", OperStatus.Operational,
                                                                                             BandType.GSM900,
                                                                                             BandType.GSM1800,
                                                                                             BandType.UMTS2100,
                                                                                             BandType.LTE1800,
                                                                                             BandType.FiveG700,
                                                                                             BandType.FiveG3500));

            mncList.Add(new MNCInfo("02", "", "MTX Connect S.a.r.l.", OperStatus.Unknown,
                                                                                             BandType.Unknown));

            mncList.Add(new MNCInfo("05", "", "Luxembourg Online S.A.", OperStatus.Unknown,
                                                                                             BandType.Unknown));

            mncList.Add(new MNCInfo("07", "", "Bouygues Telecom S.A.", OperStatus.Unknown,
                                                                                             BandType.Unknown));

            mncList.Add(new MNCInfo("10", "", "Blue Communications", OperStatus.Unknown,
                                                                                             BandType.Unknown));

            mncList.Add(new MNCInfo("71", "CFL", "Société Nationale des Chemins de Fer Luxembourgeois", OperStatus.Operational,
                                                                                             BandType.GSMR900));

            mncList.Add(new MNCInfo("77", "Tango", "Tango SA", OperStatus.Operational,
                                                                                             BandType.GSM900,
                                                                                             BandType.GSM1800,
                                                                                             BandType.UMTS2100,
                                                                                             BandType.LTE1800,
                                                                                             BandType.FiveG700,
                                                                                             BandType.FiveG3500));

            mncList.Add(new MNCInfo("78", "", "Interactive digital media GmbH", OperStatus.Unknown,
                                                                                             BandType.Unknown));

            mncList.Add(new MNCInfo("79", "", "Mitto AG", OperStatus.Unknown,
                                                                                             BandType.Unknown));

            mncList.Add(new MNCInfo("80", "", "Syniverse Technologies S.à r.l.", OperStatus.Unknown,
                                                                                             BandType.Unknown));

            mncList.Add(new MNCInfo("81", "", "E-Lux Mobile Telecommunication S.A.", OperStatus.Unknown,
                                                                                             BandType.Unknown));

            mncList.Add(new MNCInfo("99", "Orange", "Orange S.A.", OperStatus.Operational,
                                                                                             BandType.GSM900,
                                                                                             BandType.GSM1800,
                                                                                             BandType.UMTS2100,
                                                                                             BandType.LTE1800,
                                                                                             BandType.FiveG700,
                                                                                             BandType.FiveG3500));

            _countries.Add(new CountryInfo(Resources.LU, "LU", "LUX", "442", ContinentCode.EU, new MobileInfo(270, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "MT". <br/>
        /// Alpha2Cod2 MT 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForMT()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Epic", "Epic", OperStatus.Operational,
                                                                                             BandType.GSM900,
                                                                                             BandType.UMTS2100,
                                                                                             BandType.LTE1800));

            mncList.Add(new MNCInfo("11", "", "YOM Ltd.", OperStatus.Operational,
                                                                                             BandType.MVNO));

            mncList.Add(new MNCInfo("21", "GO", "Mobile Communications Limited", OperStatus.Operational,
                                                                                             BandType.GSM900,
                                                                                             BandType.UMTS2100,
                                                                                             BandType.LTE800,
                                                                                             BandType.LTE1800));

            mncList.Add(new MNCInfo("30", "GO", "Mobile Communications Limited", OperStatus.Unknown,
                                                                                             BandType.Unknown));

            mncList.Add(new MNCInfo("77", "Melita", "Melita", OperStatus.Operational,
                                                                                             BandType.GSM900,
                                                                                             BandType.UMTS2100,
                                                                                             BandType.LTE800,
                                                                                             BandType.LTE1800,
                                                                                             BandType.FiveG));

            _countries.Add(new CountryInfo(Resources.MT, "MT", "MLT", "470", ContinentCode.EU, new MobileInfo(278, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "MD". <br/>
        /// Alpha2Cod2 MD 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForMD()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("00", "IDC", "Interdnestrcom", OperStatus.Operational,
                                                                                              BandType.CDMA800));

            mncList.Add(new MNCInfo("01", "Orange", "Orange Moldova", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("02", "Moldcell", "", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("03", "Unité", "Moldtelecom", OperStatus.Operational,
                                                                                              BandType.CDMA450));

            mncList.Add(new MNCInfo("04", "Eventis", "Eventis Telecom", OperStatus.Not_Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800));

            mncList.Add(new MNCInfo("05", "Unité", "Moldtelecom", OperStatus.Operational,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE1800));

            mncList.Add(new MNCInfo("15", "IDC", "Interdnestrcom", OperStatus.Operational,
                                                                                              BandType.LTE800));

            mncList.Add(new MNCInfo("99", "Unité", "Moldtelecom", OperStatus.Operational,
                                                                                              BandType.UMTS2100));

            _countries.Add(new CountryInfo(Resources.MD, "MD", "MDA", "498", ContinentCode.EU, new MobileInfo(259, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "MC". <br/>
        /// Alpha2Cod2 MC 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForMC()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("10", "Office des Telephones", "Monaco Telecom", OperStatus.Operational,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG3500));

            _countries.Add(new CountryInfo(Resources.MC, "MC", "MCO", "492", ContinentCode.EU, new MobileInfo(212, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "ME". <br/>
        /// Alpha2Cod2 ME 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForME()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Telenor", "Telenor Montenegro", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE1800));

            mncList.Add(new MNCInfo("02", "T-Mobile", "Crnogorski Telekom", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG2100));

            mncList.Add(new MNCInfo("03", "m:tel CG", "Mtel Montenegro", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE));

            _countries.Add(new CountryInfo(Resources.ME, "ME", "MNE", "499", ContinentCode.EU, new MobileInfo(297, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "NL". <br/>
        /// Alpha2Cod2 NL 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForNL()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("00", "", "Intovoice B.V.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("01", "", "RadioAccess Network Services", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("02", "Tele2", "T-Mobile Netherlands B.V", OperStatus.Operational,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("03", "Voiceworks", "Voiceworks B.V.", OperStatus.Operational,
                                                                                              BandType.MVNE,
                                                                                              BandType.PrivateGSM1800));

            mncList.Add(new MNCInfo("04", "Vodafone", "Vodafone Libertel B.V.", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG1800));

            mncList.Add(new MNCInfo("05", "", "Elephant Talk Communications Premium Rate Services", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("06", "Vectone Mobile", "Mundio Mobile (Netherlands) Ltd", OperStatus.Not_Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("07", "Teleena", "Tata Communications MOVE B.V.", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("08", "KPN", "KPN Mobile The Netherlands B.V.", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.TDLTE2600,
                                                                                              BandType.FiveG700));

            mncList.Add(new MNCInfo("09", "Lycamobile", "Lycamobile Netherlands Limited", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("10", "KPN", "KPN B.V.", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("11", "", "Greenet Netwerk B.V", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("12", "Telfort", "KPN Mobile The Netherlands B.V.", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("13", "", "KPN Mobile The Netherlands B.V.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("14", "", "Venus & Mercury Telecom", OperStatus.Unknown,
                                                                                              BandType.FiveG));

            mncList.Add(new MNCInfo("15", "Ziggo", "Ziggo B.V.", OperStatus.Operational,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("16", "T-Mobile (BEN)", "T-Mobile Netherlands B.V", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE900,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.TDLTE2600,
                                                                                              BandType.FiveG700));

            mncList.Add(new MNCInfo("17", "Intercity Zakelijk", "Intercity Mobile Communications B.V.", OperStatus.Not_Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("18", "Ziggo", "Ziggo B.V.", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("19", "", "Mixe Communication Solutions B.V.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("20", "T-Mobile", "T-Mobile Netherlands B.V", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE900,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.TDLTE2600,
                                                                                              BandType.FiveG700));

            mncList.Add(new MNCInfo("21", "", "ProRail B.V.", OperStatus.Operational,
                                                                                              BandType.GSMR900));

            mncList.Add(new MNCInfo("22", "", "Ministerie van Defensie", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("23", "", "KORE Wireless Nederland B.V.", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("24", "", "Private Mobility Nederland B.V.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("25", "", "CapX B.V.", OperStatus.Operational,
                                                                                              BandType.GSM1800));

            mncList.Add(new MNCInfo("26", "", "SpeakUp B.V.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("27", "L-mobi", "L-Mobi Mobile B.V.", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("28", "", "Lancelot B.V.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("29", "", "Tismi B.V.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("30", "", "ASpider Solutions Nederland B.V.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("32", "", "Cubic Telecom Limited", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("33", "", "Truphone B.V.", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("60", "", "Nextgen Mobile Ltd", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("61", "", "Alcadis B.V.", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("62", "Voxbone", "Voxbone mobile", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("63", "", "Messagebird BV", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("64", "", "Zetacom B.V.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("65", "", "AGMS Netherlands B.V.", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("66", "", "Utility Connect B.V.", OperStatus.Operational,
                                                                                              BandType.CDMA450));

            mncList.Add(new MNCInfo("67", "", "Koning en Hartman B.V.", OperStatus.Operational,
                                                                                              BandType.PrivateGSM1800));

            mncList.Add(new MNCInfo("68", "", "Roamware (Netherlands) B.V.", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("69", "", "KPN Mobile The Netherlands B.V.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("91", "", "Enexis Netbeheer B.V.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            _countries.Add(new CountryInfo(Resources.NL, "NL", "NLD", "528", ContinentCode.EU, new MobileInfo(204, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "MK". <br/>
        /// Alpha2Cod2 MK 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForMK()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Telekom.mk", "Makedonski Telekom", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800));

            mncList.Add(new MNCInfo("02", "vip", "ONE.VIP DOO", OperStatus.Not_Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800));

            mncList.Add(new MNCInfo("03", "A1", "A1 Macedonia DOO", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100));

            mncList.Add(new MNCInfo("04", "Lycamobile", "Lycamobile LLC", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("10", "", "WTI Macedonia", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("11", "", "MOBIK TELEKOMUNIKACII DOOEL Skopje", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            _countries.Add(new CountryInfo(Resources.MK, "MK", "MKD", "807", ContinentCode.EU, new MobileInfo(294, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "NO". <br/>
        /// Alpha2Cod2 NO 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForNO()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Telenor", "Telenor Norge AS", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("02", "Telia", "Telia Norge AS", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG700));

            mncList.Add(new MNCInfo("03", "", "Televerket AS", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("04", "Tele2", "Tele2 (Mobile Norway AS)", OperStatus.Not_Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("05", "Telia", "Telia Norge AS", OperStatus.Not_Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100));

            mncList.Add(new MNCInfo("06", "ice", "ICE Norge AS", OperStatus.Operational,
                                                                                              BandType.LTE450));

            mncList.Add(new MNCInfo("07", "Phonero", "Phonero AS", OperStatus.Not_Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("08", "Telia", "Telia Norge AS", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("09", "Com4", "Com4 AS", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("10", "", "Norwegian Communications Authority", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("11", "SystemNet", "SystemNet AS", OperStatus.Not_Operational,
                                                                                              BandType.Test));

            mncList.Add(new MNCInfo("12", "Telenor", "Telenor Norge AS", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("14", "ice", "ICE Communication Norge AS", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100));

            mncList.Add(new MNCInfo("15", "", "eRate Norway AS", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("16", "", "Iristel Norway AS", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("20", "", "Jernbaneverket AS", OperStatus.Operational,
                                                                                              BandType.GSMR900));

            mncList.Add(new MNCInfo("21", "", "Jernbaneverket AS", OperStatus.Operational,
                                                                                              BandType.GSMR900));

            mncList.Add(new MNCInfo("22", "", "Altibox AS", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("23", "Lycamobile", "Lyca Mobile Ltd", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("24", "", "Mobile Norway AS", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("25", "", "Forsvarets kompetansesenter KKIS", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("90", "", "Nokia Solutions and Networks Norge AS", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("99", "", "TampNet AS", OperStatus.Operational,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800));

            _countries.Add(new CountryInfo(Resources.NO, "NO", "NOR", "578", ContinentCode.EU, new MobileInfo(242, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "PL". <br/>
        /// Alpha2Cod2 PL 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForPL()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Plus", "Polkomtel Sp. z o.o.", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE900,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.TD5G2500));

            mncList.Add(new MNCInfo("02", "T-Mobile", "T-Mobile Polska S.A.", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.FiveG2100));

            mncList.Add(new MNCInfo("03", "Orange", "Polska Telefonia Komórkowa Centertel Sp. z o.o.", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.FiveG2100));

            mncList.Add(new MNCInfo("04", "Aero2", "Aero 2 Sp. z o.o.", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("05", "Orange", "Polska Telefonia Komórkowa Centertel Sp. z o.o.", OperStatus.Not_Operational,
                                                                                              BandType.UMTS2100));

            mncList.Add(new MNCInfo("06", "Play", "P4 Sp. z o.o.", OperStatus.Operational,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG2100));

            mncList.Add(new MNCInfo("07", "Netia", "Netia S.A.", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("08", "", "E-Telko Sp. z o.o.", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("09", "Lycamobile", "Lycamobile Sp. z o.o.", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("10", "T-Mobile", "T-Mobile Polska S.A.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("11", "Plus", "Polkomtel Sp. z o.o.", OperStatus.Operational,
                                                                                              BandType.CDMA420));

            mncList.Add(new MNCInfo("12", "Cyfrowy Polsat", "Cyfrowy Polsat S.A.", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("13", "", "Move Telecom S.A.", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("14", "", "Telco Leaders Ltd", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("15", "Aero2", "Aero 2 Sp. z o.o.", OperStatus.Operational,
                                                                                              BandType.LTE1800));

            mncList.Add(new MNCInfo("16", "Aero2", "Aero 2 Sp. z o.o.", OperStatus.Operational,
                                                                                              BandType.LTE1800));

            mncList.Add(new MNCInfo("17", "Aero2", "Aero 2 Sp. z o.o.", OperStatus.Operational,
                                                                                              BandType.UMTS900,
                                                                                              BandType.TDLTE2600));

            mncList.Add(new MNCInfo("18", "AMD Telecom", "AMD Telecom S.A.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("19", "", "SIA NetBalt", OperStatus.Unknown,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("20", "", "TISMI B.V.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("21", "", "private networks", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("22", "", "Twilio Ireland Limited", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("23", "", "PGE Systemy S.A.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("24", "", "IT Partners Telco Sp. z o.o.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("25", "TeleCube.PL", "Claude ICT Poland Sp. z o. o.", OperStatus.Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("26", "ATE", "Advanced Technology & Experience Sp. z o.o.", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("27", "", "SIA Ntel Solutions", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("28", "PhoneNet", "PhoneNet Sp. z o.o.", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("29", "Interfonica", "0Interfonica Sp. z o.o.", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("30", "GrandTel", "GrandTel Sp. z o.o.", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("31", "Phone IT", "Phone IT Sp. z o.o.", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("32", "", "Compatel Limited", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("33", "Truphone", "Truphone Poland Sp. z o.o.", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("34", "NetWorkS!", "T-Mobile Polska S.A.", OperStatus.Operational,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("35", "", "PKP Polskie Linie Kolejowe S.A.", OperStatus.Operational,
                                                                                              BandType.GSMR));

            mncList.Add(new MNCInfo("36", "Vectone Mobile", "Mundio Mobile", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("37", "", "NEXTGEN MOBILE LTD", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("38", "", "CALLFREEDOM Sp. z o.o.", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("39", "Voxbone", "VOXBONE SA", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("40", "", "Interactive Digital Media GmbH", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("41", "", "EZ PHONE MOBILE Sp. z o.o.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("42", "", "MobiWeb Telecom Limited", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("43", "", "Smart Idea International Sp. z o.o.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("44", "", "Rebtel Poland Sp. z o.o.", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("45", "", "Virgin Mobile Polska Sp. z o.o.", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("46", "", "Terra Telekom Sp. z o.o.", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("47", "", "SMShighway Limited", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("48", "", "AGILE TELECOM S.P.A.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("49", "", "Messagebird B.V.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("90", "", "Polska Spółka Gazownictwa Sp. z o.o.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("97", "", "Politechnika Łódzka Uczelniane Centrum Informatyczne", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("98", "", "P4 Sp. z o.o.", OperStatus.Not_Operational,
                                                                                              BandType.LTE1800));

            _countries.Add(new CountryInfo(Resources.PL, "PL", "POL", "616", ContinentCode.EU, new MobileInfo(260, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "PT". <br/>
        /// Alpha2Cod2 PT 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForPT()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Vodafone", "Vodafone Portugal", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("02", "MEO", "Telecomunicações Móveis Nacionais", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("03", "NOS", "NOS Comunicações", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("04", "LycaMobile", "LycaMobile", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("05", "", "Oniway - Inforcomunicaçôes, S.A.", OperStatus.Not_Operational,
                                                                                              BandType.UMTS2100));

            mncList.Add(new MNCInfo("06", "MEO", "MEO - Serviços de Comunicações e Multimédia, S.A.", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("07", "Vectone Mobile", "Mundio Mobile (Portugal) Limited", OperStatus.Not_Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("08", "MEO", "MEO - Serviços de Comunicações e Multimédia, S.A.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("11", "", "Compatel, Limited", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("12", "", "Infraestruturas de Portugal, S.A.", OperStatus.Operational,
                                                                                              BandType.GSMR));

            mncList.Add(new MNCInfo("13", "", "G9Telecom, S.A.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("21", "Zapp", "Zapp Portugal", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("80", "MEO", "MEO - Serviços de Comunicações e Multimédia, S.A.", OperStatus.Not_Operational,
                                                                                              BandType.CDMA2000450));

            mncList.Add(new MNCInfo("91", "Vodafone", "Vodafone Portugal", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("93", "NOS", "NOS Comunicações", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            _countries.Add(new CountryInfo(Resources.PT, "PT", "PRT", "620", ContinentCode.EU, new MobileInfo(268, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "RO". <br/>
        /// Alpha2Cod2 RO 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForRO()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Vodafone", "Vodafone România", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.TDLTE2600,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("02", "Clicknet Mobile", "Telekom Romania", OperStatus.Not_Operational,
                                                                                              BandType.CDMA420));

            mncList.Add(new MNCInfo("03", "Telekom", "Telekom Romania", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("04", "Cosmote/Zapp", "Telekom Romania", OperStatus.Not_Operational,
                                                                                              BandType.CDMA420));

            mncList.Add(new MNCInfo("05", "Digi.Mobil", "RCS&RDS", OperStatus.Operational,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE900,
                                                                                              BandType.LTE2100,
                                                                                              BandType.TDLTE2600,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("06", "Telekom/Zapp", "Telekom Romania", OperStatus.Operational,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100));

            mncList.Add(new MNCInfo("10", "Orange", "Orange România", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("11", "", "Enigma-System", OperStatus.Unknown,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("15", "Idilis", "Idilis", OperStatus.Operational,
                                                                                              BandType.WiMAX,
                                                                                              BandType.TDLTE2600));

            mncList.Add(new MNCInfo("16", "Lycamobile", "Lycamobile Romania", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("19", "CFR", "Căile Ferate Române", OperStatus.Testing,
                                                                                              BandType.GSMR900));

            _countries.Add(new CountryInfo(Resources.RO, "RO", "ROU", "642", ContinentCode.EU, new MobileInfo(226, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "RU". <br/>
        /// Alpha2Cod2 RU 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForRU()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "MTS", "Mobile TeleSystems", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE900,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.TDLTE2600,
                                                                                              BandType.FiveG4700));

            mncList.Add(new MNCInfo("02", "MegaFon", "MegaFon PJSC", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("03", "NCC", "Nizhegorodskaya Cellular Communications", OperStatus.Not_Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800));

            mncList.Add(new MNCInfo("04", "Sibchallenge", "Sibchallenge", OperStatus.Not_Operational,
                                                                                              BandType.GSM900));

            mncList.Add(new MNCInfo("05", "ETK", "Yeniseytelecom", OperStatus.Not_Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.CDMA450));

            mncList.Add(new MNCInfo("06", "Skylink", "CJSC Saratov System of Cellular Communications", OperStatus.Operational,
                                                                                              BandType.CDMA450));

            mncList.Add(new MNCInfo("07", "SMARTS", "Zao SMARTS", OperStatus.Not_Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800));

            mncList.Add(new MNCInfo("08", "Vainah Telecom", "CS \"VainahTelecom\"", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.TDLTE2300));

            mncList.Add(new MNCInfo("09", "Skylink", "Khabarovsky Cellular Phone", OperStatus.Operational,
                                                                                              BandType.CDMA450));

            mncList.Add(new MNCInfo("10", "DTC", "Dontelekom", OperStatus.Not_Operational,
                                                                                              BandType.GSM900));

            mncList.Add(new MNCInfo("11", "Yota", "Scartel", OperStatus.Not_Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("12", "Baykalwestcom", "Baykal Westcom / New Telephone Company / Far Eastern Cellular", OperStatus.Not_Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.CDMA450));

            mncList.Add(new MNCInfo("12", "Akos", "", OperStatus.Not_Operational,
                                                                                              BandType.GSM1800));

            mncList.Add(new MNCInfo("13", "KUGSM", "Kuban GSM", OperStatus.Not_Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800));

            mncList.Add(new MNCInfo("14", "MegaFon", "MegaFon OJSC", OperStatus.Not_Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.TDLTE2600));

            mncList.Add(new MNCInfo("15", "SMARTS", "SMARTS Ufa, SMARTS Uljanovsk", OperStatus.Not_Operational,
                                                                                              BandType.GSM1800));

            mncList.Add(new MNCInfo("16", "Miatel", "Miatel", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("17", "Utel", "JSC Uralsvyazinform", OperStatus.Not_Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800));

            mncList.Add(new MNCInfo("18", "Osnova Telecom", "", OperStatus.Not_Operational,
                                                                                              BandType.TDLTE2300));
        
            mncList.Add(new MNCInfo("19", "INDIGO", "INDIGO", OperStatus.Not_Operational,
                                                                                              BandType.GSM1800));

            mncList.Add(new MNCInfo("20", "Tele2", "Tele2", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE450,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.TDLTE2300,
                                                                                              BandType.TDLTE2500,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("21", "GlobalTel", "JSC \"GlobalTel\"", OperStatus.Operational,
                                                                                              BandType.Satellite));

            mncList.Add(new MNCInfo("22", "", "Vainakh Telecom", OperStatus.Operational,
                                                                                              BandType.TDLTE2300));

            mncList.Add(new MNCInfo("23", "Thuraya", "GTNT", OperStatus.Operational,
                                                                                              BandType.SatelliteMVNO));

            mncList.Add(new MNCInfo("26", "VTB Mobile", "VTB Mobile", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("27", "Letai", "Tattelecom", OperStatus.Operational,
                                                                                              BandType.GSM1800,
                                                                                              BandType.LTE1800));

            mncList.Add(new MNCInfo("28", "Beeline", "Beeline", OperStatus.Not_Operational,
                                                                                              BandType.GSM900));

            mncList.Add(new MNCInfo("29", "Iridium", "Iridium Communications", OperStatus.Operational,
                                                                                              BandType.SatelliteMVNO));

            mncList.Add(new MNCInfo("32", "Win Mobile", "K-Telecom", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("33", "Sevmobile", "Sevtelekom", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("34", "Krymtelekom", "Krymtelekom", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100));

            mncList.Add(new MNCInfo("35", "MOTIV", "EKATERINBURG-2000", OperStatus.Not_Operational,
                                                                                              BandType.GSM1800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.TDLTE2600));

            mncList.Add(new MNCInfo("38", "Tambov GSM", "Central Telecommunication Company", OperStatus.Not_Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800));

            mncList.Add(new MNCInfo("39", "Rostelecom", "ROSTELECOM", OperStatus.Not_Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.TDLTE2300,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("40", "VTC Mobile", "Voentelecom", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("44", "", "Stavtelesot / North Caucasian GSM", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("45", "Gazprombank Mobile", "PJSC New Mobile Communications", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("50", "SberMobile", "Sberbank-Telecom", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("54", "TTK", "Tattelecom", OperStatus.Not_Operational,
                                                                                              BandType.LTE1800));

            mncList.Add(new MNCInfo("60", "Volna mobile", "KTK Telecom", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE));

            mncList.Add(new MNCInfo("61", "Intertelecom", "Intertelecom", OperStatus.Not_Operational,
                                                                                              BandType.CDMA800));

            mncList.Add(new MNCInfo("62", "Tinkoff Mobile", "Tinkoff Mobile", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("91", "Sonic Duo", "Sonic Duo CJSC", OperStatus.Not_Operational,
                                                                                              BandType.GSM1800));

            mncList.Add(new MNCInfo("92", "", "Primtelefon", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("93", "", "Telecom XXI", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("99", "Beeline", "OJSC Vimpel-Communications", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("811", "", "Votek Mobile", OperStatus.Not_Operational,
                                                                                              BandType.AMPS,
                                                                                              BandType.DAMPS,
                                                                                              BandType.GSM1800));

            _countries.Add(new CountryInfo(Resources.RU, "RU", "RUS", "643", ContinentCode.EU, new MobileInfo(250, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "SM". <br/>
        /// Alpha2Cod2 SM 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForSM()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "PRIMA", "San Marino Telecom", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100));

            _countries.Add(new CountryInfo(Resources.SM, "SM", "SMR", "674", ContinentCode.EU, new MobileInfo(292, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "RS". <br/>
        /// Alpha2Cod2 RS 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForRS()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Telenor", "Telenor Serbia", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800));

            mncList.Add(new MNCInfo("02", "Telenor", "Telenor Montenegro", OperStatus.Not_Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100));

            mncList.Add(new MNCInfo("03", "mts", "Telekom Srbija", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.TETRA));

            mncList.Add(new MNCInfo("04", "T-Mobile", "T-Mobile Montenegro LLC", OperStatus.Not_Operational,
                                                                                              BandType.GSM));

            mncList.Add(new MNCInfo("05", "VIP", "VIP Mobile", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800));

            mncList.Add(new MNCInfo("07", "", "Orion Telekom", OperStatus.Operational,
                                                                                              BandType.CDMA450));

            mncList.Add(new MNCInfo("09", "Vectone Mobile", "MUNDIO MOBILE d.o.o.", OperStatus.Not_Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("11", "GLOBALTEL", "GLOBALTEL d.o.o.", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("20", "VIP", "VIP Mobile", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            _countries.Add(new CountryInfo(Resources.RS, "RS", "SRB", "688", ContinentCode.EU, new MobileInfo(220, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "SK". <br/>
        /// Alpha2Cod2 SK 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForSK()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Orange", "Orange Slovensko", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("02", "Telekom", "Slovak Telekom", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.TDLTE3700,
                                                                                              BandType.FiveG2100));

            mncList.Add(new MNCInfo("03", "4ka", "SWAN Mobile, a.s.", OperStatus.Operational,
                                                                                              BandType.LTE1800,
                                                                                              BandType.TDLTE3500,
                                                                                              BandType.TDLTE3700,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("04", "Telekom", "Slovak Telekom", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100));

            mncList.Add(new MNCInfo("05", "Orange", "	Orange Slovensko", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100));

            mncList.Add(new MNCInfo("06", "O₂", "O2 Slovakia", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.TDLTE3500,
                                                                                              BandType.TDLTE3700,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("07", "Orange", "Orange Slovensko", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("08", "Unimobile", "Uniphone, s.r.o.", OperStatus.Testing,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("09", "", "DSI DATA, a.s.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("10", "", "HMZ RÁDIOKOMUNIKÁCIE, spol. s r.o.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("99", "ŽSR", "Železnice Slovenskej Republiky", OperStatus.Operational,
                                                                                              BandType.GSMR));

            _countries.Add(new CountryInfo(Resources.SK, "SK", "SVK", "703", ContinentCode.EU, new MobileInfo(231, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "SI". <br/>
        /// Alpha2Cod2 SI 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForSI()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("10", "", "SŽ - Infrastruktura, d.o.o.", OperStatus.Operational,
                                                                                              BandType.GSMR));

            mncList.Add(new MNCInfo("11", "", "BeeIN d.o.o.", OperStatus.Unknown,
                                                                                              BandType.FiveG700));

            mncList.Add(new MNCInfo("20", "", "COMPATEL Ltd", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("21", "", "NOVATEL d.o.o.", OperStatus.Unknown,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("40", "A1", "A1 Slovenija", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("41", "Mobitel", "Telekom Slovenije", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE900,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG2600));

            mncList.Add(new MNCInfo("64", "T-2", "T-2 d.o.o.", OperStatus.Operational,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE2100,
                                                                                              BandType.FiveG3600));

            mncList.Add(new MNCInfo("70", "Telemach", "Tušmobil d.o.o.", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE700,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.FiveG700,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("86", "", "ELEKTRO GORENJSKA, d.d", OperStatus.Unknown,
                                                                                              BandType.LTE700));

            _countries.Add(new CountryInfo(Resources.SI, "SI", "SVN", "705", ContinentCode.EU, new MobileInfo(293, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "ES". <br/>
        /// Alpha2Cod2 ES 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForES()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Vodafone", "Vodafone Spain", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.TDLTE2600,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("02", "Altecom/Fibracat", "Alta Tecnologia en Comunicacions SL", OperStatus.Operational,
                                                                                              BandType.TDLTE2600));

            mncList.Add(new MNCInfo("03", "Orange", "Orange Espagne S.A.U", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("04", "Yoigo", "Xfera Moviles SA", OperStatus.Operational,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("05", "Movistar", "Telefónica Móviles España", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("06", "Vodafone", "Vodafone Spain", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("07", "Movistar", "Telefónica Móviles España", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG1800,
                                                                                              BandType.FiveG2100,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("08", "Euskaltel", "", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("09", "Orange", "Orange Espagne S.A.U", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("10", "", "ZINNIA TELECOMUNICACIONES, S.L.U.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("11", "", "TELECOM CASTILLA-LA MANCHA, S.A.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("12", "", "SAC CONVERGENT AGGREGATION SERVICES, S.L.U.", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("13", "", "SYMA MOBILE ESPAÑA, S.L.", OperStatus.Unknown,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("14", "", "AVATEL MÓVIL, S.L.U.", OperStatus.Operational,
                                                                                              BandType.WiMAX));

            mncList.Add(new MNCInfo("15", "BT", "BT Group España Compañia de Servicios Globales de Telecomunicaciones S.A.U.", OperStatus.Not_Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("16", "TeleCable", "R Cable y Telecomunicaciones Galicia S.A.", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("17", "Móbil R", "R Cable y Telecomunicaciones Galicia S.A.", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("18", "ONO", "Vodafone Spain", OperStatus.Not_Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("19", "Simyo", "Orange España Virtual Sl.", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("20", "Fonyou", "Fonyou Telecom S.L.", OperStatus.Not_Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("21", "Jazztel", "Orange Espagne S.A.U.", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("22", "DIGI mobil", "Best Spain Telecom", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("23", "", "Xfera Moviles S.A.U.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("24", "", "VODAFONE ESPAÑA, S.A.U.", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("25", "Lycamobile", "LycaMobile S.L.", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("26", "", "Lleida Networks Serveis Telemátics, SL", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("27", "Truphone", "SCN Truphone, S.L.", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("28", "Murcia4G", "Consorcio de Telecomunicaciones Avanzadas, S.A.", OperStatus.Operational,
                                                                                              BandType.TDLTE2600));

            mncList.Add(new MNCInfo("29", "", "Xfera Moviles S.A.U.", OperStatus.Operational,
                                                                                              BandType.TDLTE3500));

            mncList.Add(new MNCInfo("30", "", "Compatel Limited", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("31", "", "Red Digital De Telecomunicaciones de las Islas Baleares, S.L.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("32", "Tuenti", "Telefónica Móviles España", OperStatus.Not_Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("33", "", "Xfera Móviles, S.A.U.", OperStatus.Unknown,
                                                                                              BandType.WiMAX));

            mncList.Add(new MNCInfo("34", "", "Aire Networks del Mediterráneo, S.L.U.", OperStatus.Operational,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("35", "", "INGENIUM OUTSOURCING SERVICES, S.L.", OperStatus.Unknown,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("36", "", "ALAI OPERADOR DE TELECOMUNICACIONES, S.L", OperStatus.Unknown,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("37", "", "Vodafone Spain", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("38", "", "Telefónica Móviles España, S.A.U.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("51", "ADIF", "Administrador de Infraestructuras Ferroviarias", OperStatus.Operational,
                                                                                              BandType.GSMR));

            _countries.Add(new CountryInfo(Resources.ES, "ES", "ESP", "724", ContinentCode.EU, new MobileInfo(214, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "SJ". <br/>
        /// Alpha2Cod2 SJ 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForSJ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.SJ, "SJ", "SJM", "744", ContinentCode.EU));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "SE". <br/>
        /// Alpha2Cod2 SE 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForSE()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Telia", "Telia Sverige AB", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG700));

            mncList.Add(new MNCInfo("02", "3", "HI3G Access AB", OperStatus.Operational,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE2600,
                                                                                              BandType.TDLTE2600,
                                                                                              BandType.TD5G2600));

            mncList.Add(new MNCInfo("03", "Net 1", "Teracom Mobil AB", OperStatus.Operational,
                                                                                              BandType.LTE450));

            mncList.Add(new MNCInfo("04", "WEDEN", "3G Infrastructure Services AB", OperStatus.Operational,
                                                                                              BandType.UMTS2100));

            mncList.Add(new MNCInfo("05", "Sweden 3G", "Svenska UMTS-Nät AB", OperStatus.Operational,
                                                                                              BandType.UMTS2100));

            mncList.Add(new MNCInfo("06", "Telenor", "Telenor Sverige AB", OperStatus.Operational,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("07", "Tele2", "Tele2 Sverige AB", OperStatus.Operational,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE900,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("08", "Telenor", "Telenor Sverige AB", OperStatus.Not_Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800));

            mncList.Add(new MNCInfo("09", "Com4", "Communication for Devices in Sweden AB", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("10", "Spring Mobil", "Tele2 Sverige AB", OperStatus.Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("11", "", "ComHem AB", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("12", "Lycamobile", "Lycamobile Sweden Limited", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("13", "", "A3 Företag AB", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("14", "", "Tele2 Sverige AB", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("15", "", "Sierra Wireless Sweden AB", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("16", "", "42 Telecom AB", OperStatus.Operational,
                                                                                              BandType.GSM));

            mncList.Add(new MNCInfo("17", "Gotanet", "Götalandsnätet AB", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("18", "", "Generic Mobile Systems Sweden AB", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("19", "Vectone Mobile", "Mundio Mobile (Sweden) Limited", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("20", "", "Sierra Wireless Messaging AB", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("21", "MobiSir", "Trafikverket ICT", OperStatus.Operational,
                                                                                              BandType.GSMR900));

            mncList.Add(new MNCInfo("22", "", "EuTel AB", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("23", "", "Infobip Limited (UK)", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("24", "Sweden 2G", "Net4Mobility HB", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE900,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("25", "", "Monty UK Global Ltd", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("26", "", "Twilio Sweden AB", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("27", "", "GlobeTouch AB", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("28", "", "LINK Mobile A/S", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("29", "", "Mercury International Carrier Services", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("30", "", "NextGen Mobile Ltd.", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("31", "", "RebTel Network AB", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("32", "", "Compatel Limited", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("33", "", "Mobile Arts AB", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("34", "", "Trafikverket centralfunktion IT", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("35", "", "42 Telecom LTD", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("36", "", "interactive digital media GmbH", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("37", "", "Sinch Sweden AB", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("38", "Voxbone", "Voxbone mobile", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("39", "", "Primlight AB", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("40", "", "Netmore Group AB", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("41", "", "Shyam Telecom UK Ltd.", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("42", "", "Telenor Connexion AB", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("43", "", "MobiWeb Ltd.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("44", "", "Telenabler AB", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("45", "", "Spirius AB", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("46", "Viahub", "SMS Provider Corp.", OperStatus.Unknown,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("47", "", "Viatel Sweden AB", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("48", "", "Tismi BV", OperStatus.Unknown,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("49", "", "Telia Sverige AB", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("60", "", "Telefonaktiebolaget LM Ericsson", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("61", "", "MessageBird B.V.", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("63", "FTS", "Fink Telecom Services", OperStatus.Operational,
                                                                                              BandType.Unknown));

            _countries.Add(new CountryInfo(Resources.SE, "SE", "SWE", "752", ContinentCode.EU, new MobileInfo(240, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "CH". <br/>
        /// Alpha2Cod2 CH 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForCH()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Swisscom", "Swisscom AG", OperStatus.Operational,
                                                                                              BandType.UMTS900,
                                                                                              BandType.LTE700,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE900,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG700,
                                                                                              BandType.FiveG2100,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("02", "Sunrise", "Sunrise Communications AG", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE900,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG700,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("03", "Salt", "Salt Mobile SA", OperStatus.Operational,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG700,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("05", "", "Comfone AG", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("06", "SBB-CFF-FFS", "SBB AG", OperStatus.Operational,
                                                                                              BandType.GSMR900));

            mncList.Add(new MNCInfo("07", "IN&Phone", "IN&Phone SA", OperStatus.Not_Operational,
                                                                                              BandType.GSM1800));

            mncList.Add(new MNCInfo("08", "Tele4u", "Sunrise Communications AG", OperStatus.Operational,
                                                                                              BandType.GSM1800));

            mncList.Add(new MNCInfo("09", "", "Comfone AG", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("10", "", "Stadt Polizei Zürich", OperStatus.Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("11", "", "Swisscom Broadcast AG", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("12", "Sunrise", "Sunrise Communications AG", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("50", "", "3G Mobile AG", OperStatus.Not_Operational,
                                                                                              BandType.UMTS2100));

            mncList.Add(new MNCInfo("51", "", "relario AG", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("52", "Barablu", "Barablu", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("53", "upc cablecom", "UPC Schweiz GmbH", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("54", "Lycamobile", "Lycamobile AG", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("55", "", "WeMobile SA", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("56", "", "SMSRelay AG", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("57", "", "Mitto AG", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("58", "beeone", "Beeone Communications SA", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("59", "Vectone", "Mundio Mobile Limited", OperStatus.Unknown,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("60", "Sunrise", "Sunrise Communications AG", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("61", "", "Compatel Ltd.", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("62", "", "Telecom26 AG", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("63", "FTS", "Fink Telecom Services", OperStatus.Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("64", "", "Nth AG", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("65", "", "Nexphone AG", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("66", "", "Inovia Services SA", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("67", "", "Datatrade Managed AG", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("68", "", "Intellico AG", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("99", "", "Swisscom Broadcast AG", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            _countries.Add(new CountryInfo(Resources.CH, "CH", "CHE", "756", ContinentCode.EU, new MobileInfo(228, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "TR". <br/>
        /// Alpha2Cod2 TR 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForTR()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Turkcell", "Turkcell Iletisim Hizmetleri A.S.", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("02", "Vodafone", "Vodafone Turkey", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE900,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600,
                                                                                              BandType.TDLTE2600));

            mncList.Add(new MNCInfo("03", "Türk Telekom", "Türk Telekom", OperStatus.Operational,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE900,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600,
                                                                                              BandType.TDLTE2600));

            mncList.Add(new MNCInfo("04", "Aycell", "Aycell", OperStatus.Not_Operational,
                                                                                              BandType.GSM1800));

            _countries.Add(new CountryInfo(Resources.TR, "TR", "TUR", "792", ContinentCode.EU, new MobileInfo(286, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "UA". <br/>
        /// Alpha2Cod2 UA 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForUA()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Vodafone", "PRJSC \"VF Ukraine\"", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE900,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("02", "Kyivstar", "PRJSC \"Kyivstar\"", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE900,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("03", "Kyivstar", "PRJSC \"Kyivstar\"", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE900,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("04", "Intertelecom", "Intertelecom LLC", OperStatus.Operational,
                                                                                              BandType.CDMA800));

            mncList.Add(new MNCInfo("05", "Kyivstar", "PRJSC \"Kyivstar\"", OperStatus.Not_Operational,
                                                                                              BandType.GSM1800));

            mncList.Add(new MNCInfo("06", "lifecell", "lifecell LLC", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE900,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("07", "3Mob; Lycamobile", "Trimob LLC", OperStatus.Operational,
                                                                                              BandType.UMTS2100));

            mncList.Add(new MNCInfo("08", "", "JSC Ukrtelecom", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("09", "", "PRJSC \"Farlep - Invest\"", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("10", "", "Atlantis Telecom LLC", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("21", "PEOPLEnet", "PRJSC \"Telesystems of Ukraine\"", OperStatus.Operational,
                                                                                              BandType.CDMA800));

            mncList.Add(new MNCInfo("23", "CDMA Ukraine", "	Intertelecom LLC", OperStatus.Not_Operational,
                                                                                              BandType.CDMA800));

            mncList.Add(new MNCInfo("25", "NEWTONE", "PRJSC \"Telesystems of Ukraine\"", OperStatus.Not_Operational,
                                                                                              BandType.CDMA800));

            mncList.Add(new MNCInfo("99", "Phoenix", "Phoenix", OperStatus.Operational,
                                                                                              BandType.LTE800));

            _countries.Add(new CountryInfo(Resources.UA, "UA", "UKR", "804", ContinentCode.EU, new MobileInfo(255, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "GB". <br/>
        /// Alpha2Cod2 GB 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForGB()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("00", "BT", "BT Group", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100));

            mncList.Add(new MNCInfo("01", "Vectone Mobile", "Mundio Mobile Limited", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("02", "O2 (UK)", "O2 (UK)", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE900,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.TDLTE2300,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("03", "Airtel-Vodafone", "Jersey Airtel Ltd", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("04", "FMS Solutions Ltd", "FMS Solutions Ltd", OperStatus.Reserved,
                                                                                              BandType.GSM1800));

            mncList.Add(new MNCInfo("05", "", "COLT Mobile Telecommunications Limited", OperStatus.Not_Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("06", "", "Internet Computer Bureau Limited", OperStatus.Not_Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("07", "Vodafone UK", "Vodafone", OperStatus.Not_Operational,
                                                                                              BandType.GSM1800));

            mncList.Add(new MNCInfo("08", "BT OnePhone", "BT OnePhone (UK) Ltd", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("09", "", "Tismi BV", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("10", "O2 (UK)", "Telefónica Europe", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE900,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.TDLTE2300,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("11", "O2 (UK)", "Telefónica Europe", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE900,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.TDLTE2300,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("12", "Railtrack", "Network Rail Infrastructure Ltd", OperStatus.Operational,
                                                                                              BandType.GSMR));

            mncList.Add(new MNCInfo("13", "Railtrack", "Network Rail Infrastructure Ltd", OperStatus.Operational,
                                                                                              BandType.GSMR));

            mncList.Add(new MNCInfo("14", "", "Link Mobility UK Ltd", OperStatus.Operational,
                                                                                              BandType.GSM1800));

            mncList.Add(new MNCInfo("15", "Vodafone UK", "Vodafone", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE900,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.TDLTE2600,
                                                                                              BandType.FiveG2100,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("16", "Talk Talk", "TalkTalk Communications Limited", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("17", "", "FleXtel Limited", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("18", "Cloud9", "Cloud9", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("19", "Private Mobile Networks PMN", "Teleware plc", OperStatus.Operational,
                                                                                              BandType.GSM1800));

            mncList.Add(new MNCInfo("20", "3", "Hutchison 3G UK Ltd", OperStatus.Operational,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1500,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("21", "", "LogicStar Ltd", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("22", "", "Telesign Mobile Limited", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("23", "", "Icron Network Limited", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("24", "Greenfone", "Stour Marine Limited", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("25", "Truphone", "Truphone", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("26", "Lycamobile", "Lycamobile UK Limited", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("27", "Teleena", "Tata Communications Move UK Ltd", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("28", "", "Marathon Telecom Limited", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("29", "aql", "(aq) Limited", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("30", "T-Mobile UK", "EE", OperStatus.Operational,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG700,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("31", "T-Mobile UK", "EE", OperStatus.Operational,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG700,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("32", "T-Mobile UK", "EE", OperStatus.Operational,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG700,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("33", "Orange", "EE", OperStatus.Operational,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG700,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("34", "Orange", "EE", OperStatus.Operational,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG700,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("35", "", "JSC Ingenium (UK) Limited", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("36", "Sure Mobile", "Sure Isle of Man Ltd.", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2100));

            mncList.Add(new MNCInfo("37", "", "Synectiv Ltd", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("38", "Virgin Mobile", "Virgin Media", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("39", "", "Gamma Telecom Holdings Ltd.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("50", "JT", "JT Group Limited", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("51", "Relish", "UK Broadband Limited", OperStatus.Operational,
                                                                                              BandType.TDLTE3500,
                                                                                              BandType.TDLTE3700));

            mncList.Add(new MNCInfo("52", "", "Shyam Telecom UK Ltd", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("53", "", "Limitless Mobile Ltd", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("54", "iD Mobile", "The Carphone Warehouse Limited", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("55", "Sure Mobile", "Sure (Guernsey) Limited", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("56", "", "National Cyber Security Centre", OperStatus.Unknown,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("57", "", "Sky UK Limited", OperStatus.Unknown,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("58", "Pronto GSM", "Manx Telecom", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800));

            mncList.Add(new MNCInfo("59", "", "Limitless Mobile Ltd", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("70", "", "AMSUK Ltd.", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("71", "", "Home Office", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("72", "Hanhaa Mobile", "Hanhaa Limited", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("73", "", "Bluewave Communications Ltd", OperStatus.Operational,
                                                                                              BandType.TDLTE3500));

            mncList.Add(new MNCInfo("74", "", "Pareteum Europe B.V.", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("76", "BT", "BT Group", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800));

            mncList.Add(new MNCInfo("78", "Airwave", "Airwave Solutions Ltd", OperStatus.Operational,
                                                                                              BandType.TETRA));

            mncList.Add(new MNCInfo("86", "", "EE", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "Vectone Mobile", "Mundio Mobile Limited", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("01", "", "EE", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("02", "", "EE", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("03", "Relish", "UK Broadband Limited", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("04", "5G RuralFirst, 5G NewThinking, 5G RailNext, various other brands", "University of Strathclyde StrathSDR", OperStatus.FourG_and_FiveG_pilot_networks,
                                                                                              BandType.Various));

            mncList.Add(new MNCInfo("06", "5G RuralFirst, 5G NewThinking, 5G RailNext, various other brands", "University of Strathclyde StrathSDR", OperStatus.FourG_and_FiveG_pilot_networks,
                                                                                              BandType.Various));

            mncList.Add(new MNCInfo("07", "5G RuralFirst, 5G NewThinking, 5G RailNext, various other brands", "University of Strathclyde StrathSDR", OperStatus.FourG_and_FiveG_pilot_networks,
                                                                                              BandType.Various));

            mncList.Add(new MNCInfo("77", "BT", "BT Group", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("88", "", "Telet Research (N.I.) Limited", OperStatus.Not_Operational,
                                                                                              BandType.LTE));

            mncList.Add(new MNCInfo("91", "Vodafone UK", "Vodafone United Kingdom", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("92", "Vodafone UK", "Vodafone United Kingdom", OperStatus.Not_Operational,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("94", "", "Hutchison 3G UK Ltd", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("95", "", "Network Rail Infrastructure Limited", OperStatus.TestNetwork,
                                                                                              BandType.GSMR));

            _countries.Add(new CountryInfo(Resources.GB, "GB", "GBR", "826", ContinentCode.EU, new MobileInfo(234, mncList), new MobileInfo(235, mncList)));
        }
    }
}
