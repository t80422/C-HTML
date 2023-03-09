using CsConsole.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsConsole
{
    internal class StudentStruct
    {
        public static void Main() 
        {
            //設定結構類型的區域變數
            Student std1;
            Student std3;
            //設定成員
            std1.id= 1;
            std1.email = "1234@yahoo.com.tw";//字串是物件 指派位址給email
            std1.grade = 1;
            std1.adress = "台中市南區";
            //std1.birthday = new DateTime(1991, 4, 22); //birthday設為private不能取
            std1.phone = "0921412228";
            std1.name = "Tim";

            std3.id = 2;
            std3.email = "5677@yahoo.com.tw";//字串是物件 指派位址給email
            std3.grade = 2;
            std3.adress = "雲林縣斗六市";
            //std3.birthday = new DateTime(1991, 11, 13);//birthday設為private不能取
            std3.phone = "0972799113";
            std3.name = "Ariel";

            Student? std2 = null;//若設為nullable 使用建構方式 產生一個學生結構
            std2 = new Student();//結構預設有一個空參數的建構子 Constuctor
            //無法指派成員 結構的內容為複合型別 所以無法 new 後使其nullable

            Console.WriteLine($"第一個學生的姓名:{std1.name} 第二個學生的姓名:{std3.name}"); 
        }
    }
}
