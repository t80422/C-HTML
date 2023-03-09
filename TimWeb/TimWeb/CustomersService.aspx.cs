using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TimWeb
{
    public partial class CustomersService : System.Web.UI.Page
    {
        //網頁被請求時 物件已經準備好了
        protected void Page_Load(object sender, EventArgs e)
        {
            //擷取到前端送進來的json string
            Request.Form[0].ToString();
            //反序列化 可以進行資料新增
            //回應一個訊息給前端
            System.Threading.Thread.Sleep(5000);    
            Response.Write("完成了");
        }
    }
}