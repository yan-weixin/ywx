using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Service;
using TinyShop.Models;
using Microsoft.AspNetCore.Http;

namespace TinyShop.Controllers
{
    public class LoginController : Controller
    {
        private UserService _userService;
        
        public LoginController(DataContext context)
        {
            _userService = new UserService(context);
        }
        public IActionResult Index()
        {
            return View();
            
        }
        public IActionResult Zhuce()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create([FromBody] UserVO user)
        {
            var userDO = new UserDO
            {
                UserNumber = user.UserNumber,
                UserPassword = user.UserPassword,
                Email = user.Email,
                Radio = user.Radio,
                City = user.City,
                Date = user.Date
                
            };

            try
            {
                var inserteduser = _userService.Insert(userDO);

                return Json(new
                {
                    code = "success",
                    data = inserteduser
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
        public IActionResult GetAll()
        {
            try
            {
                var result = _userService.GetAll();
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

        public IActionResult YanManage()
        {
            String Manage = HttpContext.Session.GetString("Manage");
            if (Manage == "admin442")
            {
                return Json(new
                {
                    code = "success",
                });
            }
            else
            {

                return Json(new
                {
                    code = "fail",
                   
                });
            }
        }
        public IActionResult YanUser()
        {
            String User = HttpContext.Session.GetString("User");
            if (User!=null)
            {
                return Json(new
                {
                    code = "success",
                });
            }
            else
            {

                return Json(new
                {
                    code = "fail",

                });
            }
        }
        
        public IActionResult UserYanzheng([FromBody] UserVO user)
        {

            if (user.UserNumber == "admin442")
            {
                if (user.UserPassword == "123456")
                {
                    HttpContext.Session.SetString("Manage", "admin442");
                    return Json(new
                    {
                        code = "manage"

                    });
                }
            }

           
            bool a = _userService.GetByKeyword(user.UserNumber,user.UserPassword );

            
            try
            {

                HttpContext.Session.SetString("User", user.UserNumber);

                return Json(new
                    {
                        code = "success"
                        
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
