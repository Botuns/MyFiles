using Authentication.ReqAndResModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Authentication.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserServices _userServices;
        public UserController(IUserServices userServices)
        {
            _userServices = userServices;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>Login(UserRequestModels request)
        {
            var user = _userServices.LoginUser(request);
            if (user.Status == false)
            {
                ViewBag.Message = user.Message;
                return View();
            }
            else
            {
                    ViewBag.Message = user.Message;
                //HttpContext.Session.SetInt32("Id", user.Data.Id);
                //HttpContext.Session.SetString("UserName", user.Data.UserName);
                var claims = new List<Claim>
                {
                    new Claim("Id", user.Data.Id.ToString()),
                    new Claim("UserName", user.Data.UserName),
                   

                };
                var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authenticationProperties = new AuthenticationProperties();
                var principal = new ClaimsPrincipal(claimIdentity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authenticationProperties);
                    return RedirectToAction("Index");

            }
            
        }
        public async Task<IActionResult> LogOut()
        {
            //HttpContext.Session.Clear();
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(UserRequestModels request)
        {
            var user = _userServices.RegisterUser(request);
            if (user.Status == false)
            {
                ViewBag.Message = user.Message;
                return View();
            }
            return RedirectToAction("Login");
        }

    }

}

