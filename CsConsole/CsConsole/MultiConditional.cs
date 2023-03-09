using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//多重條件 透過巢狀判斷式判斷(優良員工選拔)
namespace CsConsole
{
    internal class MultiConditional
    {
        public static void Main()
        {
            //出題目
            string[] sarrQuestion =new string[4]
            {"是否為正職員工?","是否年資滿十年?","是否最近三年考績均為甲等","去年是否為被選為優良員工"};
            //收集多條件結果(一個敘述對應的一個成果)
            //透過集合物件(Dictionary 資料辭典 收集一個名稱對應一個值)
            Dictionary<string,bool> dicItem=new Dictionary<string,bool>();
            Console.WriteLine("優良員工選拔多條件輸入(Y or N):");
            //走訪迴圈 集合中一個個項目逐一找出來作答
            
            for(int i=0;i<sarrQuestion.Length;i++)
            {
                Console.WriteLine(sarrQuestion[i]);
                string sAns= Console.ReadLine();
                bool bAns=false;

                if (sAns.Equals("Y"))//物件比對 不要使用 "==" ,"=="比的是變數內容
                {
                    bAns= true;
                }
                else if (sAns.Equals("N"))
                {
                    bAns= false;
                }
                dicItem.Add(sarrQuestion[i].ToString(),bAns);
            }
            //進行判斷是否有資格為優良員工
            bool b=false;

            foreach(string s in dicItem.Keys) 
            {
                if (dicItem[s]==false)
                {
                    b = false;
                    //不要用再判斷了
                    break;//結束迴圈jump語法
                }
                else
                {
                    b= true;
                }
            }

            string sEnd = b == false ? "真可惜,你被淘汰了" : "恭喜呀!優良員工";//三元運算子
            Console.WriteLine(sEnd);
        }
    }
}
