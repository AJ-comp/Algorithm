using AJ.Code.Properties;
using System;
using System.Collections.Generic;
using System.Text;

namespace AJ.Code
{
    public partial class Country
    {
        /*************************************************/
        /// <summary>
        /// It is add the information for the alpha2 code "DZ". <br/>
        /// Alpha2Cod2 DZ 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForDZ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();

            _countries.Add(new CountryInfo(Resources.DZ, "DZ", "DZA", "012", ContinentCode.AF, new MobileInfo(603, mncList)));
        }


    }
}
