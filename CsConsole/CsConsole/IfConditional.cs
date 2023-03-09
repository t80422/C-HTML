using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//IF判斷式
namespace CsConsole
{
    internal class IfConditional
    {
        public static void Main()
        {
            //提示標準輸出格式
            Console.WriteLine("請輸入C#成績(0-100)");
            //等待輸入(標準輸入)
            string sScore = Console.ReadLine();//static mathod
            //字串是物件 如何轉換成Int32結構類型
            int iScore;
            bool bOk= int.TryParse(sScore, out iScore);
            //判斷式
            if (bOk)
            {
                //判斷是否及格
                if(iScore>=60)
                {
                    Console.WriteLine($"輸入的成績:{iScore} 成績及格");
                }
            }
            else
            {
                Console.WriteLine($"輸入成績:{iScore} 格式有問題 無法進行判斷");
            }

            Console.WriteLine("結束");
        }
    }
}
