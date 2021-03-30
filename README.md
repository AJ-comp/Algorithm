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


# CRC
This source includes CRC-16, CRC-CCITT (xModem). 

Please see https://www.lammertbies.nl/comm/info/crc-calculation?crc=8005&method=hex


1. CRC-16 example
```c#
using Algorithm.Check;

var data = CRC.ComputeCRC16(Encoding.ASCII.GetBytes("123456789"));
```

2. CRC-CCITT (xModem) example
```c#
using Algorithm.Check;

var data = CRC.ComputeCCITTxModem(Encoding.ASCII.GetBytes("123456789"));
```

2. CRC-DNP example
```c#
using Algorithm.Check;

var data = CRC.ComputeDNP(Encoding.ASCII.GetBytes("123456789"));
```



# ISO3166-Mobile

1. Using
```c#
using AJ.Code;

// Get all countries that registered
var list = Country.AllCountries;

// Get the country information for MCC value 410
var country = Country.GetCountryInfoForMCC(410);

// Get the country information for alpha2 code value "KR"
country = Country.GetCountryInfoForAlpha2Code("KR");

// Get the country information for alpha3 code value "KOR"
country = Country.GetCountryInfoForAlpha3Code("KOR");

// Get the country information list for the continent code value NA(North America)
country = Country.GetCountryInfoForContinentCode(ContinentCode.NA);
```