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
        /// Add information for the alpha2 code "DZ". <br/>
        /// Alpha2Cod2 DZ 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForDZ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Mobilis", "Algérie Télécom", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("02", "Djezzy", "Optimum Telecom Algérie Spa", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("03", "Ooredoo", "Wataniya Telecom Algérie", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("07", "AT", "Algérie Télécom", OperStatus.Operational,
                                                                                           BandType.CDMA1900));

            mncList.Add(new MNCInfo("09", "AT", "Algérie Télécom", OperStatus.Operational,
                                                                                           BandType.LTE));

            mncList.Add(new MNCInfo("21", "ANESRIF", "Anesrif", OperStatus.Operational,
                                                                                           BandType.GSMR));

            _countries.Add(new CountryInfo(Resources.DZ, "DZ", "DZA", "012", ContinentCode.AF, new MobileInfo(603, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "AO". <br/>
        /// Alpha2Cod2 AO 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForAO()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("02", "UNITEL", "UNITEL S.a.r.l.", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("04", "MOVICEL", "MOVICEL Telecommunications S.A.", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS900,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("05", "", "Africell", OperStatus.Not_Operational,
                                                                                           BandType.Unknown));


            _countries.Add(new CountryInfo(Resources.AO, "AO", "AGO", "024", ContinentCode.AF, new MobileInfo(631, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "BJ". <br/>
        /// Alpha2Cod2 BJ 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForBJ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Libercom", "Benin Telecoms Mobile", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.LTE1800,
                                                                                           BandType.CDMA,
                                                                                           BandType.WiMAX));

            mncList.Add(new MNCInfo("02", "Moov", "Telecel Benin", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100));

            mncList.Add(new MNCInfo("03", "MTN", "Spacetel Benin", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("04", "BBCOM", "Bell Benin Communications", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800));

            mncList.Add(new MNCInfo("05", "Glo", "Glo Communication Benin", OperStatus.Not_Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800));

            _countries.Add(new CountryInfo(Resources.BJ, "BJ", "BEN", "204", ContinentCode.AF, new MobileInfo(616, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "BW". <br/>
        /// Alpha2Cod2 BW 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForBW()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Mascom", "Mascom Wireless (Pty) Limited", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("02", "Orange", "Orange (Botswana) Pty Limited", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800,
                                                                                           BandType.LTE2100,
                                                                                           BandType.TDLTE));

            mncList.Add(new MNCInfo("04", "beMobile", "Botswana Telecommunications Corporation", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            _countries.Add(new CountryInfo(Resources.BW, "BW", "BWA", "072", ContinentCode.AF, new MobileInfo(652, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "BF". <br/>
        /// Alpha2Cod2 BF 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForBF()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Telmob", "Onatel", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("02", "Orange", "Orange Burkina Faso", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("03", "Telecel Faso", "Telecel Faso SA", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.LTE1800));

            _countries.Add(new CountryInfo(Resources.BF, "BF", "BFA", "854", ContinentCode.AF, new MobileInfo(613, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "BI". <br/>
        /// Alpha2Cod2 BI 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForBI()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "econet Leo", "Econet Wireless Burundi PLC", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("02", "Tempo", "VTEL MEA", OperStatus.Not_Operational,
                                                                                           BandType.GSM900));

            mncList.Add(new MNCInfo("03", "Onatel", "Onatel", OperStatus.Operational,
                                                                                           BandType.GSM900));

            mncList.Add(new MNCInfo("07", "Smart Mobile", "LACELL SU", OperStatus.Operational,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100));

            mncList.Add(new MNCInfo("08", "Lumitel", "Viettel Burundi", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("82", "econet Leo", "Econet Wireless Burundi PLC", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100));

            _countries.Add(new CountryInfo(Resources.BI, "BI", "BDI", "108", ContinentCode.AF, new MobileInfo(642, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "CV". <br/>
        /// Alpha2Cod2 CV 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForCV()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "CVMOVEL", "CVMóvel, S.A.", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE800));

            mncList.Add(new MNCInfo("02", "T+", "UNITEL T+ TELECOMUNICACÕES, S.A.", OperStatus.Operational,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100));

            _countries.Add(new CountryInfo(Resources.CV, "CV", "CPV", "132", ContinentCode.AF, new MobileInfo(625, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "CM". <br/>
        /// Alpha2Cod2 CM 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForCM()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "MTN Cameroon", "Mobile Telephone Network Cameroon Ltd", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.TDLTE2500));

            mncList.Add(new MNCInfo("02", "Orange", "Orange Cameroun S.A.", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("03", "Camtel", "Camtel", OperStatus.Operational,
                                                                                           BandType.CDMA,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("04", "Nexttel", "Viettel Cameroun", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100));

            _countries.Add(new CountryInfo(Resources.CM, "CM", "CMR", "120", ContinentCode.AF, new MobileInfo(624, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "CF". <br/>
        /// Alpha2Cod2 CF 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForCF()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Moov", "Atlantique Telecom Centrafrique SA", OperStatus.Operational,
                                                                                           BandType.GSM900));

            mncList.Add(new MNCInfo("02", "TC", "Telecel Centrafrique", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100));

            mncList.Add(new MNCInfo("03", "Orange", "Orange RCA", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.WiMAX));

            mncList.Add(new MNCInfo("04", "Azur", "Azur RCA", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100));

            _countries.Add(new CountryInfo(Resources.CF, "CF", "CAF", "140", ContinentCode.AF, new MobileInfo(623, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "TD". <br/>
        /// Alpha2Cod2 TD 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForTD()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "	Airtel", "Bharti Airtel SA", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("02", "Tawali", "SotelTchad", OperStatus.Operational,
                                                                                           BandType.CDMA2000));

            mncList.Add(new MNCInfo("03", "Tigo", "Millicom", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE2600));

            mncList.Add(new MNCInfo("07", "Salam", "SotelTchad", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800));

            _countries.Add(new CountryInfo(Resources.TD, "TD", "TCD", "148", ContinentCode.AF, new MobileInfo(622, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "KM". <br/>
        /// Alpha2Cod2 KM 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForKM()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "HURI", "Comores Telecom", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS900));

            mncList.Add(new MNCInfo("02", "TELCO SA", "Telecom Malagasy (Telma)", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS900,
                                                                                           BandType.LTE800));

            _countries.Add(new CountryInfo(Resources.KM, "KM", "COM", "174", ContinentCode.AF, new MobileInfo(654, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "CG". <br/>
        /// Alpha2Cod2 CG 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForCG()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Airtel", "Celtel Congo", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE2600));

            mncList.Add(new MNCInfo("07", "Airtel", "Warid Telecom", OperStatus.Operational,
                                                                                           BandType.GSM900));

            mncList.Add(new MNCInfo("10", "Libertis Telecom", "MTN CONGO S.A", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE2600));

            _countries.Add(new CountryInfo(Resources.CG, "CG", "COG", "178", ContinentCode.AF, new MobileInfo(629, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "CD". <br/>
        /// Alpha2Cod2 CD 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForCD()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Vodacom", "Vodacom Congo RDC sprl", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.TDLTE3500,
                                                                                           BandType.WiMAX3500));

            mncList.Add(new MNCInfo("02", "Airtel", "Airtel sprl", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100));

            mncList.Add(new MNCInfo("05", "Supercell", "Supercell SPRL", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800));

            mncList.Add(new MNCInfo("86", "Orange RDC", "Orange RDC sarl", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.TDLTE2600));

            mncList.Add(new MNCInfo("88", "YTT", "Yozma Timeturns sprl", OperStatus.Not_Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800));

            mncList.Add(new MNCInfo("89", "Orange RDC", "Orange RDC sarl", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100));

            mncList.Add(new MNCInfo("90", "Africell", "Africell RDC sprl", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800));

            _countries.Add(new CountryInfo(Resources.CD, "CD", "COD", "180", ContinentCode.AF, new MobileInfo(630, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "CI". <br/>
        /// Alpha2Cod2 CI 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForCI()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "", "Cora de Comstar", OperStatus.Not_Operational,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("02", "Moov", "Atlantique Cellulaire", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE2600));

            mncList.Add(new MNCInfo("03", "Orange", "Orange", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("04", "KoZ", "Comium Ivory Coast Inc", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800));

            mncList.Add(new MNCInfo("05", "MTN", "Loteny Telecom", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE800,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("06", "GreenN", "Oricel", OperStatus.Operational,
                                                                                           BandType.GSM1800));

            mncList.Add(new MNCInfo("07", "café", "Aircomm", OperStatus.Operational,
                                                                                           BandType.GSM1800));

            mncList.Add(new MNCInfo("18", "", "YooMee", OperStatus.Operational,
                                                                                           BandType.TDLTE2300));

            _countries.Add(new CountryInfo(Resources.CI, "CI", "CIV", "384", ContinentCode.AF, new MobileInfo(612, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "DJ". <br/>
        /// Alpha2Cod2 DJ 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForDJ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Evatis", "Djibouti Telecom SA", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE800,
                                                                                           BandType.LTE1800));

            _countries.Add(new CountryInfo(Resources.DJ, "DJ", "DJI", "262", ContinentCode.AF, new MobileInfo(638, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "EG". <br/>
        /// Alpha2Cod2 EG 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForEG()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Orange", "Orange Egypt", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("02", "Vodafone", "Vodafone Egypt", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("03", "Etisalat", "Etisalat Egypt", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("04", "WE", "Telecom Egypt", OperStatus.Operational,
                                                                                           BandType.LTE1800));

            _countries.Add(new CountryInfo(Resources.EG, "EG", "EGY", "818", ContinentCode.AF, new MobileInfo(602, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "GQ". <br/>
        /// Alpha2Cod2 GQ 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForGQ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Orange GQ", "GETESA", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.LTE));

            mncList.Add(new MNCInfo("03", "Muni", "Green Com S.A.", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS900,
                                                                                           BandType.LTE));

            _countries.Add(new CountryInfo(Resources.GQ, "GQ", "GNQ", "226", ContinentCode.AF, new MobileInfo(627, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "ER". <br/>
        /// Alpha2Cod2 ER 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForER()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Eritel", "Eritrea Telecommunications Services Corporation", OperStatus.Operational,
                                                                                           BandType.GSM900));

            _countries.Add(new CountryInfo(Resources.ER, "ER", "ERI", "232", ContinentCode.AF, new MobileInfo(657, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "SZ". <br/>
        /// Alpha2Cod2 SZ 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForSZ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "", "SPTC", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("02", "", "Swazi Mobile Limited", OperStatus.Operational,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("10", "Swazi MTN", "Swazi MTN Limited", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.LTE1800));

            _countries.Add(new CountryInfo(Resources.SZ, "SZ", "SWZ", "748", ContinentCode.AF, new MobileInfo(653, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "ET". <br/>
        /// Alpha2Cod2 ET 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForET()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "MTN", "Ethio Telecom", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            _countries.Add(new CountryInfo(Resources.ET, "ET", "ETH", "231", ContinentCode.AF, new MobileInfo(636, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "GA". <br/>
        /// Alpha2Cod2 GA 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForGA()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Libertis", "Gabon Telecom S.A.", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE800,
                                                                                           BandType.LTE1800,
                                                                                           BandType.LTE2600));

            mncList.Add(new MNCInfo("02", "Moov", "Gabon Telecom S.A.", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE800,
                                                                                           BandType.LTE1800,
                                                                                           BandType.LTE2600));

            mncList.Add(new MNCInfo("03", "Airtel", "Airtel Gabon S.A.", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE2100));

            mncList.Add(new MNCInfo("04", "Azur", "USAN Gabon S.A.", OperStatus.Not_Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800));

            mncList.Add(new MNCInfo("05", "RAG", "Réseau de l’Administration Gabonaise", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            _countries.Add(new CountryInfo(Resources.GA, "GA", "GAB", "266", ContinentCode.AF, new MobileInfo(628, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "GM". <br/>
        /// Alpha2Cod2 GM 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForGM()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Gamcel", "Gamcel", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100));

            mncList.Add(new MNCInfo("02", "Africell", "Africell", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("03", "Comium", "Comium", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800));

            mncList.Add(new MNCInfo("04", "QCell", "QCell Gambia", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("05", "", "Gamtel-Ecowan", OperStatus.Unknown,
                                                                                           BandType.WiMAX,
                                                                                           BandType.LTE));

            mncList.Add(new MNCInfo("06", "", "NETPAGE", OperStatus.Operational,
                                                                                           BandType.TDLTE2300));

            _countries.Add(new CountryInfo(Resources.GM, "GM", "GMB", "270", ContinentCode.AF, new MobileInfo(607, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "GH". <br/>
        /// Alpha2Cod2 GH 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForGH()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "MTN", "MTN Group", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE800,
                                                                                           BandType.LTE2600));

            mncList.Add(new MNCInfo("02", "Vodafone", "Vodafone Group", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE800));

            mncList.Add(new MNCInfo("03", "AirtelTigo", "Millicom Ghana", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100));

            mncList.Add(new MNCInfo("04", "Expresso", "Kasapa / Hutchison Telecom", OperStatus.Operational,
                                                                                           BandType.CDMA2000850));

            mncList.Add(new MNCInfo("05", "", "National Security", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("06", "AirtelTigo", "Airtel", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100));

            mncList.Add(new MNCInfo("07", "Globacom", "Globacom Group", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100));

            mncList.Add(new MNCInfo("08", "Surfline", "Surfline Communications Ltd", OperStatus.Not_Operational,
                                                                                           BandType.LTE2600));

            mncList.Add(new MNCInfo("09", "NITA", "National Information Technology Agency", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("10", "Blu", "Blu Telecommunications", OperStatus.Operational,
                                                                                           BandType.TDLTE2500));

            mncList.Add(new MNCInfo("11", "", "Netafrique Dot Com Ltd", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("12", "", "BTL", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("13", "", "Goldkey", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("14", "busy", "BusyInternet", OperStatus.Operational,
                                                                                           BandType.TDLTE2300));

            mncList.Add(new MNCInfo("15", "", "Lebara", OperStatus.Operational,
                                                                                           BandType.MVNO));

            mncList.Add(new MNCInfo("16", "", "Telesol", OperStatus.Operational,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("17", "", "iBurst Africa", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            _countries.Add(new CountryInfo(Resources.GH, "GH", "GHA", "288", ContinentCode.AF, new MobileInfo(620, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "GN". <br/>
        /// Alpha2Cod2 GN 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForGN()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Orange", "Orange S.A.", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.LTE));

            mncList.Add(new MNCInfo("02", "Sotelgui", "Sotelgui Lagui", OperStatus.Operational,
                                                                                           BandType.GSM900));

            mncList.Add(new MNCInfo("03", "Telecel Guinee", "INTERCEL Guinée", OperStatus.Operational,
                                                                                           BandType.GSM900));

            mncList.Add(new MNCInfo("04", "MTN", "Areeba Guinea", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100));

            mncList.Add(new MNCInfo("05", "Cellcom", "Cellcom", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100));

            _countries.Add(new CountryInfo(Resources.GN, "GN", "GIN", "324", ContinentCode.AF, new MobileInfo(611, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "GW". <br/>
        /// Alpha2Cod2 GW 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForGW()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Guinetel", "Guinétel S.A.", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800));

            mncList.Add(new MNCInfo("02", "MTN Areeba", "Spacetel Guiné-Bissau S.A.", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100));

            mncList.Add(new MNCInfo("03", "Orange", "", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE));

            mncList.Add(new MNCInfo("07", "Guinetel", "Guinétel S.A.", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800));

            _countries.Add(new CountryInfo(Resources.GW, "GW", "GNB", "624", ContinentCode.AF, new MobileInfo(632, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "KE". <br/>
        /// Alpha2Cod2 KE 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForKE()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Safaricom", "Safaricom Limited", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("02", "Safaricom", "Safaricom Limited", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE800,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("03", "Airtel", "Bharti Airtel", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE800,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("04", "", "Mobile Pay Kenya Limited", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("05", "yu", "Essar Telecom Kenya", OperStatus.Not_Operational,
                                                                                           BandType.GSM900));

            mncList.Add(new MNCInfo("06", "", "Finserve Africa Limited", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("07", "Telkom", "Telkom Kenya", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE800));

            mncList.Add(new MNCInfo("08", "", "Wetribe Ltd", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("09", "", "Homeland Media Group Limited", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("10", "Faiba 4G", "Jamii Telecommunications Limited", OperStatus.Operational,
                                                                                           BandType.LTE700));

            mncList.Add(new MNCInfo("11", "", "Jambo Telcoms Limited", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("12", "", "Infura Limited", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("13", "", "Hidiga Investments Ltd", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            _countries.Add(new CountryInfo(Resources.KE, "KE", "KEN", "404", ContinentCode.AF, new MobileInfo(639, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "LS". <br/>
        /// Alpha2Cod2 LS 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForLS()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Vodacom", "Vodacom Lesotho (Pty) Ltd", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE800,
                                                                                           BandType.LTE1800,
                                                                                           BandType.FiveG3500));

            mncList.Add(new MNCInfo("02", "Econet Telecom", "Econet Ezi-cel", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE));

            mncList.Add(new MNCInfo("10", "Vodacom", "Vodacom Lesotho (Pty) Ltd", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            _countries.Add(new CountryInfo(Resources.LS, "LS", "LSO", "426", ContinentCode.AF, new MobileInfo(651, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "LR". <br/>
        /// Alpha2Cod2 LR 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForLR()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Lonestar Cell MTN", "Lonestar Communications Corporation", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE));

            mncList.Add(new MNCInfo("02", "Libercell", "Atlantic Wireless (Liberia) Inc.", OperStatus.Not_Operational,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("04", "Novafone", "Novafone Inc.", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100));

            mncList.Add(new MNCInfo("07", "Orange LBR", "Orange Liberia", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("20", "LIBTELCO", "Liberia Telecommunications Corporation", OperStatus.Operational,
                                                                                           BandType.CDMA2000));

            _countries.Add(new CountryInfo(Resources.LR, "LR", "LBR", "430", ContinentCode.AF, new MobileInfo(618, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "LY". <br/>
        /// Alpha2Cod2 LY 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForLY()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("00", "Libyana", "Libyana", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("01", "Madar", "Al-Madar Al-Jadeed", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("02", "Al-Jeel Phone", "Al-Jeel Al-Jadeed", OperStatus.Operational,
                                                                                           BandType.MVNO));

            mncList.Add(new MNCInfo("03", "Libya Phone", "Libya Telecom & Technology (LTT)", OperStatus.Operational,
                                                                                           BandType.MVNO,
                                                                                           BandType.LTE800));

            mncList.Add(new MNCInfo("06", "Hatef Libya", "Hatef Libya", OperStatus.Operational,
                                                                                           BandType.CDMA2000));

            _countries.Add(new CountryInfo(Resources.LY, "LY", "LBY", "434", ContinentCode.AF, new MobileInfo(606, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "MG". <br/>
        /// Alpha2Cod2 MG 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForMG()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Airtel", "Bharti Airtel", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("02", "Orange", "Orange Madagascar S.A.", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("03", "Sacel", "Sacel Madagascar S.A.", OperStatus.Not_Operational,
                                                                                           BandType.GSM900));

            mncList.Add(new MNCInfo("04", "Telma", "Telma Mobile S.A.", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800,
                                                                                           BandType.FiveG3500));

            mncList.Add(new MNCInfo("05", "BIP / blueline", "Gulfsat Madagascar S.A.", OperStatus.Operational,
                                                                                           BandType.LTE2100,
                                                                                           BandType.TDLTE2600));

            _countries.Add(new CountryInfo(Resources.MG, "MG", "MDG", "450", ContinentCode.AF, new MobileInfo(646, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "MW". <br/>
        /// Alpha2Cod2 MW 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForMW()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "TNM", "Telecom Network Malawi", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.TDLTE2500));

            mncList.Add(new MNCInfo("02", "Access", "Telecom Network Malawi", OperStatus.Operational,
                                                                                           BandType.CDMA,
                                                                                           BandType.LTE850));

            mncList.Add(new MNCInfo("10", "Airtel", "Airtel Malawi Limited", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            _countries.Add(new CountryInfo(Resources.MW, "MW", "MWI", "454", ContinentCode.AF, new MobileInfo(650, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "ML". <br/>
        /// Alpha2Cod2 ML 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForML()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Malitel", "Malitel SA", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE));

            mncList.Add(new MNCInfo("02", "Orange", "Orange Mali SA", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE));

            mncList.Add(new MNCInfo("03", "Telecel", "Alpha Telecommunication Mali S.A.", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100));

            _countries.Add(new CountryInfo(Resources.ML, "ML", "MLI", "466", ContinentCode.AF, new MobileInfo(610, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "MR". <br/>
        /// Alpha2Cod2 MR 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForMR()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Mattel", "Mattel", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.LTE));

            mncList.Add(new MNCInfo("02", "Chinguitel", "Chinguitel", OperStatus.Operational,
                                                                                           BandType.CDMA,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE));

            mncList.Add(new MNCInfo("10", "Moov", "Mauritel Mobiles", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            _countries.Add(new CountryInfo(Resources.MR, "MR", "MRT", "478", ContinentCode.AF, new MobileInfo(609, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "MU". <br/>
        /// Alpha2Cod2 MU 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForMU()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "my.t", "Cellplus Mobile Communications Ltd.", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800,
                                                                                           BandType.FiveG3500));

            mncList.Add(new MNCInfo("02", "MOKOZE / AZU", "Mahanagar Telephone Mauritius Limited (MTML)", OperStatus.Operational,
                                                                                           BandType.CDMA2000));

            mncList.Add(new MNCInfo("03", "CHILI", "Mahanagar Telephone Mauritius Limited (MTML)", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("10", "Emtel", "Emtel Ltd.", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            _countries.Add(new CountryInfo(Resources.MU, "MU", "MUS", "480", ContinentCode.AF, new MobileInfo(617, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "YT". <br/>
        /// Alpha2Cod2 YT 에 대한 정보를 추가합니다.
        /// French Departments and Territories in the Indian Ocean (France) includes YT / RE.
        /// </summary>
        /*************************************************/
        static void AddInfoForYT()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("00", "Orange", "Orange La Réunion", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("01", "Maoré Mobile", "BJT Partners", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("02", "Only", "Telco OI", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE800,
                                                                                           BandType.LTE1800,
                                                                                           BandType.LTE2100,
                                                                                           BandType.LTE2600));

            mncList.Add(new MNCInfo("03", "Free", "Telco OI", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE800,
                                                                                           BandType.LTE1800,
                                                                                           BandType.LTE2100,
                                                                                           BandType.LTE2600));

            mncList.Add(new MNCInfo("04", "Zeop", "Zeop mobile", OperStatus.Unknown,
                                                                                           BandType.LTE1800,
                                                                                           BandType.LTE2100,
                                                                                           BandType.LTE2600));

            mncList.Add(new MNCInfo("10", "SFR Réunion", "Société Réunionnaise du Radiotéléphone", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE800,
                                                                                           BandType.LTE1800,
                                                                                           BandType.LTE2600));

            _countries.Add(new CountryInfo(Resources.YT, "YT", "MYT", "175", ContinentCode.AF, new MobileInfo(647, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "MA". <br/>
        /// Alpha2Cod2 MA 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForMA()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("00", "Orange Morocco", "Médi Télécom", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE800,
                                                                                           BandType.LTE1800,
                                                                                           BandType.LTE2600));

            mncList.Add(new MNCInfo("01", "IAM", "Ittissalat Al-Maghrib (Maroc Telecom)", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE800,
                                                                                           BandType.LTE2600));

            mncList.Add(new MNCInfo("02", "INWI", "Wana Corporate", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800));

            mncList.Add(new MNCInfo("04", "", "Al Houria Telecom", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("05", "INWI", "Wana Corporate", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE800,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("06", "IAM", "Ittissalat Al-Maghrib (Maroc Telecom)", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("99", "", "Al Houria Telecom", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            _countries.Add(new CountryInfo(Resources.MA, "MA", "MAR", "504", ContinentCode.AF, new MobileInfo(604, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "MZ". <br/>
        /// Alpha2Cod2 MZ 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForMZ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "mCel", "Mocambique Celular S.A.", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS900,
                                                                                           BandType.UMTS2100));

            mncList.Add(new MNCInfo("03", "Movitel", "Movitel, SA", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE800));

            mncList.Add(new MNCInfo("04", "Vodacom", "Vodacom Mozambique, S.A.", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE800));

            _countries.Add(new CountryInfo(Resources.MZ, "MZ", "MOZ", "508", ContinentCode.AF, new MobileInfo(643, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "NA". <br/>
        /// Alpha2Cod2 NA 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForNA()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "MTC", "MTC Namibia", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("02", "switch", "Telecom Namibia", OperStatus.Operational,
                                                                                           BandType.CDMA2000800));

            mncList.Add(new MNCInfo("03", "TN Mobile", "Telecom Namibia", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800,
                                                                                           BandType.TDLTE2600));

            mncList.Add(new MNCInfo("04", "", "Paratus Telecommunications (Pty)", OperStatus.Operational,
                                                                                           BandType.WiMAX2500,
                                                                                           BandType.TDLTE));

            mncList.Add(new MNCInfo("05", "", "Demshi Investments CC", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("06", "", "MTN Namibia", OperStatus.Operational,
                                                                                           BandType.LTE));

            mncList.Add(new MNCInfo("07", "", "Capricorn Connect", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            _countries.Add(new CountryInfo(Resources.NA, "NA", "NAM", "516", ContinentCode.AF, new MobileInfo(649, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "NE". <br/>
        /// Alpha2Cod2 NE 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForNE()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "SahelCom", "La Société Sahélienne de Télécommunications (SahelCom)", OperStatus.Operational,
                                                                                           BandType.GSM900));

            mncList.Add(new MNCInfo("02", "Airtel", "Bharti Airtel Limited", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.LTE));

            mncList.Add(new MNCInfo("03", "Moov", "Atlantique Telecom (subsidiary of Etisalat)", OperStatus.Operational,
                                                                                           BandType.GSM900));

            mncList.Add(new MNCInfo("04", "Orange", "Orange Niger", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800));

            _countries.Add(new CountryInfo(Resources.NE, "NE", "NER", "562", ContinentCode.AF, new MobileInfo(614, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "NG". <br/>
        /// Alpha2Cod2 NG 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForNG()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("00", "", "Capcom", OperStatus.Not_Operational,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("20", "Airtel", "Bharti Airtel Limited", OperStatus.Operational,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("22", "InterC", "InterC Network Ltd.", OperStatus.Operational,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("24", "", "Spectranet", OperStatus.Operational,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("25", "Visafone", "Visafone Communications Ltd.", OperStatus.Not_Operational,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("26", "", "Swift", OperStatus.Operational,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("27", "Smile", "Smile Communications Nigeria", OperStatus.Operational,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("30", "MTN", "MTN Nigeria Communications Limited", OperStatus.Operational,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("40", "Ntel", "Nigerian Mobile Telecommunications Limited", OperStatus.Operational,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("50", "Glo", "Globacom Ltd", OperStatus.Operational,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("60", "9mobile", "Emerging Markets Telecommunication Services Ltd.", OperStatus.Operational,
                                                                                           BandType.Unknown));

            _countries.Add(new CountryInfo(Resources.NG, "NG", "NGA", "566", ContinentCode.AF, new MobileInfo(621, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "RE". <br/>
        /// Alpha2Cod2 RE 에 대한 정보를 추가합니다.
        /// RE is included in YT.
        /// </summary>
        /*************************************************/
        static void AddInfoForRE()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("00", "Orange", "Orange La Réunion", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("01", "Maoré Mobile", "BJT Partners", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("02", "Only", "Telco OI", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE800,
                                                                                           BandType.LTE1800,
                                                                                           BandType.LTE2100,
                                                                                           BandType.LTE2600));

            mncList.Add(new MNCInfo("03", "Free", "Telco OI", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE800,
                                                                                           BandType.LTE1800,
                                                                                           BandType.LTE2100,
                                                                                           BandType.LTE2600));

            mncList.Add(new MNCInfo("04", "Zeop", "Zeop mobile", OperStatus.Unknown,
                                                                                           BandType.LTE1800,
                                                                                           BandType.LTE2100,
                                                                                           BandType.LTE2600));

            mncList.Add(new MNCInfo("10", "SFR Réunion", "Société Réunionnaise du Radiotéléphone", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE800,
                                                                                           BandType.LTE1800,
                                                                                           BandType.LTE2600));

            _countries.Add(new CountryInfo(Resources.RE, "RE", "REU", "638", ContinentCode.AF, new MobileInfo(647, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "RW". <br/>
        /// Alpha2Cod2 RW 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForRW()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("10", "MTN", "MTN Rwandacell SARL", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS900,
                                                                                           BandType.UMTS2100));

            mncList.Add(new MNCInfo("11", "Rwandatel", "Rwandatel S.A.", OperStatus.Not_Operational,
                                                                                           BandType.CDMA));

            mncList.Add(new MNCInfo("12", "Rwandatel", "Rwandatel S.A.", OperStatus.Not_Operational,
                                                                                           BandType.GSM));

            mncList.Add(new MNCInfo("13", "Airtel", "Airtel RWANDA", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100));

            mncList.Add(new MNCInfo("14", "Airtel", "Airtel RWANDA", OperStatus.Not_Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100));

            mncList.Add(new MNCInfo("15", "Olleh", "Olleh Rwanda Networks", OperStatus.Operational,
                                                                                           BandType.LTE800,
                                                                                           BandType.LTE1800));

            _countries.Add(new CountryInfo(Resources.RW, "RW", "RWA", "646", ContinentCode.AF, new MobileInfo(635, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "SH". <br/>
        /// Alpha2Cod2 SH 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForSH()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Sure", "Sure South Atlantic Ltd.", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.LTE1800));

            _countries.Add(new CountryInfo(Resources.SH, "SH", "SHN", "654", ContinentCode.AF, new MobileInfo(658, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "ST". <br/>
        /// Alpha2Cod2 ST 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForST()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "CSTmovel", "Companhia Santomese de Telecomunicaçôe", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100));

            mncList.Add(new MNCInfo("01", "Unitel STP", "Unitel Sao Tome and Principe", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100));

            _countries.Add(new CountryInfo(Resources.ST, "ST", "STP", "678", ContinentCode.AF, new MobileInfo(626, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "SN". <br/>
        /// Alpha2Cod2 SN 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForSN()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Orange", "Sonatel", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE800,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("02", "Free", "Saga Africa Holdings Limited", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE800,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("03", "Expresso", "Expresso Telecom", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE));

            mncList.Add(new MNCInfo("04", "", "CSU-SA", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            _countries.Add(new CountryInfo(Resources.SN, "SN", "SEN", "686", ContinentCode.AF, new MobileInfo(608, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "SC". <br/>
        /// Alpha2Cod2 SC 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForSC()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Cable & Wireless", "Cable & Wireless Seychelles", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS,
                                                                                           BandType.FiveG));

            mncList.Add(new MNCInfo("02", "Mediatech", "Mediatech International", OperStatus.Not_Operational,
                                                                                           BandType.GSM1800));

            mncList.Add(new MNCInfo("05", "", "Intelvision Ltd", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("10", "Airtel", "Telecom Seychelles Ltd", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE800));

            _countries.Add(new CountryInfo(Resources.SC, "SC", "SYC", "690", ContinentCode.AF, new MobileInfo(633, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "SL". <br/>
        /// Alpha2Cod2 SL 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForSL()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Orange", "Orange SL Limited", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE));

            mncList.Add(new MNCInfo("02", "Africell", "Lintel Sierra Leone Limited", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("03", "Africell", "Lintel Sierra Leone Limited", OperStatus.Operational,
                                                                                           BandType.GSM900));

            mncList.Add(new MNCInfo("04", "Comium", "Comium (Sierra Leone) Ltd.", OperStatus.Not_Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800));

            mncList.Add(new MNCInfo("05", "Africell", "Lintel Sierra Leone Limited", OperStatus.Operational,
                                                                                           BandType.GSM900));

            mncList.Add(new MNCInfo("06", "SierraTel", "Sierra Leone Telephony", OperStatus.Operational,
                                                                                           BandType.CDMA800,
                                                                                           BandType.LTE));

            mncList.Add(new MNCInfo("07", "", "Qcell Sierra Leone", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("09", "Smart Mobile", "InterGroup Telecom SL", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100));

            mncList.Add(new MNCInfo("25", "Mobitel", "Mobitel", OperStatus.Reserved,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("40", "", "Datatel (SL) Ltd.", OperStatus.Unknown,
                                                                                           BandType.GSM));

            mncList.Add(new MNCInfo("50", "", "Datatel (SL) Ltd.", OperStatus.Unknown,
                                                                                           BandType.CDMA));

            _countries.Add(new CountryInfo(Resources.SL, "SL", "SLE", "694", ContinentCode.AF, new MobileInfo(619, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "SO". <br/>
        /// Alpha2Cod2 SO 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForSO()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Telesom", "Telesom", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE));

            mncList.Add(new MNCInfo("04", "Somafone", "Somafone FZLLC", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800));

            mncList.Add(new MNCInfo("10", "Nationlink", "NationLink Telecom", OperStatus.Operational,
                                                                                           BandType.GSM900));

            mncList.Add(new MNCInfo("20", "SOMNET", "SOMNET", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE800));

            mncList.Add(new MNCInfo("50", "Hormuud", "Hormuud Telecom Somalia Inc", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS));

            mncList.Add(new MNCInfo("30", "Golis", "Golis Telecom Somalia", OperStatus.Operational,
                                                                                           BandType.GSM900));

            mncList.Add(new MNCInfo("57", "UNITEL", "UNITEL S.a.r.l.", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800));

            mncList.Add(new MNCInfo("60", "Nationlink", "Nationlink Telecom", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800));

            mncList.Add(new MNCInfo("67", "Horntel Group", "HTG Group Somalia", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100));

            mncList.Add(new MNCInfo("70", "", "Onkod Telecom Ltd.", OperStatus.Not_Operational,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("71", "Somtel", "Somtel", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE800));

            mncList.Add(new MNCInfo("92", "Telcom", "Telcom Somalia", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.CDMA2000,
                                                                                           BandType.LTE));

            _countries.Add(new CountryInfo(Resources.SO, "SO", "SOM", "706", ContinentCode.AF, new MobileInfo(637, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "ZA". <br/>
        /// Alpha2Cod2 ZA 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForZA()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Vodacom", "Vodacom", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE900,
                                                                                           BandType.LTE1800,
                                                                                           BandType.LTE2100,
                                                                                           BandType.LTE5200,
                                                                                           BandType.FiveG700,
                                                                                           BandType.FiveG3500,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("02", "Telkom", "Telkom SA SOC Ltd", OperStatus.Operational,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800,
                                                                                           BandType.TDLTE2300));

            mncList.Add(new MNCInfo("03", "Telkom", "Telkom SA SOC Ltd", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("04", "", "Sasol (Pty) Ltd.", OperStatus.Not_Operational,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("05", "", "Telkom SA Ltd", OperStatus.Unknown,
                                                                                           BandType.Unknown3G));

            mncList.Add(new MNCInfo("06", "", "Sentech (Pty) Ltd", OperStatus.Operational,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("07", "Cell C", "Cell C (Pty) Ltd", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS900,
                                                                                           BandType.LTE1800,
                                                                                           BandType.LTE2100));

            mncList.Add(new MNCInfo("10", "MTN", "MTN Group", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE900,
                                                                                           BandType.LTE1800,
                                                                                           BandType.LTE2100,
                                                                                           BandType.FiveG700,
                                                                                           BandType.FiveG1800,
                                                                                           BandType.FiveG2100,
                                                                                           BandType.FiveG3500,
                                                                                           BandType.FiveG28000));

            mncList.Add(new MNCInfo("11", "", "South African Police Service Gauteng", OperStatus.Not_Operational,
                                                                                           BandType.TETRA410));

            mncList.Add(new MNCInfo("12", "MTN", "MTN Group", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("13", "Neotel", "Neotel Pty Ltd", OperStatus.Not_Operational,
                                                                                           BandType.CDMA800));

            mncList.Add(new MNCInfo("14", "Neotel", "Neotel Pty Ltd", OperStatus.Operational,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("16", "", "Phoenix System Integration (Pty) Ltd", OperStatus.Not_Operational,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("17", "", "Sishen Iron Ore Company (Ltd) Pty", OperStatus.Not_Operational,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("19", "Rain", "Wireless Business Solutions (Pty) Ltd", OperStatus.Operational,
                                                                                           BandType.LTE1800,
                                                                                           BandType.TDLTE2600,
                                                                                           BandType.FiveG3500));

            mncList.Add(new MNCInfo("21", "", "Cape Town Metropolitan Council", OperStatus.Not_Operational,
                                                                                           BandType.TETRA410));

            mncList.Add(new MNCInfo("24", "", "SMSPortal (Pty) Ltd.", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("25", "", "Wirels Connect", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("27", "", "A to Z Vaal Industrial Supplies Pty Ltd", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("28", "", "Hymax Talking Solutions (Pty) Ltd", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("30", "", "Bokamoso Consortium", OperStatus.Operational,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("31", "", "Karabo Telecoms (Pty) Ltd.", OperStatus.Operational,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("32", "", "Ilizwi Telecommunications", OperStatus.Operational,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("33", "", "Thinta Thinta Telecommunications Pty Ltd", OperStatus.Operational,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("34", "", "Bokone Telecoms Pty Ltd", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("35", "", "Kingdom Communications Pty Ltd", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("36", "", "Amatole Telecommunications Pty Ltd", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("38", "iBurst", "Wireless Business Solutions (Pty) Ltd", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("41", "", "South African Police Service", OperStatus.Not_Operational,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("46", "", "SMS Cellular Services (Pty) Ltd", OperStatus.Operational,
                                                                                           BandType.MVNO));

            mncList.Add(new MNCInfo("50", "", "Ericsson South Africa (Pty) Ltd", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("51", "", "Integrat (Pty) Ltd", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("53", "Lycamobile", "Lycamobile (Pty) Ltd", OperStatus.Unknown,
                                                                                           BandType.MVNO));

            mncList.Add(new MNCInfo("65", "", "Vodacom Pty Ltd", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("73", "iBurst", "Wireless Business Solutions (Pty) Ltd", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("74", "iBurst", "Wireless Business Solutions (Pty) Ltd", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("75", "ACSA", "Airports Company South Africa", OperStatus.Not_Operational,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("76", "", "Comsol Networks (Pty) Ltd", OperStatus.Operational,
                                                                                           BandType.WiMAX,
                                                                                           BandType.two8000));

            mncList.Add(new MNCInfo("77", "Umoja Connect", "One Telecom (Pty) Ltd", OperStatus.Unknown,
                                                                                           BandType.FiveG));

            _countries.Add(new CountryInfo(Resources.ZA, "ZA", "ZAF", "710", ContinentCode.AF, new MobileInfo(655, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "SS". <br/>
        /// Alpha2Cod2 SS 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForSS()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("02", "MTN", "MTN South Sudan", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100));

            mncList.Add(new MNCInfo("03", "Gemtel", "Gemtel", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800));

            mncList.Add(new MNCInfo("04", "Vivacell", "Network of the World (NOW)", OperStatus.Not_Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800));

            mncList.Add(new MNCInfo("06", "Zain", "Zain South Sudan", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE2100));

            mncList.Add(new MNCInfo("07", "Sudani", "Sudani", OperStatus.Operational,
                                                                                           BandType.CDMA));

            _countries.Add(new CountryInfo(Resources.SS, "SS", "SSD", "728", ContinentCode.AF, new MobileInfo(659, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "SD". <br/>
        /// Alpha2Cod2 SD 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForSD()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Zain SD", "Zain Group - Sudan", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("02", "MTN", "MTN Sudan", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100));

            mncList.Add(new MNCInfo("03", "MTN", "MTN Sudan", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("05", "canar", "Canar Telecom", OperStatus.Operational,
                                                                                           BandType.CDMA2000450));

            mncList.Add(new MNCInfo("07", "Sudani One", "Sudatel Group", OperStatus.Operational,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800,
                                                                                           BandType.CDMA2000800));

            mncList.Add(new MNCInfo("09", "khartoum INC", "NEC", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100));

            _countries.Add(new CountryInfo(Resources.SD, "SD", "SDN", "729", ContinentCode.AF, new MobileInfo(634, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "TZ". <br/>
        /// Alpha2Cod2 TZ 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForTZ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "", "Shared Network Tanzania Limited", OperStatus.Not_Operational,
                                                                                           BandType.UMTS900));

            mncList.Add(new MNCInfo("02", "tiGO", "MIC Tanzania Limited", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE800,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("03", "Zantel", "Zanzibar Telecom Ltd", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("04", "Vodacom", "Vodacom Tanzania Limited", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("05", "Airtel", "Bharti Airtel", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE700));

            mncList.Add(new MNCInfo("06", "Sasatel (Dovetel)", "Dovetel Limited", OperStatus.Not_Operational,
                                                                                           BandType.CDMA800));

            mncList.Add(new MNCInfo("07", "TTCL Mobile", "Tanzania Telecommunication Company LTD (TTCL)", OperStatus.Operational,
                                                                                           BandType.CDMA800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800,
                                                                                           BandType.TDLTE2300));

            mncList.Add(new MNCInfo("08", "Smart", "Benson Informatics Limited", OperStatus.Not_Operational,
                                                                                           BandType.TDLTE2300));

            mncList.Add(new MNCInfo("09", "Halotel", "Viettel Tanzania Limited", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100));

            mncList.Add(new MNCInfo("11", "SmileCom", "Smile Telecoms Holdings Ltd.", OperStatus.Operational,
                                                                                           BandType.LTE800));

            mncList.Add(new MNCInfo("12", "", "MyCell Limited", OperStatus.Not_Operational,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("13", "Cootel", "Wiafrica Tanzania Limited", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("14", "", "MO Mobile Holding Limited", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            _countries.Add(new CountryInfo(Resources.TZ, "TZ", "TZA", "834", ContinentCode.AF, new MobileInfo(640, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "TG". <br/>
        /// Alpha2Cod2 TG 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForTG()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Togo Cell", "Togo Telecom", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.LTE,
                                                                                           BandType.FiveG));

            mncList.Add(new MNCInfo("03", "Moov", "Moov Togo", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.LTE));

            _countries.Add(new CountryInfo(Resources.TG, "TG", "TGO", "768", ContinentCode.AF, new MobileInfo(615, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "TN". <br/>
        /// Alpha2Cod2 TN 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForTN()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Orange", "Orange Tunisie", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE800,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("02", "Tunicell", "Tunisie Telecom", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE800,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("03", "OOREDOO TN", "ooredoo Tunisiana", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE800,
                                                                                           BandType.LTE1800));

            _countries.Add(new CountryInfo(Resources.TN, "TN", "TUN", "788", ContinentCode.AF, new MobileInfo(605, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "UG". <br/>
        /// Alpha2Cod2 UG 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForUG()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Airtel", "Bharti Airtel", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100));

            mncList.Add(new MNCInfo("04", "", "Tangerine Uganda Limited", OperStatus.Not_Operational,
                                                                                           BandType.LTE));

            mncList.Add(new MNCInfo("06", "Vodafone", "Afrimax Uganda", OperStatus.Not_Operational,
                                                                                           BandType.TDLTE2600));

            mncList.Add(new MNCInfo("10", "MTN", "MTN Uganda", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE2600));

            mncList.Add(new MNCInfo("11", "Uganda Telecom", "Uganda Telecom Ltd.", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100));

            mncList.Add(new MNCInfo("14", "Africell", "Africell Uganda", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("16", "", "SimbaNET Uganda Limited", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("18", "Smart", "Suretelecom Uganda Ltd.", OperStatus.Not_Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100));

            mncList.Add(new MNCInfo("20", "", "Hamilton Telecom Limited", OperStatus.Not_Operational,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("22", "Airtel", "Bharti Airtel", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS));

            mncList.Add(new MNCInfo("26", "Lycamobile", "Lycamobile Network Services Uganda Limited", OperStatus.Not_Operational,
                                                                                           BandType.MVNO));

            mncList.Add(new MNCInfo("30", "", "Anupam Global Soft Uganda Limited", OperStatus.Not_Operational,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("33", "Smile", "Smile Communications Uganda Limited", OperStatus.Operational,
                                                                                           BandType.LTE800));

            mncList.Add(new MNCInfo("40", "", "Civil Aviation Authority (CAA)", OperStatus.Unknown,
                                                                                           BandType.Unknown));

            mncList.Add(new MNCInfo("44", "K2", "K2 Telecom Ltd", OperStatus.Operational,
                                                                                           BandType.MVNO));

            mncList.Add(new MNCInfo("66", "i-Tel", "i-Tel Ltd", OperStatus.Not_Operational,
                                                                                           BandType.Unknown));

            _countries.Add(new CountryInfo(Resources.UG, "UG", "UGA", "800", ContinentCode.AF, new MobileInfo(641, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "EH". <br/>
        /// Alpha2Cod2 EH 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForEH()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.EH, "EH", "ESH", "732", ContinentCode.AF));
            /// This does not have MNC. In Wiki, there is not nation alpha-2 code EH.
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "ZM". <br/>
        /// Alpha2Cod2 ZM 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForZM()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Airtel", "Bharti Airtel", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE900));

            mncList.Add(new MNCInfo("02", "MTN", "MTN Group", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("03", "ZAMTEL", "Zambia Telecommunications Company Ltd", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.TDLTE2300));

            _countries.Add(new CountryInfo(Resources.ZM, "ZM", "ZMB", "894", ContinentCode.AF, new MobileInfo(645, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "ZW". <br/>
        /// Alpha2Cod2 ZW 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForZW()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Net*One", "Net*One Cellular (Pvt) Ltd", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.LTE1800));

            mncList.Add(new MNCInfo("03", "Telecel", "Telecel Zimbabwe (PVT) Ltd", OperStatus.Operational,
                                                                                           BandType.GSM900));

            mncList.Add(new MNCInfo("04", "Econet", "Econet Wireless", OperStatus.Operational,
                                                                                           BandType.GSM900,
                                                                                           BandType.GSM1800,
                                                                                           BandType.UMTS2100,
                                                                                           BandType.LTE1800));

            _countries.Add(new CountryInfo(Resources.ZW, "ZW", "ZWE", "716", ContinentCode.AF, new MobileInfo(648, mncList)));
        }



    }
}
