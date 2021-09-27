using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WalletWebAPI.Models
{
    public class CurrencyRates
    {
        public int Id { get; set; }

        [ForeignKey("Currency")]
        public int CurrencyId { get; set; }
        public float Rate { get; set; }
    }
}
