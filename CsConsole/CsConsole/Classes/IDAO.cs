using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//定義資料維護功能規範
namespace CsConsole.Classes
{
    //Generic 泛型
    public interface IDAO<T,K>
    {
        void Insert(T source);
        T selectForObject(K key);
        List<T> selectForList(K key);
        bool Update(T source);
    }
}
