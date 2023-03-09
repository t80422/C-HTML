using CsConsole.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//自訂結構 具有自訂建構子
namespace CsConsole
{
    internal class StudentConstructor
    {
        public static void Main()
        {
            Student std1=new Student(1,"Tim","台中市南區","0921412228");
            Console.WriteLine($"姓名:{std1.name} 生日:{std1.birthday}");
            //事後指派生日
            std1.birthday = new DateTime(1991,4,22);
            Console.WriteLine($"姓名:{std1.name} 生日:{std1.birthday}");
            //採用另一種建構方式 生日有被驗證
            Student std2 = new Student(1, "Ariel", "雲林縣斗六市", "0972799113",new DateTime(2023,11,13));
            Console.WriteLine($"姓名:{std2.name} 生日:{std2.birthday}");
        }
    }
}
