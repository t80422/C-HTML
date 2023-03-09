using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//巢狀式迴圈控制流程 99乘法表
namespace CsConsole
{
    internal class 乘法表Contiune
    {
        public static void Main()
        {
            int outer = 1;
            while (outer <= 9)
            {
                int inner = 0;
                while (inner <= 9)
                {   
                    inner++;
                    Console.Write($"{outer}x{inner}={outer*inner}\t");
                    if(inner==5)
                    {
                        continue;//會跳到迴圈的下引號
                    }

                }
                Console.WriteLine();
                if(outer==5)
                {
                    break;
                }
                outer++;
            }
            Console.WriteLine("結束!");
        }
    }
}
