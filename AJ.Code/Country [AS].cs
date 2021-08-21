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
        /// Add information for the alpha2 code "AF". <br/>
        /// Alpha2Cod2 AF 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForAF()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.AF, "AF", "AFG", "004", ContinentCode.AS, new MobileInfo(412, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "AM". <br/>
        /// Alpha2Cod2 AM 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
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

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "AZ". <br/>
        /// Alpha2Cod2 AZ 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForAZ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.AZ, "AZ", "AZE", "031", ContinentCode.AS, new MobileInfo(400, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "BH". <br/>
        /// Alpha2Cod2 BH 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForBH()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.BH, "BH", "BHR", "048", ContinentCode.AS, new MobileInfo(426, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "BD". <br/>
        /// Alpha2Cod2 BD 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForBD()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.BD, "BD", "BGD", "050", ContinentCode.AS, new MobileInfo(470, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "BT". <br/>
        /// Alpha2Cod2 BT 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForBT()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.BT, "BT", "BTN", "064", ContinentCode.AS, new MobileInfo(402, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "IO". <br/>
        /// Alpha2Cod2 IO 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForIO()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.IO, "IO", "IOT", "086", ContinentCode.AS, new MobileInfo(995, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "BN". <br/>
        /// Alpha2Cod2 BN 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForBN()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "TelBru", "Telekom Brunei Berhad", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("02", "PCSB", "Progresif Cellular Sdn Bhd", OperStatus.Operational,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("03", "UNN", "Unified National Networks Sdn Bhd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("11", "DST", "Data Stream Technology Sdn Bhd", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            _countries.Add(new CountryInfo(Resources.BN, "BN", "BRN", "096", ContinentCode.AS, new MobileInfo(528, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "KH". <br/>
        /// Alpha2Cod2 KH 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForKH()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.KH, "KH", "KHM", "116", ContinentCode.AS, new MobileInfo(456, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "CN". <br/>
        /// Alpha2Cod2 CN 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForCN()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.CN, "CN", "CHN", "156", ContinentCode.AS, new MobileInfo(460, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "CX". <br/>
        /// Alpha2Cod2 CX 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForCX()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.CX, "CX", "CXR", "162", ContinentCode.AS, new MobileInfo(505, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "CC". <br/>
        /// Alpha2Cod2 CC 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForCC()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.CC, "CC", "CCK", "166", ContinentCode.AS));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "CY". <br/>
        /// Alpha2Cod2 CY 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
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

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "GE". <br/>
        /// Alpha2Cod2 GE 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForGE()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Geocell", "Silknet", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("02", "Magti", "MagtiCom", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("03", "MagtiFix", "	MagtiCom", OperStatus.Operational,
                                                                                               BandType.CDMA450));

            mncList.Add(new MNCInfo("04", "Beeline", "Mobitel", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800));

            mncList.Add(new MNCInfo("05", "S1", "Silknet", OperStatus.Operational,
                                                                                               BandType.CDMA800));

            mncList.Add(new MNCInfo("06", "", "JSC Compatel", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("07", "GlobalCell", "GlobalCell", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("08", "Silk LTE", "Silknet", OperStatus.Operational,
                                                                                               BandType.LTE2300));

            mncList.Add(new MNCInfo("09", "", "Gmobile", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("10", "", "Premium Net International SRL", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("11", "", "Mobilive", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("12", "", "Telecom1 Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("13", "", "Asanet Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("14", "DataCell", "DataHouse Global", OperStatus.Unknown,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("22", "Myphone", "Myphone Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            _countries.Add(new CountryInfo(Resources.GE, "GE", "GEO", "268", ContinentCode.AS, new MobileInfo(282, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "HK". <br/>
        /// Alpha2Cod2 HK 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForHK()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.HK, "HK", "HKG", "344", ContinentCode.AS, new MobileInfo(454, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "IN". <br/>
        /// Alpha2Cod2 IN 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForIN()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.IN, "IN", "IND", "356", ContinentCode.AS, new MobileInfo(404, mncList), new MobileInfo(405, mncList), new MobileInfo(406, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "ID". <br/>
        /// Alpha2Cod2 ID 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForID()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("00", "PSN", "PT Pasifik Satelit Nusantara (ACeS)", OperStatus.Operational,
                                                                                               BandType.Satellite));

            mncList.Add(new MNCInfo("01", "Indosat Ooredoo", "PT Indonesian Satellite Corporation Tbk (INDOSAT)", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.FiveG1800));

            mncList.Add(new MNCInfo("03", "StarOne", "PT Indosat Tbk", OperStatus.Not_Operational,
                                                                                               BandType.CDMA800));

            mncList.Add(new MNCInfo("07", "TelkomFlexi", "PT Telkom", OperStatus.Not_Operational,
                                                                                               BandType.CDMA800));

            mncList.Add(new MNCInfo("08", "AXIS", "PT Natrindo Telepon Seluler", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("09", "Smartfren", "PT Smartfren Telecom", OperStatus.Operational,
                                                                                               BandType.LTE850,
                                                                                               BandType.TDLTE2300));

            mncList.Add(new MNCInfo("10", "Telkomsel", "PT Telekomunikasi Selular", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.FiveG2300));

            mncList.Add(new MNCInfo("11", "XL", "PT XL Axiata Tbk", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("20", "TELKOMMobile", "PT Telkom Indonesia Tbk", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncList.Add(new MNCInfo("21", "IM3", "PT Indonesian Satellite Corporation Tbk (INDOSAT)", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncList.Add(new MNCInfo("27", "Net 1", "PT Sampoerna Telekomunikasi Indonesia", OperStatus.Operational,
                                                                                               BandType.LTE450));

            mncList.Add(new MNCInfo("28", "Fren/Hepi", "PT Mobile-8 Telecom", OperStatus.Operational,
                                                                                               BandType.LTE850,
                                                                                               BandType.TDLTE2300));

            mncList.Add(new MNCInfo("78", "Hinet", "PT Berca Hardayaperkasa", OperStatus.Operational,
                                                                                               BandType.TDLTE2300));

            mncList.Add(new MNCInfo("88", "BOLT! 4G LTE", "PT Internux", OperStatus.Not_Operational,
                                                                                               BandType.TDLTE2300));

            mncList.Add(new MNCInfo("89", "3", "PT Hutchison CP Telecommunications", OperStatus.Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("99", "Esia", "PT Bakrie Telecom", OperStatus.Not_Operational,
                                                                                               BandType.CDMA800));

            _countries.Add(new CountryInfo(Resources.ID, "ID", "IDN", "360", ContinentCode.AS, new MobileInfo(510, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "IR". <br/>
        /// Alpha2Cod2 IR 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForIR()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.IR, "IR", "IRN", "364", ContinentCode.AS, new MobileInfo(432, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "IQ". <br/>
        /// Alpha2Cod2 IQ 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForIQ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.IQ, "IQ", "IRQ", "368", ContinentCode.AS, new MobileInfo(418, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "IL". <br/>
        /// Alpha2Cod2 IL 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForIL()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.IL, "IL", "ISR", "376", ContinentCode.AS, new MobileInfo(425, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "JP". <br/>
        /// Alpha2Cod2 JP 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForJP()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.JP, "JP", "JPN", "392", ContinentCode.AS, new MobileInfo(440, mncList), new MobileInfo(441, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "JO". <br/>
        /// Alpha2Cod2 JO 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForJO()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.JO, "JO", "JOR", "400", ContinentCode.AS, new MobileInfo(416, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "KZ". <br/>
        /// Alpha2Cod2 KZ 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForKZ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.KZ, "KZ", "KAZ", "398", ContinentCode.AS, new MobileInfo(401, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "KP". <br/>
        /// Alpha2Cod2 KP 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForKP()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.KP, "KP", "PRK", "408", ContinentCode.AS, new MobileInfo(467, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "KR". <br/>
        /// Alpha2Cod2 KR 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/

        static void AddInfoForKR()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.KR, "KR", "KOR", "410", ContinentCode.AS, new MobileInfo(450, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "KW". <br/>
        /// Alpha2Cod2 KW 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForKW()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.KW, "KW", "KWT", "414", ContinentCode.AS, new MobileInfo(419, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "KG". <br/>
        /// Alpha2Cod2 KG 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForKG()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.KG, "KG", "KGZ", "417", ContinentCode.AS, new MobileInfo(437, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "LA". <br/>
        /// Alpha2Cod2 LA 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForLA()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.LA, "LA", "LAO", "418", ContinentCode.AS, new MobileInfo(457, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "LB". <br/>
        /// Alpha2Cod2 LB 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForLB()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.LB, "LB", "LBN", "422", ContinentCode.AS, new MobileInfo(415, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "MO". <br/>
        /// Alpha2Cod2 MO 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForMO()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.MO, "MO", "MAC", "446", ContinentCode.AS, new MobileInfo(455, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "MY". <br/>
        /// Alpha2Cod2 MY 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForMY()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "ATUR 450", "Telekom Malaysia Bhd", OperStatus.Not_Operational,
                                                                                               BandType.CDMA2000450));

            mncList.Add(new MNCInfo("10", "", "Maxis, DiGi, Celcom, XOX", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("11", "TM Homeline", "Telekom Malaysia Bhd", OperStatus.Operational,
                                                                                               BandType.CDMA2000850,
                                                                                               BandType.LTE850));

            mncList.Add(new MNCInfo("12", "Maxis", "Maxis Communications Berhad", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("13", "Celcom", "Celcom Axiata Berhad", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("14", "", "Telekom Malaysia Berhad for PSTN SMS", OperStatus.Unknown,
                                                                                               BandType.Empty));

            mncList.Add(new MNCInfo("150", "Tune Talk", "Tune Talk Sdn Bhd", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("151", "SalamFone", "Baraka Telecom Sdn Bhd", OperStatus.Not_Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("152", "Yes", "YTL Communications Sdn Bhd", OperStatus.Operational,
                                                                                               BandType.WiMAX2300,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.TDLTE2600));

            mncList.Add(new MNCInfo("153", "unifi", "Webe Digital Sdn Bhd", OperStatus.Operational,
                                                                                               BandType.WiMAX2300,
                                                                                               BandType.LTE850,
                                                                                               BandType.TDLTE2300));

            mncList.Add(new MNCInfo("154", "Tron", "Talk Focus Sdn Bhd", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("155", "Clixster", "Clixster Mobile Sdn Bhd", OperStatus.Not_Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("156", "Altel", "Altel Communications Sdn Bhd", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("157", "Telin", "Telekomunikasi Indonesia International (M) Sdn Bhd", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("16", "DiGi", "DiGi Telecommunications", OperStatus.Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("17", "Maxis", "Maxis Communications Berhad", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("18", "U Mobile", "U Mobile Sdn Bhd", OperStatus.Operational,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("19", "Celcom", "Celcom Axiata Berhad", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("20", "Electcoms", "Electcoms Berhad", OperStatus.Not_Operational,
                                                                                               BandType.DMR));

            _countries.Add(new CountryInfo(Resources.MY, "MY", "MYS", "458", ContinentCode.AS, new MobileInfo(502, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "MV". <br/>
        /// Alpha2Cod2 MV 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForMV()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.MV, "MV", "MDV", "462", ContinentCode.AS, new MobileInfo(472, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "NN". <br/>
        /// Alpha2Cod2 NN 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForMN()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.MN, "MN", "MNG", "496", ContinentCode.AS, new MobileInfo(428, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "NM". <br/>
        /// Alpha2Cod2 NM 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/

        static void AddInfoForMM()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.MM, "MM", "MMR", "104", ContinentCode.AS, new MobileInfo(414, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "NP". <br/>
        /// Alpha2Cod2 NP 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForNP()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.NP, "NP", "NPL", "524", ContinentCode.AS, new MobileInfo(429, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "OM". <br/>
        /// Alpha2Cod2 OM 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForOM()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.OM, "OM", "OMN", "512", ContinentCode.AS, new MobileInfo(422, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "PK". <br/>
        /// Alpha2Cod2 PK 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForPK()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.PK, "PK", "PAK", "586", ContinentCode.AS, new MobileInfo(410, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "PS". <br/>
        /// Alpha2Cod2 PS 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForPS()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.PS, "PS", "PSE", "275", ContinentCode.AS, new MobileInfo(425, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "PH". <br/>
        /// Alpha2Cod2 PH 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForPH()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Islacom", "Globe Telecom via Innove Communications", OperStatus.Not_Operational,
                                                                                               BandType.GSM900));

            mncList.Add(new MNCInfo("02", "Globe", "Globe Telecom", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1800,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.TDLTE2500,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("03", "SMART", "PLDT via Smart Communications", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.TDLTE2500,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("05", "Sun Cellular", "Digital Telecommunications Philippines", OperStatus.Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("11", "", "PLDT via ACeS Philippines", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("18", "Cure", "PLDT via Smart's Connectivity Unlimited Resources Enterprise", OperStatus.Not_Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("24", "ABS-CBN Mobile", "ABS-CBN Convergence with Globe Telecom", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("66", "DITO", "Dito Telecommunity Corp.", OperStatus.Operational,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("88", "", "Next Mobile Inc.", OperStatus.Operational,
                                                                                               BandType.iDEN));

            _countries.Add(new CountryInfo(Resources.PH, "PH", "PHL", "608", ContinentCode.AS, new MobileInfo(515, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "QA". <br/>
        /// Alpha2Cod2 QA 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForQA()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.QA, "QA", "QAT", "634", ContinentCode.AS, new MobileInfo(427, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "SA". <br/>
        /// Alpha2Cod2 SA 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForSA()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.SA, "SA", "SAU", "682", ContinentCode.AS, new MobileInfo(420, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "SG". <br/>
        /// Alpha2Cod2 SG 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForSG()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "SingTel", "Singapore Telecom", OperStatus.Operational,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600,
                                                                                               BandType.FiveG2100,
                                                                                               BandType.FiveG3500,
                                                                                               BandType.FiveG28000));

            mncList.Add(new MNCInfo("02", "SingTel-G18", "Singapore Telecom", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("03", "M1", "M1 Limited", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("05", "StarHub", "StarHub Mobile", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("06", "StarHub", "StarHub Mobile", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("07", "SingTel", "Singapore Telecom", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("08", "StarHub", "StarHub Mobile", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("09", "Circles.Life", "Liberty Wireless Pte Ltd", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("10", "", "TPG Telecom Pte Ltd", OperStatus.Operational,
                                                                                               BandType.LTE900,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.TDLTE2500));

            mncList.Add(new MNCInfo("11", "M1", "M1 Limited", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("12", "Grid", "GRID Communications Pte Ltd.", OperStatus.Operational,
                                                                                               BandType.iDEN800));

            _countries.Add(new CountryInfo(Resources.SG, "SG", "SGP", "702", ContinentCode.AS, new MobileInfo(525, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "LK". <br/>
        /// Alpha2Cod2 LK 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForLK()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.LK, "LK", "LKA", "144", ContinentCode.AS, new MobileInfo(413, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "SY". <br/>
        /// Alpha2Cod2 SY 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForSY()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.SY, "SY", "SYR", "760", ContinentCode.AS, new MobileInfo(417, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "TW". <br/>
        /// Alpha2Cod2 TW 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForTW()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.TW, "TW", "TWN", "158", ContinentCode.AS, new MobileInfo(466, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "TJ". <br/>
        /// Alpha2Cod2 TJ 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForTJ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.TJ, "TJ", "TJK", "762", ContinentCode.AS, new MobileInfo(436, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "TH". <br/>
        /// Alpha2Cod2 TH 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForTH()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("00", "TrueMove H / my by CAT", "National Telecom Public Company Limited (CAT Telecom)", OperStatus.Operational,
                                                                                               BandType.UMTS850));

            mncList.Add(new MNCInfo("01", "AIS", "Advanced Info Service", OperStatus.Operational,
                                                                                               BandType.GSM900));

            mncList.Add(new MNCInfo("02", "CAT CDMA", "National Telecom Public Company Limited(CAT Telecom)", OperStatus.Not_Operational,
                                                                                               BandType.CDMA800));

            mncList.Add(new MNCInfo("03", "AIS", "Advanced Wireless Network Company Ltd.", OperStatus.Operational,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.FiveG700,
                                                                                               BandType.FiveG2500));

            mncList.Add(new MNCInfo("04", "TrueMove H", "True Move H Universal Communication Company Ltd.", OperStatus.Operational,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.FiveG700,
                                                                                               BandType.FiveG2500));

            mncList.Add(new MNCInfo("05", "dtac", "DTAC TriNet Company Ltd.", OperStatus.Operational,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.FiveG700));

            mncList.Add(new MNCInfo("09", "", "Royal Thai Police", OperStatus.Operational,
                                                                                               BandType.LTE850));

            mncList.Add(new MNCInfo("15", "AIS-T / TOT Mobile", "National Telecom Public Company Limited(TOT Public Company Limited)", OperStatus.Operational,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE2100));

            mncList.Add(new MNCInfo("17", "TOT Mobile", "National Telecom Public Company Limited(TOT Public Company Limited)", OperStatus.Operational,
                                                                                               BandType.TDLTE2300));

            mncList.Add(new MNCInfo("18", "dtac", "Total Access Communications Public Company Ltd.", OperStatus.Operational,
                                                                                               BandType.GSM1800));

            mncList.Add(new MNCInfo("20", "ACeS", "ACeS", OperStatus.Unknown,
                                                                                               BandType.Satellite));

            mncList.Add(new MNCInfo("23", "AIS GSM 1800", "Digital Phone Company Ltd.", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncList.Add(new MNCInfo("25", "WE PCT", "True Corporation", OperStatus.Not_Operational,
                                                                                               BandType.PHS1900));

            mncList.Add(new MNCInfo("47", "dtac-T", "National Telecom Public Company Limited(TOT Public Company Limited)", OperStatus.Operational,
                                                                                               BandType.TDLTE2300));

            mncList.Add(new MNCInfo("99", "TrueMove", "True Corporation", OperStatus.Operational,
                                                                                               BandType.GSM1800));

            _countries.Add(new CountryInfo(Resources.TH, "TH", "THA", "764", ContinentCode.AS, new MobileInfo(520, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "TL". <br/>
        /// Alpha2Cod2 TL 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForTL()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Telkomcel", "PT Telekomunikasi Indonesia International", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE));

            mncList.Add(new MNCInfo("02", "TT", "Timor Telecom", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("03", "Telemor", "Viettel Timor-Leste", OperStatus.Operational,
                                                                                               BandType.LTE1800));

            _countries.Add(new CountryInfo(Resources.TL, "TL", "TLS", "626", ContinentCode.AS));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "TM". <br/>
        /// Alpha2Cod2 TM 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForTM()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.TM, "TM", "TKM", "795", ContinentCode.AS, new MobileInfo(438, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "AE". <br/>
        /// Alpha2Cod2 AE 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForAE()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.AE, "AE", "ARE", "784", ContinentCode.AS, new MobileInfo(424, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "UZ". <br/>
        /// Alpha2Cod2 UZ 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForUZ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.UZ, "UZ", "UZB", "860", ContinentCode.AS, new MobileInfo(434, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "VN". <br/>
        /// Alpha2Cod2 VN 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForVN()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.VN, "VN", "VNM", "704", ContinentCode.AS, new MobileInfo(452, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "YE". <br/>
        /// Alpha2Cod2 YE 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/

        static void AddInfoForYE()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.YE, "YE", "YEM", "887", ContinentCode.AS, new MobileInfo(421, mncList)));
        }
    }
}
