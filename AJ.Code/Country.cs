﻿using AJ.Code.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using static AJ.Code.MNCInfo;

namespace AJ.Code
{
    public class Country
    {
        /*******************************************************************/
        /// <summary>
        /// Get all country information that registered. <br/>
        /// 등록된 모든 국가정보를 가져옵니다.
        /// </summary>
        /*******************************************************************/
        public static IEnumerable<CountryInfo> AllCountries => _countries;


        /*******************************************************************/
        /// <summary>
        /// Get the country information list for MCC. <br/>
        /// MCC에 대한 국가정보목록을 가져옵니다.
        /// </summary>
        /// <param name="mcc"></param>
        /// <returns></returns>
        /*******************************************************************/
        public static IEnumerable<CountryInfo> GetCountryInfoForMCC(int mcc)
            => GetCountryInfoListCore((country) => country.MobileCodes.Contains(new MobileInfo(mcc)));


        /*******************************************************************/
        /// <summary>
        /// Get the country information for alpha2 code. <br/>
        /// 알파2 코드에 대한 국가정보를 가져옵니다.
        /// </summary>
        /// <param name="alpha2Code"></param>
        /// <returns></returns>
        /*******************************************************************/
        public static CountryInfo GetCountryInfoForAlpha2Code(string alpha2Code)
            => GetCountryInfoCore((country) => country.Alpha2Code == alpha2Code);


        /*******************************************************************/
        /// <summary>
        /// Get the country information for alpha3 code. <br/>
        /// 알파3 코드에 대한 국가정보를 가져옵니다.
        /// </summary>
        /// <param name="alpha3Code"></param>
        /// <returns></returns>
        /*******************************************************************/
        public static CountryInfo GetCountryInfoForAlpha3Code(string alpha3Code)
            => GetCountryInfoCore((country) => country.Alpha3Code == alpha3Code);


        /*******************************************************************/
        /// <summary>
        /// Get the country information list for the continent code. <br/>
        /// 대륙코드에 대한 국가정보목록을 가져옵니다.
        /// </summary>
        /// <param name="continentCode"></param>
        /// <returns></returns>
        /*******************************************************************/
        public static IEnumerable<CountryInfo> GetCountryInfoForContinentCode(ContinentCode continentCode)
            => GetCountryInfoListCore((country) => country.ContinentCode == continentCode);


