using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalletWebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WalletWebAPI.Controllers
{
    [Route("api/[action]")]
    [ApiController]
    public class WalletController : ControllerBase
    {
        private readonly IWalletRepository walletRepository;
        public WalletController(IWalletRepository walletRepo)
        {
            walletRepository = walletRepo;
        }

        [HttpGet("{id}")]
        public IQueryable<Wallet_Currency> Get(int id)
        {
            return walletRepository.Get(id);
        }
        [HttpGet("{id}")]
        public void FreezeWallet(int id)
        {
            walletRepository.FreezeWallet(id,true);
        }
        [HttpGet("{id}")]
        public void UnfreezeWallet(int id)
        {
            walletRepository.FreezeWallet(id,false);
        }
        [HttpPost]
        public void CreditInWallet([FromBody] Wallet_Currency value)
        {
            walletRepository.CreditInWallet(value);
        }
        [HttpPost]
        public void DebitFromWallet([FromBody] Wallet_Currency value)
        {
            walletRepository.DebitFromWallet(value);
        }
    }
}
