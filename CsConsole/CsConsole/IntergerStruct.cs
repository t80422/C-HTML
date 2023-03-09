using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsConsole
{
    internal class IntergerStruct
    {
        //主程式
        public static void Main()
        {
            //區域變數(型別不能變,內容可以變)
            byte b1;//區域變數不會有預設值
            b1 = 255;//255預設為32bit整數(隱含轉型)
            Console.WriteLine(b1);

            byte carAmount = 100;//Camel(駝峰)或匈牙利命名法
            
            Int16 s1=1000,s2=2000,s3;
            //s3 = s1 + s2;//小於Int32整數之前運算,需晉升到32bit,防止錯誤
            Int32 r1 = s1 + s2;//要這樣使用

            //若要強制使用Int16,可使用強制轉型(Excplicit Casting)
            s3 = (Int16)(s1 + s2);

            //常用的整數 Int32
            Int32 m1 = 1234567;
            //Int32 m2 = 1234567890123;//過大了 要用64bit接
            Int64 m3 = 1234567890123;

            //數值不大,但空間大
            //Int32 m4 = 1L;//L為長整數,要用64bit接
            Int64 m5 = 1L;
        }
    }
}
