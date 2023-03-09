using CsConsole.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//測試多型化(員工) 可能是工程師,業務員或員工
namespace CsConsole
{
    internal class TestEmployeesPloy
    {
        public static void Main()
        {
            Sales sales1 = new Sales(1, "Tim1", "台中市南區", "0921412228");
            sales1.Salary = 50000;

            Employees emp1= new Sales(1, "Tim2", "台中市南區", "0921412228");
            //設定底薪
            emp1.Salary = 50000;
            //設定業績目標
            ((Sales)emp1).Qa =1000000;

            Employees emp2 = new Engineer(2, "Ariel", "雲林縣斗六市", "0972799113","124","打嗝",1000);
            emp2.Salary = 40000;

            Employees emp3 = new Employees(3, "臭MOMO", "台中市南區", "0987654312");
            emp3.Salary = 30000;

            //收集起來 使用陣列(同類型的類別集合 只要是有繼承關係就可以不同類別)
            Employees[] emps = new Employees[] { emp1, emp2, emp3, sales1 };

            //每個員工姓名
            foreach (Employees e in emps)
            {
                Console.WriteLine($"姓名:{e.Name}");
            }

            //找出業務腳色 設定實際業績與獎金計算
            foreach(Employees e in emps)
            {
                //判斷員工是否為業務
                if(e is Sales)
                {
                    //明確性轉型
                    Sales s1= (Sales)e;
                    //操作獎金計算
                    s1.calBonus(1000000);
                }
            }

            //進行薪資核算
            //直接走訪Employees陣列元素
            foreach(Employees e in emps)
            {
                //採用實際建構本尊 Overriding的方法
                //VMI Virutal Method Invocation
                e.calSalary(22, 10000);
                //輸出每個人的薪水 判斷本尊
                if(e is Sales)
                {
                    Console.WriteLine($"業務員姓名:{e.Name} 業績獎金:{((Sales)e).Bonus} 實際薪水:{e.ActSalary}");
                }
                else if (e is Engineer)
                {
                    Console.WriteLine($"工程師姓名:{e.Name} 技術獎金:{((Engineer)e).TechBonus} 實際薪水:{e.ActSalary}");
                }
                else
                {
                    Console.WriteLine($"一般員工姓名:{e.Name} 實際薪水:{e.ActSalary}");
                }
                
            }
            

        }
    }
}
