using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encrypt
{
    public static class ExtensionForEncryption
    {
        public static IEnumerable<byte> EncryptWithSeed(this IEnumerable<byte> data, 
                                                                                IEnumerable<byte> seedKey, 
                                                                                bool cbcPad = true)
            => SEED.Encrypt(data.ToArray(), seedKey.ToArray(), cbcPad);

        public static IEnumerable<byte> DecryptWithSeed(this IEnumerable<byte> data, 
                                                                                IEnumerable<byte> seedKey,
                                                                                bool cbcPad = true)
            => SEED.Decrypt(data.ToArray(), seedKey.ToArray(), cbcPad);
    }
}
