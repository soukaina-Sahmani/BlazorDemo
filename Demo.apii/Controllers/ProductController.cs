using Demo.BusniessLogic.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.apii.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService = null;

        
        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }
        [HttpGet]
        [Route("GetProduits")]
        public IActionResult getProducts()
        {
            var data = _productService.GetProduits();
            return Ok(data);

        }

    }
}
