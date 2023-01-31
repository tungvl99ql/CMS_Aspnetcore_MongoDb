using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkynetScan.Constant
{
    public static class HashFunction
    {
        public static string hashfunction(string hash)
        {
            if(hash == "0x39509351")
            {
                return "IncreaseAllowance";
            }
            if (hash == "0xdd62ed3e")
            {
                return "Allowance";
            }
            if (hash == "0x095ea7b3")
            {
                return "Approve";
            }
            if (hash == "0x70a08231")
            {
                return "balanceOf";
            }
            if (hash == "0x313ce567")
            {
                return "decimals";
            }
            if (hash == "0xa457c2d7")
            {
                return "DecreaseAllowance";
            }
            if (hash == "0xa9059cbb")
            {
                return "Transfer ERC20";
            }
            if (hash == "0x23b872dd")
            {
                return "transferFrom";
            }
            if (hash == "0x60806040")
            {
                return "Create Contract";
            }
            
            return hash;
        } 
    }
}
