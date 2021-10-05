using System.Collections.Generic;
using System.Linq;

namespace AJ.Code
{
    public partial class Country
    {
        /*******************************************************************/
        /// <summary>
        /// Get all country information that registered. <br/>
        /// 등록된 모든 국가정보를 가져옵니다.
        /// </summary>
        /*******************************************************************/
        public static IEnumerable<CountryInfo> AllCountries => _countries;


        /*******************************************************************/
        /// <summary>
        /// Get the country information list for MCC. <br/>
        /// MCC에 대한 국가정보목록을 가져옵니다.
        /// </summary>
        /// <param name="mcc"></param>
        /// <returns></returns>
        /*******************************************************************/
        public static IEnumerable<CountryInfo> GetCountryInfoForMCC(int mcc)
        {
            List<CountryInfo> result = new List<CountryInfo>();
            var countries = AllCountries.Where(country => country.MobileCodes.Any(x => x.MCC == mcc));

            foreach (var country in countries) result.Add(country.MobileFilteredCountry(mcc));

            return result;
        }


        /*******************************************************************/
        /// <summary>
        /// Get the country information list that has MCC and MNC. <br/>
        /// MCC와 MNC 정보를 가지는 국가정보목록을 가져옵니다.
        /// </summary>
        /// <param name="mcc"></param>
        /// <param name="mnc"></param>
        /// <returns></returns>
        /*******************************************************************/
        public static IEnumerable<CountryInfo> GetCountryInfoForMobileInfo(int mcc, int mnc)
        {
            List<CountryInfo> result = new List<CountryInfo>();
            var countries = AllCountries.Where(country => country.MobileCodes.Any(x => x.MCC == mcc && x.HasMNC(mnc)));

            foreach (var country in countries)
            {
                var newCountry = country.CloneExceptMobileInfo();

                foreach (var mobileInfo in country.MobileCodes.Where(x => x.MCC == mcc))
                {
                    var filteredInfo = mobileInfo.Filter(mnc);
                    if (filteredInfo != null) newCountry._mobileCodes.Add(filteredInfo);
                }

                result.Add(newCountry);
            }

            return result;
        }


        /*******************************************************************/
        /// <summary>
        /// Get the country information for alpha2 code. <br/>
        /// 알파2 코드에 대한 국가정보를 가져옵니다.
        /// </summary>
        /// <param name="alpha2Code"></param>
        /// <returns></returns>
        /*******************************************************************/
        public static CountryInfo GetCountryInfoForAlpha2Code(string alpha2Code)
            => AllCountries.Where(country => country.Alpha2Code == alpha2Code).FirstOrDefault();


        /*******************************************************************/
        /// <summary>
        /// Get the country information for alpha3 code. <br/>
        /// 알파3 코드에 대한 국가정보를 가져옵니다.
        /// </summary>
        /// <param name="alpha3Code"></param>
        /// <returns></returns>
        /*******************************************************************/
        public static CountryInfo GetCountryInfoForAlpha3Code(string alpha3Code)
            => AllCountries.Where(country => country.Alpha3Code == alpha3Code).FirstOrDefault();


        /*******************************************************************/
        /// <summary>
        /// Get the country information list for the continent code. <br/>
        /// 대륙코드에 대한 국가정보목록을 가져옵니다.
        /// </summary>
        /// <param name="continentCode"></param>
        /// <returns></returns>
        /*******************************************************************/
        public static IEnumerable<CountryInfo> GetCountryInfoForContinentCode(ContinentCode continentCode)
            => AllCountries.Where(country => country.ContinentCode == continentCode);



