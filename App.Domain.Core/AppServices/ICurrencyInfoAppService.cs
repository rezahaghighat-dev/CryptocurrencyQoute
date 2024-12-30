using App.Domain.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.AppServices
{
    public interface ICurrencyInfoAppService
    {
        Task<ServiceResponse<string>> GetCurrencyPrice(string currency);
    }
}
