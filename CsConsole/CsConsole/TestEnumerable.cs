using CsConsole.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//沒有順序性的集合物件操作
namespace CsConsole
{
    internal class TestEnumerable
    {
        public static void Main()
        {
            HashSet<string>hash=new HashSet<string>();
            hash.Add("Allen");
            hash.Add("Barry");
            hash.Add("Cathy");
            hash.Add("Deby");
            bool b= hash.Add("Allen");
            if (b == false)
            {
                Console.WriteLine("沒有被參考");
            }
            Console.WriteLine(hash.Count);
            foreach(string name in hash)
            {
                Console.WriteLine(name);
            }

            //沒有順序的集合
            ISet<Customer> customers= new HashSet<Customer>();
            customers.Add(new Customer()
            {
                customerID = "001",
                companyName="楨榕發",
                country="雲林縣麥寮鎮",
                phone="0921412228"
            });
            customers.Add(new Customer()
            {
                customerID = "002",
                companyName = "中國人壽",
                country = "雲林縣斗六市",
                phone = "0972799113"
            });
            customers.Add(new Customer()
            {
                customerID = "003",
                companyName = "九罐",
                country = "台中市烏日區",
                phone = "0912345677"
            });
            //使用HashCode進行物件內容比對
            customers.Add(new Customer()
            {
                customerID = "001",
                companyName = "楨榕發",
                country = "雲林縣麥寮鎮",
                phone = "023454556"
            });
            Console.WriteLine($"客戶數量:{customers.Count}");
        }
    }
}
