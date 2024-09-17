using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.ProductDtos;

namespace SignalRWebUI.Controllers
{
    public class MenuController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactoy;

        public MenuController(IHttpClientFactory httpClientFactoy)
        {
            _httpClientFactoy = httpClientFactoy;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactoy.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7134/api/Product");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
            return View(values);
        }
    }
}
