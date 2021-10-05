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

            mncList.Add(new MNCInfo("02", "Digicel", "Digicel Aruba", OperStatus.Operational,
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
            mncList.Add(new MNCInfo("39", "BTC", "The Bahamas Telecommunications Company Ltd (BaTelCo)", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1700));

            mncList.Add(new MNCInfo("49", "Aliv", "Cable Bahamas Ltd", OperStatus.Operational,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1700));

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
            mncList.Add(new MNCInfo("600", "FLOW", "LIME (formerly known as Cable & Wireless)", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1900));

            mncList.Add(new MNCInfo("750", "Digicel", "Digicel (Barbados) Limited", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1900));

            mncList.Add(new MNCInfo("800", "Ozone", "Ozone Wireless Inc.", OperStatus.Not_Operational,
                                                                                               BandType.LTE700));

            mncList.Add(new MNCInfo("820", "", "Neptune Communications Inc.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

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
            mncList.Add(new MNCInfo("67", "DigiCell", "Belize Telemedia Limited (BTL)", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1900));

            mncList.Add(new MNCInfo("68", "INTELCO", "International Telecommunications Ltd.", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("69", "SMART", "Speednet Communications Limited", OperStatus.Operational,
                                                                                               BandType.CDMA2000850,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE700));

            mncList.Add(new MNCInfo("99", "SMART", "Speednet Communications Limited", OperStatus.Operational,
                                                                                               BandType.CDMA2000850));

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
            // mobile info for MCC 310
            List<MNCInfo> mncListfor310 = new List<MNCInfo>();
            mncListfor310.Add(new MNCInfo("59", "Cellular One", "", OperStatus.Operational,
                                                                                               BandType.CDMA));
            var mobile310 = new MobileInfo(310, mncListfor310);

            // mobile info for MCC 338
            List<MNCInfo> mncListfor338 = new List<MNCInfo>();
            mncListfor338.Add(new MNCInfo("050", "Digicel Bermuda", "", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE700));
            var mobile338 = new MobileInfo(338, mncListfor338);

            // mobile info for MCC 350
            List<MNCInfo> mncListfor350 = new List<MNCInfo>();
            mncListfor350.Add(new MNCInfo("00", "One", "Bermuda Digital Communications Ltd.", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE700));

            mncListfor350.Add(new MNCInfo("007", "", "Paradise Mobile", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncListfor350.Add(new MNCInfo("01", "Digicel Bermuda", "Telecommunications (Bermuda & West Indies) Ltd", OperStatus.Reserved,
                                                                                               BandType.GSM1900));

            mncListfor350.Add(new MNCInfo("02", "Mobility", "M3 Wireless", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS));

            mncListfor350.Add(new MNCInfo("05", "", "Telecom Networks", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor350.Add(new MNCInfo("11", "", "Deltronics", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor350.Add(new MNCInfo("15", "", "FKB Net Ltd.", OperStatus.Unknown,
                                                                                               BandType.Unknown));
            var mobile350 = new MobileInfo(350, mncListfor350);

            _countries.Add(new CountryInfo(Resources.BM, "BM", "BMU", "060", ContinentCode.NA, mobile310, mobile338, mobile350));
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
            mncList.Add(new MNCInfo("100", "dotmobile", "Data on Tap Inc.", OperStatus.Unknown,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("130", "Xplornet", "Xplornet Communications", OperStatus.Operational,
                                                                                               BandType.TDLTE3500,
                                                                                               BandType.WiMAX));

            mncList.Add(new MNCInfo("131", "Xplornet", "Xplornet Communications", OperStatus.Operational,
                                                                                               BandType.TDLTE3500,
                                                                                               BandType.WiMAX));

            mncList.Add(new MNCInfo("150", "", "Cogeco Connexion Inc.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("220", "Telus Mobility, Koodo Mobile, Public Mobile", "Telus Mobility", OperStatus.Operational,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE1700,
                                                                                               BandType.LTE2600,
                                                                                               BandType.FiveG1700));

            mncList.Add(new MNCInfo("221", "Telus", "Telus Mobility", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("222", "Telus", "Telus Mobility", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("250", "ALO", "ALO Mobile Inc.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("270", "EastLink", "Bragg Communications", OperStatus.Operational,
                                                                                               BandType.UMTS1700,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1700));

            mncList.Add(new MNCInfo("290", "Airtel Wireless", "Airtel Wireless", OperStatus.Operational,
                                                                                               BandType.iDEN900));

            mncList.Add(new MNCInfo("300", "ECOTEL", "Ecotel inc.", OperStatus.Operational,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("310", "ECOTEL", "Ecotel inc.", OperStatus.Operational,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("320", "Rogers Wireless", "Rogers Communications", OperStatus.Operational,
                                                                                               BandType.UMTS1700));

            mncList.Add(new MNCInfo("330", "", "Blue Canada Wireless Inc.", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("340", "Execulink", "Execulink", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("350", "FIRST", "FIRST Networks Operations", OperStatus.Not_Operational,
                                                                                               BandType.GSM850));

            mncList.Add(new MNCInfo("360", "MiKe", "Telus Mobility", OperStatus.Not_Operational,
                                                                                               BandType.iDEN800));

            mncList.Add(new MNCInfo("361", "Telus", "Telus Mobility", OperStatus.Not_Operational,
                                                                                               BandType.CDMA800,
                                                                                               BandType.CDMA1900));

            mncList.Add(new MNCInfo("370", "Fido", "Fido Solutions (Rogers Wireless)", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("380", "Keewaytinook Mobile", "Keewaytinook Okimakanak Mobile", OperStatus.Operational,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS1900));

            mncList.Add(new MNCInfo("390", "DMTS", "Dryden Mobility", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("420", "ABC", "A.B.C. Allen Business Communications Ltd.", OperStatus.Operational,
                                                                                               BandType.TDLTE3500));

            mncList.Add(new MNCInfo("480", "Qiniq", "SSi Connexions", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("490", "Freedom Mobile", "Shaw Communications", OperStatus.Operational,
                                                                                               BandType.UMTS1700,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1700,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("491", "Freedom Mobile", "Shaw Communications", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("500", "Videotron", "Videotron", OperStatus.Operational,
                                                                                               BandType.UMTS1700,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1700,
                                                                                               BandType.FiveG600,
                                                                                               BandType.FiveG1700,
                                                                                               BandType.FiveG2600));

            mncList.Add(new MNCInfo("510", "Videotron", "Videotron", OperStatus.Operational,
                                                                                               BandType.UMTS1700,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1700,
                                                                                               BandType.FiveG600,
                                                                                               BandType.FiveG1700,
                                                                                               BandType.FiveG2600));

            mncList.Add(new MNCInfo("520", "Videotron", "Videotron", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("530", "Keewaytinook Mobile", "Keewaytinook Okimakanak Mobile", OperStatus.Operational,
                                                                                               BandType.GSM));

            mncList.Add(new MNCInfo("540", "", "Rovvr Communications Inc.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("550", "", "Star Solutions International Inc.", OperStatus.Unknown,
                                                                                               BandType.LTE));

            mncList.Add(new MNCInfo("560", "Lynx Mobility", "Lynx Mobility", OperStatus.Not_Operational,
                                                                                               BandType.CDMA,
                                                                                               BandType.GSM));

            mncList.Add(new MNCInfo("570", "LightSquared", "LightSquared", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("590", "Quadro Mobility", "Quadro Communications Co-op", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("600", "", "Iristel", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("610", "Bell Mobility", "Bell Mobility", OperStatus.Operational,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1700,
                                                                                               BandType.LTE1900,
                                                                                               BandType.LTE2600,
                                                                                               BandType.FiveG1700));

            mncList.Add(new MNCInfo("620", "ICE Wireless", "ICE Wireless", OperStatus.Operational,
                                                                                               BandType.UMTS850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1900));

            mncList.Add(new MNCInfo("630", "Aliant Mobility", "Bell Aliant", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("640", "Bell", "Bell Mobility", OperStatus.Not_Operational,
                                                                                               BandType.CDMA800,
                                                                                               BandType.CDMA1900));

            mncList.Add(new MNCInfo("650", "TBaytel", "Thunder Bay Telephone", OperStatus.Operational,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("652", "", "BC Tel Mobility (Telus)", OperStatus.Not_Operational,
                                                                                               BandType.CDMA2000));

            mncList.Add(new MNCInfo("653", "Telus", "Telus Mobility", OperStatus.Not_Operational,
                                                                                               BandType.CDMA800,
                                                                                               BandType.CDMA1900));

            mncList.Add(new MNCInfo("655", "MTS", "Bell MTS", OperStatus.Not_Operational,
                                                                                               BandType.CDMA800,
                                                                                               BandType.CDMA1900));

            mncList.Add(new MNCInfo("656", "TBay", "Thunder Bay Telephone Mobility", OperStatus.Not_Operational,
                                                                                               BandType.CDMA));

            mncList.Add(new MNCInfo("657", "Telus", "Telus Mobility", OperStatus.Not_Operational,
                                                                                               BandType.CDMA800,
                                                                                               BandType.CDMA1900));

            mncList.Add(new MNCInfo("660", "MTS", "Bell MTS", OperStatus.Operational,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE1700));

            mncList.Add(new MNCInfo("670", "CityTel Mobility", "CityWest", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("680", "SaskTel", "SaskTel Mobility", OperStatus.Operational,
                                                                                               BandType.TDLTE2600));

            mncList.Add(new MNCInfo("681", "SaskTel", "SaskTel Mobility", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("690", "Bell", "Bell Mobility", OperStatus.Operational,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS1900));

            mncList.Add(new MNCInfo("701", "", "MB Tel Mobility", OperStatus.Not_Operational,
                                                                                               BandType.CDMA2000));

            mncList.Add(new MNCInfo("702", "", "MT&T Mobility (Aliant)", OperStatus.Not_Operational,
                                                                                               BandType.CDMA2000));

            mncList.Add(new MNCInfo("703", "", "New Tel Mobility (Aliant)", OperStatus.Not_Operational,
                                                                                               BandType.CDMA2000));

            mncList.Add(new MNCInfo("710", "Globalstar", "", OperStatus.Operational,
                                                                                               BandType.SatelliteCDMA));

            mncList.Add(new MNCInfo("720", "Rogers Wireless", "Rogers Communications", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1700,
                                                                                               BandType.LTE1900,
                                                                                               BandType.LTE2600,
                                                                                               BandType.FiveG600,
                                                                                               BandType.FiveG1700,
                                                                                               BandType.TD5G2600));

            mncList.Add(new MNCInfo("721", "Rogers Wireless", "Rogers Communications", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("730", "TerreStar Solutions", "TerreStar Networks", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("740", "Shaw Telecom", "Shaw Communications", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));
            
            mncList.Add(new MNCInfo("750", "SaskTel", "SaskTel Mobility", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("760", "Public Mobile", "Telus Mobility", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("770", "TNW Wireless", "TNW Wireless Inc.", OperStatus.Operational,
                                                                                               BandType.UMTS850));

            mncList.Add(new MNCInfo("780", "SaskTel", "SaskTel Mobility", OperStatus.Operational,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1700));

            mncList.Add(new MNCInfo("781", "SaskTel", "SaskTel Mobility", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("790", "", "NetSet Communications", OperStatus.Operational,
                                                                                               BandType.WiMAX,
                                                                                               BandType.TDLTE3500));

            mncList.Add(new MNCInfo("820", "Rogers Wireless", "Rogers Communications", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("860", "Telus", "Telus Mobility", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("880", "Bell / Telus / SaskTel", "Shared Telus, Bell, and SaskTel", OperStatus.Operational,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS1900));

            mncList.Add(new MNCInfo("910", "", "Halton Regional Police Service", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("920", "Rogers Wireless", "Rogers Communications", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("940", "Wightman Mobility", "Wightman Telecom", OperStatus.Operational,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS1900));

            mncList.Add(new MNCInfo("990", "", "Ericsson Canada", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("991", "", "Halton Regional Police Service", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("996", "", "Powertech Labs", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("997", "", "Powertech Labs", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("998", "", "Institut de Recherche d’Hydro-Québec", OperStatus.Unknown,
                                                                                               BandType.Unknown));

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
            mncList.Add(new MNCInfo("001", "Logic", "WestTel Ltd.", OperStatus.Operational,
                                                                                               BandType.LTE2500));

            mncList.Add(new MNCInfo("140", "FLOW", "Cable & Wireless (Cayman Islands) Limited", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.AMPS,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1900));

            mncList.Add(new MNCInfo("050", "Digicel", "Digicel Cayman Ltd.", OperStatus.Operational,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1800));

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
            mncList.Add(new MNCInfo("01", "Kölbi ICE", "Instituto Costarricense de Electricidad", OperStatus.Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("02", "Kölbi ICE", "Instituto Costarricense de Electricidad", OperStatus.Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("03", "Claro", "Claro CR Telecomunicaciones (Aló)", OperStatus.Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("04", "movistar", "Telefónica Móviles Costa Rica", OperStatus.Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("20", "fullmóvil", "Virtualis S.A.", OperStatus.Not_Operational,
                                                                                               BandType.MVNO));

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
            mncList.Add(new MNCInfo("01", "CUBACEL", "Empresa de Telecomunicaciones de Cuba, SA", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM850,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800));

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
            mncList.Add(new MNCInfo("020", "Digicel", "Digicel Group Limited", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE700));

            mncList.Add(new MNCInfo("110", "FLOW", "Cable & Wireless", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE700));

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
            mncList.Add(new MNCInfo("01", "Altice", "Altice Group", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS900,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE900,
                                                                                               BandType.LTE1700,
                                                                                               BandType.LTE1900));

            mncList.Add(new MNCInfo("02", "Claro", "Compañía Dominicana de Teléfonos", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE1700,
                                                                                               BandType.LTE1900,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("03", "Altice", "Altice Group", OperStatus.Operational,
                                                                                               BandType.AMPS,
                                                                                               BandType.CDMA850));

            mncList.Add(new MNCInfo("04", "Viva", "Trilogy Dominicana, S.A.", OperStatus.Operational,
                                                                                               BandType.CDMA1900,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE1700));

            mncList.Add(new MNCInfo("05", "Wind", "WIND Telecom, S.A", OperStatus.Operational,
                                                                                               BandType.TDLTE2600));

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
            mncList.Add(new MNCInfo("01", "Claro", "CTE Telecom Personal, S.A. de C.V.", OperStatus.Operational,
                                                                                              BandType.GSM1900,
                                                                                              BandType.UMTS1900));

            mncList.Add(new MNCInfo("02", "Digicel", "Digicel, S.A. de C.V.", OperStatus.Operational,
                                                                                              BandType.GSM900,
                                                                                              BandType.UMTS900));

            mncList.Add(new MNCInfo("03", "Tigo", "Telemovil El Salvador S.A.", OperStatus.Operational,
                                                                                              BandType.GSM850,
                                                                                              BandType.UMTS850,
                                                                                              BandType.LTE850,
                                                                                              BandType.LTE1700));

            mncList.Add(new MNCInfo("04", "movistar", "Telefónica Móviles El Salvador", OperStatus.Operational,
                                                                                              BandType.GSM850,
                                                                                              BandType.GSM1900,
                                                                                              BandType.UMTS850,
                                                                                              BandType.UMTS1900,
                                                                                              BandType.LTE1900));

            mncList.Add(new MNCInfo("05", "RED", "INTELFON, S.A. de C.V.", OperStatus.Operational,
                                                                                              BandType.iDEN));

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
            mncList.Add(new MNCInfo("030", "Digicel", "Digicel Grenada Ltd.", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1900));

            mncList.Add(new MNCInfo("110", "FLOW", "Cable & Wireless Grenada Ltd.", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE700));

            _countries.Add(new CountryInfo(Resources.GD, "GD", "GRD", "308", ContinentCode.NA, new MobileInfo(352, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "GP". <br/>
        /// Alpha2Cod2 GP 에 대한 정보를 추가합니다.
        /// GP is included in GF.
        /// </summary>
        /*************************************************/
        static void AddInfoForGP()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Orange", "Orange Caraïbe Mobiles", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("02", "SFR Caraïbe", "Outremer Telecom", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("03", "FLOW", "UTS Caraïbe", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("04", "Free", "Free Caraïbe", OperStatus.Upcoming,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("08", "Dauphin", "Dauphin Telecom", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS,
                                                                                               BandType.LTE));

            mncList.Add(new MNCInfo("09", "Free", "Free Caraïbe", OperStatus.Upcoming,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("10", "", "Guadeloupe Téléphone Mobile", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("11", "", "Guyane Téléphone Mobile", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("12", "", "Martinique Téléphone Mobile", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("20", "Digicel", "DIGICEL Antilles Française Guyane", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800));

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
            mncList.Add(new MNCInfo("01", "Claro", "Telecomunicaciones de Guatemala, S.A.", OperStatus.Operational,
                                                                                               BandType.CDMA1900,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE1900));

            mncList.Add(new MNCInfo("02", "Tigo", "Millicom / Local partners", OperStatus.Operational,
                                                                                               BandType.TDMA800,
                                                                                               BandType.GSM850,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE850));

            mncList.Add(new MNCInfo("03", "movistar", "Telefónica Móviles Guatemala (Telefónica)", OperStatus.Operational,
                                                                                               BandType.CDMA1900,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE1900));

            mncList.Add(new MNCInfo("?", "digicel", "Digicel Group", OperStatus.Reserved,
                                                                                               BandType.GSM900));

            mncList.Add(new MNCInfo("?", "RED/INTELFON", "INTELFON Guatemala", OperStatus.Operational,
                                                                                               BandType.iDEN800));

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
            mncList.Add(new MNCInfo("01", "Voila", "Communication Cellulaire d'Haiti S.A.", OperStatus.Not_Operational,
                                                                                               BandType.GSM850));

            mncList.Add(new MNCInfo("02", "Digicel", "Unigestion Holding S.A.", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("03", "Natcom", "NATCOM S.A.", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800));

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
            mncList.Add(new MNCInfo("001", "Claro", "Servicios de Comunicaciones de Honduras S.A. de C.V.", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE1700));

            mncList.Add(new MNCInfo("002", "Tigo", "Celtel", OperStatus.Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.GSM850,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE1700));

            mncList.Add(new MNCInfo("030", "Hondutel", "Empresa Hondureña de Telecomunicaciones", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS1900));

            mncList.Add(new MNCInfo("040", "Digicel", "Digicel de Honduras", OperStatus.Operational,
                                                                                               BandType.GSM1900));

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
            mncList.Add(new MNCInfo("020", "FLOW", "LIME (Cable & Wireless)", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("040", "Caricel", "Symbiote Investment Limited", OperStatus.Unknown,
                                                                                               BandType.LTE));

            mncList.Add(new MNCInfo("050", "Digicel", "Digicel (Jamaica) Limited", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1700,
                                                                                               BandType.LTE1900));

            mncList.Add(new MNCInfo("070", "Claro", "Oceanic Digital Jamaica Limited", OperStatus.Not_Operational,
                                                                                               BandType.GSM,
                                                                                               BandType.UMTS,
                                                                                               BandType.CDMA));

            mncList.Add(new MNCInfo("110", "FLOW", "Cable & Wireless Communications", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("180", "FLOW", "Cable & Wireless Communications", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1700,
                                                                                               BandType.LTE1900));

            _countries.Add(new CountryInfo(Resources.JM, "JM", "JAM", "388", ContinentCode.NA, new MobileInfo(338, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "MQ". <br/>
        /// Alpha2Cod2 MQ 에 대한 정보를 추가합니다.
        /// MQ is included in GF.
        /// </summary>
        /*************************************************/
        static void AddInfoForMQ()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Orange", "Orange Caraïbe Mobiles", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("02", "SFR Caraïbe", "Outremer Telecom", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("03", "FLOW", "UTS Caraïbe", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("04", "Free", "Free Caraïbe", OperStatus.Upcoming,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("08", "Dauphin", "Dauphin Telecom", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS,
                                                                                               BandType.LTE));

            mncList.Add(new MNCInfo("09", "Free", "Free Caraïbe", OperStatus.Upcoming,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("10", "", "Guadeloupe Téléphone Mobile", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("11", "", "Guyane Téléphone Mobile", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("12", "", "Martinique Téléphone Mobile", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("20", "Digicel", "DIGICEL Antilles Française Guyane", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800));

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
            mncList.Add(new MNCInfo("001", "", "Comunicaciones Digitales Del Norte, S.A. de C.V.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("010", "AT&T", "AT&T Mexico", OperStatus.Not_Operational,
                                                                                               BandType.iDEN800));

            mncList.Add(new MNCInfo("020", "Telcel", "América Móvil", OperStatus.Operational,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1700,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("030", "Movistar", "Telefónica", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("040", "Unefon", "AT&T Mexico", OperStatus.Not_Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.CDMA1900));

            mncList.Add(new MNCInfo("050", "AT&T / Unefon", "AT&T Mexico", OperStatus.Operational,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.UMTS1700,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1700,
                                                                                               BandType.LTE2600,
                                                                                               BandType.TDLTE2600));

            mncList.Add(new MNCInfo("060", "", "Servicios de Acceso Inalambrico, S.A. de C.V.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("066", "", "Telefonos de México, S.A.B. de C.V.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("070", "Unefon", "AT&T Mexico", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("080", "Unefon", "AT&T Mexico", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("090", "AT&T", "AT&T Mexico", OperStatus.Operational,
                                                                                               BandType.UMTS1700,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1700));

            mncList.Add(new MNCInfo("100", "", "Telecomunicaciones de México", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("110", "", "Maxcom Telecomunicaciones, S.A.B. de C.V.", OperStatus.Unknown,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("120", "", "Quickly Phone, S.A. de C.V.", OperStatus.Unknown,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("130", "", "Axtel, S.A.B. de C.V.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("140", "Altan Redes", "Altán Redes S.A.P.I. de C.V.", OperStatus.Operational,
                                                                                               BandType.LTE700));

            mncList.Add(new MNCInfo("150", "Ultranet", "Ultravisión, S.A. de C.V.", OperStatus.Operational,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("160", "", "Cablevisión Red, S.A. de C.V.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("170", "", "Oxio Mobile, S.A. de C.V.", OperStatus.Unknown,
                                                                                               BandType.MVNO));

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
            mncList.Add(new MNCInfo("860", "FLOW", "Cable & Wireless", OperStatus.Operational,
                                                                                               BandType.GSM850));

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
            mncList.Add(new MNCInfo("21", "Claro", "Empresa Nicaragüense de Telecomunicaciones, S.A. (ENITEL) (América Móvil)", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE1700));

            mncList.Add(new MNCInfo("30", "movistar", "Telefonía Celular de Nicaragua, S.A. (Telefónica, S.A.)", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE1900));

            mncList.Add(new MNCInfo("73", "Claro", "Servicios de Comunicaciones S.A.", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850));

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
            mncList.Add(new MNCInfo("01", "Cable & Wireless", "Cable & Wireless Panama S.A.", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1900));

            mncList.Add(new MNCInfo("02", "movistar", "Telefónica Moviles Panama S.A, Bell South Corp. (BSC)", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1700,
                                                                                               BandType.LTE1900));

            mncList.Add(new MNCInfo("020", "movistar", "Telefónica Móviles de Panama S.A", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.LTE700));

            mncList.Add(new MNCInfo("03", "Claro", "América Móvil", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1900));

            mncList.Add(new MNCInfo("04", "Digicel", "Digicel Group", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1900));

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
            // mobile info for MMC 310
            List<MNCInfo> mncListFor310 = new List<MNCInfo>();
            mncListFor310.Add(new MNCInfo("017", "ProxTel", "North Sight Communications Inc.", OperStatus.Not_Operational,
                                                                                               BandType.iDEN));

            mncListFor310.Add(new MNCInfo("260", "T-Mobile", "T-Mobile US", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.UMTS1700,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1900,
                                                                                               BandType.LTE1700,
                                                                                               BandType.FiveG600));

            mncListFor310.Add(new MNCInfo("280", "AT&T", "AT&T Mobility", OperStatus.Not_Operational,
                                                                                               BandType.GSM1900));
            var mobile310 = new MobileInfo(310, mncListFor310);

            // mobile info for MMC 313
            List<MNCInfo> mncListFor313 = new List<MNCInfo>();
            mncListFor313.Add(new MNCInfo("510", "", "Puerto Rico Telecom Company", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListFor313.Add(new MNCInfo("790", "Liberty", "Liberty Cablevision of Puerto Rico LLC", OperStatus.Operational,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1700,
                                                                                               BandType.LTE1900,
                                                                                               BandType.LTE2300,
                                                                                               BandType.FiveG850));
            var mobile313 = new MobileInfo(313, mncListFor313);

            // mobile info for MMC 330
            List<MNCInfo> mncListFor330 = new List<MNCInfo>();
            mncListFor330.Add(new MNCInfo("000", "Open Mobile", "PR Wireless", OperStatus.Operational,
                                                                                               BandType.CDMA1900));

            mncListFor330.Add(new MNCInfo("110", "Claro Puerto Rico", "América Móvil", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1700));

            mncListFor330.Add(new MNCInfo("120", "Open Mobile", "PR Wireless", OperStatus.Operational,
                                                                                               BandType.LTE700));
            var mobile330 = new MobileInfo(330, mncListFor330);

            _countries.Add(new CountryInfo(Resources.PR, "PR", "PRI", "630", ContinentCode.NA, mobile310, mobile313, mobile330));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "BL". <br/>
        /// Alpha2Cod2 BL 에 대한 정보를 추가합니다.
        /// BL is included in GF.
        /// </summary>
        /*************************************************/
        static void AddInfoForBL()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Orange", "Orange Caraïbe Mobiles", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("02", "SFR Caraïbe", "Outremer Telecom", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("03", "FLOW", "UTS Caraïbe", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("04", "Free", "Free Caraïbe", OperStatus.Upcoming,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("08", "Dauphin", "Dauphin Telecom", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS,
                                                                                               BandType.LTE));

            mncList.Add(new MNCInfo("09", "Free", "Free Caraïbe", OperStatus.Upcoming,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("10", "", "Guadeloupe Téléphone Mobile", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("11", "", "Guyane Téléphone Mobile", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("12", "", "Martinique Téléphone Mobile", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("20", "Digicel", "DIGICEL Antilles Française Guyane", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800));

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
            mncList.Add(new MNCInfo("050", "Digicel", "Wireless Ventures (St Kitts-Nevis) Limited", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.LTE700));

            mncList.Add(new MNCInfo("070", "FLOW", "UTS", OperStatus.Operational,
                                                                                               BandType.Empty));

            mncList.Add(new MNCInfo("110", "FLOW", "Cable & Wireless St. Kitts & Nevis Ltd", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.LTE700));

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
            // mobile info for MCC 338
            List<MNCInfo> mncListfor338 = new List<MNCInfo>();
            mncListfor338.Add(new MNCInfo("050", "Digicel", "Digicel", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.GSM1900,
                                                                                               BandType.LTE700));
            var mobile338 = new MobileInfo(338, mncListfor338);

            // mobile info for MCC 358
            List<MNCInfo> mncListfor358 = new List<MNCInfo>();
            mncListfor358.Add(new MNCInfo("110", "FLOW", "Cable & Wireless", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.LTE700));
            var mobile358 = new MobileInfo(358, mncListfor358);

            _countries.Add(new CountryInfo(Resources.LC, "LC", "LCA", "662", ContinentCode.NA, mobile338, mobile358));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "MF". <br/>
        /// Alpha2Cod2 MF 에 대한 정보를 추가합니다.
        /// MF is included in GF.
        /// </summary>
        /*************************************************/
        static void AddInfoForMF()
        {
            List<MNCInfo> mncList = new List<MNCInfo>();
            mncList.Add(new MNCInfo("01", "Orange", "Orange Caraïbe Mobiles", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("02", "SFR Caraïbe", "Outremer Telecom", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("03", "FLOW", "UTS Caraïbe", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("04", "Free", "Free Caraïbe", OperStatus.Upcoming,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("08", "Dauphin", "Dauphin Telecom", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS,
                                                                                               BandType.LTE));

            mncList.Add(new MNCInfo("09", "Free", "Free Caraïbe", OperStatus.Upcoming,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("10", "", "Guadeloupe Téléphone Mobile", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("11", "", "Guyane Téléphone Mobile", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("12", "", "Martinique Téléphone Mobile", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("20", "Digicel", "DIGICEL Antilles Française Guyane", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE800));

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
            mncList.Add(new MNCInfo("01", "Ameris", "St. Pierre-et-Miquelon Télécom", OperStatus.Operational,
                                                                                               BandType.GSM900));

            mncList.Add(new MNCInfo("02", "GLOBALTEL", "GLOBALTEL", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.LTE800));

            mncList.Add(new MNCInfo("03", "Ameris", "St. Pierre-et-Miquelon Télécom", OperStatus.Unknown,
                                                                                               BandType.Unknown));

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
            mncList.Add(new MNCInfo("050", "Digicel", "Digicel (St. Vincent and the Grenadines) Limited", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.GSM1900,
                                                                                               BandType.LTE700));

            mncList.Add(new MNCInfo("100", "Cingular Wireless", "", OperStatus.Unknown,
                                                                                               BandType.GSM850));

            mncList.Add(new MNCInfo("110", "FLOW", "Cable & Wireless (St. Vincent & the Grenadines) Ltd", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.LTE700));

            _countries.Add(new CountryInfo(Resources.VC, "VC", "VCT", "670", ContinentCode.NA, new MobileInfo(360, mncList)));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "SX". <br/>
        /// Alpha2Cod2 SX 에 대한 정보를 추가합니다.
        /// Former Netherlands Antilles (Kingdom of the Netherlands) includes BQ / CW / SX
        /// </summary>
        /*************************************************/
        static void AddInfoForSX()
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
            mncList.Add(new MNCInfo("01", "bmobile", "TSTT", OperStatus.Not_Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900));

            mncList.Add(new MNCInfo("12", "bmobile", "TSTT", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1900,
                                                                                               BandType.TDLTE2500,
                                                                                               BandType.FiveG2500));

            mncList.Add(new MNCInfo("13", "Digicel", "Digicel (Trinidad & Tobago) Limited", OperStatus.Not_Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS1900));

            mncList.Add(new MNCInfo("20", "bmobile", "TSTT", OperStatus.Not_Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900));

            mncList.Add(new MNCInfo("129", "bmobile", "TSTT", OperStatus.Not_Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS1900));

            mncList.Add(new MNCInfo("130", "Digicel", "Digicel (Trinidad & Tobago) Limited", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1700,
                                                                                               BandType.LTE1900));

            mncList.Add(new MNCInfo("140", "Laqtel", "LaqTel Ltd.", OperStatus.Not_Operational,
                                                                                               BandType.CDMA));

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
            // mobile info for MMC 338
            List<MNCInfo> mncListfor338 = new List<MNCInfo>();
            mncListfor338.Add(new MNCInfo("050", "Digicel", "Digicel (Turks & Caicos) Limited", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1900,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1700));
            var mobile338 = new MobileInfo(338, mncListfor338);

            // mobile info for MMC 376
            List<MNCInfo> mncListfor376 = new List<MNCInfo>();
            mncListfor376.Add(new MNCInfo("350", "FLOW", "Cable & Wireless West Indies Ltd (Turks & Caicos)", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE700));

            mncListfor376.Add(new MNCInfo("351", "Digicel", "Digicel (Turks & Caicos) Limited", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncListfor376.Add(new MNCInfo("352", "FLOW", "Cable & Wireless West Indies Ltd (Turks & Caicos)", OperStatus.Not_Operational,
                                                                                               BandType.UMTS850));

            mncListfor376.Add(new MNCInfo("360", "Digicel", "Digicel (Turks & Caicos) Limited", OperStatus.Unknown,
                                                                                               BandType.Unknown));
            var mobile376 = new MobileInfo(376, mncListfor376);

            _countries.Add(new CountryInfo(Resources.TC, "TC", "TCA", "796", ContinentCode.NA, mobile338, mobile376));
        }

        /*************************************************/
        /// <summary>
        /// Add information for the alpha2 code "US". <br/>
        /// Alpha2Cod2 US 에 대한 정보를 추가합니다.
        /// </summary>
        /*************************************************/
        static void AddInfoForUS()
        {
            // mobile info for MCC 310
            List<MNCInfo> mncListfor310 = new List<MNCInfo>();
            mncListfor310.Add(new MNCInfo("004", "Verizon", "Verizon Wireless", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("005", "Verizon", "Verizon Wireless", OperStatus.Operational,
                                                                                               BandType.CDMA2000850,
                                                                                               BandType.CDMA20001900));

            mncListfor310.Add(new MNCInfo("006", "Verizon", "Verizon Wireless", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("010", "Verizon", "Verizon Wireless", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("012", "Verizon", "Verizon Wireless", OperStatus.Operational,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1700,
                                                                                               BandType.LTE1900));

            mncListfor310.Add(new MNCInfo("013", "Verizon", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("014", "", "", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("015", "Southern LINC", "Southern Communications", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("016", "AT&T", "AT & T Mobility", OperStatus.Not_Operational,
                                                                                               BandType.CDMA20001900,
                                                                                               BandType.CDMA20001700));

            mncListfor310.Add(new MNCInfo("017", "ProxTel", "North Sight Communications Inc.", OperStatus.Not_Operational,
                                                                                               BandType.iDEN));

            mncListfor310.Add(new MNCInfo("020", "Union Wireless", "Union Telephone Company", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS));

            mncListfor310.Add(new MNCInfo("030", "AT&T", "AT&T Mobility", OperStatus.Operational,
                                                                                               BandType.GSM850));

            mncListfor310.Add(new MNCInfo("032", "IT&E Wireless", "IT&E Overseas, Inc", OperStatus.Operational,
                                                                                               BandType.CDMA1900,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE700));

            mncListfor310.Add(new MNCInfo("033", "", "Guam Telephone Authority", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("034", "Airpeak", "Airpeak", OperStatus.Operational,
                                                                                               BandType.iDEN));

            mncListfor310.Add(new MNCInfo("040", "MTA", "Matanuska Telephone Association, Inc.", OperStatus.Not_Operational,
                                                                                               BandType.CDMA));

            mncListfor310.Add(new MNCInfo("050", "GCI", "Alaska Communications", OperStatus.Operational,
                                                                                               BandType.CDMA));

            mncListfor310.Add(new MNCInfo("053", "Virgin Mobile", "Sprint", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncListfor310.Add(new MNCInfo("054", "", "Alltel US", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("060", "", "Consolidated Telcom", OperStatus.Not_Operational,
                                                                                               BandType.one900));

            mncListfor310.Add(new MNCInfo("066", "U.S. Cellular", "U.S. Cellular", OperStatus.Operational,
                                                                                               BandType.GSM,
                                                                                               BandType.CDMA));

            mncListfor310.Add(new MNCInfo("070", "AT&T", "AT&T Mobility", OperStatus.Operational,
                                                                                               BandType.GSM850));

            mncListfor310.Add(new MNCInfo("080", "AT&T", "AT&T Mobility", OperStatus.Operational,
                                                                                               BandType.GSM1900));

            mncListfor310.Add(new MNCInfo("090", "AT&T", "AT&T Mobility", OperStatus.Operational,
                                                                                               BandType.GSM1900));

            mncListfor310.Add(new MNCInfo("100", "Plateau Wireless", "New Mexico RSA 4 East LP", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS1700));

            mncListfor310.Add(new MNCInfo("110", "IT&E Wireless", "PTI Pacifica Inc.", OperStatus.Operational,
                                                                                               BandType.CDMA,
                                                                                               BandType.GSM850,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE700));

            mncListfor310.Add(new MNCInfo("120", "", "T-Mobile US", OperStatus.Operational,
                                                                                               BandType.CDMA20001900,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1900));

            mncListfor310.Add(new MNCInfo("130", "Carolina West Wireless", "Carolina West Wireless", OperStatus.Operational,
                                                                                               BandType.CDMA20001900));

            mncListfor310.Add(new MNCInfo("140", "GTA Wireless", "Teleguam Holdings, LLC", OperStatus.Operational,
                                                                                               BandType.GSM850, 
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE1700));

            mncListfor310.Add(new MNCInfo("150", "AT&T", "AT&T Mobility", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS1900));

            mncListfor310.Add(new MNCInfo("160", "T-Mobile", "T-Mobile US", OperStatus.Operational,
                                                                                               BandType.GSM1900));

            mncListfor310.Add(new MNCInfo("170", "AT&T", "AT&T Mobility", OperStatus.Operational,
                                                                                               BandType.GSM1900));

            mncListfor310.Add(new MNCInfo("180", "West Central", "West Central Wireless", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS1900));

            mncListfor310.Add(new MNCInfo("190", "GCI", "Alaska Communications", OperStatus.Operational,
                                                                                               BandType.GSM850));

            mncListfor310.Add(new MNCInfo("200", "", "T-Mobile", OperStatus.Not_Operational,
                                                                                               BandType.GSM1900));

            mncListfor310.Add(new MNCInfo("210", "", "T-Mobile", OperStatus.Not_Operational,
                                                                                               BandType.GSM1900));

            mncListfor310.Add(new MNCInfo("220", "", "T-Mobile", OperStatus.Not_Operational,
                                                                                               BandType.GSM1900));

            mncListfor310.Add(new MNCInfo("230", "", "T-Mobile", OperStatus.Not_Operational,
                                                                                               BandType.GSM1900));

            mncListfor310.Add(new MNCInfo("240", "", "T-Mobile", OperStatus.Not_Operational,
                                                                                               BandType.GSM1900));

            mncListfor310.Add(new MNCInfo("250", "", "T-Mobile", OperStatus.Not_Operational,
                                                                                               BandType.GSM1900));

            mncListfor310.Add(new MNCInfo("260", "T-Mobile", "T-Mobile US", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.UMTS1700,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1900,
                                                                                               BandType.LTE1700,
                                                                                               BandType.FiveG600));

            mncListfor310.Add(new MNCInfo("270", "", "T-Mobile", OperStatus.Not_Operational,
                                                                                               BandType.GSM1900));

            mncListfor310.Add(new MNCInfo("280", "AT&T", "AT&T Mobility", OperStatus.Not_Operational,
                                                                                               BandType.GSM1900));

            mncListfor310.Add(new MNCInfo("290", "nep", "NEP Cellcorp Inc.", OperStatus.Not_Operational,
                                                                                               BandType.GSM1900));

            mncListfor310.Add(new MNCInfo("300", "Big Sky Mobile", "iSmart Mobile, LLC", OperStatus.Not_Operational,
                                                                                               BandType.GSM1900));

            mncListfor310.Add(new MNCInfo("310", "", "T-Mobile", OperStatus.Not_Operational,
                                                                                               BandType.GSM1900));

            mncListfor310.Add(new MNCInfo("311", "", "Farmers Wireless", OperStatus.Not_Operational,
                                                                                               BandType.GSM1900));

            mncListfor310.Add(new MNCInfo("320", "Cellular One", "Smith Bagley, Inc.", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS));

            mncListfor310.Add(new MNCInfo("330", "", "Wireless Partners, LLC", OperStatus.Unknown,
                                                                                               BandType.LTE));

            mncListfor310.Add(new MNCInfo("340", "Limitless Mobile", "Limitless Mobile, LLC", OperStatus.Unknown,
                                                                                               BandType.GSM1900));

            mncListfor310.Add(new MNCInfo("350", "Verizon", "Verizon Wireless", OperStatus.Not_Operational,
                                                                                               BandType.CDMA));

            mncListfor310.Add(new MNCInfo("360", "Pioneer Cellular", "Cellular Network Partnership", OperStatus.Operational,
                                                                                               BandType.CDMA));

            mncListfor310.Add(new MNCInfo("370", "Docomo", "NTT DoCoMo Pacific", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE700));

            mncListfor310.Add(new MNCInfo("380", "AT&T", "AT&T Mobility", OperStatus.Not_Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS1900));

            mncListfor310.Add(new MNCInfo("390", "Cellular One of East Texas", "TX-11 Acquisition, LLC", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.LTE700,
                                                                                               BandType.CDMA));

            mncListfor310.Add(new MNCInfo("400", "IT&E Wireless", "IT&E Overseas, Inc", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE700));

            mncListfor310.Add(new MNCInfo("410", "AT&T", "AT&T Mobility", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS1900));

            mncListfor310.Add(new MNCInfo("420", "Cincinnati Bell", "Cincinnati Bell Wireless", OperStatus.Not_Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS1700));

            mncListfor310.Add(new MNCInfo("430", "GCI", "GCI Communications Corp.", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS1900));

            mncListfor310.Add(new MNCInfo("440", "", "Numerex", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncListfor310.Add(new MNCInfo("450", "Viaero", "Viaero Wireless", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS1900));

            mncListfor310.Add(new MNCInfo("460", "Conecto", "NewCore Wireless LLC", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncListfor310.Add(new MNCInfo("470", "", "NTT DoCoMo Pacific", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("480", "IT&E Wireless", "IT&E Overseas, Inc", OperStatus.Operational,
                                                                                               BandType.iDEN));

            mncListfor310.Add(new MNCInfo("490", "", "T-Mobile", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900));

            mncListfor310.Add(new MNCInfo("500", "Alltel", "Public Service Cellular Inc.", OperStatus.Operational,
                                                                                               BandType.CDMA2000850,
                                                                                               BandType.CDMA20001900));

            mncListfor310.Add(new MNCInfo("510", "Cellcom", "Nsight", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("520", "TNS", "Transaction Network Services", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("530", "iWireless", "Iowa Wireless Services LLC", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("540", "Phoenix", "Hilliary Communications", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900));

            mncListfor310.Add(new MNCInfo("550", "", "Syniverse Technologies", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("560", "AT&T", "AT&T Mobility", OperStatus.Not_Operational,
                                                                                               BandType.GSM850));

            mncListfor310.Add(new MNCInfo("570", "", "Broadpoint, LLC", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.LTE700));

            mncListfor310.Add(new MNCInfo("580", "", "Inland Cellular Telephone Company", OperStatus.Operational,
                                                                                               BandType.CDMA2000));

            mncListfor310.Add(new MNCInfo("590", "", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900));

            mncListfor310.Add(new MNCInfo("591", "", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("592", "", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("593", "", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("594", "", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("595", "", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("596", "", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("597", "", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("598", "", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("599", "", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("600", "Cellcom", "NewCell Inc.", OperStatus.Operational,
                                                                                               BandType.CDMA2000850,
                                                                                               BandType.CDMA20001900));

            mncListfor310.Add(new MNCInfo("610", "Epic PCS", "Elkhart Telephone Co.", OperStatus.Not_Operational,
                                                                                               BandType.GSM1900));

            mncListfor310.Add(new MNCInfo("620", "Cellcom", "Nsighttel Wireless LLC", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("630", "miSpot", "Agri-Valley Communications", OperStatus.Not_Operational,
                                                                                               BandType.LTE700));

            mncListfor310.Add(new MNCInfo("640", "", "Numerex", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncListfor310.Add(new MNCInfo("650", "Jasper", "Jasper Technologies", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncListfor310.Add(new MNCInfo("660", "T-Mobile", "", OperStatus.Not_Operational,
                                                                                               BandType.GSM1900));

            mncListfor310.Add(new MNCInfo("670", "AT&T", "AT&T Mobility", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("680", "AT&T", "AT&T Mobility", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900));

            mncListfor310.Add(new MNCInfo("690", "Limitless Mobile", "Limitless Mobile, LLC", OperStatus.Unknown,
                                                                                               BandType.GSM1900,
                                                                                               BandType.LTE1900));

            mncListfor310.Add(new MNCInfo("700", "Bigfoot Cellular", "Cross Valiant Cellular Partnership", OperStatus.Unknown,
                                                                                               BandType.GSM));

            mncListfor310.Add(new MNCInfo("710", "ASTAC", "Arctic Slope Telephone Association Cooperative", OperStatus.Operational,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE));

            mncListfor310.Add(new MNCInfo("720", "", "Syniverse Technologies", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("730", "U.S. Cellular", "U.S. Cellular", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("740", "Viaero", "Viaero Wireless", OperStatus.Operational,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1700,
                                                                                               BandType.LTE1900));

            mncListfor310.Add(new MNCInfo("750", "Appalachian Wireless", "East Kentucky Network, LLC", OperStatus.Operational,
                                                                                               BandType.CDMA2000850,
                                                                                               BandType.CDMA20001900));

            mncListfor310.Add(new MNCInfo("760", "", "Lynch 3G Communications Corporation", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("770", "iWireless", "Iowa Wireless Services", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS1700,
                                                                                               BandType.LTE1700,
                                                                                               BandType.LTE1900));

            mncListfor310.Add(new MNCInfo("780", "Dispatch Direct", "D. D. Inc.", OperStatus.Not_Operational,
                                                                                               BandType.iDEN));

            mncListfor310.Add(new MNCInfo("790", "BLAZE", "BLAZE", OperStatus.Not_Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS,
                                                                                               BandType.LTE));

            mncListfor310.Add(new MNCInfo("800", "", "T-Mobile", OperStatus.Not_Operational,
                                                                                               BandType.GSM1900));

            mncListfor310.Add(new MNCInfo("810", "", "Pacific Lightwave Inc.", OperStatus.Unknown,
                                                                                               BandType.one900));

            mncListfor310.Add(new MNCInfo("820", "", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("830", "", "T-Mobile US", OperStatus.Not_Operational,
                                                                                               BandType.WiMAX));

            mncListfor310.Add(new MNCInfo("840", "telna Mobile", "Telecom North America Mobile, Inc.", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncListfor310.Add(new MNCInfo("850", "Aeris", "Aeris Communications, Inc.", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncListfor310.Add(new MNCInfo("860", "Five Star Wireless", "TX RSA 15B2, LP", OperStatus.Operational,
                                                                                               BandType.CDMA));

            mncListfor310.Add(new MNCInfo("870", "PACE", "Kaplan Telephone Company", OperStatus.Not_Operational,
                                                                                               BandType.GSM850));

            mncListfor310.Add(new MNCInfo("880", "DTC Wireless", "Advantage Cellular Systems, Inc.", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor310.Add(new MNCInfo("890", "", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900));

            mncListfor310.Add(new MNCInfo("891", "", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("892", "", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("893", "", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("894", "", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("895", "", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("896", "", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("897", "", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("898", "", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("899", "", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor310.Add(new MNCInfo("900", "Mid-Rivers Wireless", "Cable & Communications Corporation", OperStatus.Operational,
                                                                                               BandType.CDMA2000850,
                                                                                               BandType.CDMA20001900));

            mncListfor310.Add(new MNCInfo("910", "", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.GSM850));

            mncListfor310.Add(new MNCInfo("920", "", "James Valley Wireless, LLC", OperStatus.Operational,
                                                                                               BandType.CDMA));

            mncListfor310.Add(new MNCInfo("930", "", "Copper Valley Wireless", OperStatus.Operational,
                                                                                               BandType.CDMA));

            mncListfor310.Add(new MNCInfo("940", "", "Tyntec Inc.", OperStatus.Unknown,
                                                                                               BandType.MVNO));

            mncListfor310.Add(new MNCInfo("950", "AT&T", "AT&T Mobility", OperStatus.Operational,
                                                                                               BandType.GSM850));

            mncListfor310.Add(new MNCInfo("960", "STRATA", "UBET Wireless", OperStatus.Operational,
                                                                                               BandType.CDMA));

            mncListfor310.Add(new MNCInfo("970", "", "Globalstar", OperStatus.Operational,
                                                                                               BandType.Satellite));

            mncListfor310.Add(new MNCInfo("980", "Peoples Telephone", "Texas RSA 7B3", OperStatus.Not_Operational,
                                                                                               BandType.CDMA,
                                                                                               BandType.LTE700));

            mncListfor310.Add(new MNCInfo("990", "Evolve Broadband", "Evolve Cellular Inc.", OperStatus.Operational,
                                                                                               BandType.LTE700));
            var mobile310 = new MobileInfo(310, mncListfor310);

            // mobile info for MCC 311
            List<MNCInfo> mncListfor311 = new List<MNCInfo>();
            mncListfor311.Add(new MNCInfo("000", "West Central Wireless", "Mid-Tex Cellular Ltd.", OperStatus.Operational,
                                                                                               BandType.CDMA2000850,
                                                                                               BandType.CDMA20001900));

            mncListfor311.Add(new MNCInfo("010", "Chariton Valley", "Chariton Valley Communications", OperStatus.Operational,
                                                                                               BandType.CDMA2000850,
                                                                                               BandType.CDMA20001900));

            mncListfor311.Add(new MNCInfo("012", "Verizon", "Verizon Wireless", OperStatus.Operational,
                                                                                               BandType.CDMA2000850,
                                                                                               BandType.CDMA20001900));

            mncListfor311.Add(new MNCInfo("020", "Chariton Valley", "Missouri RSA 5 Partnership", OperStatus.Operational,
                                                                                               BandType.GSM850));

            mncListfor311.Add(new MNCInfo("030", "Indigo Wireless", "Americell PA 3 Partnership", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850));

            mncListfor311.Add(new MNCInfo("040", "Choice Wireless", "Commnet Wireless", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.CDMA2000,
                                                                                               BandType.UMTS));

            mncListfor311.Add(new MNCInfo("050", "", "Thumb Cellular LP", OperStatus.Operational,
                                                                                               BandType.CDMA2000850));

            mncListfor311.Add(new MNCInfo("060", "", "Space Data Corporation", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("070", "AT&T", "AT&T Mobility", OperStatus.Operational,
                                                                                               BandType.GSM850));

            mncListfor311.Add(new MNCInfo("080", "Pine Cellular", "Pine Telephone Company", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.LTE));

            mncListfor311.Add(new MNCInfo("090", "AT&T", "AT&T Mobility", OperStatus.Operational,
                                                                                               BandType.GSM1900));

            mncListfor311.Add(new MNCInfo("100", "", "Nex-Tech Wireless", OperStatus.Operational,
                                                                                               BandType.CDMA2000));

            mncListfor311.Add(new MNCInfo("110", "Verizon", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("120", "IT&E Wireless", "IT&E Overseas, Inc", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("130", "", "Lightsquared L.P.", OperStatus.Not_Operational,
                                                                                               BandType.LTE));

            mncListfor311.Add(new MNCInfo("140", "Bravado Wireless", "Cross Telephone Company", OperStatus.Operational,
                                                                                               BandType.CDMA));

            mncListfor311.Add(new MNCInfo("150", "", "Cross Telephone Company", OperStatus.Operational,
                                                                                               BandType.GSM850));

            mncListfor311.Add(new MNCInfo("160", "", "Lightsquared L.P.", OperStatus.Not_Operational,
                                                                                               BandType.LTE));

            mncListfor311.Add(new MNCInfo("170", "", "Tampnet", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.LTE));

            mncListfor311.Add(new MNCInfo("180", "AT&T", "AT&T Mobility", OperStatus.Not_Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS1900));

            mncListfor311.Add(new MNCInfo("190", "AT&T", "AT&T Mobility", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("200", "", "ARINC", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("210", "", "Telnyx LLC", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncListfor311.Add(new MNCInfo("220", "U.S. Cellular", "U.S. Cellular", OperStatus.Operational,
                                                                                               BandType.CDMA));

            mncListfor311.Add(new MNCInfo("230", "C Spire Wireless", "Cellular South Inc.", OperStatus.Operational,
                                                                                               BandType.CDMA850,
                                                                                               BandType.CDMA1900,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1700,
                                                                                               BandType.LTE1900,
                                                                                               BandType.TDLTE2500));

            mncListfor311.Add(new MNCInfo("240", "", "Cordova Wireless", OperStatus.Operational,
                                                                                               BandType.GSM,
                                                                                               BandType.UMTS850,
                                                                                               BandType.WiMAX));

            mncListfor311.Add(new MNCInfo("250", "IT&E Wireless", "IT&E Overseas, Inc", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("260", "", "T-Mobile US", OperStatus.Not_Operational,
                                                                                               BandType.WiMAX));

            mncListfor311.Add(new MNCInfo("270", "Verizon", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("271", "Verizon", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("272", "Verizon", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("273", "Verizon", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("274", "Verizon", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("275", "Verizon", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("276", "Verizon", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("277", "Verizon", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("278", "Verizon", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("279", "Verizon", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("280", "Verizon", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("281", "Verizon", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("282", "Verizon", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("283", "Verizon", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("284", "Verizon", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("285", "Verizon", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("286", "Verizon", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("287", "Verizon", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("288", "Verizon", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("289", "Verizon", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("290", "BLAZE", "PinPoint Communications Inc.", OperStatus.Not_Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS,
                                                                                               BandType.LTE));

            mncListfor311.Add(new MNCInfo("300", "", "Nexus Communications, Inc.", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("310", "NMobile", "Leaco Rural Telephone Company Inc.", OperStatus.Not_Operational,
                                                                                               BandType.CDMA2000));

            mncListfor311.Add(new MNCInfo("320", "Choice Wireless", "Commnet Wireless", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.CDMA2000,
                                                                                               BandType.UMTS));

            mncListfor311.Add(new MNCInfo("330", "Bug Tussel Wireless", "Bug Tussel Wireless LLC", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.LTE1700,
                                                                                               BandType.WiMAX3700));

            mncListfor311.Add(new MNCInfo("340", "", "Illinois Valley Cellular", OperStatus.Operational,
                                                                                               BandType.CDMA2000,
                                                                                               BandType.LTE850));

            mncListfor311.Add(new MNCInfo("350", "Nemont", "Sagebrush Cellular, Inc.", OperStatus.Operational,
                                                                                               BandType.CDMA2000));

            mncListfor311.Add(new MNCInfo("360", "", "Stelera Wireless", OperStatus.Not_Operational,
                                                                                               BandType.UMTS1700));

            mncListfor311.Add(new MNCInfo("370", "GCI Wireless", "General Communication Inc.", OperStatus.Operational,
                                                                                               BandType.LTE1700));

            mncListfor311.Add(new MNCInfo("380", "", "New Dimension Wireless Ltd.", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncListfor311.Add(new MNCInfo("390", "Verizon", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("400", "", "", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("410", "Chat Mobility", "Iowa RSA No. 2 LP", OperStatus.Operational,
                                                                                               BandType.CDMA));

            mncListfor311.Add(new MNCInfo("420", "NorthwestCell", "Northwest Missouri Cellular LP", OperStatus.Operational,
                                                                                               BandType.CDMA));

            mncListfor311.Add(new MNCInfo("430", "Chat Mobility", "RSA 1 LP", OperStatus.Unknown,
                                                                                               BandType.CDMA));

            mncListfor311.Add(new MNCInfo("440", "", "Bluegrass Cellular LLC", OperStatus.Operational,
                                                                                               BandType.CDMA));

            mncListfor311.Add(new MNCInfo("450", "PTCI", "Panhandle Telecommunication Systems Inc.", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.LTE700));

            mncListfor311.Add(new MNCInfo("460", "", "Electric Imp Inc.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("470", "Viya", "Vitelcom Cellular Inc.", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.TDLTE2500));

            mncListfor311.Add(new MNCInfo("480", "Verizon", "Verizon Wireless", OperStatus.Operational,
                                                                                               BandType.LTE700));

            mncListfor311.Add(new MNCInfo("481", "Verizon", "Verizon Wireless", OperStatus.Not_Operational,
                                                                                               BandType.LTE700));

            mncListfor311.Add(new MNCInfo("481", "Verizon", "Verizon Wireless", OperStatus.Not_Operational,
                                                                                               BandType.LTE700));

            mncListfor311.Add(new MNCInfo("481", "Verizon", "Verizon Wireless", OperStatus.Not_Operational,
                                                                                               BandType.LTE700));

            mncListfor311.Add(new MNCInfo("481", "Verizon", "Verizon Wireless", OperStatus.Not_Operational,
                                                                                               BandType.LTE700));

            mncListfor311.Add(new MNCInfo("481", "Verizon", "Verizon Wireless", OperStatus.Not_Operational,
                                                                                               BandType.LTE700));

            mncListfor311.Add(new MNCInfo("481", "Verizon", "Verizon Wireless", OperStatus.Not_Operational,
                                                                                               BandType.LTE700));

            mncListfor311.Add(new MNCInfo("481", "Verizon", "Verizon Wireless", OperStatus.Not_Operational,
                                                                                               BandType.LTE700));

            mncListfor311.Add(new MNCInfo("481", "Verizon", "Verizon Wireless", OperStatus.Not_Operational,
                                                                                               BandType.LTE700));

            mncListfor311.Add(new MNCInfo("481", "Verizon", "Verizon Wireless", OperStatus.Not_Operational,
                                                                                               BandType.LTE700));

            mncListfor311.Add(new MNCInfo("490", "", "T-Mobile US", OperStatus.Operational,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1900,
                                                                                               BandType.TDLTE2500));

            mncListfor311.Add(new MNCInfo("500", "", "Mosaic Telecom", OperStatus.Not_Operational,
                                                                                               BandType.UMTS,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1700));

            mncListfor311.Add(new MNCInfo("510", "", "Ligado Networks", OperStatus.Not_Operational,
                                                                                               BandType.LTE));

            mncListfor311.Add(new MNCInfo("520", "", "Lightsquared L.P.", OperStatus.Not_Operational,
                                                                                               BandType.LTE));

            mncListfor311.Add(new MNCInfo("530", "NewCore", "NewCore Wireless LLC", OperStatus.Operational,
                                                                                               BandType.LTE1900));

            mncListfor311.Add(new MNCInfo("540", "", "Proximiti Mobility Inc.", OperStatus.Not_Operational,
                                                                                               BandType.GSM850));

            mncListfor311.Add(new MNCInfo("550", "Choice Wireless", "Commnet Wireless LLC", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.CDMA2000,
                                                                                               BandType.UMTS));

            mncListfor311.Add(new MNCInfo("560", "OTZ Cellular", "OTZ Communications, Inc.", OperStatus.Operational,
                                                                                               BandType.GSM850));

            mncListfor311.Add(new MNCInfo("570", "", "Mediacom", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("580", "U.S. Cellular", "U.S. Cellular", OperStatus.Operational,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE850));

            mncListfor311.Add(new MNCInfo("590", "Verizon", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("600", "Limitless Mobile", "Limitless Mobile, LLC", OperStatus.Unknown,
                                                                                               BandType.CDMA));

            mncListfor311.Add(new MNCInfo("610", "SRT Communications", "North Dakota Network Co.", OperStatus.Not_Operational,
                                                                                               BandType.CDMA));

            mncListfor311.Add(new MNCInfo("620", "", "TerreStar Networks, Inc.", OperStatus.Not_Operational,
                                                                                               BandType.Satellite));

            mncListfor311.Add(new MNCInfo("630", "Spire Wireless", "Cellular South Inc.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("640", "Rock Wireless", "Standing Rock Telecommunications", OperStatus.Operational,
                                                                                               BandType.LTE700));

            mncListfor311.Add(new MNCInfo("650", "United Wireless", "United Wireless", OperStatus.Operational,
                                                                                               BandType.CDMA,
                                                                                               BandType.LTE700,
                                                                                               BandType.WiMAX3700));

            mncListfor311.Add(new MNCInfo("660", "Metro", "Metro by T-Mobile", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncListfor311.Add(new MNCInfo("670", "Pine Belt Wireless", "Pine Belt Cellular Inc.", OperStatus.Operational,
                                                                                               BandType.CDMA,
                                                                                               BandType.LTE700));

            mncListfor311.Add(new MNCInfo("680", "", "GreenFly LLC", OperStatus.Unknown,
                                                                                               BandType.GSM1900));

            mncListfor311.Add(new MNCInfo("690", "", "TeleBEEPER of New Mexico", OperStatus.Operational,
                                                                                               BandType.paging));

            mncListfor311.Add(new MNCInfo("700", "", "Midwest Network Solutions Hub LLC", OperStatus.Unknown,
                                                                                               BandType.MVNO));

            mncListfor311.Add(new MNCInfo("710", "", "Northeast Wireless Networks LLC", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("720", "", "MainePCS LLC", OperStatus.Not_Operational,
                                                                                               BandType.GSM1900));

            mncListfor311.Add(new MNCInfo("730", "", "Proximiti Mobility Inc.", OperStatus.Operational,
                                                                                               BandType.GSM850));

            mncListfor311.Add(new MNCInfo("740", "", "Telalaska Cellular", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.LTE));

            mncListfor311.Add(new MNCInfo("750", "ClearTalk", "Flat Wireless LLC", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("760", "", "Edigen Inc.", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("770", "", "Altiostar Networks, Inc.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("780", "ASTCA", "American Samoa Telecommunications Authority", OperStatus.Operational,
                                                                                               BandType.LTE700));

            mncListfor311.Add(new MNCInfo("790", "", "Coleman County Telephone Cooperative, Inc.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("800", "", "Bluegrass Cellular LLC", OperStatus.Operational,
                                                                                               BandType.LTE700));

            mncListfor311.Add(new MNCInfo("810", "", "Bluegrass Cellular LLC", OperStatus.Operational,
                                                                                               BandType.LTE700));

            mncListfor311.Add(new MNCInfo("820", "", "Sonus Networks", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("830", "", "Thumb Cellular LP", OperStatus.Operational,
                                                                                               BandType.LTE700));

            mncListfor311.Add(new MNCInfo("840", "Cellcom", "Nsight", OperStatus.Operational,
                                                                                               BandType.LTE700));

            mncListfor311.Add(new MNCInfo("850", "Cellcom", "Nsight", OperStatus.Operational,
                                                                                               BandType.LTE700));

            mncListfor311.Add(new MNCInfo("860", "STRATA", "Uintah Basin Electronic Telecommunications", OperStatus.Operational,
                                                                                               BandType.LTE700));

            mncListfor311.Add(new MNCInfo("870", "Boost Mobile", "T-Mobile US", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncListfor311.Add(new MNCInfo("880", "", "T-Mobile US", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("882", "", "T-Mobile US", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("890", "", "Globecomm Network Services Corporation", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("900", "", "GigSky", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncListfor311.Add(new MNCInfo("910", "MobileNation", "SI Wireless LLC", OperStatus.Not_Operational,
                                                                                               BandType.CDMA,
                                                                                               BandType.LTE));

            mncListfor311.Add(new MNCInfo("920", "Chariton Valley", "Missouri RSA 5 Partnership", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("930", "", "Syringa Wireless", OperStatus.Not_Operational,
                                                                                               BandType.LTE700));

            mncListfor311.Add(new MNCInfo("940", "", "T-Mobile US", OperStatus.Not_Operational,
                                                                                               BandType.WiMAX));

            mncListfor311.Add(new MNCInfo("950", "ETC", "Enhanced Telecommmunications Corp.", OperStatus.Operational,
                                                                                               BandType.CDMA,
                                                                                               BandType.LTE700));

            mncListfor311.Add(new MNCInfo("960", "Lycamobile", "Lycamobile USA Inc.", OperStatus.Not_Operational,
                                                                                               BandType.MVNO));

            mncListfor311.Add(new MNCInfo("970", "Big River Broadband", "Big River Broadband, LLC", OperStatus.Operational,
                                                                                               BandType.LTE1700));

            mncListfor311.Add(new MNCInfo("980", "", "LigTel Communications", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor311.Add(new MNCInfo("990", "", "VTel Wireless", OperStatus.Operational,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1700));
            var mobile311 = new MobileInfo(311, mncListfor311);

            // mobile info for MCC 312
            List<MNCInfo> mncListfor312 = new List<MNCInfo>();
            mncListfor312.Add(new MNCInfo("010", "Chariton Valley", "Chariton Valley Communications Corporation, Inc", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("020", "", "Infrastructure Networks, LLC", OperStatus.Operational,
                                                                                               BandType.LTE700));

            mncListfor312.Add(new MNCInfo("030", "Bravado Wireless", "Cross Wireless", OperStatus.Operational,
                                                                                               BandType.LTE700));

            mncListfor312.Add(new MNCInfo("040", "", "Custer Telephone Co-op (CTCI)", OperStatus.Operational,
                                                                                               BandType.LTE700));

            mncListfor312.Add(new MNCInfo("050", "", "Fuego Wireless", OperStatus.Not_Operational,
                                                                                               BandType.LTE700));

            mncListfor312.Add(new MNCInfo("060", "", "CoverageCo", OperStatus.Unknown,
                                                                                               BandType.CDMA,
                                                                                               BandType.GSM));

            mncListfor312.Add(new MNCInfo("070", "", "Adams Networks Inc", OperStatus.Not_Operational,
                                                                                               BandType.LTE700));

            mncListfor312.Add(new MNCInfo("080", "SyncSouth", "South Georgia Regional Information Technology Authority", OperStatus.Operational,
                                                                                               BandType.UMTSTDD700));

            mncListfor312.Add(new MNCInfo("090", "AT&T", "AT&T Mobility", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("100", "", "ClearSky Technologies, Inc.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("110", "", "Texas Energy Network LLC", OperStatus.Not_Operational,
                                                                                               BandType.LTE));

            mncListfor312.Add(new MNCInfo("120", "Appalachian Wireless", "East Kentucky Network, LLC", OperStatus.Operational,
                                                                                               BandType.LTE700));

            mncListfor312.Add(new MNCInfo("130", "Appalachian Wireless", "East Kentucky Network, LLC", OperStatus.Operational,
                                                                                               BandType.LTE700));

            mncListfor312.Add(new MNCInfo("140", "Revol Wireless", "Cleveland Unlimited, Inc.", OperStatus.Not_Operational,
                                                                                               BandType.CDMA));

            mncListfor312.Add(new MNCInfo("150", "NorthwestCell", "Northwest Missouri Cellular LP", OperStatus.Operational,
                                                                                               BandType.LTE700));

            mncListfor312.Add(new MNCInfo("160", "Chat Mobility", "RSA1 Limited Partnership", OperStatus.Operational,
                                                                                               BandType.LTE700));

            mncListfor312.Add(new MNCInfo("170", "Chat Mobility", "Iowa RSA No. 2 LP", OperStatus.Operational,
                                                                                               BandType.LTE700));

            mncListfor312.Add(new MNCInfo("180", "", "Limitless Mobile LLC", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("190", "", "T-Mobile US", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("200", "", "Voyager Mobility LLC", OperStatus.Not_Operational,
                                                                                               BandType.MVNO));

            mncListfor312.Add(new MNCInfo("210", "", "Aspenta International, Inc.", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncListfor312.Add(new MNCInfo("220", "Chariton Valley", "Chariton Valley Communications Corporation, Inc.", OperStatus.Operational,
                                                                                               BandType.LTE700));

            mncListfor312.Add(new MNCInfo("230", "SRT Communications", "North Dakota Network Co.", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("240", "Sprint", "Sprint Corporation", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("250", "", "T-Mobile US", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("260", "NewCore", "Central LTE Holdings", OperStatus.Operational,
                                                                                               BandType.LTE1900));

            mncListfor312.Add(new MNCInfo("270", "Pioneer Cellular", "ellular Network Partnership", OperStatus.Operational,
                                                                                               BandType.LTE700));

            mncListfor312.Add(new MNCInfo("280", "Pioneer Cellular", "ellular Network Partnership", OperStatus.Operational,
                                                                                               BandType.LTE700));

            mncListfor312.Add(new MNCInfo("290", "STRATA", "Uintah Basin Electronic Telecommunications", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("300", "telna Mobile", "Telecom North America Mobile, Inc.", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncListfor312.Add(new MNCInfo("310", "", "Clear Stream Communications, LLC", OperStatus.Operational,
                                                                                               BandType.LTE700));

            mncListfor312.Add(new MNCInfo("320", "", "RTC Communications LLC", OperStatus.Operational,
                                                                                               BandType.LTE700));

            mncListfor312.Add(new MNCInfo("330", "Nemont", "Nemont Communications, Inc.", OperStatus.Operational,
                                                                                               BandType.LTE700));

            mncListfor312.Add(new MNCInfo("340", "MTA", "Matanuska Telephone Association, Inc.", OperStatus.Not_Operational,
                                                                                               BandType.LTE700));

            mncListfor312.Add(new MNCInfo("350", "", "Triangle Communication System Inc.", OperStatus.Operational,
                                                                                               BandType.LTE700));

            mncListfor312.Add(new MNCInfo("360", "", "Wes-Tex Telecommunications, Ltd.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("370", "Choice Wireless", "Commnet Wireless", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor312.Add(new MNCInfo("380", "", "Copper Valley Wireless", OperStatus.Operational,
                                                                                               BandType.LTE700));

            mncListfor312.Add(new MNCInfo("390", "FTC Wireless", "FTC Communications LLC", OperStatus.Operational,
                                                                                               BandType.UMTS,
                                                                                               BandType.LTE));

            mncListfor312.Add(new MNCInfo("400", "Mid-Rivers Wireless", "Mid-Rivers Telephone Cooperative", OperStatus.Operational,
                                                                                               BandType.LTE700));

            mncListfor312.Add(new MNCInfo("410", "", "Eltopia Communications, LLC", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("420", "", "Nex-Tech Wireless", OperStatus.Operational,
                                                                                               BandType.LTE700));

            mncListfor312.Add(new MNCInfo("430", "", "Silver Star Communications", OperStatus.Operational,
                                                                                               BandType.CDMA,
                                                                                               BandType.LTE700));

            mncListfor312.Add(new MNCInfo("440", "", "Consolidated Telcom", OperStatus.Not_Operational,
                                                                                               BandType.Two500));

            mncListfor312.Add(new MNCInfo("450", "", "Cable & Communications Corporation", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("460", "", "Ketchikan Public Utilities (KPU)", OperStatus.Operational,
                                                                                               BandType.LTE700));

            mncListfor312.Add(new MNCInfo("470", "Carolina West Wireless", "Carolina West Wireless", OperStatus.Operational,
                                                                                               BandType.LTE700));

            mncListfor312.Add(new MNCInfo("480", "Nemont", "Sagebrush Cellular, Inc.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("490", "", "TrustComm, Inc.", OperStatus.Unknown,
                                                                                               BandType.Satellite));

            mncListfor312.Add(new MNCInfo("500", "", "AB Spectrum LLC", OperStatus.Not_Operational,
                                                                                               BandType.LTE700));

            mncListfor312.Add(new MNCInfo("510", "", "WUE Inc.", OperStatus.Unknown,
                                                                                               BandType.LTE));

            mncListfor312.Add(new MNCInfo("520", "", "ANIN", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("530", "", "T-Mobile US", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("540", "", "Broadband In Hand LLC", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("550", "", "Great Plains Communications, Inc.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("560", "", "NHLT Inc.", OperStatus.Not_Operational,
                                                                                               BandType.MVNO));

            mncListfor312.Add(new MNCInfo("570", "Blue Wireless", "Buffalo-Lake Erie Wireless Systems Co., LLC", OperStatus.Not_Operational,
                                                                                               BandType.CDMA,
                                                                                               BandType.LTE));

            mncListfor312.Add(new MNCInfo("580", "", "Morgan, Lewis & Bockius LLP", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("590", "NMU", "Northern Michigan University", OperStatus.Operational,
                                                                                               BandType.LTE2600));

            mncListfor312.Add(new MNCInfo("600", "Nemont", "Sagebrush Cellular, Inc.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("610", "nTelos", "nTelos Licenses, Inc.", OperStatus.Not_Operational,
                                                                                               BandType.LTE1900));

            mncListfor312.Add(new MNCInfo("620", "", "GlobeTouch Inc.", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncListfor312.Add(new MNCInfo("630", "", "NetGenuity, Inc.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("640", "Nemont", "Sagebrush Cellular, Inc.", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("650", "", "Brightlink", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("660", "nTelos", "nTelos Wireless", OperStatus.Not_Operational,
                                                                                               BandType.LTE1900));

            mncListfor312.Add(new MNCInfo("670", "FirstNet", "AT&T Mobility", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("680", "AT&T", "AT&T Mobility", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("690", "", "TGS, LLC", OperStatus.Operational,
                                                                                               BandType.MVNO,
                                                                                               BandType.MVNE));

            mncListfor312.Add(new MNCInfo("700", "", "Wireless Partners, LLC", OperStatus.Operational,
                                                                                               BandType.LTE700));

            mncListfor312.Add(new MNCInfo("710", "", "Great North Woods Wireless LLC", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor312.Add(new MNCInfo("720", "Southern LINC", "Southern Communications Services", OperStatus.Operational,
                                                                                               BandType.LTE850));

            mncListfor312.Add(new MNCInfo("730", "", "Triangle Communication System Inc.", OperStatus.Operational,
                                                                                               BandType.CDMA));

            mncListfor312.Add(new MNCInfo("740", "Locus Telecommunications", "KDDI America, Inc.", OperStatus.Not_Operational,
                                                                                               BandType.MVNO));

            mncListfor312.Add(new MNCInfo("750", "", "Artemis Networks LLC", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("760", "ASTAC", "Arctic Slope Telephone Association Cooperative", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("770", "Verizon", "Verizon Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("780", "", "Redzone Wireless", OperStatus.Operational,
                                                                                               BandType.TDLTE2500));

            mncListfor312.Add(new MNCInfo("790", "", "Gila Electronics", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("800", "", "Cirrus Core Networks", OperStatus.Unknown,
                                                                                               BandType.MVNO));

            mncListfor312.Add(new MNCInfo("810", "BBCP", "Bristol Bay Telephone Cooperative", OperStatus.Operational,
                                                                                               BandType.CDMA,
                                                                                               BandType.LTE));

            mncListfor312.Add(new MNCInfo("820", "", "Santel Communications Cooperative, Inc.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("830", "", "Kings County Office of Education", OperStatus.Operational,
                                                                                               BandType.WiMAX));

            mncListfor312.Add(new MNCInfo("840", "", "South Georgia Regional Information Technology Authority", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("850", "", "Onvoy Spectrum, LLC", OperStatus.Unknown,
                                                                                               BandType.MVNO));

            mncListfor312.Add(new MNCInfo("860", "ClearTalk", "Flat Wireless, LLC", OperStatus.Operational,
                                                                                               BandType.CDMA,
                                                                                               BandType.LTE1900,
                                                                                               BandType.LTE1700));

            mncListfor312.Add(new MNCInfo("870", "", "GigSky Mobile, LLC", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncListfor312.Add(new MNCInfo("880", "", "Albemarle County Public Schools", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("890", "", "Circle Gx", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("900", "ClearTalk", "Flat West Wireless, LLC", OperStatus.Operational,
                                                                                               BandType.CDMA,
                                                                                               BandType.LTE1900,
                                                                                               BandType.LTE1700));

            mncListfor312.Add(new MNCInfo("910", "Appalachian Wireless", "East Kentucky Network, LLC", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("920", "", "ortheast Wireless Networks LLC", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("930", "", "Hewlett-Packard Communication Services, LLC", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("940", "", "Webformix", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("950", "", "Custer Telephone Co-op (CTCI)", OperStatus.Operational,
                                                                                               BandType.CDMA));

            mncListfor312.Add(new MNCInfo("960", "", "M&A Technology, Inc.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("970", "", "IOSAZ Intellectual Property LLC", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("980", "", "Mark Twain Communications Company", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor312.Add(new MNCInfo("990", "Premier Broadband", "Premier Holdings LLC", OperStatus.Unknown,
                                                                                               BandType.Unknown));
            var mobile312 = new MobileInfo(312, mncListfor312);

            // mobile info for MCC 313
            List<MNCInfo> mncListfor313 = new List<MNCInfo>();
            mncListfor313.Add(new MNCInfo("000", "", "Tennessee Wireless", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("010", "Bravado Wireless", "Cross Wireless LLC", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("020", "CTC Wireless", "Cambridge Telephone Company Inc.", OperStatus.Operational,
                                                                                               BandType.CDMA));

            mncListfor313.Add(new MNCInfo("030", "Snake River PCS", "Eagle Telephone System Inc.", OperStatus.Operational,
                                                                                               BandType.CDMA));

            mncListfor313.Add(new MNCInfo("040", "NNTC Wireless", "Nucla-Naturita Telephone Company", OperStatus.Operational,
                                                                                               BandType.CDMA));

            mncListfor313.Add(new MNCInfo("050", "Breakaway Wireless", "Manti Tele Communications Company, Inc.", OperStatus.Not_Operational,
                                                                                               BandType.CDMA));

            mncListfor313.Add(new MNCInfo("060", "", "Country Wireless", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("061", "", "Country Wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("070", "", "Midwest Network Solutions Hub LLC", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("080", "", "Speedwavz LLP", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("090", "", "Vivint Wireless, Inc.", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("100", "FirstNet", "AT&T FirstNet", OperStatus.Operational,
                                                                                               BandType.LTE700));

            mncListfor313.Add(new MNCInfo("110", "FirstNet", "AT&T FirstNet", OperStatus.Unknown,
                                                                                               BandType.LTE));

            mncListfor313.Add(new MNCInfo("120", "FirstNet", "AT&T FirstNet", OperStatus.Unknown,
                                                                                               BandType.LTE));

            mncListfor313.Add(new MNCInfo("130", "FirstNet", "AT&T FirstNet", OperStatus.Unknown,
                                                                                               BandType.LTE));

            mncListfor313.Add(new MNCInfo("140", "FirstNet", "AT&T FirstNet", OperStatus.Unknown,
                                                                                               BandType.LTE));

            mncListfor313.Add(new MNCInfo("150", "FirstNet", "700 MHz Public Safety Broadband", OperStatus.Unknown,
                                                                                               BandType.LTE));

            mncListfor313.Add(new MNCInfo("160", "FirstNet", "700 MHz Public Safety Broadband", OperStatus.Unknown,
                                                                                               BandType.LTE));

            mncListfor313.Add(new MNCInfo("170", "FirstNet", "700 MHz Public Safety Broadband", OperStatus.Unknown,
                                                                                               BandType.LTE));

            mncListfor313.Add(new MNCInfo("180", "FirstNet", "700 MHz Public Safety Broadband", OperStatus.Unknown,
                                                                                               BandType.LTE));

            mncListfor313.Add(new MNCInfo("190", "FirstNet", "700 MHz Public Safety Broadband", OperStatus.Unknown,
                                                                                               BandType.LTE));

            mncListfor313.Add(new MNCInfo("200", "", "Mercury Network Corporation", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("210", "AT&T", "AT&T Mobility", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("220", "", "Custer Telephone Co-op (CTCI)", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("230", "", "Velocity Communications Inc.", OperStatus.Unknown,
                                                                                               BandType.LTE));

            mncListfor313.Add(new MNCInfo("240", "Peak Internet", "Fundamental Holdings, Corp.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("250", "", "Imperial County Office of Education", OperStatus.Unknown,
                                                                                               BandType.LTE));

            mncListfor313.Add(new MNCInfo("260", "", "Expeto Wireless Inc.", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncListfor313.Add(new MNCInfo("270", "", "Blackstar Management", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("280", "", "King Street Wireless, LP", OperStatus.Unknown,
                                                                                               BandType.LTE700));

            mncListfor313.Add(new MNCInfo("290", "", "Gulf Coast Broadband LLC", OperStatus.Unknown,
                                                                                               BandType.LTE));

            mncListfor313.Add(new MNCInfo("300", "", "Cambio WiFi of Delmarva, LLC", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor313.Add(new MNCInfo("310", "", "CAL.NET, Inc.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("320", "", "Paladin Wireless", OperStatus.Unknown,
                                                                                               BandType.LTE3500));

            mncListfor313.Add(new MNCInfo("330", "", "CenturyTel Broadband Services LLC", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("340", "", "Dish Network", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("350", "", "Dish Network", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("360", "", "Dish Network", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("370", "", "Red Truck Wireless, LLC", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("380", "", "OptimERA Inc.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("390", "", "ltice USA Wireless, Inc.", OperStatus.Unknown,
                                                                                               BandType.MVNO));

            mncListfor313.Add(new MNCInfo("400", "", "Texoma Communications, LLC", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("410", "", "pdvWireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("420", "", "Hudson Valley Wireless", OperStatus.Unknown,
                                                                                               BandType.LTE3500));

            mncListfor313.Add(new MNCInfo("440", "", "Arvig Enterprises, Inc.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("450", "", "Spectrum Wireless Holdings, LLC", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("460", "", "Mobi, Inc.", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncListfor313.Add(new MNCInfo("470", "", "San Diego Gas & Electric Company", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("480", "", "Ready Wireless, LLC", OperStatus.Unknown,
                                                                                               BandType.MVNO));

            mncListfor313.Add(new MNCInfo("490", "", "Puloli, Inc.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("500", "", "Shelcomm, Inc.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("510", "", "Puerto Rico Telecom Company", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("520", "", "Florida Broadband, Inc.", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("540", "", "Nokia Innovations US LLC", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("550", "", "Mile High Networks LLC", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("560", "", "ransit Wireless LLC", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("570", "Pioneer Cellular", "Cellular Network Partnership", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("580", "", "Telecall Telecommunications Corp.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("590", "Southern LINC", "Southern Communications Services, Inc.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("600", "", "ST Engineering iDirect", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("610", "", "Crystal Automation Systems, Inc.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("620", "", "Screened Images, Inc.", OperStatus.Unknown,
                                                                                               BandType.Unknown1700));

            mncListfor313.Add(new MNCInfo("630", "", "LICT Corporation", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("640", "", "Geoverse LLC", OperStatus.Unknown,
                                                                                               BandType.LTE3500));

            mncListfor313.Add(new MNCInfo("650", "", "Chevron USA, Inc.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("660", "", "Hudson Valley Wireless", OperStatus.Unknown,
                                                                                               BandType.LTE3500));

            mncListfor313.Add(new MNCInfo("670", "", "Hudson Valley Wireless", OperStatus.Unknown,
                                                                                               BandType.LTE3500));

            mncListfor313.Add(new MNCInfo("680", "", "Hudson Valley Wireless", OperStatus.Unknown,
                                                                                               BandType.LTE3500));

            mncListfor313.Add(new MNCInfo("690", "", "Shenandoah Cable Television, LLC", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor313.Add(new MNCInfo("700", "", "Ameren Services Company", OperStatus.Unknown,
                                                                                               BandType.eight00));

            mncListfor313.Add(new MNCInfo("710", "", "Extent Systems", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("720", "", "1st Point Communications, LLC", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("730", "", "TruAccess Networks", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("740", "", "RTO Wireless, LLC", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("750", "ZipLink", "CellTex Networks, LLC", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("760", "", "Hologram, Inc.", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncListfor313.Add(new MNCInfo("770", "", "Tango Networks", OperStatus.Unknown,
                                                                                               BandType.MVNO));

            mncListfor313.Add(new MNCInfo("780", "", "Windstream Holdings", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("790", "Liberty", "Liberty Cablevision of Puerto Rico LLC", OperStatus.Operational,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1700,
                                                                                               BandType.LTE1900,
                                                                                               BandType.LTE2300,
                                                                                               BandType.FiveG850));

            mncListfor313.Add(new MNCInfo("800", "", "Wireless Technologies of Nebraska", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("810", "", "Watch Communications", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("820", "", "Inland Cellular Telephone Company", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor313.Add(new MNCInfo("830", "", "360 Communications", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("840", "", "CellBlox Acqusitions", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("850", "", "oftcom Internet Communications, Inc", OperStatus.Operational,
                                                                                               BandType.LTE));

            mncListfor313.Add(new MNCInfo("860", "Nextlink", "AMG Technology Investment Group", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("870", "", "ElektraFi LLC", OperStatus.Operational,
                                                                                               BandType.FiveG3500));

            mncListfor313.Add(new MNCInfo("880", "", "Shuttle wireless", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("890", "TCOE", "Tulare County Office of Education", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("900", "", "Tribal Networks", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("910", "", "San Diego Gas & Electric", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("920", "", "JCI", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("930", "Rock Wireless", "Standing Rock Telecom", OperStatus.Operational,
                                                                                               BandType.LTE2500));

            mncListfor313.Add(new MNCInfo("940", "", "Motorola Solutions", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("950", "", "Cheyenne and Arapaho Development Group", OperStatus.Unknown,
                                                                                               BandType.Two500));

            mncListfor313.Add(new MNCInfo("960", "", "Townes 5G, LLC", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("970", "", "Tycrhron", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("980", "", "Next Generation Application LLC", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor313.Add(new MNCInfo("990", "", "Ericsson US", OperStatus.Unknown,
                                                                                               BandType.Unknown));
            var mobile313 = new MobileInfo(313, mncListfor313);

            // mobile info for MCC 314
            List<MNCInfo> mncListfor314 = new List<MNCInfo>();
            mncListfor314.Add(new MNCInfo("010", "", "Boingo Wireless Inc.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor314.Add(new MNCInfo("020", "", "Spectrum Wireless Holdings, LLC", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor314.Add(new MNCInfo("030", "", "Baicells Technologies North America Inc.", OperStatus.Unknown,
                                                                                               BandType.LTE));

            mncListfor314.Add(new MNCInfo("100", "", "Reserved for Public Safety", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor314.Add(new MNCInfo("110", "", "Reserved for Public Safety", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor314.Add(new MNCInfo("120", "", "Reserved for Public Safety", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor314.Add(new MNCInfo("130", "", "Reserved for Public Safety", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor314.Add(new MNCInfo("140", "", "Reserved for Public Safety", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor314.Add(new MNCInfo("150", "", "Reserved for Public Safety", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor314.Add(new MNCInfo("160", "", "Reserved for Public Safety", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor314.Add(new MNCInfo("170", "", "Reserved for Public Safety", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor314.Add(new MNCInfo("180", "", "Reserved for Public Safety", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncListfor314.Add(new MNCInfo("190", "", "Reserved for Public Safety", OperStatus.Unknown,
                                                                                               BandType.Unknown));
            var mobile314 = new MobileInfo(314, mncListfor314);

            // mobile info for MCC 315
            List<MNCInfo> mncListfor315 = new List<MNCInfo>();
            mncListfor315.Add(new MNCInfo("010", "CBRS", "Citizens Broadband Radio Service", OperStatus.Unknown,
                                                                                               BandType.TDLTE3500));
            var mobile315 = new MobileInfo(315, mncListfor315);

            // mobile info for MCC 316
            List<MNCInfo> mncListfor316 = new List<MNCInfo>();
            mncListfor316.Add(new MNCInfo("010", "Nextel", "Nextel Communications", OperStatus.Not_Operational,
                                                                                               BandType.iDEN800));

            mncListfor316.Add(new MNCInfo("011", "Southern LINC", "Southern Communications Services", OperStatus.Not_Operational,
                                                                                               BandType.iDEN800));
            var mobile316 = new MobileInfo(316, mncListfor316);

            _countries.Add(new CountryInfo(Resources.US, "US", "USA", "840", ContinentCode.NA, mobile310, mobile311, mobile312, mobile313, mobile314, mobile315, mobile316));
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
            mncList.Add(new MNCInfo("170", "FLOW", "Cable & Wireless", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1900));

            mncList.Add(new MNCInfo("370", "", "BVI Cable TV Ltd", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("570", "CCT Boatphone", "Caribbean Cellular Telephone", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1900));

            mncList.Add(new MNCInfo("770", "Digicel", "Digicel (BVI) Limited", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1700));

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
            // mobile info for MCC 310
            List<MNCInfo> mncListfor310 = new List<MNCInfo>();
            mncListfor310.Add(new MNCInfo("120", "Sprint", "Sprint Corporation", OperStatus.Operational,
                                                                                               BandType.CDMA20001900,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1900));

            mncListfor310.Add(new MNCInfo("260", "T-Mobile", "T-Mobile US", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.UMTS1700,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1900,
                                                                                               BandType.LTE1700,
                                                                                               BandType.FiveG600));

            mncListfor310.Add(new MNCInfo("410", "AT&T", "Liberty", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS1900));
            var mobile310 = new MobileInfo(310, mncListfor310);

            // mobile info for MCC 311
            List<MNCInfo> mncListfor311 = new List<MNCInfo>();
            mncListfor311.Add(new MNCInfo("470", "Viya", "Vitelcom Cellular Inc.", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.TDLTE2500));
            var mobile311 = new MobileInfo(311, mncListfor311);

            ///	The US Virgin Islands share the US MCCs instead of using the assigned MCC 332

            _countries.Add(new CountryInfo(Resources.VI, "VI", "VIR", "850", ContinentCode.NA, new MobileInfo(332), mobile310, mobile311));
        }
    }
}
