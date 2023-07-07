using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositorySearch.BL;
using RepositorySearch.Models;

namespace RepositorySearch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public SearchController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

       
        [HttpGet("search")]
        public async Task<IActionResult> SearchRepositories(string searchKeyword)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var apiUrl = $"https://api.github.com/search/repositories?q={searchKeyword}";

            var response = await httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();
                return Ok(responseData);
            }

            return BadRequest();
        }
    }
}
