using System;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Data.Models;
using Service;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;
using TinyShop.Models;
using Microsoft.AspNetCore.Hosting;
using System.Linq;
using System.Xml.Schema;

namespace TinyShop.Controllers
{
    public class ProductController : Controller
    {
      
        private ProductService _productService;
        private readonly IHostingEnvironment _hostingEnvironment;
        
        public ProductController(DataContext context, IHostingEnvironment hostingEnvironment)
        {
            _productService = new ProductService(context);
            _hostingEnvironment = hostingEnvironment;
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
                ProductType = product.ProductType,
                ImgUrl = product.ImgUrl,
                Shuliang=Convert.ToInt32(product.Shuliang),
                Jianjie=product.Jianjie

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
        
        public IActionResult Index()
        {
            return View();
        }

       
        public IActionResult GetAll(string order)
        {
            try
            {
                var result = _productService.GetAll(order);
                return Json(new
                {
                    code = "success",
                    data = result
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
        //得到用户订单列表
        public IActionResult GetAllLine()
        {
            try
            {
                var result = _productService.GetAllLine();
                return Json(new
                {
                    code = "success",
                    data = result
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
        //得到当前用户的所有订单
        public IActionResult GetUserCart(string order)
        {
            String user = HttpContext.Session.GetString("User");
            try
            {   
                var result = _productService.GetUserCart(order,user);
                //Double a = result.Sum(t => t.Price * t.Shuliang);
                return Json(new
                {
                    code = "success",
                    data = result
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
        public IActionResult GetUserSh(string order)
        {
            String user = HttpContext.Session.GetString("User");
            try
            {
                var result = _productService.GetAllaaCart( user);
                //Double a = result.Sum(t => t.Price * t.Shuliang);
                return Json(new
                {
                    code = "success",
                    data = result
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
        public IActionResult GetAllCart(string order)
        {
            try
            {
                var result = _productService.GetAllCart(order);
               
                return Json(new
                {
                    code = "success",
                    data = result
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
        public IActionResult JieSuan()
        {
            String user = HttpContext.Session.GetString("User");
            var users = _productService.Search(user);
            var result = _productService.GetAllaCart(user);
            
            Double a = result.Sum(t => t.Price * t.Shuliang);
            var line = new LineDO
            {
                Total = a,
                Adress = users.City,
                UserName = user,
                Zhuangtai = "未配送",

            };
            foreach (CartDO cart in result)
            {
                cart.Time = "2";
                _productService.UpdateShu(cart);
            }
            try
            {
               
                _productService.InsertLine(line);
                return Json(new
                {
                    code = "success",
                    data = a
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
        public IActionResult Delete(long id)
        {
            try
            {
                _productService.Delete(id);
                return Json(new
                {
                    code = "success",
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
        public IActionResult DeleteCart(long id)
        {
            try
            {
                var cart = _productService.GetByIdCart(id);
                var product = _productService.GetByNumber(cart.ProductNumber);
                product.Shuliang = product.Shuliang + cart.Shuliang;
                _productService.Update(product);
                _productService.DeleteCart(id);
                return Json(new
                {
                    code = "success",
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
        public IActionResult GetProductById(long id)
        {
            
            try
            {
                var product = _productService.GetById(id);
                return Json(new
                {
                    code = "success",
                    data = product
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

        public IActionResult Edit(long id)
        {
            ViewBag.Id = id;
            return View();
        }
        public IActionResult Table()
        {
            return View();
        }
        public IActionResult Update([FromBody] ProductVO product)
        {
            try
            {
                var productDO = new ProductDO
                {
                    Id = product.Id,
                    ProductNumber = product.ProductNumber,
                    ProductName = product.ProductName,
                    ProductType = product.ProductType,
                    Price = Convert.ToDouble(product.Price),
                    ImgUrl=product.ImgUrl,
                    Shuliang = Convert.ToInt32(product.Shuliang),
                    Jianjie = product.Jianjie
                };
                _productService.Update(productDO);
                return Json(new
                {
                    code = "success",
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
        //      修改购物车商品数量
        public IActionResult UpdateCart(long id)
        {
            try
            {
                var product = _productService.GetByIdCart(id);
                var reslut = _productService.GetByNumber(product.ProductNumber);
                product.Shuliang++;
                reslut.Shuliang--;
                product.Total = (product.Price * product.Shuliang).ToString();
                _productService.UpdateShu(product);
                _productService.Update(reslut);
                return Json(new
                {
                    code = "success",
                    data=product
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
        public IActionResult One(long id)
        {
            try
            {
                var product = _productService.GetByIdLine(id);
                product.Zhuangtai = "已送达";
                _productService.UpdateLine(product);
                return Json(new
                {
                    code = "success",
                    data = product
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
        public IActionResult Two(long id)
        {
            try
            {
                var product = _productService.GetByIdLine(id);
                product.Zhuangtai = "已完成";
                _productService.UpdateLine(product);
                return Json(new
                {
                    code = "success",
                    data = product
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
        public IActionResult DownCart(long id)
        {
            var product = _productService.GetByIdCart(id);
            var reslut = _productService.GetByNumber(product.ProductNumber);
            if (product.Shuliang > 1)
            {
                product.Shuliang--;
                product.Total = (product.Price * product.Shuliang).ToString();
               
                reslut.Shuliang++;
            }
            else
            {
                return Json(new
                {
                    code = "fail",
                   
                });
            }
            try
            {

                _productService.Update(reslut);
                _productService.UpdateShu(product);
                return Json(new
                {
                    code = "success",
                    data = product
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
        public IActionResult GetProductsByKeyword(string keyword)
        {
            try
            {
                var result = _productService.GetByKeyword(keyword);

                return Json(new
                {
                    code = "success",
                    data = result
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

        public IActionResult GetAllProductsByCategory(string category)
        {
            try
            {
                var result = _productService.GetByCategory(category);

                return Json(new
                {
                    code = "success",
                    data = result
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
        public IActionResult UploadImage(IFormFile file)
        {

            var uploadDir = "upload";

            var fileExtension = Path.GetExtension(file.FileName);

            var targetFileName = $"{Guid.NewGuid()}{fileExtension}";

            var targetDir = Path.Combine(_hostingEnvironment.WebRootPath, uploadDir);
            var targetFilePath = Path.Combine(targetDir, targetFileName);

            try
            {
                if (!Directory.Exists(targetDir))
                {
                    Directory.CreateDirectory(targetDir);
                }

                using (var fs = new FileStream(targetFilePath, FileMode.Create))
                {
                    file.CopyTo(fs);
                }

                return Json(new
                {
                    code = "success",
                    data = targetFileName
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
        
        public IActionResult Cart(long id)
        {
            String user = HttpContext.Session.GetString("User");
            var users = _productService.Search(user);
            var product = _productService.GetById(id);
            var car = _productService.GetByCartNumber(product.ProductNumber);
            product.Shuliang--;
            if (car != null&&car.UserName==user&&car.Time=="1")
            {
                car.Shuliang++;
                _productService.UpdateShu(car);
            }
            else
            {
                var cart = new CartDO
                {
                    ProductNumber = product.ProductNumber,
                    ProductName = product.ProductName,
                    Price = Convert.ToDouble(product.Price),
                    ProductType = product.ProductType,
                    Shuliang = 1,
                    UserName = user,
                    ImgUrl = users.City,
                    Total = Convert.ToString(product.Price),
                    Time="1"

                };
                _productService.Insertcart(cart);
            }

            try
            {
                _productService.Update(product);
                

                return Json(new
                {
                    code = "success",
                    date=product
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
