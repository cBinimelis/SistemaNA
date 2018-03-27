using SistemaNA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Collections;
using System.Web.UI.WebControls;
using System.Data;

public partial class NavPrivada_Catalogo : System.Web.UI.Page
{
    BDConxDataContext bdc;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            BindGrid();
        }
    }

    int ProductID = 0;
    private void BindGrid()
    {
        bdc = new BDConxDataContext();
        grillaProductos.DataSource = from vProductos in bdc.vProductos select vProductos;
        grillaProductos.DataBind();
    }
    
    protected void lbZapatos_Click(object sender, EventArgs e)
    {
        CarroDeCompras carrito = CarroDeCompras.CapturarProducto();
        carrito.Agregar(1);
        Response.Redirect("VerCarrito.aspx");
    }
    protected void lbCamisas_Click(object sender, EventArgs e)
    {
        CarroDeCompras carrito = CarroDeCompras.CapturarProducto();
        carrito.Agregar(2);
        Response.Redirect("VerCarrito.aspx");
    }
    protected void lbPantalones_Click(object sender, EventArgs e)
    {
        CarroDeCompras carrito = CarroDeCompras.CapturarProducto();
        carrito.Agregar(3);
        Response.Redirect("VerCarrito.aspx");
    }
    protected void lbSandalias_Click(object sender, EventArgs e)
    {
        CarroDeCompras carrito = CarroDeCompras.CapturarProducto();
        carrito.Agregar(4);
        Response.Redirect("VerCarrito.aspx");
    }
    protected void lbBoxer_Click(object sender, EventArgs e)
    {
        CarroDeCompras carrito = CarroDeCompras.CapturarProducto();
        carrito.Agregar(5);
        Response.Redirect("VerCarrito.aspx");
    }
    protected void AgregarProductos(int id)
    {
        CarroDeCompras carrito = CarroDeCompras.CapturarProducto();
        carrito.Agregar(id);
    }
    private void Mensaje(String Tit, String Msg, String Stat)
    {
        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "Alerta('" + Tit + "','" + Msg + "','" + Stat + "');", true);
    }

    protected void btn_verCarrito_Click(object sender, EventArgs e)
    {
        Response.Redirect("VerCarrito.aspx");
    }
    

    protected void grillaProductos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Select")
        {
            //Determine the RowIndex of the Row whose Button was clicked.
            int rowIndex = Convert.ToInt32(e.CommandArgument);

            //Reference the GridView Row.
            GridViewRow row = grillaProductos.Rows[rowIndex];

            //Fetch value of Name.
            string ID = (row.FindControl("lbl_id") as Label).Text;
            ProductID = Convert.ToInt32(ID);
            AgregarProductos(ProductID);
        }
    }
}