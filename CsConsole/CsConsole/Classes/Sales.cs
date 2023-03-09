using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsConsole.Classes
{
    //業務員也是員工 父親指向Employees 
    public class Sales:Employees
    {
        #region Data Field
        private int _qa;//業績
        private int _actqa;//實際業績
        private int _bonus;//業績獎金
        #endregion
        #region Property
        public int Qa { get => _qa; 
            set 
            {
                if(value>0)
                {
                    _qa = value;
                }
            }
        }
        public int Actqa { get => _actqa; }
        public int Bonus { get => _bonus; }
        #endregion
        #region 建構子
        //沒有寫建構子 編譯產生預設建構子 指向父親空參數建構子
        public Sales(int _id, string _name, string _address, string _phone,int _qa)
        {
            //編譯產生指向父類別空參數
            this.Id = _id;
            this._name = _name;
            this._address = _address;
            this._phone = _phone;
            //業績設定
            if (_qa > 0)
            {
                this._qa = _qa;
            }
        }
         //父類別若無空參數 子類別必須明確寫出建構子(裡面使用 base(,...)父類別建構子)
        public Sales(int _id,string _name,string _address,string _phone):base( _id, _name, _address, _phone)
        {

        }
        #endregion
        #region Method
        //Property設定
        //獎金核算方法(傳遞實際業績)
        public void calBonus(int _actQa)
        {
            //儲存實際業績
            this._actqa = _actQa;
            //判斷是否達標
            if(_actqa>= _qa * 0.9)
            {
                //核算獎金
                _bonus = (int)(_actqa * 0.05);
            }
        }
        //堅持與父類別的方法名稱一樣(修飾詞 回應值 方法名稱 參數架構),此方法稱為Overritting(複寫)
        public override void calSalary(int days,int traBonus)
        {
            //加上業績獎金,原先底薪算法不變
            base.calSalary(days,traBonus);
            _actsalary += _bonus;
        }
        #endregion
    }
}