        static Country()
        {
            AddInfoForAF();
            AddInfoForAL();
            AddInfoForDZ();
            AddInfoForAS();
            AddInfoForAD();
            AddInfoForAO();
            AddInfoForAI();
            AddInfoForAQ();
            AddInfoForAG();
            AddInfoForAR();
            AddInfoForAM();
            AddInfoForAW();
            AddInfoForAU();
            AddInfoForAT();
            AddInfoForAZ();
            AddInfoForBS();
            AddInfoForBH();
            AddInfoForBD();
            AddInfoForBB();
            AddInfoForBY();
            AddInfoForBE();
            AddInfoForBZ();
            AddInfoForBJ();
            AddInfoForBM();
            AddInfoForBT();
            AddInfoForBO();
            AddInfoForBQ();
            AddInfoForBA();
            AddInfoForBW();
            AddInfoForBV();
            AddInfoForBR();
            AddInfoForIO();
            AddInfoForBN();
            AddInfoForBG();
            AddInfoForBF();
            AddInfoForBI();
            AddInfoForCV();
            AddInfoForKH();
            AddInfoForCM();
            AddInfoForCA();
            AddInfoForKY();
            AddInfoForCF();
            AddInfoForTD();
            AddInfoForCL();
            AddInfoForCN();
            AddInfoForCX();
            AddInfoForCC();
            AddInfoForCO();
            AddInfoForKM();
            AddInfoForCG();
            AddInfoForCD();
            AddInfoForCK();
            AddInfoForCR();
            AddInfoForCI();
            AddInfoForHR();
            AddInfoForCU();
            AddInfoForCW();
            AddInfoForCY();
            AddInfoForCZ();
            AddInfoForDK();
            AddInfoForDJ();
            AddInfoForDM();
            AddInfoForDO();
            AddInfoForEC();
            AddInfoForEG();
            AddInfoForSV();
            AddInfoForGQ();
            AddInfoForER();
            AddInfoForEE();
            AddInfoForSZ();
            AddInfoForET();
            AddInfoForFK();
            AddInfoForFO();
            AddInfoForFJ();
            AddInfoForFI();
            AddInfoForFR();
            AddInfoForGF();
            AddInfoForPF();
            AddInfoForTF();
            AddInfoForGA();
            AddInfoForGM();
            AddInfoForGE();
            AddInfoForDE();
            AddInfoForGH();
            AddInfoForGI();
            AddInfoForGR();
            AddInfoForGL();
            AddInfoForGD();
            AddInfoForGP();
            AddInfoForGU();
            AddInfoForGT();
            AddInfoForGG();
            AddInfoForGN();
            AddInfoForGW();
            AddInfoForGY();
            AddInfoForHT();
            AddInfoForHM();
            AddInfoForVA();
            AddInfoForHN();
            AddInfoForHK();
            AddInfoForHU();
            AddInfoForIS();
            AddInfoForIN();
            AddInfoForID();
            AddInfoForIR();
            AddInfoForIQ();
            AddInfoForIE();
            AddInfoForIM();
            AddInfoForIL();
            AddInfoForIT();
            AddInfoForJM();
            AddInfoForJP();
            AddInfoForJE();
            AddInfoForJO();
            AddInfoForKZ();
            AddInfoForKE();
            AddInfoForKI();
            AddInfoForKP();
            AddInfoForKR();
            AddInfoForKW();
            AddInfoForKG();
            AddInfoForLA();
            AddInfoForLV();
            AddInfoForLB();
            AddInfoForLS();
            AddInfoForLR();
            AddInfoForLY();
            AddInfoForLI();
            AddInfoForLT();
            AddInfoForLU();
            AddInfoForMO();
            AddInfoForMG();
            AddInfoForMW();
            AddInfoForMY();
            AddInfoForMV();
            AddInfoForML();
            AddInfoForMT();
            AddInfoForMH();
            AddInfoForMQ();
            AddInfoForMR();
            AddInfoForMU();
            AddInfoForYT();
            AddInfoForMX();
            AddInfoForFM();
            AddInfoForMD();
            AddInfoForMC();
            AddInfoForMN();
            AddInfoForME();
            AddInfoForMS();
            AddInfoForMA();
            AddInfoForMZ();
            AddInfoForMM();
            AddInfoForNA();
            AddInfoForNR();
            AddInfoForNP();
            AddInfoForNL();
            AddInfoForNC();
            AddInfoForNZ();
            AddInfoForNI();
            AddInfoForNE();
            AddInfoForNG();
            AddInfoForNU();
            AddInfoForNF();
            AddInfoForMP();
            AddInfoForMK();
            AddInfoForNO();
            AddInfoForOM();
            AddInfoForPK();
            AddInfoForPW();
            AddInfoForPS();
            AddInfoForPA();
            AddInfoForPG();
            AddInfoForPY();
            AddInfoForPE();
            AddInfoForPH();
            AddInfoForPN();
            AddInfoForPL();
            AddInfoForPT();
            AddInfoForPR();
            AddInfoForQA();
            AddInfoForRE();
            AddInfoForRO();
            AddInfoForRU();
            AddInfoForRW();
            AddInfoForBL();
            AddInfoForSH();
            AddInfoForKN();
            AddInfoForLC();
            AddInfoForMF();
            AddInfoForPM();
            AddInfoForVC();
            AddInfoForWS();
            AddInfoForSM();
            AddInfoForST();
            AddInfoForSA();
            AddInfoForSN();
            AddInfoForRS();
            AddInfoForSC();
            AddInfoForSL();
            AddInfoForSG();
            AddInfoForSX();
            AddInfoForSK();
            AddInfoForSI();
            AddInfoForSB();
            AddInfoForSO();
            AddInfoForZA();
            AddInfoForGS();
            AddInfoForSS();
            AddInfoForES();
            AddInfoForLK();
            AddInfoForSD();
            AddInfoForSR();
            AddInfoForSJ();
            AddInfoForSE();
            AddInfoForCH();
            AddInfoForSY();
            AddInfoForTW();
            AddInfoForTJ();
            AddInfoForTZ();
            AddInfoForTH();
            AddInfoForTL();
            AddInfoForTG();
            AddInfoForTK();
            AddInfoForTO();
            AddInfoForTT();
            AddInfoForTN();
            AddInfoForTR();
            AddInfoForTM();
            AddInfoForTC();
            AddInfoForTV();
            AddInfoForUG();
            AddInfoForUA();
            AddInfoForAE();
            AddInfoForGB();
            AddInfoForUS();
            AddInfoForUM();
            AddInfoForUY();
            AddInfoForUZ();
            AddInfoForVU();
            AddInfoForVE();
            AddInfoForVN();
            AddInfoForVG();
            AddInfoForVI();
            AddInfoForWF();
            AddInfoForEH();
            AddInfoForYE();
            AddInfoForZM();
            AddInfoForZW();
            AddInfoForAX();
        }


        /*************************************************/
        /// <summary>
        /// It is add the information for the alpha2 code "LT". <br/>
        /// Alpha2Cod2 LT 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForAF()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.AF, "AF", "AFG", "004", ContinentCode.AS, new MobileInfo(412, mncList)));
        }

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