        static Country()
        {
            AddInfoForAF();
            AddInfoForAL();
            AddInfoForDZ();
            AddInfoForAS();
            AddInfoForAD();
            AddInfoForAO();
            AddInfoForAI();
            AddInfoForAQ();
            AddInfoForAG();
            AddInfoForAR();
            AddInfoForAM();
            AddInfoForAW();
            AddInfoForAU();
            AddInfoForAT();
            AddInfoForAZ();
            AddInfoForBS();
            AddInfoForBH();
            AddInfoForBD();
            AddInfoForBB();
            AddInfoForBY();
            AddInfoForBE();
            AddInfoForBZ();
            AddInfoForBJ();
            AddInfoForBM();
            AddInfoForBT();
            AddInfoForBO();
            AddInfoForBQ();
            AddInfoForBA();
            AddInfoForBW();
            AddInfoForBV();
            AddInfoForBR();
            AddInfoForIO();
            AddInfoForBN();
            AddInfoForBG();
            AddInfoForBF();
            AddInfoForBI();
            AddInfoForCV();
            AddInfoForKH();
            AddInfoForCM();
            AddInfoForCA();
            AddInfoForKY();
            AddInfoForCF();
            AddInfoForTD();
            AddInfoForCL();
            AddInfoForCN();
            AddInfoForCX();
            AddInfoForCC();
            AddInfoForCO();
            AddInfoForKM();
            AddInfoForCG();
            AddInfoForCD();
            AddInfoForCK();
            AddInfoForCR();
            AddInfoForCI();
            AddInfoForHR();
            AddInfoForCU();
            AddInfoForCW();
            AddInfoForCY();
            AddInfoForCZ();
            AddInfoForDK();
            AddInfoForDJ();
            AddInfoForDM();
            AddInfoForDO();
            AddInfoForEC();
            AddInfoForEG();
            AddInfoForSV();
            AddInfoForGQ();
            AddInfoForER();
            AddInfoForEE();
            AddInfoForSZ();
            AddInfoForET();
            AddInfoForFK();
            AddInfoForFO();
            AddInfoForFJ();
            AddInfoForFI();
            AddInfoForFR();
            AddInfoForGF();
            AddInfoForPF();
            AddInfoForTF();
            AddInfoForGA();
            AddInfoForGM();
            AddInfoForGE();
            AddInfoForDE();
            AddInfoForGH();
            AddInfoForGI();
            AddInfoForGR();
            AddInfoForGL();
            AddInfoForGD();
            AddInfoForGP();
            AddInfoForGU();
            AddInfoForGT();
            AddInfoForGG();
            AddInfoForGN();
            AddInfoForGW();
            AddInfoForGY();
            AddInfoForHT();
            AddInfoForHM();
            AddInfoForVA();
            AddInfoForHN();
            AddInfoForHK();
            AddInfoForHU();
            AddInfoForIS();
            AddInfoForIN();
            AddInfoForID();
            AddInfoForIR();
            AddInfoForIQ();
            AddInfoForIE();
            AddInfoForIM();
            AddInfoForIL();
            AddInfoForIT();
            AddInfoForJM();
            AddInfoForJP();
            AddInfoForJE();
            AddInfoForJO();
            AddInfoForKZ();
            AddInfoForKE();
            AddInfoForKI();
            AddInfoForKP();
            AddInfoForKR();
            AddInfoForXK();
            AddInfoForKW();
            AddInfoForKG();
            AddInfoForLA();
            AddInfoForLV();
            AddInfoForLB();
            AddInfoForLS();
            AddInfoForLR();
            AddInfoForLY();
            AddInfoForLI();
            AddInfoForLT();
            AddInfoForLU();
            AddInfoForMO();
            AddInfoForMG();
            AddInfoForMW();
            AddInfoForMY();
            AddInfoForMV();
            AddInfoForML();
            AddInfoForMT();
            AddInfoForMH();
            AddInfoForMQ();
            AddInfoForMR();
            AddInfoForMU();
            AddInfoForYT();
            AddInfoForMX();
            AddInfoForFM();
            AddInfoForMD();
            AddInfoForMC();
            AddInfoForMN();
            AddInfoForME();
            AddInfoForMS();
            AddInfoForMA();
            AddInfoForMZ();
            AddInfoForMM();
            AddInfoForNA();
            AddInfoForNR();
            AddInfoForNP();
            AddInfoForNL();
            AddInfoForNC();
            AddInfoForNZ();
            AddInfoForNI();
            AddInfoForNE();
            AddInfoForNG();
            AddInfoForNU();
            AddInfoForNF();
            AddInfoForMP();
            AddInfoForMK();
            AddInfoForNO();
            AddInfoForOM();
            AddInfoForPK();
            AddInfoForPW();
            AddInfoForPS();
            AddInfoForPA();
            AddInfoForPG();
            AddInfoForPY();
            AddInfoForPE();
            AddInfoForPH();
            AddInfoForPN();
            AddInfoForPL();
            AddInfoForPT();
            AddInfoForPR();
            AddInfoForQA();
            AddInfoForRE();
            AddInfoForRO();
            AddInfoForRU();
            AddInfoForRW();
            AddInfoForBL();
            AddInfoForSH();
            AddInfoForKN();
            AddInfoForLC();
            AddInfoForMF();
            AddInfoForPM();
            AddInfoForVC();
            AddInfoForWS();
            AddInfoForSM();
            AddInfoForST();
            AddInfoForSA();
            AddInfoForSN();
            AddInfoForRS();
            AddInfoForSC();
            AddInfoForSL();
            AddInfoForSG();
            AddInfoForSX();
            AddInfoForSK();
            AddInfoForSI();
            AddInfoForSB();
            AddInfoForSO();
            AddInfoForZA();
            AddInfoForGS();
            AddInfoForSS();
            AddInfoForES();
            AddInfoForLK();
            AddInfoForSD();
            AddInfoForSR();
            ///  AddInfoForSJ();
            AddInfoForSE();
            AddInfoForCH();
            AddInfoForSY();
            AddInfoForTW();
            AddInfoForTJ();
            AddInfoForTZ();
            AddInfoForTH();
            AddInfoForTL();
            AddInfoForTG();
            AddInfoForTK();
            AddInfoForTO();
            AddInfoForTT();
            AddInfoForTN();
            AddInfoForTR();
            AddInfoForTM();
            AddInfoForTC();
            AddInfoForTV();
            AddInfoForUG();
            AddInfoForUA();
            AddInfoForAE();
            AddInfoForGB();
            AddInfoForUS();
            AddInfoForUM();
            AddInfoForUY();
            AddInfoForUZ();
            AddInfoForVU();
            AddInfoForVE();
            AddInfoForVN();
            AddInfoForVG();
            AddInfoForVI();
            AddInfoForWF();
            AddInfoForEH();
            AddInfoForYE();
            AddInfoForZM();
            AddInfoForZW();
            AddInfoForAX();
        }

        private static List<CountryInfo> _countries = new List<CountryInfo>();
    }
}

