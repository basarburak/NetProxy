using Microsoft.AspNetCore.Mvc;
using NetProxy.Api.Contract.ViewModels;
using System.Collections.Generic;

namespace NetProxy.Hosting.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<ProductViewModel>> Get()
        {
            var productVm = new List<ProductViewModel>();
            for (int i = 1; i < 11; i++) productVm.Add(new ProductViewModel() { Id = i, Name = $"Product {i}" });
            return productVm;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
