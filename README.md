# ISO3166-Mobile

1. Using
```c#
using AJ.Code;

// Get all countries that registered
var list = Country.AllCountries;

// Get the country information list for MCC value 234
var countries = Country.GetCountryInfoForMCC(234);

// Get the country information for alpha2 code value "KR"
var country = Country.GetCountryInfoForAlpha2Code("KR");

// Get the country information for alpha3 code value "KOR"
var country = Country.GetCountryInfoForAlpha3Code("KOR");

// Get the country information list for the continent code value NA(North America)
var countries = Country.GetCountryInfoForContinentCode(ContinentCode.NA);

// Get the country information list that has MCC & MNC
var countries = Country.GetCountryInfoForMobileInfo(310, "032"); // Guam

// Get Home Country
foreach(var country in countries)
  var homeCountry = country.HomeCountry;  // if country is Guam then homeCountry is USA
```



# CRC
Please see https://www.lammertbies.nl/comm/info/crc-calculation?crc=8005&method=hex


```c#
using Algorithm.Check;

// Get CRC-16
var data = CRC.ComputeCRC16(Encoding.ASCII.GetBytes("123456789"));

// Get CRC-CCITT (xModem)
var data = CRC.ComputeCCITTxModem(Encoding.ASCII.GetBytes("123456789"));

// Get CRC-DNP
var data = CRC.ComputeDNP(Encoding.ASCII.GetBytes("123456789"));

// Get CRC-32
var data = CRC.ComputeCRC32(Encoding.ASCII.GetBytes("123456789"));
```




# Seed
Please see https://seed.kisa.or.kr/kisa/algorithm/EgovSeedInfo.do

The above site includes an English manual.

The IV value is {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}.


1. Encryption example
```c#
// You can set this value to whatever you want. (It must be a 16 byte array)
byte[] SeedKey = new byte[16] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5 };
byte[] dataToEncrypt = Encoding.UTF8.GetBytes("test");

var dataEncrypted = SEED.Encrypt(dataToEncrypt, SeedKey);
```

2. Decryption example
```c#
// The SeedKey must same as the SeedKey used when encryption.
byte[] SeedKey = new byte[16] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5 };
var dataDecrypted = SEED.Decrypt(dataEncrypted, SeedKey);
```
