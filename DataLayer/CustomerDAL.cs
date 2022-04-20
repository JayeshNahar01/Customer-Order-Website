using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient.Server;

namespace DataLayer
{
    public class CustomerDAL 
    {
        public bool AddCustomer(Customer entity)                                   // to save the new customers
        {
            try
            {
                using (CustOrderContext custOrderContext = new CustOrderContext())
                {
                    custOrderContext.Customers.Add(entity);
                    custOrderContext.SaveChanges();
                    return true;
                }

            }catch(Exception ex)
            {
                return false;
            }
        }

        public bool Update(Customer entity)                                // to update the already registered customer details
        {
            try
            {
                using (CustOrderContext custOrderContext = new CustOrderContext())
                {
                    var result = custOrderContext.Customers.Where(m => m.ID == entity.ID).FirstOrDefault();
                    if(result!=null)
                    {
                        //result.ID = entity.ID;
                        result.Name = entity.Name;
                        result.EmailID = entity.EmailID;
                        result.PhoneNo = entity.PhoneNo;
                        result.Password = entity.Password;
                        result.Address = result.Address;
                        result.City = result.City;
                        custOrderContext.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }catch(Exception ex)
            {
                return false;
            }
        }

        public bool Delete(Customer entity)                               // to delete select field from customers information
        {
            try
            {
                using(CustOrderContext custOrderContext = new CustOrderContext())
                {
                    var result = custOrderContext.Customers.Where(m => m.ID == entity.ID).FirstOrDefault();
                    if(result!=null)
                    {
                        custOrderContext.Customers.Remove(result);
                        custOrderContext.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }catch(Exception ex)
            {
                return false;

            }
        }

        public Customer GetByID(int? id)
        {
            try
            {
                using (CustOrderContext dbContext = new CustOrderContext())
                {
                    string email_id = Convert.ToString(id);
                    var result = dbContext.Customers.Where(x => x.ID == id).FirstOrDefault();
                    return result;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Customer GetByEmail(string emailid)
        {
            try
            {
                using (CustOrderContext dbContext = new CustOrderContext())
                {
                    string email_id = Convert.ToString(emailid);
                    var result = dbContext.Customers.Where(x => x.EmailID == emailid).FirstOrDefault();
                    return result;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public ICollection<Customer> GetAll()                          // to retrive info of all customers
        {
            try
            {
                using (CustOrderContext custOrderContext = new CustOrderContext())
                {
                    var result = custOrderContext.Customers.ToList();
                    return result;
                }

            }catch(Exception ex)
            {
                return null;
            }
        }
    }
}
        