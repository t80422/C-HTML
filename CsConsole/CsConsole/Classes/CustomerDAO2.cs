using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsConsole.Classes
{
    public class CustomerDAO2 : IDAO<Customer, string>
    {
        public void Insert(Customer source)
        {
            Console.WriteLine($"改版新增:{source.companyName}");
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
