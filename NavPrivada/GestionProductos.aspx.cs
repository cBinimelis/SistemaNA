using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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


    int idUsuario;
    DateTime Tiempo = System.DateTime.Now;

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
                SqlDataReader usuario = sql.consulta("SELECT * FROM Usuarios WHERE Correo = '" + Session["Admin"].ToString() + "'");
                if (usuario.Read())
                {
                    idUsuario = Convert.ToInt32(usuario[0].ToString());
                }
                bdc = new BDConxDataContext();
                Productos p = new Productos();
                p.Descripcion = txt_Descripcion.Text;
                p.Precio = Convert.ToInt32(txt_Precio.Text);
                p.FechaCreacion = Tiempo;
                p.IdEstadoProducto = Convert.ToInt32(dd_estadoN.SelectedValue);
                p.IdTipoProducto = Convert.ToInt32(dd_tipoN.SelectedValue);
                p.IdUsuario = idUsuario;
                bdc.Productos.InsertOnSubmit(p);
                bdc.SubmitChanges();
                codigoBarras(Tiempo, txt_Descripcion.Text);
                limpiar();
                BindGrid();
            }
        }
        catch (Exception ex)
        {
            Mensaje("Ha surgido un problema", ex.Message, "warning");
        }
    }

    //CODIGO PARA ASIGNAR UN CODIGO DE BARRAS A LOS PRODUCTOS NUEVOS
    private void codigoBarras(DateTime Tiempo, String Descripcion)
    {
        SqlDataReader BaseCod = sql.consulta("EXEC AgregarCodigo '" + Descripcion + "'");
        if (BaseCod.Read())
        {
            int do_it =sql.ejecutar("UPDATE Productos SET CodBarra ='NOVA-" + BaseCod[2] + "-" + BaseCod[1] + "' WHERE IdProducto = " + BaseCod[0] + "");
            if (do_it > 0)
            {
                Mensaje("Felicidades", "Se ha creado el producto exitosamente", "success");
            }
            else
            {
                Mensaje("Por poquito", "Se ha creado el producto, pero sin codigo de barras", "warning");
            }
        }
    }


    protected void GrillaProductos_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow && e.Row.RowIndex != GrillaProductos.EditIndex)
        {
            (e.Row.Cells[5].Controls[2] as LinkButton).Attributes["onclick"] = "return Delete(this, event);";
        }
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
        GridViewRow row = GrillaProductos.Rows[e.RowIndex];
        int ProductID = Convert.ToInt32(GrillaProductos.DataKeys[e.RowIndex].Values[0]);
        String CodBarra = (row.FindControl("txt_codbarra") as TextBox).Text.Trim();
        String Descripcion = (row.FindControl("txt_descripcion") as TextBox).Text.Trim();
        String Precio = (row.FindControl("txt_precio") as TextBox).Text.Trim();
        if (CodBarra.Equals("") || Descripcion.Equals("") || Precio.Equals(""))
        {
            Mensaje("No tan rapido", "No puedes dejar campos vacios", "error");
        }
        else
        {
            bdc = new BDConxDataContext();
            Productos pr = (from p in bdc.Productos where p.IdProducto == ProductID select p).FirstOrDefault();
            pr.CodBarra = CodBarra;
            pr.Descripcion = Descripcion;
            pr.Precio = Convert.ToInt32(Precio);
            bdc.SubmitChanges();
            GrillaProductos.EditIndex = -1;
            Mensaje("Completado con exito", "Se han actualizado los datos", "success");
            this.BindGrid();
        }
    }

    protected void GrillaProductos_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int ProductID = Convert.ToInt32(GrillaProductos.DataKeys[e.RowIndex].Values[0]);
        bdc = new BDConxDataContext();
        Productos pr = (from p in bdc.Productos where p.IdProducto == ProductID select p).FirstOrDefault();
        pr.IdEstadoProducto = 4;
        bdc.SubmitChanges();
        GrillaProductos.EditIndex = -1;
        Mensaje("Felicidades", "Producto Eliminado del sistema", "success");
        this.BindGrid();
    }

    private void Mensaje(String Tit, String Msg, String Stat)
    {
        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "Alerta('" + Tit + "','" + Msg + "','" + Stat + "');", true);
    }
    
    private void limpiar()
    {
        txt_Descripcion.Text = "";
        txt_Precio.Text = "";
    }
}