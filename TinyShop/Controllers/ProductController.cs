using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TinyShop.Controllers
{
    public class ProductController : Controller
    {
        private ProductService _productService;

        public ProductController(DataContext context)
        {
            _productService = new ProductService(context);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([FromBody] ProductVO product)
        {
            var productDO = new ProductDO
            {
                ProductNumber = product.ProductNumber,
                ProductName = product.ProductName,
                Price = Convert.ToDouble(product.Price),
                Price = product.Price
            };

            try
            {
                var insertedProduct = _productService.Insert(productDO);

                return Json(new
                {
                    code = "success",
                    data = insertedProduct
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    code = "fail",
                    message = ex.Message
                });
            }
        }
    }
}
