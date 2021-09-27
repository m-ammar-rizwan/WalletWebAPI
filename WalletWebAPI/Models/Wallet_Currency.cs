using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WalletWebAPI.Models
{
    public class Wallet_Currency
    {
        public int Id { get; set; }

        [ForeignKey("Currency")]
        public int CurrencyId { get; set; }

        [ForeignKey("Wallet")]
        public int WalletId { get; set; }
        public float Amount { get; set; }
    }
}
