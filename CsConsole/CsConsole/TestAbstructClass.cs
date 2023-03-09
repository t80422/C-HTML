using CsConsole.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//測試抽象類別
namespace CsConsole
{
    internal class TestAbstructClass
    {
        public static void Main() 
        {
            //抽象類別變數類型定義
            //Animal dog= new Animal(); 抽象類別不能建構為物件
            Animal dog = null;
            //透過子類別 Dog 是 Animal 實作的個體物件
            //dog = new Dog();//通稱動物 本尊是一隻狗
            dog = new Cat();//軟體工程上.net core 採用注入依賴關係(DI)(由工廠產生物件)
            dog.Name = "餔餔";
            dog.Moveing();
        }
    }
}
