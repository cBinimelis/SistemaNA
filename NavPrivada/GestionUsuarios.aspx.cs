using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NavPrivada_GestionUsuarios : System.Web.UI.Page
{
    BDConxDataContext bdc;
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
        GrillaUsuarios.DataSource = from Usuarios in bdc.Usuarios select Usuarios;
        GrillaUsuarios.DataBind();
    }

    private void llenaEstado()
    {
        bdc = new BDConxDataContext();
        dd_estado.DataSource = bdc.EstadoUsuario;
        dd_estado.DataTextField = "Descripcion";
        dd_estado.DataValueField = "IdEstadoUsuario";
        dd_estado.DataBind();
    }

    private void llenaTipo()
    {
        bdc = new BDConxDataContext();
        dd_tipo.DataSource = bdc.TipoUsuario;
        dd_tipo.DataTextField = "Descripcion";
        dd_tipo.DataValueField = "IdTipoUsuario";
        dd_tipo.DataBind();
    }

    protected void btn_crear_Click(object sender, EventArgs e)
    {
        try
        {
            if (txt_NombreN.Text.Trim().Equals("") || txt_ApellidoN.Text.Trim().Equals("") || txt_CorreoN.Text.Trim().Equals("") || txt_PasswordN.Text.Trim().Equals("") || txt_ConfPass.Text.Trim().Equals(""))
            {
                Mensaje("No puedes dejar campos vacios", "warning");
            }
            else
            {
                if(txt_PasswordN.Text != txt_ConfPass.Text)
                {
                    Mensaje("Las contraseñas no coinciden", "info");
                }
            }
        }
        catch (Exception ex)
        {

        }
    }

    protected void GrillaUsuarios_RowDataBound(object sender, GridViewRowEventArgs e)
    {

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

    }

    protected void GrillaUsuarios_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

    }

    private void Mensaje(String Msg, String Stat)
    {
        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "Alerta('" + Msg + "','" + Stat + "');", true);
    }

}