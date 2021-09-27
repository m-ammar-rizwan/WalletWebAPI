using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WalletWebAPI.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Wallet> Wallet { get; set; }
        public DbSet<Wallet_Currency> Wallet_Currency { get; set; }
        public DbSet<CurrencyRates> CurrencyRates { get; set; }
        public DbSet<Currency> Currency { get; set; }
       

    }
}
