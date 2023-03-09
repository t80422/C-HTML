using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//測試Decimal與Double的差異
namespace CsConsole
{
    internal class Decimal
    {
        //Entry Point
        public static void Main()
        {
            double d1 = 1234567890.123456789;
            decimal m1 = 1234567890.123456789M;//Decimal類型數字後面要加上 M 不然他會預設為Double
            Console.WriteLine($"double:{d1}");
            Console.WriteLine($"decimal:{m1}");

            //跟 Int64 做比較
            //Int64 i1 = 12345678909876543212L;//值太大
            decimal m2 = 123456789098765432123M;
            Console.WriteLine($"m2={m2}");

            decimal m3 = 0.0M;//是精確數值,真的是0
            //decimal m4 = 100 / m3;
            //Console.WriteLine($"m4={m4}"); //會報錯

            //使用結構的static const (const:常數預設為static)
            Console.WriteLine($"Decimal最小的值:{decimal.MinValue} 最大的值:{decimal.MaxValue}");
        }
    }
}
