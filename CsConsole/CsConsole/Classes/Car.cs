using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsConsole.Classes
{
    public class Car : IMove
    {
        public void move()
        {
            Console.WriteLine("驅動輪子");
        }
    }
}
