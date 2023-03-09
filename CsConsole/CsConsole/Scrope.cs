using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//考試成績等級判斷
namespace CsConsole
{
    internal class Scrope
    {
        public static void Main()
        {
            Console.WriteLine("輸入C#成績(0-100)");
            string sScore= Console.ReadLine();
            bool bScore=int.TryParse(sScore, out int iScore);
            if (bScore)
            {
                if (iScore>=90)
                {
                    Console.WriteLine($"輸入成績:{sScore} 甲等");
                }
                else if (iScore>=80)
                {
                    Console.WriteLine($"輸入成績:{sScore} 乙等");
                }
                else if (iScore >= 70)
                {
                    Console.WriteLine($"輸入成績:{sScore} 丙等");
                }
                else if (iScore >= 60)
                {
                    Console.WriteLine($"輸入成績:{sScore} 丁等");
                }
                else
                {
                    Console.WriteLine($"輸入成績:{sScore} 戊等");
                }
            }
            else
            {
                Console.WriteLine($"輸入成績:{sScore} 格式不對");
            }
        }
    }
}
