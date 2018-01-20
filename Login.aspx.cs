using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_login_Click(object sender, EventArgs e)
    {
        if (txt_username.Text.Trim().Equals("") || txt_password.Text.Trim().Equals(""))
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "Vacio();", true);
        }
        else
        {
            Session["Admin"] = txt_username.Text;
            Response.Redirect("NavAdmin/Inicio.aspx");
        }
    }
}