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
            mncList.Add(new MNCInfo("00", "Nextel", "NII Holdings, Inc.", OperStatus.Not_Operational,
                                                                                               BandType.iDEN850));

            mncList.Add(new MNCInfo("01", "", "SISTEER DO BRASIL TELECOMUNICAÇÔES", OperStatus.Unknown,
                                                                                               BandType.MVNO));
            
            mncList.Add(new MNCInfo("02", "TIM", "Telecom Italia Mobile", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.LTE2600,
                                                                                               BandType.FiveG700,
                                                                                               BandType.FiveG1800,
                                                                                               BandType.FiveG2600));

            mncList.Add(new MNCInfo("03", "TIM", "Telecom Italia Mobile", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.LTE2600,
                                                                                               BandType.FiveG700,
                                                                                               BandType.FiveG1800,
                                                                                               BandType.FiveG2600));

            mncList.Add(new MNCInfo("04", "TIM", "Telecom Italia Mobile", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.LTE2600,
                                                                                               BandType.FiveG700,
                                                                                               BandType.FiveG1800,
                                                                                               BandType.FiveG2600));

            mncList.Add(new MNCInfo("05", "Claro", "Claro", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600,
                                                                                               BandType.FiveG2600));

            mncList.Add(new MNCInfo("06", "Vivo", "Telefônica Brasil S.A.", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600,
                                                                                               BandType.FiveG700,
                                                                                               BandType.FiveG1800,
                                                                                               BandType.FiveG2600));

            mncList.Add(new MNCInfo("10", "Vivo", "Telefônica Brasil S.A.", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600,
                                                                                               BandType.FiveG700,
                                                                                               BandType.FiveG1800,
                                                                                               BandType.FiveG2600));

            mncList.Add(new MNCInfo("11", "Vivo", "Telefônica Brasil S.A.", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600,
                                                                                               BandType.FiveG700,
                                                                                               BandType.FiveG1800,
                                                                                               BandType.FiveG2600));

            mncList.Add(new MNCInfo("15", "Sercomtel", "Sercomtel Celular", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS850));

            mncList.Add(new MNCInfo("16", "Brasil Telecom GSM", "Brasil Telecom GSM", OperStatus.Not_Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100));

            mncList.Add(new MNCInfo("17", "Surf Telecom", "Correios Celular[pt]", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("18", "datora", "Datora (Vodafone)", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("21", "LIGUE", "Ligue Telecom", OperStatus.Operational,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("23", "Vivo", "Telefônica Brasil S.A.", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("24", "", "Amazonia Celular", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("28", "No name", "", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("30", "Oi", "TNL PCS Oi", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("31", "Oi", "TNL PCS Oi", OperStatus.Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("32", "Algar Telecom", "Algar Telecom S.A.", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("33", "Algar Telecom", "Algar Telecom S.A.", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("34", "Algar Telecom", "Algar Telecom S.A.", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("35", "", "Telcom Telecomunicações", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("36", "", "Options Telecomunicações", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("37", "aeiou", "Unicel", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("38", "Claro", "Claro", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("39", "Nextel", "NII Holdings, Inc.", OperStatus.Operational,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE1800,
                                                                                               BandType.LTE2100));

            mncList.Add(new MNCInfo("54", "Conecta", "PORTO SEGURO TELECOMUNICAÇÔES", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("99", "Local", "", OperStatus.Operational,
                                                                                               BandType.Unknown));

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
            mncList.Add(new MNCInfo("01", "entel", "Entel Telefonía Móvil S.A.", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("02", "movistar", "Telefónica Móvil de Chile", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("03", "CLARO CL", "Claro Chile S.A.", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("04", "WOM", "Novator Partners", OperStatus.Operational,
                                                                                               BandType.iDEN));

            mncList.Add(new MNCInfo("05", "", "Multikom S.A.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("06", "Telsur", "Blue Two Chile S.A.", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("07", "movistar", "Telefónica Móvil de Chile", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("08", "VTR Móvil", "VTR S.A.", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("09", "WOM", "Novator Partners", OperStatus.Operational,
                                                                                               BandType.UMTS1700,
                                                                                               BandType.LTE1700));

            mncList.Add(new MNCInfo("10", "entel", "Entel Telefonía Móvil S.A.", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS1900));

            mncList.Add(new MNCInfo("11", "", "Celupago S.A.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("12", "Colo-Colo Móvil Wanderers Móvil", "Telestar Móvil S.A.", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("13", "Virgin Mobile", "Tribe Mobile Chile SPA", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("14", "", "Netline Telefónica Móvil Ltda", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("15", "", "Cibeles Telecom S.A.", OperStatus.Unknown,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("16", "", "Nomade Telecomunicaciones S.A.", OperStatus.Unknown,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("17", "", "COMPATEL Chile Limitada", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("18", "", "Empresas Bunker S.A.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("19", "móvil Falabella", "Sociedad Falabella Móvil SPA", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("20", "", "Inversiones Santa Fe Limitada", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("22", "", "Cellplus SpA", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("23", "", "Claro Servicios Empresariales S. A.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("26", "", "WILL S.A.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("27", "", "Cibeles Telecom S.A.", OperStatus.Unknown,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("99", "Will", "WILL Telefonía", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS1900));

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
            mncList.Add(new MNCInfo("001", "movistar", "Colombia Telecomunicaciones S.A. ESP", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("002", "Edatel", "Edatel S.A. ESP", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("003", "", "LLEIDA S.A.S.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("004", "", "COMPATEL COLOMBIA SAS", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("020", "Tigo", "Une EPM Telecomunicaciones S.A. E.S.P.", OperStatus.Operational,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("099", "EMCALI", "Empresas Municipales de Cali", OperStatus.Operational,
                                                                                               BandType.GSM900));

            mncList.Add(new MNCInfo("101", "Claro", "Comunicacion Celular S.A. (Comcel)", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE1700,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("102", "", "Bellsouth Colombia", OperStatus.Not_Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.CDMA850));

            mncList.Add(new MNCInfo("103", "Tigo", "Colombia Móvil S.A. ESP", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1700,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("111", "Tigo", "Colombia Móvil S.A. ESP", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1700,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("123", "movistar", "Colombia Telecomunicaciones S.A. ESP", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE850,
                                                                                               BandType.LTE1700,
                                                                                               BandType.LTE1900));

            mncList.Add(new MNCInfo("130", "AVANTEL", "Avantel S.A.S", OperStatus.Operational,
                                                                                               BandType.iDEN,
                                                                                               BandType.UMTS1700,
                                                                                               BandType.LTE1700));

            mncList.Add(new MNCInfo("142", "", "Une EPM Telecomunicaciones S.A. E.S.P.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("154", "Virgin Mobile", "Virgin Mobile Colombia S.A.S.", OperStatus.Operational,
                                                                                               BandType.MVNO));

            mncList.Add(new MNCInfo("165", "", "Colombia Móvil S.A. ESP", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("176", "", "DirecTV Colombia Ltda", OperStatus.Operational,
                                                                                               BandType.LTE2600,
                                                                                               BandType.TD5G2600));

            mncList.Add(new MNCInfo("187", "eTb", "Empresa de Telecomunicaciones de Bogotá S.A. ESP", OperStatus.Operational,
                                                                                               BandType.LTE1700));

            mncList.Add(new MNCInfo("199", "", "SUMA Movil SAS", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("208", "", "UFF Movil SAS", OperStatus.Not_Operational,
                                                                                               BandType.LTE1700));

            mncList.Add(new MNCInfo("210", "", "Hablame Colombia SAS ESP", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("220", "", "Libre Tecnologias SAS", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("230", "", "Setroc Mobile Group SAS", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("240", "", "Logistica Flash Colombia SAS", OperStatus.Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("360", "WOM", "Partners Telecom Colombia SAS", OperStatus.Operational,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("666", "Claro", "Comunicacion Celular S.A. (Comcel)", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

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
            mncList.Add(new MNCInfo("00", "Movistar", "Otecel S.A.", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE1900));

            mncList.Add(new MNCInfo("01", "Claro", "CONECEL S.A.", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE1900,
                                                                                               BandType.LTE1700));

            mncList.Add(new MNCInfo("02", "CNT Mobile", "Corporación Nacional de Telecomunicaciones (CNT EP)", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE1700));

            mncList.Add(new MNCInfo("03", "Tuenti", "Otecel S.A.", OperStatus.Operational,
                                                                                               BandType.MVNO));

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
            mncList.Add(new MNCInfo("001", "Sure", "Sure South Atlantic Ltd.", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.LTE1800,
                                                                                               BandType.WiMAX2400,
                                                                                               BandType.WiMAX3500));

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
            mncList.Add(new MNCInfo("01", "Digicel", "U-Mobile (Cellular) Inc.", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS850));

            mncList.Add(new MNCInfo("002", "GT&T Cellink Plus", "Guyana Telephone & Telegraph Co.", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE700));

            mncList.Add(new MNCInfo("003", "", "Quark Communications Inc.", OperStatus.Operational,
                                                                                               BandType.TDLTE));

            mncList.Add(new MNCInfo("05", "", "eGovernment Unit, Ministry of the Presidency", OperStatus.Unknown,
                                                                                               BandType.Unknown));

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
            mncList.Add(new MNCInfo("01", "VOX", "Hola Paraguay S.A.", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS900,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE1700));

            mncList.Add(new MNCInfo("02", "Claro", "AMX Paraguay S.A.", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE1700));

            mncList.Add(new MNCInfo("03", "", "Compañia Privada de Comunicaciones S.A.", OperStatus.Unknown,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("04", "Tigo", "Telefónica Celular Del Paraguay S.A. (Telecel)", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE1700));

            mncList.Add(new MNCInfo("05", "Personal", "Núcleo S.A. (TIM)", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE1900));

            mncList.Add(new MNCInfo("06", "Copaco", "Copaco S.A.", OperStatus.Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.LTE1700));

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
            mncList.Add(new MNCInfo("06", "Movistar", "Telefónica del Perú S.A.A.", OperStatus.Operational,
                                                                                               BandType.CDMA2000850,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1700));

            mncList.Add(new MNCInfo("07", "Entel", "Entel Perú S.A.", OperStatus.Operational,
                                                                                               BandType.iDEN));

            mncList.Add(new MNCInfo("10", "Claro", "América Móvil Perú", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1900,
                                                                                               BandType.TDLTE3500,
                                                                                               BandType.FiveG3500,
                                                                                               BandType.FiveG39000));

            mncList.Add(new MNCInfo("15", "Bitel", "Viettel Peru S.A.C.", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE900));

            mncList.Add(new MNCInfo("17", "Entel", "Entel Perú S.A.", OperStatus.Operational,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE1700,
                                                                                               BandType.TDLTE2300,
                                                                                               BandType.FiveG3500));

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
            mncList.Add(new MNCInfo("02", "Telesur", "Telecommunications Company Suriname (Telesur)", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1800,
                                                                                               BandType.FiveG3700));

            mncList.Add(new MNCInfo("03", "Digicel", "Digicel Group Limited", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS850));

            mncList.Add(new MNCInfo("04", "Digicel", "Digicel Group Limited", OperStatus.Not_Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.UMTS));

            mncList.Add(new MNCInfo("05", "Telesur", "Telecommunications Company Suriname (Telesur)", OperStatus.Unknown,
                                                                                               BandType.CDMA450));

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
            mncList.Add(new MNCInfo("00", "Antel", "Administración Nacional de Telecomunicaciones", OperStatus.Not_Operational,
                                                                                               BandType.TDMA));

            mncList.Add(new MNCInfo("01", "Antel", "Administración Nacional de Telecomunicaciones", OperStatus.Operational,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS850,
                                                                                               BandType.UMTS2100,
                                                                                               BandType.LTE700,
                                                                                               BandType.LTE1700,
                                                                                               BandType.FiveG28000));

            mncList.Add(new MNCInfo("03", "Antel", "Administración Nacional de Telecomunicaciones", OperStatus.Not_Operational,
                                                                                               BandType.Unknown));

            mncList.Add(new MNCInfo("07", "Movistar", "Telefónica Móviles Uruguay", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS850,
                                                                                               BandType.LTE1900));

            mncList.Add(new MNCInfo("10", "Claro", "AM Wireless Uruguay S.A.", OperStatus.Operational,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE1700));

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
            mncList.Add(new MNCInfo("01", "Digitel", "Corporacion Digitel C.A.", OperStatus.Not_Operational,
                                                                                               BandType.GSM900));

            mncList.Add(new MNCInfo("02", "Digitel GSM", "Corporacion Digitel C.A.", OperStatus.Operational,
                                                                                               BandType.GSM900,
                                                                                               BandType.GSM1800,
                                                                                               BandType.UMTS900,
                                                                                               BandType.LTE1800));

            mncList.Add(new MNCInfo("03", "DirecTV", "Galaxy Entertainment de Venezuela C.A.", OperStatus.Unknown,
                                                                                               BandType.LTE2600));

            mncList.Add(new MNCInfo("04", "movistar", "Telefónica Móviles Venezuela", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.GSM1900,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE1700));

            mncList.Add(new MNCInfo("06", "Movilnet", "Telecomunicaciones Movilnet", OperStatus.Operational,
                                                                                               BandType.GSM850,
                                                                                               BandType.UMTS1900,
                                                                                               BandType.LTE1700));

            _countries.Add(new CountryInfo(Resources.VE, "VE", "VEN", "862", ContinentCode.SA, new MobileInfo(734, mncList)));
        }
    }
}
