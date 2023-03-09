using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsConsole
{
    internal class TestCharReader
    {
        public static void Main()
        {
            string file = @"C:\Users\user\Desktop\C#HTML5\Images\Utility.bas";
            //接水管理論(Stream>Char>String)裝飾模式Decorator Pattern
            using (Stream fs1 = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                //建立Reader
                TextReader reader = new StreamReader(fs1, System.Text.Encoding.UTF8);
                StringBuilder builder = new StringBuilder();
                char[] buffer= new char[50];
                int realLen = 0;
                while ((realLen=reader.Read(buffer,0,buffer.Length))>0)
                {
                    builder.Append(buffer,0,realLen);//比"+"串字串還要有效率
                }
                string content = builder.ToString();
                //fs1.Close();
                Console.WriteLine(content);
            }//呼叫物件解構進行關閉 
        }
    }
}
