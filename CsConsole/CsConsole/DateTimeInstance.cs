using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//命令視窗輸入字串格式 轉換成個別DateTime(判斷是否滿18歲)
namespace CsConsole
{
    internal class DateTimeInstance
    {
        //Entry Point
        public static void Main()
        {
            Console.WriteLine("請輸入出生年月日");
            string sBirthday =Console.ReadLine();
            Console.WriteLine($"您的生日:{sBirthday}");
            //將String物件(Reference Type)轉換成DateTime結構(Value Type)
            DateTime Birthday=  DateTime.Parse(sBirthday);
            Console.WriteLine($"生日:{Birthday.ToLongDateString()}");
            //看是否滿18歲,兩個日期轉換成天數,相減,除以年度
            DateTime Today = DateTime.Today;
            TimeSpan timediff = Today - Birthday;
            double days= timediff.TotalDays;
            double years = days / 365.25;
            Console.WriteLine($"年齡為:{years}");
            //建構子 Constructor
            DateTime myDate = new DateTime(2000, 1, 1);
            Console.WriteLine(myDate);
        }
    }
}
