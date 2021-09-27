using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WalletWebAPI.Models
{
    public class SQLWalletRepository : IWalletRepository
    {
        private readonly AppDbContext context;
        public SQLWalletRepository(AppDbContext context)
        {
            this.context = context;
        }
        public IQueryable<Wallet_Currency> Get(int Id)
        {
            return context.Wallet_Currency.Where(x => x.WalletId == Id);

        }
        public void CreditInWallet(Wallet_Currency wallet_Currency)
        {
            var res = context.Wallet.Find(wallet_Currency.WalletId);
            if (res != null)
            {
                if (!res.IsFreezed)
                {
                    var queryResult = context.Wallet_Currency.Where(x => x.CurrencyId == wallet_Currency.CurrencyId && x.WalletId == wallet_Currency.WalletId).FirstOrDefault();
                    if (queryResult != null)
                    {
                        queryResult.Amount = queryResult.Amount + wallet_Currency.Amount;
                        var wallet = context.Wallet_Currency.Attach(queryResult);
                        wallet.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        context.SaveChanges();
                    }
                    else
                    {
                        context.Wallet_Currency.Add(wallet_Currency);
                        context.SaveChanges();
                    }
                }

            }

        }
        public void DebitFromWallet(Wallet_Currency wallet_Currency)
        {
            var res = context.Wallet.Find(wallet_Currency.WalletId);
            if (res != null)
            {
                if (!res.IsFreezed)
                {
                    var queryResult = context.Wallet_Currency.Where(x => x.CurrencyId == wallet_Currency.CurrencyId && x.WalletId == wallet_Currency.WalletId).FirstOrDefault();
                    if (queryResult != null)
                    {
                        queryResult.Amount = queryResult.Amount + wallet_Currency.Amount;
                        var wallet = context.Wallet_Currency.Attach(queryResult);
                        wallet.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        context.SaveChanges();
                    }
                }

            }

        }
        public void FreezeWallet(int id,bool isFreeze)
        {
            var res = context.Wallet.Find(id);
            if (res != null)
            {
                res.IsFreezed = isFreeze;
                var wallet = context.Wallet.Attach(res);
                wallet.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();

            }
        }
        
    }
}
