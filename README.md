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
