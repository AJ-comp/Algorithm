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
var countries = Country.GetCountryInfoForMobileInfo(310, 32); // Guam

// Get Home Country
foreach(var country in countries)
  var homeCountry = country.HomeCountry;  // if country is Guam then homeCountry is USA
```



# CRC
Please see https://www.lammertbies.nl/comm/info/crc-calculation?crc=8005&method=hex


```c#
using Algorithm.Check;

var data = Encoding.ASCII.GetBytes("123456789");

// Example for CRC-16
var crc = CRC.ComputeCRC16(data); // this method is deprecated.
var crc = data.CRC16(); // new method. please use this.
var dataWithCRC = data.WithCRC16();

// Example for CRC-CCITT (xModem)
var crc = CRC.ComputeCCITTxModem(data); // this method is deprecated.
var crc = data.CCITTxModem(); // new method. please use this.
var dataWithCRC = data.WithCCITTxModem();

// Example for CRC-DNP
var crc = CRC.ComputeDNP(data); // this method is deprecated.
var crc = data.DNP(); // new method. please use this.
var dataWithCRC = data.WithDNP();

// Example for CRC-32
var crc = CRC.ComputeCRC32(data); // this method is deprecated.
var crc = data.CRC32(); // new method. please use this.
var dataWithCRC = data.WithCRC32();


// Example for Checksum8
var checksum = data.CheckSum8Xor();	// Get checksum8 xor
var dataWithChecksum = data.WithCheckSum8Xor();

var checksum = data.CheckSum8Modulo256(); // Get checksum8 modulo256
var dataWithChecksum = data.WithCheckSum8Modulo256();

var checksum = data.CheckSum8TwosComplement(); // Get checksum8 2's complement
var dataWithChecksum = data.WithCheckSum8TwosComplement();

var checksum = data.NMEACheckSum(); // Get checksum in use in NMEA fomat
var dataWithChecksum = data.WithNMEACheckSum();

```




# Seed
Please see https://seed.kisa.or.kr/kisa/algorithm/EgovSeedInfo.do

The above site includes an English manual.

The IV value is {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}.


1. Encryption example
```c#
// You can set this value to whatever you want. (It must be a 16 byte array)
byte[] SeedKey = new byte[16] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5 };
var dataToEncrypt = Encoding.UTF8.GetBytes("test");

var dataEncrypted = SEED.Encrypt(dataToEncrypt, SeedKey); // this method is deprecated.
var dataEncrypted = dataToEncrypt.EncryptWithSeed(SeedKey); // new method. please use this.
```

2. Decryption example
```c#
// The SeedKey must same as the SeedKey used when encryption.
byte[] SeedKey = new byte[16] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5 };
var dataDecrypted = SEED.Decrypt(dataEncrypted, SeedKey); // this method is deprecated.
var dataDecrypted = dataEncrypted.DecryptWithSeed(SeedKey); // new method. please use this.
```
