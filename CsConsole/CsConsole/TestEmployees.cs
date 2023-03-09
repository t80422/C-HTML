using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsConsole.Classes;

//測試自訂員工類別(具封裝性員工資料)
namespace CsConsole
{
    internal class TestEmployees
    {
        public static void Main()
        {
            //定義區域變數 Employees類型
            //Classes.Employees emp; 因為在不同命名空間 所以要有完整的namespace
            //可以使用using 先行引用命名空間
            Employees emp1 = new Employees();//等號就是將物件為只指派給emp1變數儲存
            //建構 Constructor (執行階段記憶體堆積一個個體) 一個員工物件
            emp1.Id= 1;//借助屬性設定員工編號
            emp1.Name = "Tim";
            emp1.Phone = "0921412228";
            emp1.Adress = "台中市南區";
            emp1.Birthday = new DateTime(1991, 4, 22);
            emp1.Salary = 50000;
            emp1.Sextype = SexType.男性;

            Console.WriteLine($"員工編號:{emp1.Id} 生日:{emp1.Birthday} 薪水:{emp1.Salary} 性別:{emp1.Sextype}");

            //操作父類別建構起來通用功能(Method)
            //操作一個物件 變數位址 回可讀字串
            Console.WriteLine(emp1.ToString());
            Console.WriteLine(emp1);

            //建構員工物件 資料已準備好 建構子一氣呵成 員工資料初始化
            Employees emp2=new Employees(1,"臭MOMO","雲林縣斗六市","0932313520");
            
            //建構空參數建構子 透過物件初始化直接設定 Property/Data Field
            Employees emp3 = new Employees()
            {
                Id = 3,
                Name="臭小咪",
                Adress="台中市南區",
                Phone="234568",
                Birthday=new DateTime(1930,1,1),
                Salary=50000
            };

            //具名參數
            Employees emp4 = new Employees(_name: "張翠珊", _adress: "台中市", _phone: "03423525",_id:4);

            Console.WriteLine($"員工編號:{emp4.Id} 姓名:{emp4.Id}");
        }
    }
}
