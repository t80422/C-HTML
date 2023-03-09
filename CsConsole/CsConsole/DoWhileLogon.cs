using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//登入驗證作業(使用Do While)
namespace CsConsole
{
    internal class DoWhileLogon
    {
        public static void Main()
        {
            //會員資料 string[] 陣列(初始化語法)
            string[] users = new string[]
            {
                "Allen","Berry","Cathy","Dely","Eric","Frank"
            };
            //進行登入模擬
            int start = 1;
            bool isvalid=false;//存不存在這個會員
            string user;
            do
            {
                //提示輸入帳號
                Console.WriteLine("請輸入帳號:");
                //輸入
                user= Console.ReadLine();
                //判斷有無這個會員
                //使用foreach語法進行判斷
                foreach(string name in users)
                {
                    //判斷是否有這位使用者
                    //string 是類別(class) 參考型別(referanec),會造成位址比位址,內容應該要用Equals來做比較
                    if (user.Equals(name))
                    {
                        isvalid= true;
                        goto Over;
                    }
                }

                //使用Array static method :ForEach
                //Action(委派)使用程序(Function)來做驗證
                Array.ForEach<string>(users,
                    //直接function傳遞進去(使用Lambda語法)
                    (a) =>
                    {
                        if(a.Equals(user))
                        {
                            isvalid=true;
                            //goto Over; 不能用goto
                        }
                    }
                    );

                Console.WriteLine($"您還有{3 - start}次機會");
                start++;

            } while (start<=3);//最多三次機會
            
            Over:
            //判斷是否通過
            if(isvalid)
            {
                Console.WriteLine($"{user}通過驗證");
            }
            else
            {
                Console.WriteLine("驗證不通過");
            }
        }
    }
}
