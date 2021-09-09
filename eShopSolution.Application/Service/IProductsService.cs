using eShopSolution.ViewModel;
using System.Threading.Tasks;

namespace eShopSolution.Application
{
    public interface IProductsService
    {
        Task<ProductViewModel> GetProductById(GetProductByIdCommand request);
    }
}
