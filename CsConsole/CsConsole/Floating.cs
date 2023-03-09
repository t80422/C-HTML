using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//測試浮點運算(小數點)
namespace CsConsole
{
    internal class Floating
    {
        //Main Program(Entry Point)
        public static void Main()
        {
            //定義區域變數 單精準
            Single f1;
            //Console.WriteLine(f1);//區域變數不會有預設值
            //f1 = 12345.6789;//帶小數點的數值都會預設為Double
            f1 = 12345.6789F;//要加F才行

            double dbl = 12345.6789;//小數點數值預設為Double,所以這樣寫沒問題
            Console.WriteLine($"單精準:{f1} 倍精準:{dbl}");//前面加$就可以在大括號裡代入變數

            string str = "單精準:{f1} 倍精準:{dbl}";//沒加$就是單純字串
            Console.WriteLine(str);

            //字串常設定動態模式,這都跟變數有關
            string str2 =string.Format("單精準:{0} 倍精準: {1}",f1,dbl);//使用大括號加上順序來接(從0開始)
            Console.WriteLine(str2);
            Console.WriteLine("單精準:{0} 倍精準: {1}", f1, dbl);//WriteLine也可以用這種方式
        }
    }
}
