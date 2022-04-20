using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class OwnerDAL
    {

        public Owner GetByEmailID(string emailid)                              // to retrive info of specific customer
        {
            try
            {
                using (CustOrderContext custOrderContext = new CustOrderContext())
                {

                    var result = custOrderContext.Owners.Where(m => m.EmailID == emailid).FirstOrDefault();
                    return result;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public Owner GetByID(int? id)
        {
            try
            {
                using (CustOrderContext dbContext = new CustOrderContext())
                {
                   
                    var result = dbContext.Owners.Where(x => x.ID == id).FirstOrDefault();
                    return result;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
