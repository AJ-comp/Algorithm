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
