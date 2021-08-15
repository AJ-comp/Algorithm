using System;
using System.Collections.Generic;
using System.Text;
using AJ.Code.Properties;

namespace AJ.Code
{
    public partial class Country
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

            _countries.Add(new CountryInfo(Resources.AQ, "AQ", "ATA", "010", ContinentCode.AN, new MobileInfo(672, mncList)));
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
