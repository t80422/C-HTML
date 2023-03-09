using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//多維度陣列(一個學生有三個成績)
namespace CsConsole
{
    internal class MultyArray
    {
        public static void Main()
        {
            //設定學生姓名陣列初始化
            string[] names = { "Allen", "Bella", "Cathy", "Daly", "Ella" };
            //問元素數量
            Console.WriteLine(names.Length);
            //設定兩個維度陣列(宗歸宗舉寫法)
            //int[,] values = new int[names.Length, 3];
            //values[0,0] = 100;
            //values[0, 1] = 90;
            //values[0, 2] = 80;

            //兩個維度陣列初始化
            int[,] values = new int[,]
            {
                {100,90,70},
                {90,80,60},
                {80,70,50},
                {70,60,40},
                {60,50,40}
            };
            Console.WriteLine("數量:"+values.Length);
            //輸出表格
            Console.WriteLine("學生成績單");
            Console.WriteLine("================================");
            //抬頭列
            Console.WriteLine("姓名\t國文\t英文\t數學");
            for(int i=0;i<names.Length;i++)
            {
                Console.Write(names[i]+"\t");
                for(int j=0;j<values.GetLength(1);j++)
                {
                    Console.Write(values[i,j]+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
