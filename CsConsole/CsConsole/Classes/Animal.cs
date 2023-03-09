using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsConsole.Classes
{
    //有抽象方法 類別也要設成抽象
    //例外:自己定義抽象類別沒有任何抽象方法(軟體工程實現Adapter...)
    public abstract class Animal
    {
        //Data Field
        private string _name;
        //屬性
        public string Name { get => _name; set => _name = value; }
        //功能(不知道對象是何種動物,怎麼動,所以設成抽象方法)
        public abstract void Moveing();

        public void Eating()
        {
            Console.WriteLine("動物會吃東西");
        }
    }
}
