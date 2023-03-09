using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Entity Class
namespace CsConsole.Classes
{
    public class Customer
    {
        //自動屬性寫法 屬性沒有實做,Data Field也沒寫 在編譯的時候系統會自動產生
        //public string customerID { get; set; }
        public string customerID { get; set; }
        public string companyName { get; set; }
        public string phone { get; set; }
        public string country { get; set; }

        public override bool Equals(object obj)
        {
            bool r = false;
            //判斷是否為Customer
            if(obj is Customer)
            {
                Customer customer= (Customer)obj;
                if(customerID.Equals(customer.customerID))
                {
                    if(companyName.Equals(customer.companyName))
                    {
                        r = true;
                    }
                }
            }
            return r;
        }
        public override int GetHashCode()
        {
            return customerID.GetHashCode() + companyName.GetHashCode();
        }
    }
}
