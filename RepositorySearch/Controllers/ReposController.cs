using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositorySearch.Models;
using System.Collections.Generic;

namespace RepositorySearch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReposController : ControllerBase
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;

        public ReposController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet]
        [Authorize]
        public ActionResult<IEnumerable<RepositoryModel>> Search(string searchItem)
        {
            // Implement the logic to search for repositories using the provided search term
            // You can use the q parameter to pass the search term from the client
            // Return the search results as IEnumerable<Repository>
            return Ok();
        }

        [HttpPost("bookmark")]
        [Authorize]
        public ActionResult Bookmark(RepositoryModel repository)
        {
            // Implement the logic to store the bookmarked repository in the user's session
            // You can access the current user's information from the HttpContext.User property
            // Use the _session variable to access the session and store the bookmarked repository
            return Ok();
        }

        [HttpGet("bookmarks")]
        [Authorize]
        public ActionResult<IEnumerable<RepositoryModel>> GetBookmarks()
        {
            // Implement the logic to retrieve the user's bookmarked repositories from the session
            // Return the bookmarked repositories as IEnumerable<Repository>
            return Ok();
        }
    }
}
