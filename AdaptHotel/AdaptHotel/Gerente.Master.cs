using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdaptHotel
{
    public partial class Gerente : System.Web.UI.MasterPage
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Response.Redirect("~/views/Error/401.aspx");
            }
            else
            {
                dynamic usuario = Session["usuario"];

                if (usuario.Perfil.getTipo() != "gerente")
                {
                    Response.Redirect("~/views/Error/403.aspx");
                } 
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string parameter = Request["__EVENTARGUMENT"];

                if (parameter == "logout")
                {
                    Session.Remove("usuario");
                    Response.Redirect("~/views/Login.aspx");
                }
            }
        }
    }
}