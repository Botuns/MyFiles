using BotunsEngineeringServices.Contexts;
using BotunsEngineeringServices.DTOs.ClientsDTO;
using BotunsEngineeringServices.Implementations.Repositories;
using BotunsEngineeringServices.Interfaces.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BotunsEngineeringServices.Controllers
{
    public class ClientController : Controller
    {
        private readonly ApplicationContext _context;
        public IClientServices _clientServices;
       
        public ClientController(ApplicationContext context, IClientServices clientServices)
        {
            _context = context;
            _clientServices = clientServices;
            
            
        }         
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateClient()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult CreateClient(ClientRequestModel clientRequest)
        {
            var cclient = _clientServices.GetClientByEmailandPassword(clientRequest.Email, clientRequest.Password);
            if (cclient.IsSuccess == true)
            {
                ViewBag.Message = cclient.Message;
            }
            else
            {
                _clientServices.CreateClient(clientRequest);
                ViewBag.Message = cclient.Message;
            }
            return View();
        }
        public IActionResult LogIn()
        {
            return View();
        }
        public async Task<IActionResult> LogIn(ClientLoginRequestModel clientLogin)
        {
            var client = _clientServices.LogIn(clientLogin);
            if (client.IsSuccess == false) { ViewBag.Message = client.Message; }
            else { ViewBag.Message = client.Message; }
            var claims = new List<Claim>
            {
                  new Claim("Id", client.Data.Id.ToString()),
                  new Claim("FirstName", client.Data.FirstName),


            };
            var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var authenticationProperties = new AuthenticationProperties();
            var principal = new ClaimsPrincipal(claimIdentity);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authenticationProperties);
            return RedirectToAction("Index");


        }
        public async Task<IActionResult> LogOut()
        {
           
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
