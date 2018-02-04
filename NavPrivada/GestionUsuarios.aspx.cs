using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NavPrivada_GestionUsuarios : System.Web.UI.Page
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
        GrillaUsuarios.DataSource = from vUsuarios in bdc.vUsuarios select vUsuarios;
        GrillaUsuarios.DataBind();
    }

    private void llenaEstado()
    {
        bdc = new BDConxDataContext();
        dd_estadoN.DataSource = bdc.EstadoUsuario;
        dd_estadoN.DataTextField = "Descripcion";
        dd_estadoN.DataValueField = "IdEstadoUsuario";
        dd_estadoN.DataBind();
    }

    private void llenaTipo()
    {
        bdc = new BDConxDataContext();
        dd_tipoN.DataSource = bdc.TipoUsuario;
        dd_tipoN.DataTextField = "Descripcion";
        dd_tipoN.DataValueField = "IdTipoUsuario";
        dd_tipoN.DataBind();
    }

    protected void btn_crear_Click(object sender, EventArgs e)
    {
        try
        {
            if (txt_NombreN.Text.Trim().Equals("") || txt_ApellidoN.Text.Trim().Equals("") || txt_CorreoN.Text.Trim().Equals("") || txt_PasswordN.Text.Trim().Equals("") || txt_ConfPass.Text.Trim().Equals(""))
            {
                Mensaje("No tan rapido", "No puedes dejar campos vacios", "warning");
            }
            else
            {
                if (txt_PasswordN.Text != txt_ConfPass.Text)
                {
                    Mensaje("Mas cuidado", "Las contraseñas no coinciden", "info");
                }
                else
                {
                    bdc = new BDConxDataContext();
                    Usuarios u = new Usuarios();
                    u.Nombre = txt_NombreN.Text;
                    u.Apellido = txt_ApellidoN.Text;
                    u.Correo = txt_CorreoN.Text;
                    u.Password = txt_PasswordN.Text;
                    u.IdEstadoUsuario = 1;
                    u.IdTipoUsuario = dd_tipoN.SelectedIndex;
                    bdc.Usuarios.InsertOnSubmit(u);
                    bdc.SubmitChanges();
                    Mensaje("Felicitaciones", "Usuario agregado exitosamente", "success");
                    limpiar();
                }
            }
        }
        catch (Exception ex)
        {

        }
    }

    protected void GrillaUsuarios_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            var dde = (DropDownList)e.Row.FindControl("dd_estado");
            sql.llenacombo(dde, "SELECT * FROM EstadoUsuario", "Descripcion", "IdEstadoUsuario");
            var ddt = (DropDownList)e.Row.FindControl("dd_tipo");
            sql.llenacombo(ddt, "SELECT * FROM TipoUsuario", "Descripcion", "IdTipoUsuario");
        }

        if (e.Row.RowType == DataControlRowType.DataRow && e.Row.RowIndex != GrillaUsuarios.EditIndex)
        {
            (e.Row.Cells[6].Controls[2] as LinkButton).Attributes["onclick"] = "return Delete(this, event);";
        }
    }

    protected void GrillaUsuarios_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GrillaUsuarios.EditIndex = e.NewEditIndex;
        this.BindGrid();
    }

    protected void GrillaUsuarios_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GrillaUsuarios.EditIndex = -1;
        this.BindGrid();
    }

    protected void GrillaUsuarios_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = GrillaUsuarios.Rows[e.RowIndex];
        int UserID = Convert.ToInt32(GrillaUsuarios.DataKeys[e.RowIndex].Values[0]);
        String Nombre = (row.FindControl("txt_nombre") as TextBox).Text.Trim();
        String Apellido = (row.FindControl("txt_apellido") as TextBox).Text.Trim();
        String Correo = (row.FindControl("txt_correo") as TextBox).Text.Trim();
        String Password = (row.FindControl("txt_password") as TextBox).Text.Trim();
        int dde = (row.FindControl("dd_estado") as DropDownList).SelectedIndex;
        int ddt = (row.FindControl("dd_tipo") as DropDownList).SelectedIndex;
        if (Nombre.Equals("") || Apellido.Equals("") || Correo.Equals("") || Password.Equals("") || dde == 0 || ddt == 0)
        {
            Mensaje("No tan rapido", "No puedes dejar campos vacios", "error");
        }
        else
        {
            bdc = new BDConxDataContext();
            Usuarios us = (from u in bdc.Usuarios where u.IdUsuario == UserID select u).FirstOrDefault();
            us.Nombre = Nombre;
            us.Apellido = Apellido;
            us.Correo = Correo;
            us.Password = Password;
            us.IdEstadoUsuario = dde;
            us.IdTipoUsuario = ddt;
            bdc.SubmitChanges();
            GrillaUsuarios.EditIndex = -1;
            Mensaje("Completado con exito", "Se han actualizado los datos", "success");
            this.BindGrid();
        }
    }

    protected void GrillaUsuarios_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = GrillaUsuarios.Rows[e.RowIndex];
        int UserID = Convert.ToInt32(GrillaUsuarios.DataKeys[e.RowIndex].Values[0]);
        bdc = new BDConxDataContext();
        Usuarios us = (from u in bdc.Usuarios where u.IdUsuario == UserID select u).FirstOrDefault();
        us.IdEstadoUsuario = 3;
        bdc.SubmitChanges();
        GrillaUsuarios.EditIndex = -1;
        Mensaje("Felicidades", "Usuario Eliminado del sistema", "success");
        this.BindGrid();
    }

    private void Mensaje(String Tit, String Msg, String Stat)
    {
        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "Alerta('" + Tit + "','" + Msg + "','" + Stat + "');", true);
    }

    private void limpiar()
    {
        txt_NombreN.Text = "";
        txt_ApellidoN.Text = "";
        txt_CorreoN.Text = "";
        txt_PasswordN.Text = "";
        txt_ConfPass.Text = "";
    }

}