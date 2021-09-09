using eShopSolution.Data;
using eShopSolution.ViewModel;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.Application
{
    public class ProductsService : IProductsService
    {
        private readonly EShopDBContext _context;

        public ProductsService(EShopDBContext context)
        {
            _context = context;
        }

        public async Task<ProductViewModel> GetProductById(GetProductByIdCommand request)
        {
            var product = await _context.Products
                .Select(s => new ProductViewModel
                {
                    Id = s.Id,
                    Price = s.Price,
                    OriginalPrice = s.OriginalPrice,
                    Stock = s.Stock,
                    ViewCount = s.ViewCount,
                    DateCreated = s.DateCreated
                })
                .FirstOrDefaultAsync(f => f.Id == request.Id);

            return product ?? new ProductViewModel();
        }
    }
}
