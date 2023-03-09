using CsConsole.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//具有順序性的集合物件
namespace CsConsole
{
    public class TestArrayList
    {
        public static void Main()
        {
            //設定區域變數(沒有泛型 參數參考物件為Object)
            ArrayList list= new ArrayList(10);
            list.Add(new object());
            list.Add(new Customer());
            list.Add(100);//100為struct 在此 autoboxing 自動封裝成物件參考型別
            list.Add("Allen");
            list.Add("Bella");
            //ArrayList是有順序的集合 就算內容一樣也沒關係
            list.Add("Allen");
            Console.WriteLine(list.Count);

            for(int i=0;i<list.Count;i++)
            {
                Console.WriteLine(list[i].ToString());
            }
        }
    }
}
