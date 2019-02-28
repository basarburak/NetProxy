using NetProxy.Api.Contract.Extensions;
using NetProxy.Api.Contract.ViewModels;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NetProxy.Api.Contract.Services
{
    public class ProductApi : IProductService
    {
        readonly IHttpClientFactory _httpClientFactory;
        HttpClient _productHttp;
        public ProductApi(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _productHttp = _httpClientFactory.CreateClient(ApiConstant.ApiName);
        }

        public async Task<List<ProductViewModel>> GetAllProduct()
        {
            var result = await _productHttp.GetAsync("product");
            return await result.ResponseMessageToMap<List<ProductViewModel>>();
        }
    }
}
