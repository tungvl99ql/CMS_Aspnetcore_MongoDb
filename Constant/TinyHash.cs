using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkynetScan.Constant
{
    public static class TinyHash
    {
        public static string hashtiny(string hash)
        {
            string StartHash = hash.Substring(0, 6);
            string EndHash = hash.Substring(hash.Length - 6, 6);
            var _hash = StartHash + "...." + EndHash;

            return _hash;
        } 
    }
}
