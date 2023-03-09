using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsConsole.Classes
{
    public class Order
    {
        //自動屬性寫法
        public int orderID { get; set; }
        public DateTime? orderDate { get; set; }
        public DateTime? shippedDate { get; set; }
    }
}
