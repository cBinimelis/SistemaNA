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
            llenaEstado();
            llenaTipo();
        }
    }

    private void BindGrid()
    {
        bdc = new BDConxDataContext();
        GrillaProductos.DataSource = from vProductos in bdc.vProductos select vProductos;
        GrillaProductos.DataBind();
    }

    private void llenaEstado()
    {
        bdc = new BDConxDataContext();
        dd_estadoN.DataSource = bdc.EstadoProducto;
        dd_estadoN.DataTextField = "Descripcion";
        dd_estadoN.DataValueField = "IdEstadoProducto";
        dd_estadoN.DataBind();
    }

    private void llenaTipo()
    {
        bdc = new BDConxDataContext();
        dd_tipoN.DataSource = bdc.TipoProducto;
        dd_tipoN.DataTextField = "Descripcion";
        dd_tipoN.DataValueField = "IdTipoProducto";
        dd_tipoN.DataBind();
    }
    protected void btn_crear_Click(object sender, EventArgs e)
    {
        try
        {
            if (txt_Descripcion.Text.Trim().Equals("") || txt_Precio.Text.Trim().Equals(""))
            {
                Mensaje("Un momento", "No puedes dejar campos vacios", "warning");
            }
            else
            {
                bdc = new BDConxDataContext();
                Productos p = new Productos();
                p.Descripcion = txt_Descripcion.Text;
                p.Precio = Convert.ToInt32(txt_Precio.Text);
            }
        }
        catch (Exception ex)
        {
            Mensaje("Ha surgido un problema", ex.Message, "warning");
        }
    }

    protected void GrillaProductos_RowDataBound(object sender, GridViewRowEventArgs e)
    {

    }

    protected void GrillaProductos_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GrillaProductos.EditIndex = e.NewEditIndex;
        this.BindGrid();
    }

    protected void GrillaProductos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GrillaProductos.EditIndex = -1;
        this.BindGrid();
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