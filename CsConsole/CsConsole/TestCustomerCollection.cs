using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//辭典應用(Dictionary)
namespace CsConsole
{
    internal class TestCustomerCollection
    {
        public static void Main() 
        {
            try
            {
                Hashtable customers = new Hashtable();
                customers.Add("id", 1);
                customers.Add("name", "Tim");
                customers.Add("adress", "台中市南區");
                customers.Add("phone", "0921412228");
                customers.Add("birthday", new DateTime(1991, 4, 22));
                customers.Add("name", "Tim");
                //蒐集多筆客戶資料,需借助集合物件lList
                ArrayList data = new ArrayList();
                data.Add(customers);
                //收集其他資料辭典物件
                Hashtable customers2 = new Hashtable();
                customers2.Add("id", 2);
                customers2.Add("name", "Ariel");
                customers2.Add("adress", "雲林縣斗六市");
                customers2.Add("phone", "0972799113");
                customers2.Add("birthday", new DateTime(1991, 11, 13));
                data.Add(customers2);
                //走訪每個客戶資料
                for (int i = 0; i < data.Count; i++)
                {
                    Hashtable cust = data[i] as Hashtable;
                    //取出所也的key(沒有順序)
                    ICollection fields = cust.Keys;
                    //走訪每個欄位
                    foreach (object field in fields)
                    {
                        Console.Write($"{field}:{cust[field]}\t");
                    }
                    Console.WriteLine();
                }
            } catch (ArgumentException ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
