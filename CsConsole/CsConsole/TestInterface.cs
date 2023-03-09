using CsConsole.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//測試介面
namespace CsConsole
{
    public class TestInterface
    {
        public static void Main()
        {
            //介面當型別 介面多型化
            //IDAO<Customer, string> dao=new CustomerDAO();
            //改版物件
            IDAO<Customer, string> dao = new CustomerDAO2();
            //新增
            Customer customer = new Customer()
            {   
                customerID="001",
                companyName="全瑩",
                country="台中市",
                phone="12345678"
            };
            dao.Insert(customer);//傳遞參數沒有使用 SQL Pass Through

        }
    }
}
