using Ecommerce_Web.Models;
using Ecommerce_Web.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce_Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<ActionResult<IEnumerable<ProductViewModel>>> Index()
        {
            var result = await _productService.GetAllProducts();

            if (result == null)
                return View("Error");

            return View(result);
        }
    }
}
