using CsConsole.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//測試業務員與員工
namespace CsConsole
{
    internal class TestSales
    {
        public static void Main()
        {
            //建構員工
            Employees emp=new Employees(1,"Tim","台中市南區","0921412228");
            //堆積Object>Employees
            Console.WriteLine(emp.ToString());
            //設定底薪(操作屬性property寫法)
            emp.Salary = 50000;
            //核算薪資
            emp.calSalary(22, 10000);//Instance Method Call實例化方法呼叫
            //問實際薪水
            Console.WriteLine($"員工薪水:{emp.ActSalary}");
            //建構業務員
            Sales sales = new Sales(2, "臭MOMO", "台中市南區", "0932313520", 1000000);
            //繼承自Employees,所以可以使用Object
            Console.WriteLine(sales.ToString());
            //設定底薪
            sales.Salary = 40000;
            int qa = sales.Qa;
            Console.WriteLine($"業務員業績:{qa}");
            //業務員也是員工
            Console.WriteLine($"編號:{sales.Id} 姓名:{sales.Name}");
            //核算獎金
            sales.calBonus(1000000);
            Console.WriteLine($"業務業績獎金:{sales.Bonus}");
            //核算薪水(繼承Employees的方法calSalary)
            sales.calSalary(22, 10000);
            Console.WriteLine($"業務員實際薪水:{sales.ActSalary}");
        }
    }
}
