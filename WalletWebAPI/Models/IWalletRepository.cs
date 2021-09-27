using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WalletWebAPI.Models
{
    public interface IWalletRepository
    {
        public IQueryable<Wallet_Currency> Get(int Id);
        public void CreditInWallet(Wallet_Currency wallet_Currency);
        public void DebitFromWallet(Wallet_Currency value);
        public void FreezeWallet(int id, bool isFreeze);
    }
}
