using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsConsole.Classes
{
    public class CustomerDAO : IDAO<Customer, string>
    {
        public void Insert(Customer source)
        {
            Console.WriteLine($"新增客戶成功:{source.customerID}");
        }

        public List<Customer> selectForList(string key)
        {
            throw new NotImplementedException();
        }

        public Customer selectForObject(string key)
        {
            throw new NotImplementedException();
        }

        public bool Update(Customer source)
        {
            throw new NotImplementedException();
        }
    }
}
