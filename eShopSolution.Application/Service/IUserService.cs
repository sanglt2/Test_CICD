using eShopSolution.ViewModel;
using System.Threading.Tasks;

namespace eShopSolution.Application
{
    public interface IUserService
    {
        Task<ApiResult<string>> Authenticate(LoginRequestCommand request);
        Task<bool> Register(RegisterRequestCommand request);
    }
}
