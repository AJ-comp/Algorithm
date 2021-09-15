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
            mncList.Add(new MNCInfo("01", "AWCC", "Afghan Wireless Communication Company", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("20", "Roshan", "Telecom Development Company Afghanistan Ltd.", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("40", "MTN", "MTN Group Afghanistan", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("50", "Etisalat", "Etisalat Afghanistan", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("55", "WASEL", "WASEL Afghanistan", OperStatus.Operational,
                                                                                               BandType.CDMA800));

            mncList.Add(new MNCInfo("80", "Salaam", "Afghan Telecom", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("88", "Salaam", "Afghan Telecom", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

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
            mncList.Add(new MNCInfo("01", "Azercell", "", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("02", "Bakcell", "", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("03", "FONEX", "CATEL", OperStatus.Operational,
                                                                                               BandType.CDMA450));

            mncList.Add(new MNCInfo("04", "Nar Mobile", "Azerfon", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("05", "", "Special State Protection Service of the Republic of Azerbaijan", OperStatus.Unknown,
                                                                                               BandType.TETRA));

            mncList.Add(new MNCInfo("06", "Naxtel", "Nakhtel LLC", OperStatus.Operational,
                                                                                               BandType.CDMA800,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800));

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
            mncList.Add(new MNCInfo("01", "Batelco", "Bahrain Telecommunications Company", OperStatus.Operational,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("02", "zain BH", "Zain Bahrain", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("03", "", "Civil Aviation Authority", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("04", "STC", "STC Bahrain", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("05", "Batelco", "Bahrain Telecommunications Company", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800));

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
            mncList.Add(new MNCInfo("01", "Grameenphone", "Grameenphone Ltd.", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("02", "Robi", "Axiata Bangladesh Ltd.", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100));

            mncList.Add(new MNCInfo("03", "Banglalink", "Banglalink Digital Communications Ltd.", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("04", "TeleTalk", "Teletalk Bangladesh Limited", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("05", "Citycell", "Pacific Bangladesh Telecom Limited", OperStatus.Not_Operational,
                                                                                               BandType.CDMA800));

            mncList.Add(new MNCInfo("07", "Airtel", "Bharti Airtel Bangladesh Ltd.", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("09", "ollo", "Bangladesh Internet Exchange Limited (BIEL)", OperStatus.Not_Operational,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE2600,
                                                                                               BandType.WiMAX3500));

            mncList.Add(new MNCInfo("10", "Banglalion", "Banglalion Communications Ltd.", OperStatus.Operational,
                                                                                               BandType.TDLTE2600,
                                                                                               BandType.WiMAX3500));

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
            mncList.Add(new MNCInfo("11", "B-Mobile", "Bhutan Telecom Limited", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("77", "TashiCell", "Tashi InfoComm Limited", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE700));

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
            mncList.Add(new MNCInfo("01", "FonePlus", "Sure (Diego Garcia) Ltd", OperStatus.Operational,
                                                                                               BandType.GSM900));

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
            mncList.Add(new MNCInfo("01", "Cellcard", "CamGSM / The Royal Group", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("02", "Smart", "Smart Axiata Co. Ltd", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100));

            mncList.Add(new MNCInfo("03", "qb", "Cambodia Advance Communications Co. Ltd", OperStatus.Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("04", "qb", "Cambodia Advance Communications Co. Ltd", OperStatus.Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("05", "Smart", "Smart Axiata Co. Ltd", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100));

            mncList.Add(new MNCInfo("06", "Smart", "Smart Axiata Co. Ltd", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100));

            mncList.Add(new MNCInfo("08", "Metfone", "Viettel", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("09", "Metfone", "Viettel", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("11", "SEATEL", "SEATEL Cambodia", OperStatus.Operational,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("18", "Cellcard", "The Royal Group", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

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
            mncList.Add(new MNCInfo("00", "China Mobile", "China Mobile", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.TDSCDMA1900,
                                                                                               BandType.TDSCDMA2000,
                                                                                               BandType.TDLTE1900,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.TDLTE2500,
                                                                                               BandType.FiveG2500));

            mncList.Add(new MNCInfo("01", "China Unicom", "China Unicom", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.TDLTE2500,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("02", "China Mobile", "China Mobile", OperStatus.Not_Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.TDSCDMA1900,
                                                                                               BandType.TDSCDMA2000,
                                                                                               BandType.TDLTE1900,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.TDLTE2500));

            mncList.Add(new MNCInfo("03", "China Telecom", "China Telecom", OperStatus.Operational,
                                                                                               BandType.CDMA2000800));

            mncList.Add(new MNCInfo("04", "China Mobile", "Global Star Satellite", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("05", "China Telecom", "China Telecom", OperStatus.Not_Operational,
                                                                                               BandType.CDMA2000800,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.TDLTE2500));

            mncList.Add(new MNCInfo("06", "China Unicom", "China Unicom", OperStatus.Not_Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("07", "China Mobile", "China Mobile", OperStatus.Not_Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.TDSCDMA1900,
                                                                                               BandType.TDSCDMA2000,
                                                                                               BandType.TDLTE1900,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.TDLTE2500));

            mncList.Add(new MNCInfo("08", "China Mobile", "China Mobile", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("09", "China Unicom", "China Unicom", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("11", "China Telecom", "China Telecom", OperStatus.Operational,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.TDLTE2500,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("20", "China Tietong", "China Tietong", OperStatus.Operational,
                                                                                               BandType.GSMR));

            _countries.Add(new CountryInfo(Resources.CN, "CN", "CHN", "156", ContinentCode.AS, new MobileInfo(460, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "CX". <br/>
        /// Alpha2Cod2 CX 에 대한 정보를 추가합니다.
        /// CX is included in AU.
        /// </summary>
        /*************************************************/
        static void AddInfoForCX()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Telstra", "Telstra Corporation Limited", OperStatus.Operational,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.LTE2600,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("02", "Optus", "Singtel Optus Pty Ltd", OperStatus.Operational,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.LTE2600,
                                                                                               BandType.TD5G2300,
                                                                                               BandType.FiveG3500,
                                                                                               BandType.FiveG28000));

            mncList.Add(new MNCInfo("03", "Vodafone", "Vodafone Hutchison Australia Pty Ltd", OperStatus.Operational,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.FiveG700,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("04", "", "Department of Defence", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("05", "Ozitel", "", OperStatus.Not_Operational,
                                                                                               BandType.Empty));

            mncList.Add(new MNCInfo("06", "3", "Vodafone Hutchison Australia Pty Ltd", OperStatus.Not_Operational,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("07", "Vodafone", "Vodafone Network Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("08", "One.Tel", "One.Tel Limited", OperStatus.Not_Operational,
                                                                                               BandType.GSM900));

            mncList.Add(new MNCInfo("09", "Airnet", "", OperStatus.Not_Operational,
                                                                                               BandType.Empty));

            mncList.Add(new MNCInfo("10", "Norfolk Is.", "Norfolk Telecom", OperStatus.Operational,
                                                                                               BandType.GSM900));

            mncList.Add(new MNCInfo("11", "Telstra", "Telstra Corporation Limited", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("12", "3", "Vodafone Hutchison Australia Pty Ltd", OperStatus.Not_Operational,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("13", "RailCorp", "Railcorp, Transport for NSW", OperStatus.Operational,
                                                                                               BandType.GSMR1800));

            mncList.Add(new MNCInfo("14", "AAPT", "TPG Telecom", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("15", "3GIS", "", OperStatus.Not_Operational,
                                                                                               BandType.Empty));

            mncList.Add(new MNCInfo("16", "VicTrack", "Victorian Rail Track", OperStatus.Operational,
                                                                                               BandType.GSMR1800));

            mncList.Add(new MNCInfo("17", "", "Optus", OperStatus.Operational,
                                                                                               BandType.TDLTE2300));

            mncList.Add(new MNCInfo("18", "Pactel", "Pactel International Pty Ltd", OperStatus.Not_Operational,
                                                                                               BandType.Empty));

            mncList.Add(new MNCInfo("19", "Lycamobile", "Lycamobile Pty Ltd", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("20", "", "Ausgrid Corporation", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("21", "", "Queensland Rail Limited", OperStatus.Unknown,
                                                                                               BandType.GSMR1800));

            mncList.Add(new MNCInfo("22", "", "iiNet Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("23", "", "Challenge Networks Pty Ltd", OperStatus.Operational,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100));

            mncList.Add(new MNCInfo("24", "", "Advanced Communications Technologies Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("25", "", "Pilbara Iron Company Services Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("26", "", "Dialogue Communications Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("27", "", "Nexium Telecommunications", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("28", "", "RCOM International Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("30", "", "Compatel Limited", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("31", "", "BHP", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("32", "", "Thales Australia", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("33", "", "CLX Networks Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("34", "", "Santos Limited", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("35", "", "MessageBird Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("36", "Optus", "Optus Mobile Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("37", "", "Yancoal Australia Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("38", "Truphone", "Truphone Pty Ltd", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("39", "Telstra", "Telstra Corporation Ltd.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("40", "", "CITIC Pacific Mining", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("41", "", "Aqura Technologies Pty", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("42", "GEMCO", "Groote Eylandt Mining Company Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("43", "", "Arrow Energy Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("44", "", "Roy Hill Iron Ore Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("45", "", "Clermont Coal Operations Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("46", "", "AngloGold Ashanti Australia Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("47", "", "Woodside Energy Limited", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("48", "", "Titan ICT Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("49", "", "Field Solutions Group Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("50", "", "Pivotel Group Pty Ltd", OperStatus.Operational,
                                                                                               BandType.Satellite));

            mncList.Add(new MNCInfo("51", "", "Fortescue Metals Group", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("52", "", "OptiTel Australia", OperStatus.Operational,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.FiveG1800,
                                                                                               BandType.FiveG2100));

            mncList.Add(new MNCInfo("53", "", "Shell Australia Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("61", "CommTel NS", "Commtel Network Solutions Pty Ltd", OperStatus.Implement_Design,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100));

            mncList.Add(new MNCInfo("62", "NBN", "National Broadband Network Co.", OperStatus.Operational,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.TDLTE3500));

            mncList.Add(new MNCInfo("68", "NBN", "National Broadband Network Co.", OperStatus.Operational,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.TDLTE3500));

            mncList.Add(new MNCInfo("71", "Telstra", "Telstra Corporation Limited", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("72", "Telstra", "Telstra Corporation Limited", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("88", "", "Pivotel Group Pty Ltd", OperStatus.Operational,
                                                                                               BandType.Satellite));

            mncList.Add(new MNCInfo("90", "Optus", "Singtel Optus Proprietary Ltd", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("99", "One.Tel", "One.Tel", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            _countries.Add(new CountryInfo(Resources.CX, "CX", "CXR", "162", ContinentCode.AS, new MobileInfo(505, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "CC". <br/>
        /// Alpha2Cod2 CC 에 대한 정보를 추가합니다.
        /// CX is included in AU.
        /// </summary>
        /*************************************************/
        static void AddInfoForCC()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Telstra", "Telstra Corporation Limited", OperStatus.Operational,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.LTE2600,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("02", "Optus", "Singtel Optus Pty Ltd", OperStatus.Operational,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.LTE2600,
                                                                                               BandType.TD5G2300,
                                                                                               BandType.FiveG3500,
                                                                                               BandType.FiveG28000));

            mncList.Add(new MNCInfo("03", "Vodafone", "Vodafone Hutchison Australia Pty Ltd", OperStatus.Operational,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.FiveG700,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("04", "", "Department of Defence", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("05", "Ozitel", "", OperStatus.Not_Operational,
                                                                                               BandType.Empty));

            mncList.Add(new MNCInfo("06", "3", "Vodafone Hutchison Australia Pty Ltd", OperStatus.Not_Operational,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("07", "Vodafone", "Vodafone Network Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("08", "One.Tel", "One.Tel Limited", OperStatus.Not_Operational,
                                                                                               BandType.GSM900));

            mncList.Add(new MNCInfo("09", "Airnet", "", OperStatus.Not_Operational,
                                                                                               BandType.Empty));

            mncList.Add(new MNCInfo("10", "Norfolk Is.", "Norfolk Telecom", OperStatus.Operational,
                                                                                               BandType.GSM900));

            mncList.Add(new MNCInfo("11", "Telstra", "Telstra Corporation Limited", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("12", "3", "Vodafone Hutchison Australia Pty Ltd", OperStatus.Not_Operational,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("13", "RailCorp", "Railcorp, Transport for NSW", OperStatus.Operational,
                                                                                               BandType.GSMR1800));

            mncList.Add(new MNCInfo("14", "AAPT", "TPG Telecom", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("15", "3GIS", "", OperStatus.Not_Operational,
                                                                                               BandType.Empty));

            mncList.Add(new MNCInfo("16", "VicTrack", "Victorian Rail Track", OperStatus.Operational,
                                                                                               BandType.GSMR1800));

            mncList.Add(new MNCInfo("17", "", "Optus", OperStatus.Operational,
                                                                                               BandType.TDLTE2300));

            mncList.Add(new MNCInfo("18", "Pactel", "Pactel International Pty Ltd", OperStatus.Not_Operational,
                                                                                               BandType.Empty));

            mncList.Add(new MNCInfo("19", "Lycamobile", "Lycamobile Pty Ltd", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("20", "", "Ausgrid Corporation", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("21", "", "Queensland Rail Limited", OperStatus.Unknown,
                                                                                               BandType.GSMR1800));

            mncList.Add(new MNCInfo("22", "", "iiNet Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("23", "", "Challenge Networks Pty Ltd", OperStatus.Operational,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100));

            mncList.Add(new MNCInfo("24", "", "Advanced Communications Technologies Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("25", "", "Pilbara Iron Company Services Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("26", "", "Dialogue Communications Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("27", "", "Nexium Telecommunications", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("28", "", "RCOM International Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("30", "", "Compatel Limited", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("31", "", "BHP", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("32", "", "Thales Australia", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("33", "", "CLX Networks Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("34", "", "Santos Limited", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("35", "", "MessageBird Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("36", "Optus", "Optus Mobile Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("37", "", "Yancoal Australia Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("38", "Truphone", "Truphone Pty Ltd", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("39", "Telstra", "Telstra Corporation Ltd.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("40", "", "CITIC Pacific Mining", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("41", "", "Aqura Technologies Pty", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("42", "GEMCO", "Groote Eylandt Mining Company Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("43", "", "Arrow Energy Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("44", "", "Roy Hill Iron Ore Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("45", "", "Clermont Coal Operations Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("46", "", "AngloGold Ashanti Australia Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("47", "", "Woodside Energy Limited", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("48", "", "Titan ICT Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("49", "", "Field Solutions Group Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("50", "", "Pivotel Group Pty Ltd", OperStatus.Operational,
                                                                                               BandType.Satellite));

            mncList.Add(new MNCInfo("51", "", "Fortescue Metals Group", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("52", "", "OptiTel Australia", OperStatus.Operational,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.FiveG1800,
                                                                                               BandType.FiveG2100));

            mncList.Add(new MNCInfo("53", "", "Shell Australia Pty Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("61", "CommTel NS", "Commtel Network Solutions Pty Ltd", OperStatus.Implement_Design,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100));

            mncList.Add(new MNCInfo("62", "NBN", "National Broadband Network Co.", OperStatus.Operational,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.TDLTE3500));

            mncList.Add(new MNCInfo("68", "NBN", "National Broadband Network Co.", OperStatus.Operational,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.TDLTE3500));

            mncList.Add(new MNCInfo("71", "Telstra", "Telstra Corporation Limited", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("72", "Telstra", "Telstra Corporation Limited", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("88", "", "Pivotel Group Pty Ltd", OperStatus.Operational,
                                                                                               BandType.Satellite));

            mncList.Add(new MNCInfo("90", "Optus", "Singtel Optus Proprietary Ltd", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("99", "One.Tel", "One.Tel", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            _countries.Add(new CountryInfo(Resources.CC, "CC", "CCK", "166", ContinentCode.AS, new MobileInfo(505, mncList)));
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
            mncList.Add(new MNCInfo("00", "1O1O / One2Free / New World Mobility / SUNMobile", "CSL Limited", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("01", "", "CITIC Telecom 1616", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("02", "", "CSL Limited", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.AMPS));

            mncList.Add(new MNCInfo("03", "3", "Hutchison Telecom", OperStatus.Operational,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.LTE2600,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("04", "3 (2G)", "Hutchison Telecom", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800));

            mncList.Add(new MNCInfo("05", "3 (CDMA)", "Hutchison Telecom", OperStatus.Not_Operational,
                                                                                               BandType.CDMA800));

            mncList.Add(new MNCInfo("06", "SmarTone", "SmarTone Mobile Communications Limited", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.LTE2600,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("07", "China Unicom", "China Unicom (Hong Kong) Limited", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("08", "Truphone", "Truphone Limited", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("09", "", "China Motion Telecom", OperStatus.Not_Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("10", "New World Mobility", "CSL Limited", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncList.Add(new MNCInfo("11", "", "China-Hong Kong Telecom", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("12", "CMCC HK", "China Mobile Hong Kong Company Limited", OperStatus.Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.TDSCDMA2000,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.LTE2600,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("13", "CMCC HK", "China Mobile Hong Kong Company Limited", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("14", "", "Hutchison Telecom", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800));

            mncList.Add(new MNCInfo("15", "", "SmarTone Mobile Communications Limited", OperStatus.Operational,
                                                                                               BandType.GSM1800));

            mncList.Add(new MNCInfo("16", "PCCW Mobile (2G)", "PCCW", OperStatus.Operational,
                                                                                               BandType.GSM1800));

            mncList.Add(new MNCInfo("17", "", "SmarTone Mobile Communications Limited", OperStatus.Operational,
                                                                                               BandType.GSM1800));

            mncList.Add(new MNCInfo("18", "", "CSL Limited", OperStatus.Not_Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800));

            mncList.Add(new MNCInfo("19", "PCCW Mobile (3G)", "PCCW-HKT", OperStatus.Operational,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("20", "PCCW Mobile (4G)", "PCCW-HKT", OperStatus.Operational,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("21", "", "21Vianet Mobile Ltd.", OperStatus.Not_Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("22", "", "263 Mobile Communications (HongKong) Limited", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("23", "Lycamobile", "Lycamobile Hong Kong Ltd", OperStatus.Not_Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("24", "", "Multibyte Info Technology Ltd", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("25", "", "Hong Kong Government", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("26", "", "Hong Kong Government", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("29", "PCCW Mobile (CDMA)", "PCCW-HKT", OperStatus.Operational,
                                                                                               BandType.CDMA800));

            mncList.Add(new MNCInfo("30", "CMCC HK", "China Mobile Hong Kong Company Limited", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("31", "CTExcel", "China Telecom Global Limited", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("32", "", "Hong Kong Broadband Network Ltd", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("35", "", "Webbing Hong Kong Ltd", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("36", "", "Easco Telecommunications Limited", OperStatus.Unknown,
                                                                                               BandType.Unknown));

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
            // mobile info for MCC 404
            List<MNCInfo> mncListfor404 = new List<MNCInfo>();
            mncListfor404.Add(new MNCInfo("01", "Vi India", "Haryana", OperStatus.Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor404.Add(new MNCInfo("02", "AirTel", "Punjab", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300));

            mncListfor404.Add(new MNCInfo("03", "AirTel", "Himachal Pradesh", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300));

            mncListfor404.Add(new MNCInfo("04", "Vi India", "Delhi & NCR", OperStatus.Not_Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor404.Add(new MNCInfo("05", "Vi India", "Gujarat", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor404.Add(new MNCInfo("07", "Vi India", "Andhra Pradesh and Telangana", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor404.Add(new MNCInfo("09", "Reliance", "Assam", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor404.Add(new MNCInfo("10", "AirTel", "Delhi & NCR", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300));

            mncListfor404.Add(new MNCInfo("11", "Vi India", "Delhi & NCR", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor404.Add(new MNCInfo("12", "Vi India", "Haryana", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor404.Add(new MNCInfo("13", "Vi India", "Andhra Pradesh and Telangana", OperStatus.Not_Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor404.Add(new MNCInfo("14", "Vi India", "Punjab", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor404.Add(new MNCInfo("15", "Vi India", "Uttar Pradesh (East)", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor404.Add(new MNCInfo("16", "Airtel", "North East", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300));

            mncListfor404.Add(new MNCInfo("17", "AIRCEL", "West Bengal", OperStatus.Not_Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800));

            mncListfor404.Add(new MNCInfo("18", "Reliance", "Himachal Pradesh", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor404.Add(new MNCInfo("19", "Vi India", "Kerala", OperStatus.Not_Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.TDLTE2500));

            mncListfor404.Add(new MNCInfo("20", "Vi India", "Mumbai", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor404.Add(new MNCInfo("21", "Loop Mobile", "Mumbai", OperStatus.Not_Operational,
                                                                                               BandType.GSM900));

            mncListfor404.Add(new MNCInfo("22", "Vi India", "Maharashtra & Goa", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.TDLTE2500));

            mncListfor404.Add(new MNCInfo("24", "Vi India", "Gujarat", OperStatus.Not_Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor404.Add(new MNCInfo("25", "AIRCEL", "Bihar", OperStatus.Not_Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800));

            mncListfor404.Add(new MNCInfo("27", "Vi India", "Maharashtra & Goa", OperStatus.Not_Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.TDLTE2500));

            mncListfor404.Add(new MNCInfo("28", "AIRCEL", "Odisha", OperStatus.Not_Operational,
                                                                                               BandType.GSM900));

            mncListfor404.Add(new MNCInfo("29", "AIRCEL", "Assam", OperStatus.Not_Operational,
                                                                                               BandType.GSM900));

            mncListfor404.Add(new MNCInfo("30", "Vi India", "Kolkata", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor404.Add(new MNCInfo("31", "AirTel", "Kolkata", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.TDLTE2300));

            mncListfor404.Add(new MNCInfo("34", "BSNL Mobile", "Haryana", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE2100));

            mncListfor404.Add(new MNCInfo("35", "Aircel", "Himachal Pradesh", OperStatus.Not_Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800));

            mncListfor404.Add(new MNCInfo("36", "Reliance", "Bihar & Jharkhand", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor404.Add(new MNCInfo("37", "Aircel", "Jammu & Kashmir", OperStatus.Not_Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100));

            mncListfor404.Add(new MNCInfo("38", "BSNL Mobile", "Assam", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE2100));

            mncListfor404.Add(new MNCInfo("40", "AirTel", "Chennai", OperStatus.Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300));

            mncListfor404.Add(new MNCInfo("41", "AirTel", "Chennai", OperStatus.Not_Operational,
                                                                                               BandType.GSM900));

            mncListfor404.Add(new MNCInfo("42", "AirTel", "Tamil Nadu", OperStatus.Not_Operational,
                                                                                               BandType.GSM900));

            mncListfor404.Add(new MNCInfo("43", "Vi India", "Tamil Nadu", OperStatus.Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100));

            mncListfor404.Add(new MNCInfo("44", "Vi India", "Karnataka", OperStatus.Not_Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100));

            mncListfor404.Add(new MNCInfo("45", "Airtel", "Karnataka", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300));

            mncListfor404.Add(new MNCInfo("46", "Vi India", "Kerala", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.TDLTE2500));

            mncListfor404.Add(new MNCInfo("48", "Dishnet Wireless", "Unknown", OperStatus.Not_Operational,
                                                                                               BandType.GSM900));

            mncListfor404.Add(new MNCInfo("49", "Airtel", "Andhra Pradesh and Telangana", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300));

            mncListfor404.Add(new MNCInfo("50", "Reliance", "North East", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor404.Add(new MNCInfo("51", "BSNL Mobile", "Himachal Pradesh", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE2100));

            mncListfor404.Add(new MNCInfo("52", "Reliance", "Odisha", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor404.Add(new MNCInfo("53", "BSNL Mobile", "Punjab", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE2100));

            mncListfor404.Add(new MNCInfo("54", "BSNL Mobile", "Uttar Pradesh (West)", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE2100));

            mncListfor404.Add(new MNCInfo("55", "BSNL Mobile", "Uttar Pradesh (East)", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE2100));

            mncListfor404.Add(new MNCInfo("56", "Vi India", "Uttar Pradesh (West)", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor404.Add(new MNCInfo("57", "BSNL Mobile", "Gujarat", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE2100));

            mncListfor404.Add(new MNCInfo("58", "BSNL Mobile", "Madhya Pradesh & Chhattisgarh", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE2100));

            mncListfor404.Add(new MNCInfo("59", "BSNL Mobile", "Rajasthan", OperStatus.Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100));

            mncListfor404.Add(new MNCInfo("60", "Vi India", "Rajasthan", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor404.Add(new MNCInfo("62", "BSNL Mobile", "Jammu & Kashmir", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE2100));

            mncListfor404.Add(new MNCInfo("64", "BSNL Mobile", "Chennai", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE2100));

            mncListfor404.Add(new MNCInfo("66", "BSNL Mobile", "Maharashtra & Goa", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE2100));

            mncListfor404.Add(new MNCInfo("67", "Reliance", "Madhya Pradesh & Chhattisgarh", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor404.Add(new MNCInfo("68", "MTNL", "Delhi & NCR", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE2100));

            mncListfor404.Add(new MNCInfo("69", "MTNL", "Mumbai", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100));

            mncListfor404.Add(new MNCInfo("70", "AirTel", "Rajasthan", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300));

            mncListfor404.Add(new MNCInfo("71", "BSNL Mobile", "Karnataka (Bangalore)", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE2100));

            mncListfor404.Add(new MNCInfo("72", "BSNL Mobile", "Kerala", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE2100));

            mncListfor404.Add(new MNCInfo("73", "BSNL Mobile", "Andhra Pradesh and Telangana", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE2100));

            mncListfor404.Add(new MNCInfo("74", "BSNL Mobile", "West Bengal", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE2100));

            mncListfor404.Add(new MNCInfo("75", "BSNL Mobile", "Bihar", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE2100));

            mncListfor404.Add(new MNCInfo("76", "BSNL Mobile", "Odisha", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE2100));

            mncListfor404.Add(new MNCInfo("77", "BSNL Mobile", "North East", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE2100));

            mncListfor404.Add(new MNCInfo("78", "Vi India", "Madhya Pradesh & Chattishgarh", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.TDLTE2500));

            mncListfor404.Add(new MNCInfo("79", "BSNL Mobile", "Andaman Nicobar", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.LTE2100));

            mncListfor404.Add(new MNCInfo("80", "BSNL Mobile", "Tamil Nadu", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE2100));

            mncListfor404.Add(new MNCInfo("81", "BSNL Mobile", "Kolkata", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE2100));

            mncListfor404.Add(new MNCInfo("82", "Vi India", "Himachal Pradesh", OperStatus.Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor404.Add(new MNCInfo("83", "Reliance", "Kolkata", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor404.Add(new MNCInfo("84", "Vi India", "Chennai", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100));

            mncListfor404.Add(new MNCInfo("85", "Reliance", "West Bengal", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor404.Add(new MNCInfo("86", "Vi India", "Karnataka", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100));

            mncListfor404.Add(new MNCInfo("87", "Vi India", "Rajasthan", OperStatus.Not_Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor404.Add(new MNCInfo("88", "Vi India", "Punjab", OperStatus.Not_Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor404.Add(new MNCInfo("89", "Vi India", "Uttar Pradesh (East)", OperStatus.Not_Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor404.Add(new MNCInfo("90", "AirTel", "Maharashtra", OperStatus.Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300));

            mncListfor404.Add(new MNCInfo("91", "AIRCEL", "Kolkata", OperStatus.Not_Operational,
                                                                                               BandType.GSM900));

            mncListfor404.Add(new MNCInfo("92", "AirTel", "Mumbai", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300));

            mncListfor404.Add(new MNCInfo("93", "AirTel", "Madhya Pradesh", OperStatus.Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300));

            mncListfor404.Add(new MNCInfo("94", "AirTel", "Tamil Nadu", OperStatus.Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300));

            mncListfor404.Add(new MNCInfo("95", "AirTel", "Kerala", OperStatus.Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300));

            mncListfor404.Add(new MNCInfo("96", "AirTel", "Haryana", OperStatus.Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300));

            mncListfor404.Add(new MNCInfo("97", "AirTel", "Uttar Pradesh (West)", OperStatus.Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300));

            mncListfor404.Add(new MNCInfo("98", "AirTel", "Gujarat", OperStatus.Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300));
            var mobile404 = new MobileInfo(404, mncListfor404);

            // mobile info for MCC 405
            List<MNCInfo> mncListfor405 = new List<MNCInfo>();
            mncListfor405.Add(new MNCInfo("01", "Reliance", "Andhra Pradesh and Telangana", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("025", "TATA DOCOMO", "Andhra Pradesh and Telangana", OperStatus.Not_Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100));

            mncListfor405.Add(new MNCInfo("026", "TATA DOCOMO", "Assam", OperStatus.Not_Operational,
                                                                                               BandType.CDMA850));

            mncListfor405.Add(new MNCInfo("027", "TATA DOCOMO", "Bihar/Jharkhand", OperStatus.Not_Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("028", "TATA DOCOMO", "Chennai", OperStatus.Not_Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("029", "TATA DOCOMO", "Delhi", OperStatus.Not_Operational,
                                                                                               BandType.CDMA850));

            mncListfor405.Add(new MNCInfo("03", "Reliance", "Bihar", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor405.Add(new MNCInfo("030", "TATA DOCOMO", "Gujarat", OperStatus.Not_Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100));

            mncListfor405.Add(new MNCInfo("031", "TATA DOCOMO", "Haryana", OperStatus.Not_Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100));

            mncListfor405.Add(new MNCInfo("032", "TATA DOCOMO", "Himachal Pradesh", OperStatus.Not_Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100));

            mncListfor405.Add(new MNCInfo("033", "TATA DOCOMO", "Jammu & Kashmir", OperStatus.Not_Operational,
                                                                                               BandType.CDMA850));

            mncListfor405.Add(new MNCInfo("034", "TATA DOCOMO", "Karnataka", OperStatus.Not_Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100));

            mncListfor405.Add(new MNCInfo("035", "TATA DOCOMO", "Kerala", OperStatus.Not_Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100));

            mncListfor405.Add(new MNCInfo("036", "TATA DOCOMO", "Kolkata", OperStatus.Not_Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("037", "TATA DOCOMO", "Maharashtra & Goa", OperStatus.Not_Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100));

            mncListfor405.Add(new MNCInfo("038", "TATA DOCOMO", "Madhya Pradesh", OperStatus.Not_Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100));

            mncListfor405.Add(new MNCInfo("039", "TATA DOCOMO", "Mumbai", OperStatus.Not_Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("04", "Reliance", "Chennai", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor405.Add(new MNCInfo("041", "TATA DOCOMO", "Odisha", OperStatus.Not_Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("042", "TATA DOCOMO", "Punjab", OperStatus.Not_Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100));

            mncListfor405.Add(new MNCInfo("043", "TATA DOCOMO", "Rajasthan", OperStatus.Not_Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100));

            mncListfor405.Add(new MNCInfo("044", "TATA DOCOMO", "Tamil Nadu including Chennai", OperStatus.Not_Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("045", "TATA DOCOMO", "Uttar Pradesh (East)", OperStatus.Not_Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("046", "TATA DOCOMO", "Uttar Pradesh (West) & Uttarakhand", OperStatus.Not_Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100));

            mncListfor405.Add(new MNCInfo("047", "TATA DOCOMO", "West Bengal", OperStatus.Not_Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("05", "Reliance", "Delhi & NCR", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor405.Add(new MNCInfo("06", "Reliance", "Gujarat", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor405.Add(new MNCInfo("07", "Reliance", "Haryana", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor405.Add(new MNCInfo("08", "Reliance", "Himachal Pradesh", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor405.Add(new MNCInfo("09", "Reliance", "Jammu & Kashmir", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor405.Add(new MNCInfo("10", "Reliance", "Karnataka", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor405.Add(new MNCInfo("11", "Reliance", "Kerala", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor405.Add(new MNCInfo("12", "Reliance", "Kolkata", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor405.Add(new MNCInfo("13", "Reliance", "Maharashtra & Goa", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor405.Add(new MNCInfo("14", "Reliance", "Madhya Pradesh", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor405.Add(new MNCInfo("15", "Reliance", "Mumbai", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor405.Add(new MNCInfo("17", "Reliance", "Odisha", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor405.Add(new MNCInfo("18", "Reliance", "Punjab", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor405.Add(new MNCInfo("19", "Reliance", "Rajasthan", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor405.Add(new MNCInfo("20", "Reliance", "Tamil Nadu", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor405.Add(new MNCInfo("21", "Reliance", "Uttar Pradesh (East)", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor405.Add(new MNCInfo("22", "Reliance", "Uttar Pradesh (West)", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor405.Add(new MNCInfo("23", "Reliance", "West Bengal", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor405.Add(new MNCInfo("51", "AirTel", "West Bengal", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300));

            mncListfor405.Add(new MNCInfo("52", "AirTel", "Bihar & Jharkhand", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300));

            mncListfor405.Add(new MNCInfo("53", "AirTel", "Odisha", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300));

            mncListfor405.Add(new MNCInfo("54", "AirTel", "Uttar Pradesh (East)", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300));

            mncListfor405.Add(new MNCInfo("55", "Airtel", "Jammu & Kashmir", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300));

            mncListfor405.Add(new MNCInfo("56", "AirTel", "Assam", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300));

            mncListfor405.Add(new MNCInfo("66", "Vi India", "Uttar Pradesh (West)", OperStatus.Not_Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor405.Add(new MNCInfo("67", "Vi India", "West Bengal", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor405.Add(new MNCInfo("70", "Vi India", "Bihar & Jharkhand", OperStatus.Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor405.Add(new MNCInfo("750", "Vi India", "Jammu & Kashmir", OperStatus.Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor405.Add(new MNCInfo("751", "Vi India", "Assam", OperStatus.Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor405.Add(new MNCInfo("752", "Vi India", "Bihar & Jharkhand", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor405.Add(new MNCInfo("753", "Vi India", "Odisha", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor405.Add(new MNCInfo("754", "Vi India", "Himachal Pradesh", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor405.Add(new MNCInfo("755", "Vi India", "North East", OperStatus.Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor405.Add(new MNCInfo("756", "Vi India", "Madhya Pradesh & Chhattisgarh", OperStatus.Not_Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.TDLTE2500));

            mncListfor405.Add(new MNCInfo("799", "Vi India", "Mumbai", OperStatus.Not_Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor405.Add(new MNCInfo("800", "AIRCEL", "Delhi & NCR", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("801", "AIRCEL", "Andhra Pradesh and Telangana", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("802", "AIRCEL", "Gujarat", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("803", "AIRCEL", "Karnataka", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("804", "AIRCEL", "Maharashtra & Goa", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("805", "AIRCEL", "Mumbai", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("806", "AIRCEL", "Rajasthan", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("807", "AIRCEL", "Haryana", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("808", "AIRCEL", "Madhya Pradesh", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("809", "AIRCEL", "Kerala", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("810", "AIRCEL", "Uttar Pradesh (East)", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("811", "AIRCEL", "Uttar Pradesh (West)", OperStatus.Not_Operational,
                                                                                               BandType.GSM));

            mncListfor405.Add(new MNCInfo("812", "AIRCEL", "Punjab", OperStatus.Not_Operational,
                                                                                               BandType.GSM));

            mncListfor405.Add(new MNCInfo("819", "Uninor", "Andhra Pradesh and Telangana", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("818", "Uninor", "Uttar Pradesh (West)", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("820", "Uninor", "Karnataka", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("821", "Uninor", "Kerala", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("822", "Uninor", "Kolkata", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("824", "Videocon Telecom", "Assam", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("827", "Videocon Telecom", "Gujarat", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("834", "Videocon Telecom", "Madhya Pradesh", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("844", "Uninor", "Delhi & NCR", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("840", "Jio", "West Bengal", OperStatus.Operational,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1800,
                                                                                               BandType.TDLTE2300));

            mncListfor405.Add(new MNCInfo("845", "Vi India", "Assam", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor405.Add(new MNCInfo("846", "Vi India", "Jammu & Kashmir", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor405.Add(new MNCInfo("847", "Vi India", "Karnataka", OperStatus.Not_Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100));

            mncListfor405.Add(new MNCInfo("848", "Vi India", "Kolkata", OperStatus.Not_Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor405.Add(new MNCInfo("849", "Vi India", "North East", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor405.Add(new MNCInfo("850", "Vi India", "Odisha", OperStatus.Not_Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor405.Add(new MNCInfo("851", "Vi India", "Punjab", OperStatus.Not_Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor405.Add(new MNCInfo("852", "Vi India", "Tamil Nadu", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100));

            mncListfor405.Add(new MNCInfo("853", "Vi India", "West Bengal", OperStatus.Not_Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor405.Add(new MNCInfo("854", "Jio", "Andhra Pradesh", OperStatus.Operational,
                                                                                               BandType.LTE1800,
                                                                                               BandType.TDLTE2300));

            mncListfor405.Add(new MNCInfo("855", "Jio", "Assam", OperStatus.Operational,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1800,
                                                                                               BandType.TDLTE2300));

            mncListfor405.Add(new MNCInfo("856", "Jio", "Bihar", OperStatus.Operational,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1800,
                                                                                               BandType.TDLTE2300));

            mncListfor405.Add(new MNCInfo("857", "Jio", "Gujarat", OperStatus.Operational,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1800,
                                                                                               BandType.TDLTE2300));

            mncListfor405.Add(new MNCInfo("858", "Jio", "Haryana", OperStatus.Operational,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1800,
                                                                                               BandType.TDLTE2300));

            mncListfor405.Add(new MNCInfo("859", "Jio", "Himachal Pradesh", OperStatus.Operational,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1800,
                                                                                               BandType.TDLTE2300));

            mncListfor405.Add(new MNCInfo("860", "Jio", "Jammu & Kashmir", OperStatus.Operational,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1800,
                                                                                               BandType.TDLTE2300));

            mncListfor405.Add(new MNCInfo("861", "Jio", "Karnataka", OperStatus.Operational,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1800,
                                                                                               BandType.TDLTE2300));

            mncListfor405.Add(new MNCInfo("862", "Jio", "Kerala", OperStatus.Operational,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1800,
                                                                                               BandType.TDLTE2300));

            mncListfor405.Add(new MNCInfo("863", "Jio", "Madhya Pradesh", OperStatus.Operational,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1800,
                                                                                               BandType.TDLTE2300));

            mncListfor405.Add(new MNCInfo("864", "Jio", "Maharashtra", OperStatus.Operational,
                                                                                               BandType.LTE1800,
                                                                                               BandType.TDLTE2300));

            mncListfor405.Add(new MNCInfo("865", "Jio", "North East", OperStatus.Operational,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1800,
                                                                                               BandType.TDLTE2300));

            mncListfor405.Add(new MNCInfo("866", "Jio", "Odisha", OperStatus.Operational,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1800,
                                                                                               BandType.TDLTE2300));

            mncListfor405.Add(new MNCInfo("867", "Jio", "Punjab", OperStatus.Operational,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1800,
                                                                                               BandType.TDLTE2300));

            mncListfor405.Add(new MNCInfo("868", "Jio", "Rajasthan", OperStatus.Operational,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1800,
                                                                                               BandType.TDLTE2300));

            mncListfor405.Add(new MNCInfo("869", "Jio", "Tamil Nadu (incl. Chennai)", OperStatus.Operational,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1800,
                                                                                               BandType.TDLTE2300));

            mncListfor405.Add(new MNCInfo("870", "Jio", "Uttar Pradesh (West)", OperStatus.Operational,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1800,
                                                                                               BandType.TDLTE2300));

            mncListfor405.Add(new MNCInfo("871", "Jio", "Uttar Pradesh (East)", OperStatus.Operational,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1800,
                                                                                               BandType.TDLTE2300));

            mncListfor405.Add(new MNCInfo("872", "Jio", "Delhi", OperStatus.Operational,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1800,
                                                                                               BandType.TDLTE2300));

            mncListfor405.Add(new MNCInfo("873", "Jio", "Kolkata", OperStatus.Operational,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1800,
                                                                                               BandType.TDLTE2300));

            mncListfor405.Add(new MNCInfo("874", "Jio", "Mumbai", OperStatus.Operational,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1800,
                                                                                               BandType.TDLTE2300));

            mncListfor405.Add(new MNCInfo("875", "Uninor", "Assam", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("880", "Uninor", "West Bengal", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("881", "S Tel", "Assam", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("908", "Vi India", "Andhra Pradesh and Telangana", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor405.Add(new MNCInfo("909", "Vi India", "Delhi", OperStatus.Not_Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor405.Add(new MNCInfo("910", "Vi India", "Haryana", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500));

            mncListfor405.Add(new MNCInfo("911", "Vi India", "Maharashtra", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.TDLTE2500));

            mncListfor405.Add(new MNCInfo("912", "Etisalat DB (cheers)", "Andhra Pradesh and Telangana", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("913", "Etisalat DB (cheers)", "Delhi & NCR", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("914", "Etisalat DB (cheers)", "Gujarat", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("917", "Etisalat DB (cheers)", "Kerala", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("927", "Uninor", "Gujarat", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncListfor405.Add(new MNCInfo("929", "Uninor", "Maharashtra", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));
            var mobile405 = new MobileInfo(405, mncListfor405);

            _countries.Add(new CountryInfo(Resources.IN, "IN", "IND", "356", ContinentCode.AS, mobile404, mobile405, new MobileInfo(406)));
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
            mncList.Add(new MNCInfo("01", "Uname", "Ertebatat Iran", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncList.Add(new MNCInfo("02", "ApTel, AzarTel", "NeginTel", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("08", "Shatel Mobile", "Shatel Group", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("10", "Samantel", "Samantel Mobile", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("11", "IR-TCI (Hamrah-e-Avval)", "Mobile Communications Company of Iran (MCI)", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("12", "Avacell(HiWEB)", "Dadeh Dostar asr Novin p.j.s. co & Information Technology Company of Iran", OperStatus.Operational,
                                                                                               BandType.LTE800,
                                                                                               BandType.TDLTE2600));

            mncList.Add(new MNCInfo("14", "TKC/KFZO", "Telecommunication Kish Company", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800));

            mncList.Add(new MNCInfo("19", "Espadan (JV-PJS)", "Mobile Telecommunications Company of Esfahan", OperStatus.Operational,
                                                                                               BandType.GSM900));

            mncList.Add(new MNCInfo("20", "RighTel", "Social Security Investment Co.", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("21", "RighTel", "Social Security Investment Co.", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("32", "Taliya", "TCI of Iran and Iran Mobin", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800));

            mncList.Add(new MNCInfo("35", "MTN Irancell", "MTN Irancell Telecommunications Services Company", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.LTE2600,
                                                                                               BandType.TDLTE3500,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("40", "Mobinnet", "Ertebatat Mobinnet", OperStatus.Operational,
                                                                                               BandType.WiMAX,
                                                                                               BandType.LTE3500));

            mncList.Add(new MNCInfo("45", "Zi-Tel", "Farabord Dadeh Haye Iranian Co.", OperStatus.Operational,
                                                                                               BandType.TDLTE));

            mncList.Add(new MNCInfo("50", "Shatel Mobile", "Shatel Group", OperStatus.Operational,
                                                                                               BandType.TDLTE2600MHz));

            mncList.Add(new MNCInfo("70", "MTCE", "Telephone Communications Company of Iran", OperStatus.Operational,
                                                                                               BandType.GSM900));

            mncList.Add(new MNCInfo("71", "KOOHE NOOR", "Telephone Communications Company of Iran", OperStatus.Operational,
                                                                                               BandType.GSM900));

            mncList.Add(new MNCInfo("90", "Iraphone", "IRAPHONE GHESHM of Iran", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800));

            mncList.Add(new MNCInfo("93", "Iraphone", "Iraphone", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800));

            mncList.Add(new MNCInfo("93", "Farzanegan Pars", "Farzanegan Pars", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800));

            mncList.Add(new MNCInfo("99", "TCI (GSM WLL)", "TCI of Iran and Rightel", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800));

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
            mncList.Add(new MNCInfo("00", "Asia Cell", "Asia Cell Telecommunications Company", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("05", "Asia Cell", "Asia Cell Telecommunications Company", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("08", "SanaTel", "", OperStatus.Operational,
                                                                                               BandType.GSM900));

            mncList.Add(new MNCInfo("20", "Zain", "Zain Iraq", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("30", "Zain", "Zain Iraq", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("40", "Korek", "Telecom Ltd", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("45", "Mobitel", "Mobitel Co. Ltd.", OperStatus.Operational,
                                                                                               BandType.UMTS));

            mncList.Add(new MNCInfo("62", "Itisaluna", "Itisaluna Wireless CO.", OperStatus.Operational,
                                                                                               BandType.CDMA800,
                                                                                               BandType.CDMA1900));

            mncList.Add(new MNCInfo("92", "Omnnea", "Omnnea Wireless", OperStatus.Operational,
                                                                                               BandType.CDMA));

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
            mncList.Add(new MNCInfo("01", "Partner", "Partner Communications Company Ltd.", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("02", "Cellcom", "Cellcom Israel Ltd.", OperStatus.Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("03", "Pelephone", "Pelephone Communications Ltd.", OperStatus.Operational,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("04", "", "Globalsim Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("05", "Jawwal", "Palestine Cellular Communications Ltd.", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("06", "Wataniya Mobile", "Wataniya Palestine Ltd. (Ooredoo)", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("07", "Hot Mobile", "Hot Mobile Ltd.", OperStatus.Operational,
                                                                                               BandType.iDEN800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("08", "Golan Telecom", "Golan Telecom Ltd.", OperStatus.Operational,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("09", "We4G", "Marathon 018 Xphone Ltd.", OperStatus.Operational,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("10", "Partner", "Partner Communications Company Ltd.", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("11", "", "365 Telecom", OperStatus.Not_Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("12", "x2one", "Free Telecom", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("13", "", "Ituran Cellular Communications", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("14", "Youphone", "Alon Cellular Ltd.", OperStatus.Not_Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("15", "Home Cellular", "Home Cellular Ltd.", OperStatus.Not_Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("16", "Rami Levy", "Rami Levy Communications Ltd.", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("17", "Sipme", "Gale Phone", OperStatus.Not_Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("18", "Cellact Communications", "Cellact Communications Ltd.", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("19", "019 Mobile", "019 Communication Services Ltd. / TELZAR", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("20", "Bezeq", "Bezeq The Israeli Telecommunication Corp Ltd.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("21", "Bezeq International", "B.I.P. Communications Ltd.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("22", "", "Maskyoo Telephonia Ltd.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("23", "", "Beezz Communication Solutions Ltd.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("24", "012 Mobile", "Partner Communications Company Ltd.", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("25", "IMOD", "Israel Ministry of Defense", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncList.Add(new MNCInfo("26", "Annatel", "LB Annatel Ltd.", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("28", "", "PHI Networks", OperStatus.Unknown,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("29", "", "CG Networks", OperStatus.Unknown,
                                                                                               BandType.Unknown));

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
            // mobile info for MCC 440
            List<MNCInfo> mncListfor440 = new List<MNCInfo>();
            mncListfor440.Add(new MNCInfo("00", "Y!Mobile", "SoftBank Corp.", OperStatus.Operational,
                                                                                               BandType.UMTS1800));

            mncListfor440.Add(new MNCInfo("01", "UQ WiMAX", "UQ Communications Inc.", OperStatus.Operational,
                                                                                               BandType.TDLTE2500));

            mncListfor440.Add(new MNCInfo("02", "", "Hanshin Cable Engineering Co., Ltd.", OperStatus.Unknown,
                                                                                               BandType.WiMAX2500));

            mncListfor440.Add(new MNCInfo("03", "IIJmio", "Internet Initiative Japan Inc.", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncListfor440.Add(new MNCInfo("04", "", "Japan Radio Company, Ltd.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor440.Add(new MNCInfo("05", "", "Wireless City Planning Inc.", OperStatus.Operational,
                                                                                               BandType.TDLTE2500));

            mncListfor440.Add(new MNCInfo("06", "", "SAKURA Internet Inc.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor440.Add(new MNCInfo("07", "", "LTE-X, Inc.", OperStatus.Unknown,
                                                                                               BandType.MVNO));

            mncListfor440.Add(new MNCInfo("08", "", "Panasonic Systems Solutions Japan Co., Ltd.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor440.Add(new MNCInfo("09", "", "Marubeni Wireless Communications Inc.", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncListfor440.Add(new MNCInfo("10", "NTT docomo", "NTT DoCoMo, Inc.", OperStatus.Operational,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1500,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE3500,
                                                                                               BandType.FiveG3500,
                                                                                               BandType.FiveG4700,
                                                                                               BandType.FiveG28000));

            mncListfor440.Add(new MNCInfo("11", "Rakuten Mobile", "Rakuten Mobile Network, Inc.", OperStatus.Operational,
                                                                                               BandType.LTE1800,
                                                                                               BandType.FiveG3700));

            mncListfor440.Add(new MNCInfo("12", "", "Cable media waiwai Co., Ltd.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor440.Add(new MNCInfo("20", "SoftBank", "SoftBank Corp.", OperStatus.Operational,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1500,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500,
                                                                                               BandType.TDLTE3500,
                                                                                               BandType.FiveG3700,
                                                                                               BandType.FiveG28000));

            mncListfor440.Add(new MNCInfo("21", "SoftBank", "SoftBank Corp.", OperStatus.Operational,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1500,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500,
                                                                                               BandType.TDLTE3500,
                                                                                               BandType.FiveG3700,
                                                                                               BandType.FiveG28000));

            mncListfor440.Add(new MNCInfo("50", "au", "KDDI Corporation", OperStatus.Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1500,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500,
                                                                                               BandType.TDLTE3500,
                                                                                               BandType.FiveG3700,
                                                                                               BandType.FiveG28000));

            mncListfor440.Add(new MNCInfo("51", "au", "KDDI Corporation", OperStatus.Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1500,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500,
                                                                                               BandType.TDLTE3500,
                                                                                               BandType.FiveG3700,
                                                                                               BandType.FiveG28000));

            mncListfor440.Add(new MNCInfo("52", "au", "KDDI Corporation", OperStatus.Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1500,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500,
                                                                                               BandType.TDLTE3500,
                                                                                               BandType.FiveG3700,
                                                                                               BandType.FiveG28000));

            mncListfor440.Add(new MNCInfo("53", "au", "KDDI Corporation", OperStatus.Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1500,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500,
                                                                                               BandType.TDLTE3500,
                                                                                               BandType.FiveG3700,
                                                                                               BandType.FiveG28000));

            mncListfor440.Add(new MNCInfo("54", "au", "KDDI Corporation", OperStatus.Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.CDMA2000));

            mncListfor440.Add(new MNCInfo("70", "au", "KDDI Corporation", OperStatus.Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.CDMA2000));

            mncListfor440.Add(new MNCInfo("71", "au", "KDDI Corporation", OperStatus.Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.CDMA2000));

            mncListfor440.Add(new MNCInfo("72", "au", "KDDI Corporation", OperStatus.Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.CDMA2000));

            mncListfor440.Add(new MNCInfo("73", "au", "KDDI Corporation", OperStatus.Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.CDMA2000));

            mncListfor440.Add(new MNCInfo("74", "au", "KDDI Corporation", OperStatus.Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.CDMA2000));

            mncListfor440.Add(new MNCInfo("75", "au", "KDDI Corporation", OperStatus.Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.CDMA2000));

            mncListfor440.Add(new MNCInfo("76", "au", "KDDI Corporation", OperStatus.Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.CDMA2000));

            mncListfor440.Add(new MNCInfo("78", "au", "Okinawa Cellular Telephone", OperStatus.Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.CDMA2000));
            var mobile440 = new MobileInfo(440, mncListfor440);

            // mobile info for MCC 441
            List<MNCInfo> mncListfor441 = new List<MNCInfo>();
            mncListfor441.Add(new MNCInfo("00", "", "Wireless City Planning Inc.", OperStatus.Operational,
                                                                                               BandType.TDLTE2500));

            mncListfor441.Add(new MNCInfo("01", "SoftBank", "SoftBank Corp.", OperStatus.Operational,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1500,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500,
                                                                                               BandType.TDLTE3500,
                                                                                               BandType.FiveG3700));

            mncListfor441.Add(new MNCInfo("10", "UQ WiMAX", "UQ Communications Inc.", OperStatus.Operational,
                                                                                               BandType.TDLTE2500));

            mncListfor441.Add(new MNCInfo("91", "", "Tokyo Organising Committee of the Olympic and Paralympic Games", OperStatus.Unknown,
                                                                                               BandType.Unknown));
            var mobile441 = new MobileInfo(441, mncListfor441);

            _countries.Add(new CountryInfo(Resources.JP, "JP", "JPN", "392", ContinentCode.AS, mobile440, mobile441));
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
            mncList.Add(new MNCInfo("01", "zain JO", "Jordan Mobile Telephone Services", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("02", "XPress Telecom", "XPress Telecom", OperStatus.Not_Operational,
                                                                                               BandType.iDEN800));

            mncList.Add(new MNCInfo("03", "Umniah", "Umniah Mobile Company", OperStatus.Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE3500));

            mncList.Add(new MNCInfo("77", "Orange", "Petra Jordanian Mobile Telecommunications Company (MobileCom)", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600));

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
            mncList.Add(new MNCInfo("01", "Beeline", "KaR-Tel LLP", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100));

            mncList.Add(new MNCInfo("02", "Kcell", "Kcell JSC", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("07", "Altel", "Altel", OperStatus.Operational,
                                                                                               BandType.UMTS850,
                                                                                               BandType.GSM1800,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("08", "Kazakhtelecom", "", OperStatus.Operational,
                                                                                               BandType.CDMA450,
                                                                                               BandType.CDMA800));

            mncList.Add(new MNCInfo("77", "Tele2.kz", "MTS", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.FiveG));

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
            mncList.Add(new MNCInfo("05", "Koryolink", "Cheo Technology Jv Company", OperStatus.Operational,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("06", "Koryolink", "Cheo Technology Jv Company", OperStatus.Operational,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("193", "SunNet", "Korea Posts and Telecommunications Corporation", OperStatus.Not_Operational,
                                                                                               BandType.GSM900));

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
            mncList.Add(new MNCInfo("01", "", "Globalstar Asia Pacific", OperStatus.Operational,
                                                                                               BandType.Satellite));

            mncList.Add(new MNCInfo("02", "KT", "KT", OperStatus.Operational,
                                                                                               BandType.FiveG3500,
                                                                                               BandType.FiveG28000));

            mncList.Add(new MNCInfo("03", "Power 017", "Shinsegi Telecom, Inc.", OperStatus.Not_Operational,
                                                                                               BandType.CDMA850));

            mncList.Add(new MNCInfo("04", "KT", "KT", OperStatus.Operational,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("05", "SKTelecom", "SK Telecom", OperStatus.Operational,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.LTE2600,
                                                                                               BandType.FiveG3500,
                                                                                               BandType.FiveG28000));

            mncList.Add(new MNCInfo("06", "LG U+", "LG Telecom", OperStatus.Operational,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE2100,
                                                                                               BandType.LTE2600,
                                                                                               BandType.FiveG3500,
                                                                                               BandType.FiveG28000));

            mncList.Add(new MNCInfo("07", "KT", "KT", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("08", "olleh", "KT", OperStatus.Operational,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100));

            mncList.Add(new MNCInfo("11", "Tplus", "Korea Cable Telecom", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("12", "SKTelecom", "SK Telecom", OperStatus.Operational,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1800));

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
            mncList.Add(new MNCInfo("02", "zain KW", "Zain Kuwait", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("03", "K.S.C Ooredoo", "National Mobile Telecommunications", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("04", "STC", "Saudi Telecom Company", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.FiveG2100,
                                                                                               BandType.FiveG3500));

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
            mncList.Add(new MNCInfo("01", "Beeline", "Sky Mobile LLC", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800));

            mncList.Add(new MNCInfo("03", "", "7 Mobile", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("05", "MegaCom", "Alfa Telecom CJSC", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100));

            mncList.Add(new MNCInfo("09", "O!", "NurTelecom LLC", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("10", "", "Saima Telecom", OperStatus.Operational,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("11", "", "iTel", OperStatus.Unknown,
                                                                                               BandType.Unknown));

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
            mncList.Add(new MNCInfo("01", "LaoTel", "Lao Telecom", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.FiveG));

            mncList.Add(new MNCInfo("02", "ETL", "Enterprise of Telecommunications Lao", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("03", "Unitel", "Star Telecom Co., Ltd", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("07", "Best", "Best Telecom Co., Ltd", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("08", "Beeline", "VimpelCom Lao Ltd", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100));

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
            mncList.Add(new MNCInfo("01", "Alfa", "MIC 1", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("03", "Touch", "MIC 2", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("05", "Ogero Mobile", "Ogero Telecom", OperStatus.Not_Operational,
                                                                                               BandType.GSM900));

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
            mncList.Add(new MNCInfo("00", "SmarTone", "Smartone – Comunicações Móveis, S.A.", OperStatus.Operational,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("01", "CTM", "Companhia de Telecomunicações de Macau, S.A.R.L.", OperStatus.Operational,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("02", "China Telecom", "China Telecom (Macau) Company Limited", OperStatus.Not_Operational,
                                                                                               BandType.CDMA800));

            mncList.Add(new MNCInfo("03", "3", "Hutchison Telephone (Macau), Limitada", OperStatus.Not_Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800));

            mncList.Add(new MNCInfo("04", "CTM", "Companhia de Telecomunicações de Macau, S.A.R.L.", OperStatus.Operational,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("05", "3", "Hutchison Telephone (Macau), Limitada", OperStatus.Operational,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("06", "SmarTone", "Smartone – Comunicações Móveis, S.A.", OperStatus.Operational,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("07", "China Telecom", "China Telecom (Macau) Limitada", OperStatus.Operational,
                                                                                               BandType.LTE1800));

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
            mncList.Add(new MNCInfo("01", "Dhiraagu", "Dhivehi Raajjeyge Gulhun", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("02", "Ooredoo", "Ooredoo Maldives", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600));

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
            mncList.Add(new MNCInfo("88", "Unitel", "Unitel LLC", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1800,
                                                                                               BandType.TDLTE2300));

            mncList.Add(new MNCInfo("91", "Skytel", "Skytel LLC", OperStatus.Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("98", "G-Mobile", "G-Mobile LLC", OperStatus.Operational,
                                                                                               BandType.CDMA450,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("99", "Mobicom", "Mobicom Corporation", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1800));

            _countries.Add(new CountryInfo(Resources.MN, "MN", "MNG", "496", ContinentCode.AS, new MobileInfo(428, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "MM". <br/>
        /// Alpha2Cod2 NM 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/

        static void AddInfoForMM()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("00", "MPT", "Myanmar Posts and Telecommunications", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("01", "MPT", "Myanmar Posts and Telecommunications", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100));

            mncList.Add(new MNCInfo("02", "MPT", "Myanmar Posts and Telecommunications", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("03", "CDMA800", "Myanmar Economic Corporation", OperStatus.Operational,
                                                                                               BandType.CDMA800));

            mncList.Add(new MNCInfo("04", "MPT", "Myanmar Posts and Telecommunications", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("05", "Ooredoo", "Ooredoo Myanmar", OperStatus.Operational,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100));

            mncList.Add(new MNCInfo("06", "Telenor", "Telenor Myanmar", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100));

            mncList.Add(new MNCInfo("09", "Mytel", "Myanmar National Tele & Communication Co., Ltd", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE2100));

            mncList.Add(new MNCInfo("20", "ACS", "Amara Communication Co., Ltd", OperStatus.Operational,
                                                                                               BandType.TDLTE2600));

            mncList.Add(new MNCInfo("21", "ACS", "Amara Communication Co., Ltd", OperStatus.Operational,
                                                                                               BandType.TDLTE2600));

            mncList.Add(new MNCInfo("22", "", "Fortune Telecom Co., Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("23", "", "Global Technology Co., Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

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
            mncList.Add(new MNCInfo("01", "Namaste / NT Mobile / Sky Phone", "Nepal Telecom (NDCL)", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.CDMA850,
                                                                                               BandType.WiMAX));

            mncList.Add(new MNCInfo("02", "Ncell", "Ncell Pvt. Ltd.", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("03", "UTL", "United Telecom Limited", OperStatus.Operational,
                                                                                               BandType.CDMA2000800));

            mncList.Add(new MNCInfo("04", "SmartCell", "Smart Telecom Pvt. Ltd. (STPL)", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

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
            mncList.Add(new MNCInfo("02", "Omantel", "Oman Telecommunications Company", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("03", "ooredoo", "Omani Qatari Telecommunications Company SAOC", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS900,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("04", "Omantel", "Oman Telecommunications Company", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("06", "Omantel", "Omani Qatari Telecommunications Company SAOC", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

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
            mncList.Add(new MNCInfo("01", "Jazz", "Mobilink-PMCL", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("02", "3G EVO / CharJi 4G", "PTCL", OperStatus.Operational,
                                                                                               BandType.CDMA20001900,
                                                                                               BandType.TDLTE1900));

            mncList.Add(new MNCInfo("03", "Ufone", "Pakistan Telecommunication Mobile Ltd", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("04", "Zong", "China Mobile", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100));

            mncList.Add(new MNCInfo("05", "SCO Mobile", "SCO Mobile Ltd", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("06", "Telenor", "Telenor Pakistan", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("07", "Jazz", "WaridTel", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("08", "SCO Mobile", "SCO Mobile Ltd", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

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
            mncList.Add(new MNCInfo("05", "Jawwal", "Palestine Cellular Communications, Ltd.", OperStatus.Operational,
                                                                                               BandType.GSM900));

            mncList.Add(new MNCInfo("06", "Wataniya", "Wataniya Palestine Mobile Telecommunications Company", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800));

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
            mncList.Add(new MNCInfo("01", "ooredoo", "ooredoo", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("02", "Vodafone", "Vodafone Qatar", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("05", "Ministry of Interior", "Ministry of Interior", OperStatus.Operational,
                                                                                               BandType.TETRA380));

            mncList.Add(new MNCInfo("06", "Ministry of Interior", "Ministry of Interior", OperStatus.Operational,
                                                                                               BandType.LTE));

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
            mncList.Add(new MNCInfo("01", "Al Jawal (STC )", "Saudi Telecom Company", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("03", "Mobily", "Etihad Etisalat Company", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.TDLTE2500));

            mncList.Add(new MNCInfo("04", "Zain SA", "Zain Saudi Arabia", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.TDLTE2500,
                                                                                               BandType.FiveG2500,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("05", "Virgin Mobile", "Virgin Mobile Saudi Arabia", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("06", "Lebara Mobile", "Lebara Mobile", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("21", "RGSM", "Saudi Railways GSM", OperStatus.Operational,
                                                                                               BandType.GSMR900));

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
            mncList.Add(new MNCInfo("01", "Mobitel", "Mobitel (Pvt) Ltd", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100));

            mncList.Add(new MNCInfo("02", "Dialog", "Dialog Axiata PLC", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("03", "Hutch", "Hutchison Telecommunications Lanka (Pvt) Ltd", OperStatus.Not_Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("04", "Lanka Bell", "Lanka Bell Ltd", OperStatus.Operational,
                                                                                               BandType.CDMA,
                                                                                               BandType.WiMAX,
                                                                                               BandType.TDLTE2300));

            mncList.Add(new MNCInfo("05", "Airtel", "Bharti Airtel Lanka (Pvt) Ltd", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("08", "Hutch", "Hutchison Telecommunications Lanka (Pvt) Ltd", OperStatus.Not_Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("09", "Hutch", "Hutchison Telecommunications Lanka (Pvt) Ltd", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("11", "Dialog", "Dialog Broadband Networks (Pvt) Ltd", OperStatus.Operational,
                                                                                               BandType.CDMA,
                                                                                               BandType.WiMAX,
                                                                                               BandType.TDLTE2300));

            mncList.Add(new MNCInfo("12", "SLT", "Sri Lanka Telecom PLC", OperStatus.Operational,
                                                                                               BandType.TDLTE2600));

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
            mncList.Add(new MNCInfo("01", "Syriatel", "Syriatel Mobile Telecom", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("02", "MTN", "MTN Syria", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("09", "", "Syrian Telecom", OperStatus.Unknown,
                                                                                               BandType.Unknown));

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
            mncList.Add(new MNCInfo("01", "FarEasTone", "Far EasTone Telecommunications Co Ltd", OperStatus.Operational,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.LTE2600,
                                                                                               BandType.FiveG2100,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("02", "FarEasTone", "Far EasTone Telecommunications Co Ltd", OperStatus.Not_Operational,
                                                                                               BandType.GSM900));

            mncList.Add(new MNCInfo("03", "FarEasTone", "Far EasTone Telecommunications Co Ltd", OperStatus.Not_Operational,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("05", "Gt", "Asia Pacific Telecom", OperStatus.Operational,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE900,
                                                                                               BandType.TDLTE2600,
                                                                                               BandType.FiveG3500,
                                                                                               BandType.FiveG28000));

            mncList.Add(new MNCInfo("06", "FarEasTone", "Far EasTone Telecommunications Co Ltd", OperStatus.Not_Operational,
                                                                                               BandType.GSM900));

            mncList.Add(new MNCInfo("07", "FarEasTone", "Far EasTone Telecommunications Co Ltd", OperStatus.Not_Operational,
                                                                                               BandType.WiMAX2600));

            mncList.Add(new MNCInfo("09", "VMAX", "Vmax Telecom", OperStatus.Operational,
                                                                                               BandType.WiMAX2600));

            mncList.Add(new MNCInfo("10", "G1", "Global Mobile Corp.", OperStatus.Operational,
                                                                                               BandType.WiMAX2600));

            mncList.Add(new MNCInfo("11", "Chunghwa LDM", "LDTA/Chunghwa Telecom", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncList.Add(new MNCInfo("12", "", "Ambit Microsystems", OperStatus.Operational,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE900));

            mncList.Add(new MNCInfo("56", "FITEL", "First International Telecom", OperStatus.Not_Operational,
                                                                                               BandType.WiMAX2600,
                                                                                               BandType.PHS));

            mncList.Add(new MNCInfo("68", "", "Tatung InfoComm", OperStatus.Not_Operational,
                                                                                               BandType.WiMAX2600));

            mncList.Add(new MNCInfo("88", "FarEasTone", "Far EasTone Telecommunications Co Ltd", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800));

            mncList.Add(new MNCInfo("89", "T Star", "Taiwan Star Telecom", OperStatus.Operational,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE2600,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("90", "T Star", "Taiwan Star Telecom", OperStatus.Unknown,
                                                                                               BandType.LTE900));

            mncList.Add(new MNCInfo("92", "Chunghwa", "Chunghwa Telecom", OperStatus.Operational,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.LTE2600,
                                                                                               BandType.FiveG2100,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("93", "MobiTai", "Mobitai Communications", OperStatus.Not_Operational,
                                                                                               BandType.GSM900));

            mncList.Add(new MNCInfo("97", "Taiwan Mobile", "Taiwan Mobile Co. Ltd", OperStatus.Operational,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("99", "TransAsia", "TransAsia Telecoms", OperStatus.Not_Operational,
                                                                                               BandType.GSM900));

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
            mncList.Add(new MNCInfo("01", "Tcell", "JV Somoncom", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("02", "Tcell", "Indigo Tajikistan", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("03", "MegaFon", "TT Mobile", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800));

            mncList.Add(new MNCInfo("04", "Babilon-M", "Babilon-Mobile", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100));

            mncList.Add(new MNCInfo("05", "ZET-Mobile", "Tacom", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE2100));

            mncList.Add(new MNCInfo("10", "Babilon-T", "Babilon-T", OperStatus.Operational,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.WiMAX));

            mncList.Add(new MNCInfo("12", "Tcell", "Indigo", OperStatus.Unknown,
                                                                                               BandType.UMTS2100));

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

            _countries.Add(new CountryInfo(Resources.TL, "TL", "TLS", "626", ContinentCode.AS, new MobileInfo(514, mncList)));
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
            mncList.Add(new MNCInfo("01", "MTS", "MTS Turkmenistan", OperStatus.Not_Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("02", "TM-Cell", "Altyn Asyr", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("03", "AGTS CDMA", "AŞTU", OperStatus.Operational,
                                                                                               BandType.CDMA450));

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
            mncList.Add(new MNCInfo("02", "Etisalat", "Emirates Telecom Corp", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("03", "du", "Emirates Integrated Telecommunications Company", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.FiveG3500));

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
            mncList.Add(new MNCInfo("01", "", "Buztel", OperStatus.Not_Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800));

            mncList.Add(new MNCInfo("02", "", "Uzmacom", OperStatus.Not_Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800));

            mncList.Add(new MNCInfo("03", "UzMobile", "Uzbektelekom", OperStatus.Operational,
                                                                                               BandType.CDMA450));

            mncList.Add(new MNCInfo("04", "Beeline", "Unitel LLC", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("05", "Ucell", "Coscom", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE2600,
                                                                                               BandType.FiveG3500));

            mncList.Add(new MNCInfo("06", "Perfectum Mobile", "RUBICON WIRELESS COMMUNICATION", OperStatus.Operational,
                                                                                               BandType.CDMA800));

            mncList.Add(new MNCInfo("07", "Mobiuz", "Universal Mobile Systems (UMS)", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800));

            mncList.Add(new MNCInfo("08", "UzMobile", "Uzbektelekom", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("09", "EVO", "OOO «Super iMAX»", OperStatus.Operational,
                                                                                               BandType.WiMAX,
                                                                                               BandType.LTE2300));

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
            mncList.Add(new MNCInfo("01", "MobiFone", "Vietnam Mobile Telecom Services Company", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("02", "Vinaphone", "Vietnam Telecom Services Company", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("03", "S-Fone", "S-Telecom", OperStatus.Not_Operational,
                                                                                               BandType.CDMA2000800));

            mncList.Add(new MNCInfo("04", "Viettel Mobile", "Viettel Telecom", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100));

            mncList.Add(new MNCInfo("05", "Vietnamobile", "Hanoi Telecom", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("06", "EVNTelecom", "EVN Telecom", OperStatus.Not_Operational,
                                                                                               BandType.CDMA2000450));

            mncList.Add(new MNCInfo("07", "Gmobile", "GTEL Mobile JSC", OperStatus.Operational,
                                                                                               BandType.GSM1800));

            mncList.Add(new MNCInfo("08", "I-Telecom", "Indochina Telecom", OperStatus.Operational,
                                                                                               BandType.WiMAX));

            mncList.Add(new MNCInfo("09", "REDDI", "MOBICAST JSC", OperStatus.Operational,
                                                                                               BandType.MVNO));

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
            mncList.Add(new MNCInfo("01", "SabaFon", "", OperStatus.Operational,
                                                                                               BandType.GSM900));

            mncList.Add(new MNCInfo("02", "MTN", "Spacetel Yemen", OperStatus.Operational,
                                                                                               BandType.GSM900));

            mncList.Add(new MNCInfo("03", "Yemen Mobile", "Yemen Mobile", OperStatus.Operational,
                                                                                               BandType.CDMA2000800));

            mncList.Add(new MNCInfo("04", "Y", "HiTS-UNITEL", OperStatus.Operational,
                                                                                               BandType.GSM900));

            _countries.Add(new CountryInfo(Resources.YE, "YE", "YEM", "887", ContinentCode.AS, new MobileInfo(421, mncList)));
        }
    }
}
