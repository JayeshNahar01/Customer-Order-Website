using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;
using X.PagedList.Mvc.Core;
using X.PagedList;
using X.PagedList.Mvc;

namespace CustOrderWebApp.Controllers
{
    public class OwnerController : Controller
    {
        OwnerDAL ownerDAL = new OwnerDAL();
        OrderDAL orderDAL = new OrderDAL();
        public IActionResult LoginPage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginPage(Owner owner)
        {
            var result = ownerDAL.GetByEmailID(owner.EmailID);

            if (result != null)
            {
                if (result.Password == owner.Password)
                {

                   
                    return View("OwnerloggedIn", result);
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

        public IActionResult OwnerloggedIn(Owner owner, int? id)
        {
            if (id != null)
            {
                var own = ownerDAL.GetByID(id);
                return View(own);
            }
            else
            {
                //ViewBag.OrderPlacemsg = msg;
                return View(owner);
            }


        }



        public IActionResult ViewAllOrders(int? page)
        {

            var result = orderDAL.GetAllOrders().ToPagedList(page ?? 1, 6);
            return View(result);
        }

        public IActionResult DeleteOrder(int orderID)
        {

            var result = orderDAL.GetByOrderID(orderID);
            //var result = subjectMasterBLL.DeleteSubject(subjectMaster);
            var deleteResult = orderDAL.DeleteOrder(result);
            if (deleteResult)
            {
                return RedirectToAction("ViewAllOrders", new { id = result.CustomerID });
            }
            else
            {
                return View();
            }
        }


    }
}
