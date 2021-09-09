using eShopSolution.Application;
using eShopSolution.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ShopSolution.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductsController : ControllerBase
    {
        private IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        [HttpGet]
        [Route("get-product-by-id/{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var command = new GetProductByIdCommand
            {
                Id = id
            };

            var result = await _productsService.GetProductById(command);

            return Ok(result);
        }
    }
}