        static void AddInfoForDZ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.DZ, "DZ", "DZA", "012", ContinentCode.AF, new MobileInfo(603, mncList)));
        }

        static void AddInfoForAS()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.AS, "AS", "ASM", "016", ContinentCode.OC, new MobileInfo(544, mncList)));
        }

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

        static void AddInfoForAO()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.AO, "AO", "AGO", "024", ContinentCode.AF, new MobileInfo(631, mncList)));
        }

        static void AddInfoForAI()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("010", "", "Digicel", OperStatus.Operational,
                                                                                                BandType.GSM850,
                                                                                                BandType.UMTS850,
                                                                                                BandType.UMTS1900,
                                                                                                BandType.LTE700));

            mncList.Add(new MNCInfo("840", "FLOW", "Cable & Wireless", OperStatus.Operational,
                                                                                                BandType.GSM850,
                                                                                                BandType.UMTS850,
                                                                                                BandType.UMTS1900,
                                                                                                BandType.LTE700));

            _countries.Add(new CountryInfo(Resources.AI, "AI", "AIA", "660", ContinentCode.NA, new MobileInfo(365, mncList)));
        }

        static void AddInfoForAQ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.AQ, "AQ", "ATA", "010", ContinentCode.AN, new MobileInfo(672, mncList)));
        }

        static void AddInfoForAG()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("030", "APUA", "Antigua Public Utilities Authority", OperStatus.Operational,
                                                                                               BandType.GSM1900));

            mncList.Add(new MNCInfo("050", "Digicel", "Antigua Wireless Ventures Limited", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE700));

            mncList.Add(new MNCInfo("920", "FLOW", "Cable & Wireless Caribbean Cellular (Antigua) Limited", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1800,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE1700));

            mncList.Add(new MNCInfo("930", "", "AT&T Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            _countries.Add(new CountryInfo(Resources.AG, "AG", "ATG", "028", ContinentCode.NA, new MobileInfo(344, mncList)));
        }

        static void AddInfoForAR()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.AR, "AR", "ARG", "032", ContinentCode.SA, new MobileInfo(722, mncList)));
        }

        static void AddInfoForAM()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Beeline", "Veon Armenia CJSC", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE450,
                                                                                               BandType.LTE800));

            mncList.Add(new MNCInfo("04", "Karabakh Telecom", "Karabakh Telecom", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS900));

            mncList.Add(new MNCInfo("05", "VivaCell-MTS", "K Telecom CJSC", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("10", "Ucom", "Ucom LLC", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600));

            _countries.Add(new CountryInfo(Resources.AM, "AM", "ARM", "051", ContinentCode.AS, new MobileInfo(283, mncList)));
        }

        static void AddInfoForAW()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "SETAR", "Servicio di Telecomunicacion di Aruba", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.TDMA800));

            mncList.Add(new MNCInfo("02", "	Digicel", "Digicel Aruba", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            _countries.Add(new CountryInfo(Resources.AW, "AW", "ABW", "533", ContinentCode.NA, new MobileInfo(363, mncList)));
        }

        static void AddInfoForAU()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.AU, "AU", "AUS", "036", ContinentCode.OC, new MobileInfo(505, mncList)));
        }

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

        static void AddInfoForAZ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.AZ, "AZ", "AZE", "031", ContinentCode.AS, new MobileInfo(400, mncList)));
        }

        static void AddInfoForBS()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.BS, "BS", "BHS", "044", ContinentCode.NA, new MobileInfo(364, mncList)));
        }

        static void AddInfoForBH()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.BH, "BH", "BHR", "048", ContinentCode.AS, new MobileInfo(426, mncList)));
        }

        static void AddInfoForBD()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.BD, "BD", "BGD", "050", ContinentCode.AS, new MobileInfo(470, mncList)));
        }

        static void AddInfoForBB()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.BB, "BB", "BRB", "052", ContinentCode.NA, new MobileInfo(342, mncList)));
        }

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

        static void AddInfoForBZ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.BZ, "BZ", "BLZ", "084", ContinentCode.NA, new MobileInfo(702, mncList)));
        }

        static void AddInfoForBJ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.BJ, "BJ", "BEN", "204", ContinentCode.AF, new MobileInfo(616, mncList)));
        }

        static void AddInfoForBM()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.BM, "BM", "BMU", "060", ContinentCode.NA, new MobileInfo(350, mncList)));
        }

        static void AddInfoForBT()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.BT, "BT", "BTN", "064", ContinentCode.AS, new MobileInfo(402, mncList)));
        }

        static void AddInfoForBO()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.BO, "BO", "BOL", "068", ContinentCode.SA, new MobileInfo(736, mncList)));
        }

        static void AddInfoForBQ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.BQ, "BQ", "BES", "535", ContinentCode.SA, new MobileInfo(362, mncList)));
        }

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

        static void AddInfoForBW()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.BW, "BW", "BWA", "072", ContinentCode.AF, new MobileInfo(652, mncList)));
        }

        static void AddInfoForBV()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.BV, "BV", "BVT", "074", ContinentCode.AN, new MobileInfo(257, mncList)));
        }

        static void AddInfoForBR()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.BR, "BR", "BRA", "076", ContinentCode.SA, new MobileInfo(724, mncList)));
        }

        static void AddInfoForIO()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.IO, "IO", "IOT", "086", ContinentCode.AS, new MobileInfo(995, mncList)));
        }

        static void AddInfoForBN()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.BN, "BN", "BRN", "096", ContinentCode.AS, new MobileInfo(528, mncList)));
        }

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

        static void AddInfoForBF()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.BF, "BF", "BFA", "854", ContinentCode.AF, new MobileInfo(613, mncList)));
        }

        static void AddInfoForBI()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.BI, "BI", "BDI", "108", ContinentCode.AF, new MobileInfo(642, mncList)));
        }

        static void AddInfoForCV()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.CV, "CV", "CPV", "132", ContinentCode.AF, new MobileInfo(625, mncList)));
        }

        static void AddInfoForKH()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.KH, "KH", "KHM", "116", ContinentCode.AS, new MobileInfo(456, mncList)));
        }

        static void AddInfoForCM()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            
            _countries.Add(new CountryInfo(Resources.CM, "CM", "CMR", "120", ContinentCode.AF, new MobileInfo(624, mncList)));
        }

        static void AddInfoForCA()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.CA, "CA", "CAN", "124", ContinentCode.NA, new MobileInfo(302, mncList)));
        }

        static void AddInfoForKY()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.KY, "KY", "CYM", "136", ContinentCode.NA, new MobileInfo(346, mncList)));
        }

        static void AddInfoForCF()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.CF, "CF", "CAF", "140", ContinentCode.AF, new MobileInfo(623, mncList)));
        }

        static void AddInfoForTD()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.TD, "TD", "TCD", "148", ContinentCode.AF, new MobileInfo(622, mncList)));
        }

        static void AddInfoForCL()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.CL, "CL", "CHL", "152", ContinentCode.SA, new MobileInfo(730, mncList)));
        }

        static void AddInfoForCN()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.CN, "CN", "CHN", "156", ContinentCode.AS, new MobileInfo(460, mncList)));
        }

        static void AddInfoForCX()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.CX, "CX", "CXR", "162", ContinentCode.AS, new MobileInfo(505, mncList)));
        }

        static void AddInfoForCC()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.CC, "CC", "CCK", "166", ContinentCode.AS));
        }

        static void AddInfoForCO()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.CO, "CO", "COL", "170", ContinentCode.SA, new MobileInfo(732, mncList)));
        }

        static void AddInfoForKM()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.KM, "KM", "COM", "174", ContinentCode.AF, new MobileInfo(654, mncList)));
        }

        static void AddInfoForCG()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.CG, "CG", "COG", "178", ContinentCode.AF, new MobileInfo(629, mncList)));
        }

        static void AddInfoForCD()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.CD, "CD", "COD", "180", ContinentCode.AF, new MobileInfo(630, mncList)));
        }

        static void AddInfoForCK()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.CK, "CK", "COK", "184", ContinentCode.OC, new MobileInfo(548, mncList)));
        }

        static void AddInfoForCR()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.CR, "CR", "CRI", "188", ContinentCode.NA, new MobileInfo(712, mncList)));
        }

        static void AddInfoForCI()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.CI, "CI", "CIV", "384", ContinentCode.AF, new MobileInfo(612, mncList)));
        }

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

        static void AddInfoForCU()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.CU, "CU", "CUB", "192", ContinentCode.NA, new MobileInfo(368, mncList)));
        }

        static void AddInfoForCW()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.CW, "CW", "CUW", "531", ContinentCode.SA, new MobileInfo(362, mncList)));
        }

        static void AddInfoForCY()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Cytamobile-Vodafone", "Cyprus Telecommunications Authority", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600,
                                                                                              BandType.FiveG700,
                                                                                              BandType.FiveG3500));

            mncList.Add(new MNCInfo("02", "Cytamobile-Vodafone", "Cyprus Telecommunications Authority", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("10", "Epic", "Monaco Telecom", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.GSM1800,
                                                                                              BandType.UMTS900,
                                                                                              BandType.UMTS2100,
                                                                                              BandType.LTE800,
                                                                                              BandType.LTE1800,
                                                                                              BandType.LTE2600));

            mncList.Add(new MNCInfo("20", "PrimeTel", "PrimeTel PLC", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("22", "lemontel", "Lemontel Ltd", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("23", "Vectone Mobile", "Mundio Mobile Cyprus Ltd.", OperStatus.Not_Operational,
                                                                                              BandType.MVNO));

            _countries.Add(new CountryInfo(Resources.CY, "CY", "CYP", "196", ContinentCode.AS, new MobileInfo(280, mncList)));
        }

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

        static void AddInfoForDJ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.DJ, "DJ", "DJI", "262", ContinentCode.AF, new MobileInfo(638, mncList)));
        }

        static void AddInfoForDM()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.DM, "DM", "DMA", "212", ContinentCode.NA, new MobileInfo(366, mncList)));
        }

        static void AddInfoForDO()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.DO, "DO", "DOM", "214", ContinentCode.NA, new MobileInfo(370, mncList)));
        }
        static void AddInfoForEC()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.EC, "EC", "ECU", "218", ContinentCode.SA, new MobileInfo(740, mncList)));
        }

        static void AddInfoForEG()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.EG, "EG", "EGY", "818", ContinentCode.AF, new MobileInfo(602, mncList)));
        }

        static void AddInfoForSV()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.SV, "SV", "SLV", "222", ContinentCode.NA, new MobileInfo(706, mncList)));
        }

        static void AddInfoForGQ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.GQ, "GQ", "GNQ", "226", ContinentCode.AF, new MobileInfo(627, mncList)));
        }

        static void AddInfoForER()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.ER, "ER", "ERI", "232", ContinentCode.AF, new MobileInfo(657, mncList)));
        }

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

        static void AddInfoForSZ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.SZ, "SZ", "SWZ", "748", ContinentCode.AF, new MobileInfo(653, mncList)));
        }

        static void AddInfoForET()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.ET, "ET", "ETH", "231", ContinentCode.AF, new MobileInfo(636, mncList)));
        }

        static void AddInfoForFK()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.FK, "FK", "FLK", "238", ContinentCode.SA, new MobileInfo(750, mncList)));
        }

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

        static void AddInfoForFJ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.FJ, "FJ", "FJI", "242", ContinentCode.OC, new MobileInfo(542, mncList)));
        }

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

        static void AddInfoForGF()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.GF, "GF", "GUF", "254", ContinentCode.SA, new MobileInfo(742, mncList)));
        }

        static void AddInfoForPF()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.PF, "PF", "PYF", "258", ContinentCode.OC, new MobileInfo(547, mncList)));
        }

        static void AddInfoForTF()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.TF, "TF", "ATF", "260", ContinentCode.AN));
        }


        static void AddInfoForGA()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.GA, "GA", "GAB", "266", ContinentCode.AF, new MobileInfo(628, mncList)));
        }

        static void AddInfoForGM()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.GM, "GM", "GMB", "270", ContinentCode.AF, new MobileInfo(607, mncList)));
        }

        static void AddInfoForGE()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.GE, "GE", "GEO", "268", ContinentCode.AS, new MobileInfo(282, mncList)));
        }

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

            mncList.Add(new MNCInfo("42", "CCC Event", "Chaos Computer Club", OperStatus.Temporaryoperational,
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

        static void AddInfoForGH()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.GH, "GH", "GHA", "288", ContinentCode.AF, new MobileInfo(620, mncList)));
        }

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

        static void AddInfoForGL()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "", "TELE Greenland A/S", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900,
                                                                                              BandType.LTE800));

            mncList.Add(new MNCInfo("02", "Nanoq Media", "inu:it a/s", OperStatus.Operational,
                                                                                              BandType.TDLTE2500));

            _countries.Add(new CountryInfo(Resources.GL, "GL", "GRL", "304", ContinentCode.NA, new MobileInfo(290, mncList)));
        }

        static void AddInfoForGD()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.GD, "GD", "GRD", "308", ContinentCode.NA, new MobileInfo(352, mncList)));
        }

        static void AddInfoForGP()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.GP, "GP", "GLP", "312", ContinentCode.NA, new MobileInfo(340, mncList)));
        }

        static void AddInfoForGU()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.GU, "GU", "GUM", "316", ContinentCode.OC, new MobileInfo(310, mncList), new MobileInfo(311, mncList)));
        }

        static void AddInfoForGT()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.GT, "GT", "GTM", "320", ContinentCode.NA, new MobileInfo(704, mncList)));
        }

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

        static void AddInfoForGN()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.GN, "GN", "GIN", "324", ContinentCode.AF, new MobileInfo(611, mncList)));
        }

        static void AddInfoForGW()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.GW, "GW", "GNB", "624", ContinentCode.AF, new MobileInfo(632, mncList)));
        }

        static void AddInfoForGY()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.GY, "GY", "GUY", "328", ContinentCode.SA, new MobileInfo(738, mncList)));
        }

        static void AddInfoForHT()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.HT, "HT", "HTI", "332", ContinentCode.NA, new MobileInfo(372, mncList)));
        }

        static void AddInfoForHM()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.HM, "HM", "HMD", "334", ContinentCode.AN));
        }

        static void AddInfoForVA()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.VA, "VA", "VAT", "336", ContinentCode.EU));
        }

        static void AddInfoForHN()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.HN, "HN", "HND", "340", ContinentCode.NA, new MobileInfo(708, mncList)));
        }

        static void AddInfoForHK()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.HK, "HK", "HKG", "344", ContinentCode.AS, new MobileInfo(454, mncList)));
        }

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

        static void AddInfoForIN()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.IN, "IN", "IND", "356", ContinentCode.AS, new MobileInfo(404, mncList), new MobileInfo(405, mncList), new MobileInfo(406, mncList)));
        }

        static void AddInfoForID()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.ID, "ID", "IDN", "360", ContinentCode.AS, new MobileInfo(510, mncList)));
        }

        static void AddInfoForIR()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.IR, "IR", "IRN", "364", ContinentCode.AS, new MobileInfo(432, mncList)));
        }

        static void AddInfoForIQ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.IQ, "IQ", "IRQ", "368", ContinentCode.AS, new MobileInfo(418, mncList)));
        }

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

        static void AddInfoForIL()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.IL, "IL", "ISR", "376", ContinentCode.AS, new MobileInfo(425, mncList)));
        }

        static void AddInfoForJM()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.JM, "JM", "JAM", "388", ContinentCode.NA, new MobileInfo(338, mncList)));
        }

        static void AddInfoForJP()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.JP, "JP", "JPN", "392", ContinentCode.AS, new MobileInfo(440, mncList), new MobileInfo(441, mncList)));
        }

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

        static void AddInfoForJO()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.JO, "JO", "JOR", "400", ContinentCode.AS, new MobileInfo(416, mncList)));
        }

        static void AddInfoForKZ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.KZ, "KZ", "KAZ", "398", ContinentCode.AS, new MobileInfo(401, mncList)));
        }

        static void AddInfoForKE()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.KE, "KE", "KEN", "404", ContinentCode.AF, new MobileInfo(639, mncList)));
        }

        static void AddInfoForKI()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.KI, "KI", "KIR", "296", ContinentCode.OC, new MobileInfo(545, mncList)));
        }

        static void AddInfoForKP()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.KP, "KP", "PRK", "408", ContinentCode.AS, new MobileInfo(467, mncList)));
        }

        static void AddInfoForKR()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.KR, "KR", "KOR", "410", ContinentCode.AS, new MobileInfo(450, mncList)));
        }

        static void AddInfoForKW()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.KW, "KW", "KWT", "414", ContinentCode.AS, new MobileInfo(419, mncList)));
        }

        static void AddInfoForKG()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.KG, "KG", "KGZ", "417", ContinentCode.AS, new MobileInfo(437, mncList)));
        }

        static void AddInfoForLA()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.LA, "LA", "LAO", "418", ContinentCode.AS, new MobileInfo(457, mncList)));
        }

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

            mncList.Add(new MNCInfo("07", "", "SIA MEGATEL", OperStatus.Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("08", "IZZI", "IZZI", OperStatus.Not_Operational,
                                                                                              BandType.MVNO));

            mncList.Add(new MNCInfo("09", "Xomobile", "Camel Mobile", OperStatus.Operational,
                                                                                              BandType.MVNO));

            _countries.Add(new CountryInfo(Resources.LV, "LV", "LVA", "428", ContinentCode.EU, new MobileInfo(247, mncList)));
        }

        static void AddInfoForLB()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.LB, "LB", "LBN", "422", ContinentCode.AS, new MobileInfo(415, mncList)));
        }

        static void AddInfoForLS()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.LS, "LS", "LSO", "426", ContinentCode.AF, new MobileInfo(651, mncList)));
        }

        static void AddInfoForLR()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.LR, "LR", "LBR", "430", ContinentCode.AF, new MobileInfo(618, mncList)));
        }

        static void AddInfoForLY()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.LY, "LY", "LBY", "434", ContinentCode.AF, new MobileInfo(606, mncList)));
        }

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

        static void AddInfoForMO()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.MO, "MO", "MAC", "446", ContinentCode.AS, new MobileInfo(455, mncList)));
        }

        static void AddInfoForMG()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.MG, "MG", "MDG", "450", ContinentCode.AF, new MobileInfo(646, mncList)));
        }

        static void AddInfoForMW()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.MW, "MW", "MWI", "454", ContinentCode.AF, new MobileInfo(650, mncList)));
        }

        static void AddInfoForMY()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.MY, "MY", "MYS", "458", ContinentCode.AS, new MobileInfo(502, mncList)));
        }

        static void AddInfoForMV()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.MV, "MV", "MDV", "462", ContinentCode.AS, new MobileInfo(472, mncList)));
        }

        static void AddInfoForML()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.ML, "ML", "MLI", "466", ContinentCode.AF, new MobileInfo(610, mncList)));
        }

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

        static void AddInfoForMH()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.MH, "MH", "MHL", "584", ContinentCode.OC, new MobileInfo(551, mncList)));
        }

        static void AddInfoForMQ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.MQ, "MQ", "MTQ", "474", ContinentCode.NA, new MobileInfo(340, mncList)));
        }

        static void AddInfoForMR()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.MR, "MR", "MRT", "478", ContinentCode.AF, new MobileInfo(609, mncList)));
        }

        static void AddInfoForMU()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.MU, "MU", "MUS", "480", ContinentCode.AF, new MobileInfo(617, mncList)));
        }

        static void AddInfoForYT()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.YT, "YT", "MYT", "175", ContinentCode.AF));
        }

        static void AddInfoForMX()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.MX, "MX", "MEX", "484", ContinentCode.NA, new MobileInfo(334, mncList)));
        }

        static void AddInfoForFM()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.FM, "FM", "FSM", "583", ContinentCode.OC, new MobileInfo(550, mncList)));
        }

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

        static void AddInfoForMN()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.MN, "MN", "MNG", "496", ContinentCode.AS, new MobileInfo(428, mncList)));
        }

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

        static void AddInfoForMS()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.MS, "MS", "MSR", "500", ContinentCode.NA, new MobileInfo(354, mncList)));
        }

        static void AddInfoForMA()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.MA, "MA", "MAR", "504", ContinentCode.AF, new MobileInfo(604, mncList)));
        }

        static void AddInfoForMZ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.MZ, "MZ", "MOZ", "508", ContinentCode.AF, new MobileInfo(643, mncList)));
        }

        static void AddInfoForMM()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.MM, "MM", "MMR", "104", ContinentCode.AS, new MobileInfo(414, mncList)));
        }

        static void AddInfoForNA()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.NA, "NA", "NAM", "516", ContinentCode.AF, new MobileInfo(649, mncList)));
        }

        static void AddInfoForNR()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.NR, "NR", "NRU", "520", ContinentCode.OC, new MobileInfo(536, mncList)));
        }

        static void AddInfoForNP()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.NP, "NP", "NPL", "524", ContinentCode.AS, new MobileInfo(429, mncList)));
        }

        static void AddInfoForNL()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            mncList.Add(new MNCInfo("00", "", "", OperStatus.Unknown,
                                                                                              BandType.Unknown));

            _countries.Add(new CountryInfo(Resources.NL, "NL", "NLD", "528", ContinentCode.EU, new MobileInfo(204, mncList)));
        }

        static void AddInfoForNC()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.NC, "NC", "NCL", "540", ContinentCode.OC, new MobileInfo(546, mncList)));
        }

        static void AddInfoForNZ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.NZ, "NZ", "NZL", "554", ContinentCode.OC, new MobileInfo(530, mncList)));
        }

        static void AddInfoForNI()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.NI, "NI", "NIC", "558", ContinentCode.NA, new MobileInfo(710, mncList)));
        }

        static void AddInfoForNE()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.NE, "NE", "NER", "562", ContinentCode.AF, new MobileInfo(614, mncList)));
        }

        static void AddInfoForNG()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.NG, "NG", "NGA", "566", ContinentCode.AF, new MobileInfo(621, mncList)));
        }

        static void AddInfoForNU()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.NU, "NU", "NIU", "570", ContinentCode.OC, new MobileInfo(555, mncList)));
        }

        static void AddInfoForNF()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.NF, "NF", "NFK", "574", ContinentCode.OC, new MobileInfo(505, mncList)));
        }

        static void AddInfoForMP()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.MP, "MP", "MNP", "580", ContinentCode.OC, new MobileInfo(310, mncList)));
        }

        static void AddInfoForMK()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.MK, "MK", "MKD", "807", ContinentCode.EU, new MobileInfo(294, mncList)));
        }

        static void AddInfoForNO()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.NO, "NO", "NOR", "578", ContinentCode.EU, new MobileInfo(242, mncList)));
        }

        static void AddInfoForOM()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.OM, "OM", "OMN", "512", ContinentCode.AS, new MobileInfo(422, mncList)));
        }

        static void AddInfoForPK()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.PK, "PK", "PAK", "586", ContinentCode.AS, new MobileInfo(410, mncList)));
        }

        static void AddInfoForPW()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.PW, "PW", "PLW", "585", ContinentCode.OC, new MobileInfo(552, mncList)));
        }

        static void AddInfoForPS()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.PS, "PS", "PSE", "275", ContinentCode.AS, new MobileInfo(425, mncList)));
        }

        static void AddInfoForPA()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.PA, "PA", "PAN", "591", ContinentCode.NA, new MobileInfo(714, mncList)));
        }

        static void AddInfoForPG()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.PG, "PG", "PNG", "598", ContinentCode.OC, new MobileInfo(537, mncList)));
        }

        static void AddInfoForPY()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.PY, "PY", "PRY", "600", ContinentCode.SA, new MobileInfo(744, mncList)));
        }

        static void AddInfoForPE()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.PE, "PE", "PER", "604", ContinentCode.SA, new MobileInfo(716, mncList)));
        }

        static void AddInfoForPH()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.PH, "PH", "PHL", "608", ContinentCode.AS, new MobileInfo(515, mncList)));
        }

        static void AddInfoForPN()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.PN, "PN", "PCN", "612", ContinentCode.OC));
        }

        static void AddInfoForPL()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.PL, "PL", "POL", "616", ContinentCode.EU, new MobileInfo(260, mncList)));
        }

        static void AddInfoForPT()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.PT, "PT", "PRT", "620", ContinentCode.EU, new MobileInfo(268, mncList)));
        }

        static void AddInfoForPR()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.PR, "PR", "PRI", "630", ContinentCode.NA, new MobileInfo(330, mncList)));
        }

        static void AddInfoForQA()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.QA, "QA", "QAT", "634", ContinentCode.AS, new MobileInfo(427, mncList)));
        }

        static void AddInfoForRE()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.RE, "RE", "REU", "638", ContinentCode.AF, new MobileInfo(647, mncList)));
        }

        static void AddInfoForRO()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.RO, "RO", "ROU", "642", ContinentCode.EU, new MobileInfo(226, mncList)));
        }

        static void AddInfoForRU()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.RU, "RU", "RUS", "643", ContinentCode.EU, new MobileInfo(250, mncList)));
        }

        static void AddInfoForRW()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.RW, "RW", "RWA", "646", ContinentCode.AF, new MobileInfo(635, mncList)));
        }

        static void AddInfoForBL()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.BL, "BL", "BLM", "652", ContinentCode.NA, new MobileInfo(340, mncList)));
        }

        static void AddInfoForSH()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.SH, "SH", "SHN", "654", ContinentCode.AF, new MobileInfo(658, mncList)));
        }

        static void AddInfoForKN()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.KN, "KN", "KNA", "659", ContinentCode.NA, new MobileInfo(356, mncList)));
        }

        static void AddInfoForLC()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.LC, "LC", "LCA", "662", ContinentCode.NA, new MobileInfo(358, mncList)));
        }

        static void AddInfoForMF()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.MF, "MF", "MAF", "663", ContinentCode.NA, new MobileInfo(340, mncList)));
        }

        static void AddInfoForPM()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.PM, "PM", "SPM", "666", ContinentCode.NA, new MobileInfo(308, mncList)));
        }

        static void AddInfoForVC()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.VC, "VC", "VCT", "670", ContinentCode.NA, new MobileInfo(360, mncList)));
        }

        static void AddInfoForWS()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.WS, "WS", "WSM", "882", ContinentCode.OC, new MobileInfo(549, mncList)));
        }

        static void AddInfoForSM()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.SM, "SM", "SMR", "674", ContinentCode.EU, new MobileInfo(292, mncList)));
        }

        static void AddInfoForST()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.ST, "ST", "STP", "678", ContinentCode.AF, new MobileInfo(626, mncList)));
        }

        static void AddInfoForSA()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.SA, "SA", "SAU", "682", ContinentCode.AS, new MobileInfo(420, mncList)));
        }

        static void AddInfoForSN()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.SN, "SN", "SEN", "686", ContinentCode.AF, new MobileInfo(608, mncList)));
        }

        static void AddInfoForRS()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.RS, "RS", "SRB", "688", ContinentCode.EU, new MobileInfo(220, mncList)));
        }

        static void AddInfoForSC()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.SC, "SC", "SYC", "690", ContinentCode.AF, new MobileInfo(633, mncList)));
        }

        static void AddInfoForSL()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.SL, "SL", "SLE", "694", ContinentCode.AF, new MobileInfo(619, mncList)));
        }

        static void AddInfoForSG()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.SG, "SG", "SGP", "702", ContinentCode.AS, new MobileInfo(525, mncList)));
        }

        static void AddInfoForSX()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.SX, "SX", "SXM", "534", ContinentCode.NA, new MobileInfo(362, mncList)));
        }

        static void AddInfoForSK()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.SK, "SK", "SVK", "703", ContinentCode.EU, new MobileInfo(231, mncList)));
        }

        static void AddInfoForSI()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.SI, "SI", "SVN", "705", ContinentCode.EU, new MobileInfo(293, mncList)));
        }

        static void AddInfoForSB()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.SB, "SB", "SLB", "090", ContinentCode.OC, new MobileInfo(540, mncList)));
        }

        static void AddInfoForSO()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.SO, "SO", "SOM", "706", ContinentCode.AF, new MobileInfo(637, mncList)));
        }

        static void AddInfoForZA()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.ZA, "ZA", "ZAF", "710", ContinentCode.AF, new MobileInfo(655, mncList)));
        }

        static void AddInfoForGS()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.GS, "GS", "SGS", "239", ContinentCode.AN));
        }

        static void AddInfoForSS()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.SS, "SS", "SSD", "728", ContinentCode.AF, new MobileInfo(659, mncList)));
        }

        static void AddInfoForES()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.ES, "ES", "ESP", "724", ContinentCode.EU, new MobileInfo(214, mncList)));
        }

        static void AddInfoForLK()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.LK, "LK", "LKA", "144", ContinentCode.AS, new MobileInfo(413, mncList)));
        }

        static void AddInfoForSD()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.SD, "SD", "SDN", "729", ContinentCode.AF, new MobileInfo(634, mncList)));
        }

        static void AddInfoForSR()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.SR, "SR", "SUR", "740", ContinentCode.SA, new MobileInfo(746, mncList)));
        }

        static void AddInfoForSJ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.SJ, "SJ", "SJM", "744", ContinentCode.EU));
        }

        static void AddInfoForSE()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.SE, "SE", "SWE", "752", ContinentCode.EU, new MobileInfo(240, mncList)));
        }

        static void AddInfoForCH()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.CH, "CH", "CHE", "756", ContinentCode.EU, new MobileInfo(228, mncList)));
        }

        static void AddInfoForSY()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.SY, "SY", "SYR", "760", ContinentCode.AS, new MobileInfo(417, mncList)));
        }

        static void AddInfoForTW()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.TW, "TW", "TWN", "158", ContinentCode.AS, new MobileInfo(466, mncList)));
        }

        static void AddInfoForTJ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.TJ, "TJ", "TJK", "762", ContinentCode.AS, new MobileInfo(436, mncList)));
        }

        static void AddInfoForTZ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.TZ, "TZ", "TZA", "834", ContinentCode.AF, new MobileInfo(640, mncList)));
        }

        static void AddInfoForTH()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.TH, "TH", "THA", "764", ContinentCode.AS, new MobileInfo(520, mncList)));
        }

        static void AddInfoForTL()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.TL, "TL", "TLS", "626", ContinentCode.AS));
        }

        static void AddInfoForTG()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.TG, "TG", "TGO", "768", ContinentCode.AF, new MobileInfo(615, mncList)));
        }

        static void AddInfoForTK()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.TK, "TK", "TKL", "772", ContinentCode.OC, new MobileInfo(554, mncList)));
        }

        static void AddInfoForTO()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.TO, "TO", "TON", "776", ContinentCode.OC, new MobileInfo(539, mncList)));
        }

        static void AddInfoForTT()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.TT, "TT", "TTO", "780", ContinentCode.NA, new MobileInfo(374, mncList)));
        }

        static void AddInfoForTN()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.TN, "TN", "TUN", "788", ContinentCode.AF, new MobileInfo(605, mncList)));
        }

        static void AddInfoForTR()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.TR, "TR", "TUR", "792", ContinentCode.EU, new MobileInfo(286, mncList)));
        }

        static void AddInfoForTM()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.TM, "TM", "TKM", "795", ContinentCode.AS, new MobileInfo(438, mncList)));
        }

        static void AddInfoForTC()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.TC, "TC", "TCA", "796", ContinentCode.NA, new MobileInfo(376, mncList)));
        }

        static void AddInfoForTV()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.TV, "TV", "TUV", "798", ContinentCode.OC, new MobileInfo(553, mncList)));
        }

        static void AddInfoForUG()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.UG, "UG", "UGA", "800", ContinentCode.AF, new MobileInfo(641, mncList)));
        }

        static void AddInfoForUA()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.UA, "UA", "UKR", "804", ContinentCode.EU, new MobileInfo(255, mncList)));
        }

        static void AddInfoForAE()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.AE, "AE", "ARE", "784", ContinentCode.AS, new MobileInfo(424, mncList)));
        }

        static void AddInfoForGB()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.GB, "GB", "GBR", "826", ContinentCode.EU, new MobileInfo(234, mncList), new MobileInfo(235, mncList)));
        }

        static void AddInfoForUS()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.US, "US", "USA", "840", ContinentCode.NA, new MobileInfo(310, mncList),
                                                                                               new MobileInfo(311, mncList),
                                                                                               new MobileInfo(312, mncList),
                                                                                               new MobileInfo(313, mncList),
                                                                                               new MobileInfo(314, mncList),
                                                                                               new MobileInfo(315, mncList),
                                                                                               new MobileInfo(316, mncList)));
        }

        static void AddInfoForUM()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.UM, "UM", "UMI", "581", ContinentCode.OC));
        }

        static void AddInfoForUY()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.UY, "UY", "URY", "858", ContinentCode.SA, new MobileInfo(748, mncList)));
        }

        static void AddInfoForUZ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.UZ, "UZ", "UZB", "860", ContinentCode.AS, new MobileInfo(434, mncList)));
        }

        static void AddInfoForVU()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.VU, "VU", "VUT", "548", ContinentCode.OC, new MobileInfo(541, mncList)));
        }

        static void AddInfoForVE()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.VE, "VE", "VEN", "862", ContinentCode.SA, new MobileInfo(734, mncList)));
        }

        static void AddInfoForVN()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.VN, "VN", "VNM", "704", ContinentCode.AS, new MobileInfo(452, mncList)));
        }

        static void AddInfoForVG()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.VG, "VG", "VGB", "092", ContinentCode.NA, new MobileInfo(348, mncList)));
        }

        static void AddInfoForVI()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.VI, "VI", "VIR", "850", ContinentCode.NA, new MobileInfo(332, mncList)));
        }

        static void AddInfoForWF()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.WF, "WF", "WLF", "876", ContinentCode.OC, new MobileInfo(543, mncList)));
        }

        static void AddInfoForEH()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.EH, "EH", "ESH", "732", ContinentCode.AF));
        }

        static void AddInfoForYE()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.YE, "YE", "YEM", "887", ContinentCode.AS, new MobileInfo(421, mncList)));
        }

        static void AddInfoForZM()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.ZM, "ZM", "ZMB", "894", ContinentCode.AF, new MobileInfo(645, mncList)));
        }

        static void AddInfoForZW()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.ZW, "ZW", "ZWE", "716", ContinentCode.AF, new MobileInfo(648, mncList)));
        }

        static void AddInfoForAX()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.AX, "AX", "ALA", "248", ContinentCode.OC));
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
