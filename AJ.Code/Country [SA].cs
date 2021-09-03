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
        /// Add information for the alpha2 code "AR". <br/>
        /// Alpha2Cod2 AR 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForAR()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("010", "Movistar", "Telefónica Móviles Argentina S.A.", OperStatus.Operational,
                                                                                                BandType.GSM850,
                                                                                                BandType.GSM1900,
                                                                                                BandType.UMTS850,
                                                                                                BandType.UMTS1900,
                                                                                                BandType.LTE700,
                                                                                                BandType.LTE1700,
                                                                                                BandType.LTE2600));

            mncList.Add(new MNCInfo("020", "Nextel", "NII Holdings", OperStatus.Operational,
                                                                                                BandType.iDEN800));

            mncList.Add(new MNCInfo("034", "Personal", "Telecom Personal S.A.", OperStatus.Operational,
                                                                                                BandType.Unknown));

            mncList.Add(new MNCInfo("040", "Globalstar", "TE.SA.M Argentina S.A.", OperStatus.Operational,
                                                                                                BandType.Unknown));

            mncList.Add(new MNCInfo("070", "Movistar", "Telefónica Móviles Argentina S.A.", OperStatus.Operational,
                                                                                                BandType.GSM1900));

            mncList.Add(new MNCInfo("310", "Claro", "AMX Argentina S.A.", OperStatus.Operational,
                                                                                                BandType.GSM1900));

            mncList.Add(new MNCInfo("320", "Claro", "AMX Argentina S.A.", OperStatus.Operational,
                                                                                                BandType.GSM850,
                                                                                                BandType.GSM1900,
                                                                                                BandType.UMTS850,
                                                                                                BandType.UMTS1900,
                                                                                                BandType.LTE1700));

            mncList.Add(new MNCInfo("330", "Claro", "AMX Argentina S.A.", OperStatus.Operational,
                                                                                                BandType.GSM850,
                                                                                                BandType.GSM1900,
                                                                                                BandType.UMTS850,
                                                                                                BandType.UMTS1900,
                                                                                                BandType.LTE1700));

            mncList.Add(new MNCInfo("341", "Personal", "Telecom Personal S.A.", OperStatus.Operational,
                                                                                                BandType.GSM850,
                                                                                                BandType.GSM1900,
                                                                                                BandType.UMTS850,
                                                                                                BandType.UMTS1900,
                                                                                                BandType.LTE1700,
                                                                                                BandType.LTE1700,
                                                                                                BandType.LTE2600,
                                                                                                BandType.FiveG2600));

            mncList.Add(new MNCInfo("350", "PORT-HABLE", "Hutchison Telecommunications Argentina S.A.", OperStatus.Operational,
                                                                                                BandType.GSM900));

            _countries.Add(new CountryInfo(Resources.AR, "AR", "ARG", "032", ContinentCode.SA, new MobileInfo(722, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "BO". <br/>
        /// Alpha2Cod2 BO 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForBO()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Viva", "Nuevatel PCS De Bolivia SA", OperStatus.Operational,
                                                                                                BandType.GSM850,
                                                                                                BandType.GSM1900,
                                                                                                BandType.LTE1700));

            mncList.Add(new MNCInfo("02", "Entel", "Entel SA", OperStatus.Operational,
                                                                                                BandType.GSM850,
                                                                                                BandType.GSM1900,
                                                                                                BandType.UMTS850,
                                                                                                BandType.LTE700));

            mncList.Add(new MNCInfo("03", "Tigo", "Telefónica Celular De Bolivia S.A", OperStatus.Operational,
                                                                                                BandType.GSM850,
                                                                                                BandType.UMTS850,
                                                                                                BandType.UMTS1900,
                                                                                                BandType.LTE700));

            _countries.Add(new CountryInfo(Resources.BO, "BO", "BOL", "068", ContinentCode.SA, new MobileInfo(736, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "BQ". <br/>
        /// Alpha2Cod2 BQ 에 대한 정보를 추가합니다.
        /// BQ is included in SX.
        /// </summary>
        /*************************************************/
        static void AddInfoForBQ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("31", "", "Eutel N.V.", OperStatus.Unknown,
                                                                                               BandType.GSM));

            mncList.Add(new MNCInfo("33", "", "WICC N.V.", OperStatus.Unknown,
                                                                                               BandType.GSM));

            mncList.Add(new MNCInfo("51", "Telcell", "Telcell N.V.", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("54", "ECC", "East Caribbean Cellular", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800));

            mncList.Add(new MNCInfo("59", "FLOW", "Liberty Latin America", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800));

            mncList.Add(new MNCInfo("60", "FLOW", "Liberty Latin America", OperStatus.Operational,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("63", "", "CSC N.V.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("68", "Digicel", "Curaçao Telecom N.V.", OperStatus.Operational,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("69", "Digicel", "Curaçao Telecom N.V.", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800));

            mncList.Add(new MNCInfo("74", "", "PCS N.V.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("76", "Digicel", "Antiliano Por N.V.", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("78", "Telbo", "Telefonia Bonairiano N.V.", OperStatus.Operational,
                                                                                               BandType.UMTS900,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("91", "FLOW", "Liberty Latin America", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE2100));

            mncList.Add(new MNCInfo("94", "Bayòs", "Bòbò Frus N.V.", OperStatus.Operational,
                                                                                               BandType.TDMAPCS));

            mncList.Add(new MNCInfo("95", "MIO", "E.O.C.G. Wireless", OperStatus.Not_Operational,
                                                                                               BandType.CDMA2000850));

            _countries.Add(new CountryInfo(Resources.BQ, "BQ", "BES", "535", ContinentCode.SA, new MobileInfo(362, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "BR". <br/>
        /// Alpha2Cod2 BR 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForBR()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.BR, "BR", "BRA", "076", ContinentCode.SA, new MobileInfo(724, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "CL". <br/>
        /// Alpha2Cod2 CL 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForCL()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.CL, "CL", "CHL", "152", ContinentCode.SA, new MobileInfo(730, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "CO". <br/>
        /// Alpha2Cod2 CO 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForCO()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.CO, "CO", "COL", "170", ContinentCode.SA, new MobileInfo(732, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "CW". <br/>
        /// Alpha2Cod2 CW 에 대한 정보를 추가합니다.
        /// CW is included in SX.
        /// </summary>
        /*************************************************/
        static void AddInfoForCW()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("31", "", "Eutel N.V.", OperStatus.Unknown,
                                                                                               BandType.GSM));

            mncList.Add(new MNCInfo("33", "", "WICC N.V.", OperStatus.Unknown,
                                                                                               BandType.GSM));

            mncList.Add(new MNCInfo("51", "Telcell", "Telcell N.V.", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("54", "ECC", "East Caribbean Cellular", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800));

            mncList.Add(new MNCInfo("59", "FLOW", "Liberty Latin America", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800));

            mncList.Add(new MNCInfo("60", "FLOW", "Liberty Latin America", OperStatus.Operational,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("63", "", "CSC N.V.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("68", "Digicel", "Curaçao Telecom N.V.", OperStatus.Operational,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("69", "Digicel", "Curaçao Telecom N.V.", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800));

            mncList.Add(new MNCInfo("74", "", "PCS N.V.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("76", "Digicel", "Antiliano Por N.V.", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("78", "Telbo", "Telefonia Bonairiano N.V.", OperStatus.Operational,
                                                                                               BandType.UMTS900,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("91", "FLOW", "Liberty Latin America", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE2100));

            mncList.Add(new MNCInfo("94", "Bayòs", "Bòbò Frus N.V.", OperStatus.Operational,
                                                                                               BandType.TDMAPCS));

            mncList.Add(new MNCInfo("95", "MIO", "E.O.C.G. Wireless", OperStatus.Not_Operational,
                                                                                               BandType.CDMA2000850));

            _countries.Add(new CountryInfo(Resources.CW, "CW", "CUW", "531", ContinentCode.SA, new MobileInfo(362, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "EC". <br/>
        /// Alpha2Cod2 EC 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForEC()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.EC, "EC", "ECU", "218", ContinentCode.SA, new MobileInfo(740, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "FK". <br/>
        /// Alpha2Cod2 FK 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForFK()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.FK, "FK", "FLK", "238", ContinentCode.SA, new MobileInfo(750, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "GF". <br/>
        /// Alpha2Cod2 GF 에 대한 정보를 추가합니다.
        /// French Guiana shares MCC 340 in addition to using the assigned MCC 742.
        /// French Antilles (France) includes BL / GF / GP / MF / MQ
        /// </summary>
        /*************************************************/
        static void AddInfoForGF()
        {
            // mobile info for MCC 340
            List<MNCInfo> mncListfor340 = new List<MNCInfo>();
            mncListfor340.Add(new MNCInfo("01", "Orange", "Orange Caraïbe Mobiles", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.LTE2600));

            mncListfor340.Add(new MNCInfo("02", "SFR Caraïbe", "Outremer Telecom", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600));

            mncListfor340.Add(new MNCInfo("03", "FLOW", "UTS Caraïbe", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS,
                                                                                               BandType.LTE1800));

            mncListfor340.Add(new MNCInfo("04", "Free", "Free Caraïbe", OperStatus.Upcoming,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600));

            mncListfor340.Add(new MNCInfo("08", "Dauphin", "Dauphin Telecom", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS,
                                                                                               BandType.LTE));

            mncListfor340.Add(new MNCInfo("09", "Free", "Free Caraïbe", OperStatus.Upcoming,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600));

            mncListfor340.Add(new MNCInfo("10", "", "Guadeloupe Téléphone Mobile", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncListfor340.Add(new MNCInfo("11", "", "Guyane Téléphone Mobile", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncListfor340.Add(new MNCInfo("12", "", "Martinique Téléphone Mobile", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncListfor340.Add(new MNCInfo("20", "Digicel", "DIGICEL Antilles Française Guyane", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800));
            var mobile340 = new MobileInfo(340, mncListfor340);

            _countries.Add(new CountryInfo(Resources.GF, "GF", "GUF", "254", ContinentCode.SA, new MobileInfo(742), mobile340));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "GY". <br/>
        /// Alpha2Cod2 GY 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForGY()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.GY, "GY", "GUY", "328", ContinentCode.SA, new MobileInfo(738, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "PY". <br/>
        /// Alpha2Cod2 PY 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForPY()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.PY, "PY", "PRY", "600", ContinentCode.SA, new MobileInfo(744, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "PE". <br/>
        /// Alpha2Cod2 PE 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForPE()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.PE, "PE", "PER", "604", ContinentCode.SA, new MobileInfo(716, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "SR". <br/>
        /// Alpha2Cod2 SR 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForSR()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.SR, "SR", "SUR", "740", ContinentCode.SA, new MobileInfo(746, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "UY". <br/>
        /// Alpha2Cod2 UY 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForUY()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.UY, "UY", "URY", "858", ContinentCode.SA, new MobileInfo(748, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "VE". <br/>
        /// Alpha2Cod2 VE 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForVE()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.VE, "VE", "VEN", "862", ContinentCode.SA, new MobileInfo(734, mncList)));
        }
    }
}
