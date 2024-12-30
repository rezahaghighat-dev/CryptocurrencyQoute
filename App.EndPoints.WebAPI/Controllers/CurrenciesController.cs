using App.Domain.Core.AppServices;
using App.Domain.Core.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrenciesController : ControllerBase
    {
        private readonly ICurrencyInfoAppService _currencyInfoAppService;

        public CurrenciesController(ICurrencyInfoAppService currencyInfoAppService)
        {
            _currencyInfoAppService = currencyInfoAppService;
        }

        [HttpGet]
        [Route("GetCryptocurrencyQouteByName")]
        public async Task<ActionResult<ServiceResponse<string>>> GetCurrencyQoute(string currency)
        {
            return Ok(await _currencyInfoAppService.GetCurrencyPrice(currency));
        }
    }
}
