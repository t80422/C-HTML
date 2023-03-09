using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//測試整數與小數點運算
namespace CsConsole
{
    internal class IntFloat
    {
        //Entry Point
        public static void Main()
        {
            byte b1=1,b2=100;
            Int16 i1 = 1234;
            Int64 i2 = 100;
            Single s1 = 100; 
            Single s2= 100L;
            double s3 =100.5 + s2 + s1 + i2 + i1 + b1 + b2;//最大的型別為100.0的Double,所以一定要用最大型別接
            Console.WriteLine($"結果為:{s3}");

            //小數的0不是真正的0,他還帶有微量的數字,但除法的0就是真的0了
            int i4 = 0;
            //Int32 i3 = 100 / i4;//執行階段產生錯誤的話會拋出例外的物件
            //Console.WriteLine($"結果為:{i3}");

            double d1 = 0.0;
            double d2 = 100.0 / d1;
            Console.WriteLine($"結果為:{d2}");

            double d3 = 100 / 3;//這樣會輸出33,因為兩者都是整數,所以輸出的值會是整數
            Console.WriteLine($"100/3={d3}");
            double d4 = 100 / 3.0;//要將其中一個數轉為Double,因輸出的型別會用最大型別接
            Console.WriteLine($"100/3.0={d4}");
        }
    }
}
