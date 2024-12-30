using App.Domain.Core.Data;

namespace App.Infra.ExternalServices.ExchaneRatesAPI
{
    public class CurrencyInfoRepository : ICurrencyInfoRepository
    {
        private readonly ExchangeRateApiConfig _config;
        private readonly HttpClient _httpClient;

        public CurrencyInfoRepository(ExchangeRateApiConfig config, HttpClient httpClient)
        {
            _config = config;
            _httpClient = httpClient;
        }

        public async Task<string> GetCurrencyPriceWithBaseAUD(string currency)
        {
            string apiUrl = _config.LatestRatesEndPointWithBaseAUD + currency.ToUpper();
            try
            {
                var response = await _httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                return $"Failure: {ex.Message}";
            }
        }

        public async Task<string> GetCurrencyPriceWithBaseBRL(string currency)
        {
            string apiUrl = _config.LatestRatesEndPointWithBaseBRL + currency.ToUpper();

            try
            {
                var response = await _httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                return $"Failure: {ex.Message}";
            }
        }

        public async Task<string> GetCurrencyPriceWithBaseEUR(string currency)
        {
            string apiUrl = _config.LatestRatesEndPointWithBaseEUR + currency.ToUpper();

            try
            {
                var response = await _httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                return $"Failure: {ex.Message}";
            }
        }

        public async Task<string> GetCurrencyPriceWithBaseGBP(string currency)
        {
            string apiUrl = _config.LatestRatesEndPointWithBaseGBP + currency.ToUpper();

            try
            {
                var response = await _httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                return $"Failure: {ex.Message}";
            }
        }

        public async Task<string> GetCurrencyPriceWithBaseUSD(string currency)
        {
            string apiUrl = _config.LatestRatesEndPointWithBaseUSD + currency.ToUpper();

            try
            {
                var response = await _httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                return $"Failure: {ex.Message}";
            }
        }
    }
}
