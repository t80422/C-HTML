using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//輸出1-100之間奇數
namespace CsConsole
{
    internal class ForLoop
    {
        public static void Main() 
        {
            for(int i=1;i<=100;i+=2)
            {
                Console.Write(i + "\t");
            }
        }

    }
}
