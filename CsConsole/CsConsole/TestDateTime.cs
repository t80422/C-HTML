using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//測試DateTime結構
namespace CsConsole
{
    internal class TestDateTime
    {
        //Entry Point
        public static void Main()
        {
            //取出電腦系統日期與時間
            //定義區域變數DateTime
            DateTime today = DateTime.Now;//Now 是DateTime的屬性(Property),是一種程序,有回應值
            Console.WriteLine($"現在時間:{today.ToString()}");
            Console.WriteLine($"現在時間:{today}");//隱含ToString()

            //操作個體DateTime 會員註冊的日期 期限是六個月 如何知道何時到期
            DateTime d1= today.AddMonths(6);//Instance(個別的) Method
            Console.WriteLine($"起始時間:{today} 終止時間:{d1}");

            //操作屬性 取出年月日 重新整理成民國年
            int year = today.Year - 1911;
            int month = today.Month;
            int day = today.Day;//get property 只能取,不能設定
            Console.WriteLine($"民國:{year}年{month}月{day}日");


        }
    }
}
