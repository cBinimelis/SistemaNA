using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NavPrivada_GestionUsuarios : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Session.ToString() != "Admin")
        //{
        //    Response.Redirect("../NavPrivada/Inicio.aspx");
        //}

        if (!this.IsPostBack)
        {
            this.BindGrid();
        }
    }
    private void BindGrid()
    {
        using (BDConxDataContext bdc = new BDConxDataContext())
        {
            GrillaUsuarios.DataSource = from Usuarios in bdc.Usuarios select Usuarios;
            GrillaUsuarios.DataBind();
        }
    }

    protected void GrillaUsuarios_RowDataBound(object sender, GridViewRowEventArgs e)
    {

    }

    protected void GrillaUsuarios_RowEditing(object sender, GridViewEditEventArgs e)
    {

    }

    protected void GrillaUsuarios_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }

    protected void GrillaUsuarios_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

    }

    protected void GrillaUsuarios_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

    }
}