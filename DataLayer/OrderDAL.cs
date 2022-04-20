using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class OrderDAL 
    {

        public bool AddOrder(Order entity)                                   // to save the new customers
        {
            try
            {
                using (CustOrderContext custOrderContext = new CustOrderContext())
                {
                    custOrderContext.Orders.Add(entity);
                    custOrderContext.SaveChanges();
                    return true;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public ICollection<Order> GetByCustomerID(int id)                              // to retrive info of specific customer
        {
            try
            {
                using (CustOrderContext custOrderContext = new CustOrderContext())
                {
                    
                    var result = custOrderContext.Orders.Where(m => m.CustomerID == id).ToList();
                    return result;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public Order GetByOrderID(int orderID)                              // to retrive info of specific customer
        {
            try
            {
                using (CustOrderContext custOrderContext = new CustOrderContext())
                {

                    var result = custOrderContext.Orders.Where(m => m.ID == orderID).FirstOrDefault();
                    return result;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }



        public bool DeleteOrder(Order entity)                               // to delete select field from customers information
        {
            try
            {
                using (CustOrderContext custOrderContext = new CustOrderContext())
                {
                    var result = custOrderContext.Orders.Where(m => m.ID == entity.ID).FirstOrDefault();
                    if (result != null)
                    {
                        custOrderContext.Orders.Remove(result);
                        custOrderContext.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            catch (Exception ex)
            {
                return false;

            }
        }

        public List<Order> GetAllOrders()                          // to retrive info of all customers
        {
            try
            {
                using (CustOrderContext custOrderContext = new CustOrderContext())
                {
                    var result = custOrderContext.Orders.ToList();
                    return result;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //public bool Save(Customers entity)                                   // to save the new customers
        //{
        //    try
        //    {
        //        using (CustOrderContext custOrderContext = new CustOrderContext())
        //        {
        //            custOrderContext.Customers.Add(entity);
        //            custOrderContext.SaveChanges();
        //            return true;
        //        }

        //    }catch(Exception ex)
        //    {
        //        return false;
        //    }
        //}

        //public bool Update(Customers entity)                                // to update the already registered customer details
        //{
        //    try
        //    {
        //        using (CustOrderContext custOrderContext = new CustOrderContext())
        //        {
        //            var result = custOrderContext.Customers.Where(m => m.ID == entity.ID).FirstOrDefault();
        //            if(result!=null)
        //            {
        //                //result.ID = entity.ID;
        //                result.Name = entity.Name;
        //                result.EmailID = entity.EmailID;
        //                result.PhoneNo = entity.PhoneNo;
        //                result.Password = entity.Password;
        //                result.Address = result.Address;
        //                result.City = result.City;
        //                custOrderContext.SaveChanges();
        //                return true;
        //            }
        //            else
        //            {
        //                return false;
        //            }
        //        }
        //    }catch(Exception ex)
        //    {
        //        return false;
        //    }
        //}



        //public Customers GetById(object id)                              // to retrive info of specific customer
        //{
        //    try
        //    {
        //        using(CustOrderContext custOrderContext = new CustOrderContext())
        //        {
        //            var currentEmail = Convert.ToString(id);
        //            var result = custOrderContext.Customers.Where(m => m.EmailID == currentEmail).FirstOrDefault();
        //            return result;
        //        }

        //    }catch(Exception ex)
        //    {
        //        return null;
        //    }
        //}


    }
}
        