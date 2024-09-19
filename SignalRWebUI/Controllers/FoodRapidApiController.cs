﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dto.RapidApiDtos;

namespace SignalRWebUI.Controllers
{
    public class FoodRapidApiController : Controller
    {
        public async Task<IActionResult> Index()
        {
            
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://tasty.p.rapidapi.com/recipes/list?from=0&size=60&tags=under_30_minutes"),
                Headers =
    {
        { "x-rapidapi-key", "51c955dfa9msh53f306b50b0ded1p173382jsn13316903dea8" },
        { "x-rapidapi-host", "tasty.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var root = JsonConvert.DeserializeObject<RootTastyApi>(body);
                var values = root.Results;
                return View(values.ToList());
            }
           
        }
    }
}
