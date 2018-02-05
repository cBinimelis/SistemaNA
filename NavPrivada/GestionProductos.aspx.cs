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
            //this.BindGrid();
            llenaCategoria();
        }
    }

    private void BindGrid()
    {
        bdc = new BDConxDataContext();
        GrillaProductos.DataSource = from vUsuarios in bdc.vUsuarios select vUsuarios;
        GrillaProductos.DataBind();
    }

    private void llenaCategoria()
    {

    }
}