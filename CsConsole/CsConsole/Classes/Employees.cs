using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsConsole.Classes
{
    //沒有指定父親 預設為Object 類別
    public class Employees
    {
        #region 資料欄
        //Data Field 員工可以儲存資訊(特徵 用來分類用)
        //這些資訊會有預設值 因為個體物件活在Heap空間
        protected int _id;
        protected string _name;
        protected string _address;
        protected string _phone;
        protected string _email;
        protected DateTime _birthday;
        protected decimal _salary;
        public SexType Sextype;
        //實際薪資經過核算 protected不封裝子類別 封裝執行階段產生的物件
        protected decimal _actsalary;
        #endregion 
        //類別若沒有寫建構子 編譯會產生預設的 (空參數)
        //建構子名稱與類別名稱一樣
        //自訂建構子需要參數
        #region 建構子
        public Employees(int _id,string _name,string _adress, string _phone) 
        {
            Id = _id;
            this._name = _name;
            this._address = _adress;
            this._phone = _phone;
        }

        //使用多載(OverLoading)設計建構子
        public Employees()
        {
            //編譯產生一行指向父親的空參數(Object)
        }
        #endregion
        #region 屬性
        //Property 屬性 存取編號 _id
        public int Id
        {
            set 
            {
                if (value > 0)
                {
                    _id = value;
                }
                else
                {
                    throw new Exception("設定編號不對");//擲出例外
                }
            }
            get
            {
                return _id;
            }
        }

        public string Name { get => _name; set => _name = value; }
        public string Adress { get => _address; set => _address = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Email { get => _email; set => _email = value; }
        public DateTime Birthday { get => _birthday;
            set
            {
                TimeSpan Age = DateTime.Now - value;
                if (Age.TotalDays/365.25 >= 18)
                {
                    _birthday= value;
                }
                else
                {
                    throw new Exception("年齡未滿18歲");
                }
            }
        }
        public decimal Salary { get => _salary;
            set 
            {
                if(value<0)
                {
                    throw new Exception("薪水不能是負數");
                }
                else
                {
                    _salary = value;
                }
            }

        }

        //getter 唯獨屬性 問實際薪資
        public decimal ActSalary
        {
            get
            {
                return _actsalary;
            }
        }

        #endregion
        //方法method(功能 行為)
        //薪資核算 考量出勤天數
        public virtual void calSalary(int days,int traBonus)
        {
            //出勤天數與全勤天數比率方式來算
            if(days>0)
            {
                //全勤22天
                _actsalary=((days / 22.0M) * _salary)+traBonus;
            }
            
        }
    }
}
