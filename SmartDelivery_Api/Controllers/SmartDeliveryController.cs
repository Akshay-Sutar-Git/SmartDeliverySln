using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartDelivery_Infra.Models;
using SmartDelivery_Infra.Repositories;
using SmartDelivery_Infra.Repositories.ReposInterFace;

namespace SmartDelivery_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SmartDeliveryController : ControllerBase
    {
        private readonly ISmartDeliveryRepos repos;

        public SmartDeliveryController(ISmartDeliveryRepos _repos)
        {
            repos = _repos;
        }

        [HttpGet("GetAllCategories")]
        public async Task<ActionResult<IEnumerable<Category>>> GetAllCategories()
        {
            var categories = await repos.GetCategoriesAsync();
            return Ok(categories);
        }
    }
}
