using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WalletWebAPI.Models
{
    public class Wallet
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public bool IsFreezed { get; set; }
    }
}
