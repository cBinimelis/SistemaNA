using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NavPrivada_GestProd : System.Web.UI.Page
{
    BDConxDataContext bdc;
    Conexion sql = new Conexion();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            this.BindGrid();
            llenaCategoria();
        }
    }

    private void BindGrid()
    {
        bdc = new BDConxDataContext();
        GrillaProductos.DataSource = from vProductos in bdc.vProductos select vProductos;
        GrillaProductos.DataBind();
    }

    private void llenaCategoria()
    {

    }

    protected void GrillaProductos_RowDataBound(object sender, GridViewRowEventArgs e)
    {

    }

    protected void GrillaProductos_RowEditing(object sender, GridViewEditEventArgs e)
    {

    }

    protected void GrillaProductos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }

    protected void GrillaProductos_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

    }

    protected void GrillaProductos_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

    }

    private void Mensaje(String Tit, String Msg, String Stat)
    {
        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "Alerta('" + Tit + "','" + Msg + "','" + Stat + "');", true);
    }
}