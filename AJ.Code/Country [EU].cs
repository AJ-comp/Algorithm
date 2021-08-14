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
        /// It is add the information for the alpha2 code "AD". <br/>
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
        /// It is add the information for the alpha2 code "AL". <br/>
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
        /// It is add the information for the alpha2 code "AT". <br/>
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
    }
}
