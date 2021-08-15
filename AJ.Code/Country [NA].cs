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
        /// Add information for the alpha2 code "AI". <br/>
        /// Alpha2Cod2 AI 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
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

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "AG". <br/>
        /// Alpha2Cod2 AG 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
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

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "AW". <br/>
        /// Alpha2Cod2 AW 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/

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

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "BS". <br/>
        /// Alpha2Cod2 BS 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForBS()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.BS, "BS", "BHS", "044", ContinentCode.NA, new MobileInfo(364, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "BB". <br/>
        /// Alpha2Cod2 BB 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForBB()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.BB, "BB", "BRB", "052", ContinentCode.NA, new MobileInfo(342, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "BZ". <br/>
        /// Alpha2Cod2 BZ 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForBZ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.BZ, "BZ", "BLZ", "084", ContinentCode.NA, new MobileInfo(702, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "BM". <br/>
        /// Alpha2Cod2 BM 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForBM()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.BM, "BM", "BMU", "060", ContinentCode.NA, new MobileInfo(350, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "CA". <br/>
        /// Alpha2Cod2 CA 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForCA()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.CA, "CA", "CAN", "124", ContinentCode.NA, new MobileInfo(302, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "KY". <br/>
        /// Alpha2Cod2 KY 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForKY()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.KY, "KY", "CYM", "136", ContinentCode.NA, new MobileInfo(346, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "CR". <br/>
        /// Alpha2Cod2 CR 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForCR()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.CR, "CR", "CRI", "188", ContinentCode.NA, new MobileInfo(712, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "CU". <br/>
        /// Alpha2Cod2 CU 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForCU()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.CU, "CU", "CUB", "192", ContinentCode.NA, new MobileInfo(368, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "DM". <br/>
        /// Alpha2Cod2 DM 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForDM()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.DM, "DM", "DMA", "212", ContinentCode.NA, new MobileInfo(366, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "DO". <br/>
        /// Alpha2Cod2 DO 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForDO()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.DO, "DO", "DOM", "214", ContinentCode.NA, new MobileInfo(370, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "SV". <br/>
        /// Alpha2Cod2 SV 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForSV()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.SV, "SV", "SLV", "222", ContinentCode.NA, new MobileInfo(706, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "GL". <br/>
        /// Alpha2Cod2 GL 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
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

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "GD". <br/>
        /// Alpha2Cod2 GD 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForGD()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.GD, "GD", "GRD", "308", ContinentCode.NA, new MobileInfo(352, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "GP". <br/>
        /// Alpha2Cod2 GP 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForGP()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.GP, "GP", "GLP", "312", ContinentCode.NA, new MobileInfo(340, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "GT". <br/>
        /// Alpha2Cod2 GT 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForGT()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.GT, "GT", "GTM", "320", ContinentCode.NA, new MobileInfo(704, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "HT". <br/>
        /// Alpha2Cod2 HT 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForHT()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.HT, "HT", "HTI", "332", ContinentCode.NA, new MobileInfo(372, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "HN". <br/>
        /// Alpha2Cod2 HN 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForHN()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.HN, "HN", "HND", "340", ContinentCode.NA, new MobileInfo(708, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "JM". <br/>
        /// Alpha2Cod2 JM 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForJM()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.JM, "JM", "JAM", "388", ContinentCode.NA, new MobileInfo(338, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "MQ". <br/>
        /// Alpha2Cod2 MQ 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForMQ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.MQ, "MQ", "MTQ", "474", ContinentCode.NA, new MobileInfo(340, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "MX". <br/>
        /// Alpha2Cod2 MX 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForMX()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.MX, "MX", "MEX", "484", ContinentCode.NA, new MobileInfo(334, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "MS". <br/>
        /// Alpha2Cod2 MS 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForMS()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.MS, "MS", "MSR", "500", ContinentCode.NA, new MobileInfo(354, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "NI". <br/>
        /// Alpha2Cod2 NI 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForNI()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.NI, "NI", "NIC", "558", ContinentCode.NA, new MobileInfo(710, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "PA". <br/>
        /// Alpha2Cod2 PA 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForPA()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.PA, "PA", "PAN", "591", ContinentCode.NA, new MobileInfo(714, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "PR". <br/>
        /// Alpha2Cod2 PR 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForPR()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.PR, "PR", "PRI", "630", ContinentCode.NA, new MobileInfo(330, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "BL". <br/>
        /// Alpha2Cod2 BL 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForBL()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.BL, "BL", "BLM", "652", ContinentCode.NA, new MobileInfo(340, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "KN". <br/>
        /// Alpha2Cod2 KN 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForKN()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.KN, "KN", "KNA", "659", ContinentCode.NA, new MobileInfo(356, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "LC". <br/>
        /// Alpha2Cod2 LC 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForLC()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.LC, "LC", "LCA", "662", ContinentCode.NA, new MobileInfo(358, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "MF". <br/>
        /// Alpha2Cod2 MF 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForMF()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.MF, "MF", "MAF", "663", ContinentCode.NA, new MobileInfo(340, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "PM". <br/>
        /// Alpha2Cod2 PM 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForPM()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.PM, "PM", "SPM", "666", ContinentCode.NA, new MobileInfo(308, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "VC". <br/>
        /// Alpha2Cod2 VC 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForVC()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.VC, "VC", "VCT", "670", ContinentCode.NA, new MobileInfo(360, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "SX". <br/>
        /// Alpha2Cod2 SX 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForSX()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.SX, "SX", "SXM", "534", ContinentCode.NA, new MobileInfo(362, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "TT". <br/>
        /// Alpha2Cod2 TT 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForTT()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.TT, "TT", "TTO", "780", ContinentCode.NA, new MobileInfo(374, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "TC". <br/>
        /// Alpha2Cod2 TC 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForTC()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.TC, "TC", "TCA", "796", ContinentCode.NA, new MobileInfo(376, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "US". <br/>
        /// Alpha2Cod2 US 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
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

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "VG". <br/>
        /// Alpha2Cod2 VG 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForVG()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.VG, "VG", "VGB", "092", ContinentCode.NA, new MobileInfo(348, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "VI". <br/>
        /// Alpha2Cod2 VI 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForVI()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.VI, "VI", "VIR", "850", ContinentCode.NA, new MobileInfo(332, mncList)));
        }
    }
}
