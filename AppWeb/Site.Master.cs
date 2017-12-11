using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;
using System.Web.UI.HtmlControls;

namespace AppWeb
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void genererCambios()
        {
            ((HtmlGenericControl)this.Page.Master.FindControl("cosas")).Style.Add("display", "none");
        }
    }
}