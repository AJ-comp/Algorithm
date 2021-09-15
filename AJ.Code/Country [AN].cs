using System;
using System.Collections.Generic;
using System.Text;
using AJ.Code.Properties;
using static AJ.Code.MNCInfo;

namespace AJ.Code
{
    public partial class Country
        /// Except for BV, other nations dosen't exist in wiki
    {
        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "AQ". <br/>
        /// Alpha2Cod2 AQ 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForAQ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.AQ, "AQ", "ATA", "010", ContinentCode.AN, new MobileInfo(672)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "BV". <br/>
        /// Alpha2Cod2 BV 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForBV()
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
                                                                                           BandType.WiMAX));

            mncList.Add(new MNCInfo("06", "beCloud", "Belorussian Cloud Technologies", OperStatus.Operational,
                                                                                           BandType.LTE800,
                                                                                           BandType.LTE1800,
                                                                                           BandType.LTE2600));

            _countries.Add(new CountryInfo(Resources.BV, "BV", "BVT", "074", ContinentCode.AN, new MobileInfo(257, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "TF". <br/>
        /// Alpha2Cod2 TF 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForTF()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.TF, "TF", "ATF", "260", ContinentCode.AN));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "HM". <br/>
        /// Alpha2Cod2 HM 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForHM()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.HM, "HM", "HMD", "334", ContinentCode.AN));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "GS". <br/>
        /// Alpha2Cod2 GS 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForGS()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.GS, "GS", "SGS", "239", ContinentCode.AN));
        }
    }
}
