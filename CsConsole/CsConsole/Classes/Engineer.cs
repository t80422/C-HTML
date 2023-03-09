using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//工程師
namespace CsConsole.Classes
{
    public class Engineer:Employees
    {

        //Date Field
        private string _tech;//技術性工作
        private int _techBonus;//技術津貼
        
        //自訂建構子 注入初始化資訊
        public Engineer(int _id,string _name,string _address,string _phone, string _email,string _tech,int _techBonus)
        {
            //直接在這指派給父類別規劃的成員
            this._id= _id;
            this._name= _name;
            this._address= _address;
            this._phone= _phone;
            this._email= _email;
            this._tech= _tech;
            if (_techBonus > 0)
            {
                this._techBonus = _techBonus;
            }
            
        }

        public string Tech { get => _tech; set => _tech = value; }
        public int TechBonus { get => _techBonus; }

        //Overriding 複寫
        public override void calSalary(int days, int traBonus)
        {   
            //基本薪資
            base.calSalary(days, traBonus);
            //技術津貼
            _actsalary += _techBonus;
        }
    }
}
