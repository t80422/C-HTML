using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsConsole.Classes
{
    public class OrderDAO : IDAO<Order, int>
    {
        public void Insert(Order source)
        {
            Console.WriteLine($"新增訂單成功:{source.orderID}");
        }

        public List<Order> selectForList(int key)
        {
            throw new NotImplementedException();
        }

        public Order selectForObject(int key)
        {
            throw new NotImplementedException();
        }

        public bool Update(Order source)
        {
            throw new NotImplementedException();
        }
    }
}
