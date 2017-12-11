using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EL;

namespace AplicacionWeb
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Init();
        }


        public void Init()
        {
            ContentPlaceHolder objHolder;
            objHolder = (ContentPlaceHolder)Master.FindControl("ContentPlaceHolder1");
            objHolder.FindControl("cosas").Visible = false;
 
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Server.Transfer("Login.aspx");
        }

 
    }
}