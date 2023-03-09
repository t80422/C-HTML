using System;

namespace CsConsole.Domain
{
    //自訂資料型別struct
    //到處看的到才可以使用Modififer
    //struct 值型別 固定空間(不能衍生子類別)
    public struct Student
    {
        //規劃成員 可以被儲存的資訊 Data Field
        public int id;
        public string name;
        public string adress;
        public string phone;
        public string email;
        //保護起來 封裝性 資訊隱藏
        private DateTime? _birthday;//只有在這個區域看的到
        public int? grade;
        //規劃屬性進行生日設定(setter)與取得(getter)
        public DateTime? birthday
        {
            set 
            {
                //.birthday=new DateTime(xx,xx,xx) value就是new DateTime(xx,xx,xx)
                if (value<DateTime.Now)
                {
                    _birthday = value;
                }
            }
            get
            {
                return _birthday;
            }
        }
        //自訂建構子
        //結構建構子必須設定每一個成員
        public Student(int id,string name,string adress,string phone)
        {
            this.id = id;
            this.name = name;
            this.adress = adress;
            this.phone = phone;
            this.email = null;
            this._birthday = null;
            this.grade = null;
        }
        //透過參數架構不一樣就可以使用多載
        public Student(int id, string name, string adress, string phone,DateTime birthday)
        {
            this.id = id;
            this.name = name;
            this.adress = adress;
            this.phone = phone;
            this.email = null;

            if (birthday > DateTime.Now)
            {
                this._birthday = null;
            }
            else
            {
                this._birthday = birthday;
            }
            
            this.grade = null;
        }
    }
}
     