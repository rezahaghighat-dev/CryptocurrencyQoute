using App.Domain.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Data
{
    public interface ICurrencyInfoRepository
    {
        Task<string> GetCurrencyPriceWithBaseUSD(string currency);
        Task<string> GetCurrencyPriceWithBaseEUR(string currency);
        Task<string> GetCurrencyPriceWithBaseBRL(string currency);
        Task<string> GetCurrencyPriceWithBaseGBP(string currency);
        Task<string> GetCurrencyPriceWithBaseAUD(string currency);
    }
}
