using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CoinAPI.REST.V1;


namespace DogecoinNewsDaily.Pages
{
    public class MarketsModel : PageModel
    {
        private readonly ILogger<MarketsModel> _logger;

        public MarketsModel(ILogger<MarketsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet() // On load ? 
        {
            RequestCoinAPI();
        }  
        public void RequestCoinAPI() 
        {
            var client = new CoinApiRestClient();
            client.
        }
    }
}
