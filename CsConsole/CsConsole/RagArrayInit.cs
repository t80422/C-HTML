using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//不規則維度陣列初始化
namespace CsConsole
{
    internal class RagArrayInit
    {
        public static void Main() 
        {
            string[] names = { "Allen", "Bella", "Cathy", "David" };
            int[][] scores = new int[][]
            {
                new int[]{100,90},
                new int[]{90,80,70},
                new int[]{80,70,60,50},
                new int[]{70,60,50}
            };
            //走訪
            Console.WriteLine("姓名\t國文\t數學\t英文\t程式");
            Console.WriteLine("========================================");
            for(int i=0;i<names.Length;i++)
            {
                //輸出姓名
                Console.Write(names[i]+"\t");
                for(int j = 0; j < scores[i].Length; j++)
                {
                    Console.Write(scores[i][j]+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
