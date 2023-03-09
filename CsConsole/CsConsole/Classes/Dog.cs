using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsConsole.Classes
{
    //繼承一個具有抽象方法的抽象類別 抽象方法要實作(不實做 此類別就要繼續抽象 public abstruct class Dog:Animal)
    public class Dog : Animal
    {
        //實作Implement(抽象方法) 架構就是Overriding
        public override void Moveing()
        {
            Console.WriteLine("我是一隻狗,我會咬人");
        }
    }

}
