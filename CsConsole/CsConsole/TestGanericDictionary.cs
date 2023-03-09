using CsConsole.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//泛型的資料辭典集合應用
namespace CsConsole
{
    internal class TestGanericDictionary
    {
        public static void Main()
        {
            //員工配置交通工具
            //Object Initializer 物件初始化語法
            Dictionary<Employee,IMove> emps=new Dictionary<Employee,IMove>();
            emps.Add
            (
                new Employee()
                {
                    id = 1,
                    name = "Tim",
                    phone = "0921412228"
                },new Bike()
            );
            emps.Add
            (
                new Employee()
                {
                    id = 2,
                    name = "Ariel",
                    phone = "0972799113"
                }, new Car()
            );
            //找出所有員工(巢狀類別架構)
            Dictionary<Employee,IMove>.KeyCollection keys=emps.Keys;
            foreach(Employee e in keys)
            {
                //拿這個key問value
                IMove traf  =emps[e];
                //如何移動
                traf.move();
            }
        }
    }
}
