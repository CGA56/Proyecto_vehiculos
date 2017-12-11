using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace AppWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Init();
        }

      

        protected void Button1_Click(object sender, EventArgs e)
        {
             string nombreUser = Session["usuario"].ToString();
             string pass = Session["pass"].ToString();

             if (txtUsuario.Text.Equals(nombreUser) & (txtClave.Text.Equals(pass)))
             {
                 desbloquear();
                 Server.TransferRequest("Mostrar.aspx");
             }
  
        }

        private void Init()
        {
            ContentPlaceHolder objHolder;
            objHolder = (ContentPlaceHolder)Master.FindControl("ContentPlaceHolder1");
            objHolder.FindControl("cosas").Visible = false;

            Session.Add("pass", "pepe");
            Session.Add("usuario", "pepe");
        }

        private void desbloquear()
        {
            ContentPlaceHolder objHolder;
            objHolder = (ContentPlaceHolder)Master.FindControl("ContentPlaceHolder1");
            objHolder.FindControl("cosas").Visible = true;
            txtClave.Text="";
            txtUsuario.Text = "";

        }

         

    }
}