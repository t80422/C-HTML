using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//條件式迴圈
namespace CsConsole
{
    internal class TestWhile
    {
        public static void Main()
        {
            //恆為成立 無窮迴圈 模擬一種Listener 用在自動化 or Socket連接
            int a = 0;

            while (true)
            {
                Console.WriteLine(a);
                a ++;
                if (a == 100)
                {
                    break;//中斷迴圈
                }
            }
        }
    }
}
