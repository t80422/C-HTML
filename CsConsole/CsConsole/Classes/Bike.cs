using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CsConsole.Classes
{
    public class Bike : IMove
    {
        public void move()
        {
            Console.WriteLine("用腳踩");
        }
    }
}
