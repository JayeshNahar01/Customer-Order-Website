using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace CustOrderWebApp.Controllers
{
    public class CustomerController : Controller
    {
        CustomerDAL customerDAL = new CustomerDAL();

       
        public IActionResult LoginPage()
        {
            //ViewData["ReturnUrl"] = returnUrl;
            return View();
        }
     
      
        [HttpPost]
        public IActionResult LoginPage(Customer customer)
        {
            var result = customerDAL.GetByEmail(customer.EmailID);
            if (result != null)
            {
                if (result.Password == customer.Password)
                {

                    //var claims = new List<Claim>();
                    //claims.Add(new Claim("EmailID", result.EmailID));
                    //claims.Add(new Claim(ClaimTypes.NameIdentifier, result.EmailID));
                    //var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    //var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    //await HttpContext.SignInAsync(claimsPrincipal);
                    return View("CustomerLoggedIn", result);
                }
                else
                {
                    ViewBag.WrongPass = "Incorrect Password";
                    return View("LoginPage");
                  
                }
            }
            else
            {
                ViewBag.WrongEmailPass = "User does not exist";
                return View("LoginPage");
            }

        }

        public IActionResult CustomerLoggedIn(Customer customer,  int? id)
        {
            if(id!=null)
            {
                var cust = customerDAL.GetByID(id);
                return View(cust);
            }
            else
            {
                //ViewBag.OrderPlacemsg = msg;
                return View(customer);
            }
           

        }



        public IActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            var result = customerDAL.AddCustomer(customer);
            if (result)
            {
                Console.WriteLine("Successfully Registered");
                return RedirectToAction("LoginPage");
            }
            else
            {
                Console.WriteLine("Unsuccessfull Registration");
                return View();
            }
        }
    }
}
