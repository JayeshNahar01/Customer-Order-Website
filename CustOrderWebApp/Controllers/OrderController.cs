using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;
//using PagedList;
//using PagedList.Mvc;
using X.PagedList.Mvc.Core;
using X.PagedList;
using X.PagedList.Mvc;
namespace CustOrderWebApp.Controllers
{
    public class OrderController : Controller
    {
        CustomerDAL customerDAL = new CustomerDAL();
        OrderDAL orderDAL = new OrderDAL();


        public IActionResult AddOrder(int CustomerID)
        {
            ViewBag.CustomerID = CustomerID;
            ViewBag.OrderDate = DateTime.Now;
            ViewBag.ShipmentDate = DateTime.Now.AddDays(7);
            return View();

        }

        [HttpPost]
        public IActionResult AddOrder(Order order)
        {

            var result = orderDAL.AddOrder(order);
            if (result)
            {

                return RedirectToAction("CustomerloggedIn", "Customer", new { id = order.CustomerID });
            }
            else
            {
                Console.WriteLine("Unsuccessfull Registration");
                return View();
            }

        }




        public IActionResult DisplayOrderList(int id, int? page)
        {

            var result = orderDAL.GetByCustomerID(id).ToPagedList(page ?? 1, 6);
            return View(result);
        }



        public IActionResult DeleteOrder(int orderID)
        {

            var result = orderDAL.GetByOrderID(orderID);
            //var result = subjectMasterBLL.DeleteSubject(subjectMaster);
            var deleteResult = orderDAL.DeleteOrder(result);
            if (deleteResult)
            {
                return RedirectToAction("DisplayOrderList", new { id = result.CustomerID } );
            }
            else
            {
                return View();
            }

        }
    }
}
