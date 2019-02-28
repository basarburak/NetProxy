using NetProxy.Api.Contract.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetProxy.Api.Contract.Services
{
    public interface IProductService
    {
        Task<List<ProductViewModel>> GetAllProduct();
    }
}
