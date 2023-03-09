using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//不規則維度陣列(每個人考試科目不一樣)
namespace CsConsole
{
    internal class RegArray
    {
        public static void Main()
        {
            int[][] scores = null;
            //建構元素,不等量
            scores = new int[5][];
            //設定每個人的科目
            scores[0] = new int[2];
            scores[1] = new int[3];
            scores[2] = new int[3];
            scores[3] = new int[4];
            scores[4] = new int[4];
            //assign value
            scores[0][0] = 100;
            scores[0][1] = 90;
            scores[1][0] = 80;
            scores[1][1] = 70;
            scores[1][2] = 60;
            //元素數量
            Console.WriteLine(scores.Length);//只問出第一個維度
            //走訪第一個維度每一個元素對應科目數量
            for(int i=0;i<scores.Length;i++)
            {
                Console.WriteLine($"第{i+1}個人 考{scores[i].Length}科");
            }
        }
    }
}
